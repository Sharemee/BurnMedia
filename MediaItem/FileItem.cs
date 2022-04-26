//
// FileItem.cs
//
// by Eric Haddan
//
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using IMAPI2.Interop;

namespace IMAPI2.MediaItem
{
    /// <summary>
    /// 
    /// </summary>
    class FileItem : IMediaItem
    {
        private const long SECTOR_SIZE = 2048;

        private long m_fileLength = 0;

        public FileItem(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("The file added to FileItem was not found!", path);
            }

            Path = path;

            FileInfo fileInfo = new FileInfo(Path);
            displayName = fileInfo.Name;
            m_fileLength = fileInfo.Length;

            //
            // Get the File icon
            //
            SHFILEINFO shinfo = new SHFILEINFO();
            _ = Win32.SHGetFileInfo(Path, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), Win32.SHGFI_ICON | Win32.SHGFI_SMALLICON);

            if (shinfo.hIcon != null)
            {
                //The icon is returned in the hIcon member of the shinfo struct
                IconConverter imageConverter = new IconConverter();
                Icon icon = Icon.FromHandle(shinfo.hIcon);
                try
                {
                    fileIconImage = (Image)imageConverter.ConvertTo(icon, typeof(Image));
                }
                catch (NotSupportedException)
                {
                }
                Win32.DestroyIcon(shinfo.hIcon);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public long SizeOnDisc
        {
            get
            {
                if (m_fileLength > 0)
                {
                    return ((m_fileLength / SECTOR_SIZE) + 1) * SECTOR_SIZE;
                }

                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Path { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Image FileIconImage
        {
            get
            {
                return fileIconImage;
            }
        }
        private Image fileIconImage = null;


        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            return displayName;
        }
        private string displayName;

        public bool AddToFileSystem(IFsiDirectoryItem rootItem)
        {
            IStream stream = null;
            try
            {
                Win32.SHCreateStreamOnFile(Path, Win32.STGM_READ | Win32.STGM_SHARE_DENY_WRITE, ref stream);
                if (stream != null)
                {
                    rootItem.AddFile(displayName, stream);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (stream != null)
                {
                    Marshal.FinalReleaseComObject(stream);
                }
            }
            return false;
        }
    }
}
