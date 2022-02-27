//
// DirectoryItem.cs
//
// by Eric Haddan
//
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using IMAPI2.Interop;

namespace IMAPI2.MediaItem
{
    /// <summary>
    /// 媒体项目之目录类型项目
    /// </summary>
    public class DirectoryItem : IMediaItem
    {
        /// <summary>
        /// 文件或者目录路径
        /// </summary>
        public string Path { get; private set; }
        /// <summary>
        /// 文件图标图片
        /// </summary>
        public Image FileIconImage { get; private set; }
        private string displayName;
        private readonly List<IMediaItem> mediaItems;

        /// <summary>
        /// 目录类型项目构造函数
        /// </summary>
        /// <param name="directoryPath">目录路径</param>
        public DirectoryItem(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
                throw new FileNotFoundException("The directory added to DirectoryItem was not found!", directoryPath);
            Path = directoryPath;

            FileInfo fileInfo = new FileInfo(Path);
            displayName = fileInfo.Name;

            // Init medial item container
            mediaItems = new List<IMediaItem>();

            // Get all the files in the directory
            string[] files = Directory.GetFiles(Path);
            foreach (string file in files)
            {
                mediaItems.Add(new FileItem(file));
            }

            // Get all the subdirectories
            string[] directories = Directory.GetDirectories(Path);
            foreach (string directory in directories)
            {
                mediaItems.Add(new DirectoryItem(directory));
            }

            // Get the Directory icon
            SHFILEINFO shinfo = new SHFILEINFO();
            IntPtr hImg = Win32.SHGetFileInfo(Path, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), Win32.SHGFI_ICON | Win32.SHGFI_SMALLICON);
            if (shinfo.hIcon != null)
            {
                //The icon is returned in the hIcon member of the shinfo struct
                IconConverter imageConverter = new IconConverter();
                Icon icon = Icon.FromHandle(shinfo.hIcon);
                try
                {
                    FileIconImage = (Image)imageConverter.ConvertTo(icon, typeof(Image));
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
        public override string ToString() => displayName;

        /// <summary>
        /// 
        /// </summary>
        public long SizeOnDisc
        {
            get
            {
                long totalSize = 0;
                foreach (IMediaItem mediaItem in mediaItems)
                {
                    totalSize += mediaItem.SizeOnDisc;
                }
                return totalSize;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rootItem"></param>
        /// <returns></returns>
        public bool AddToFileSystem(IFsiDirectoryItem rootItem)
        {
            try
            {
                rootItem.AddTree(Path, true);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
