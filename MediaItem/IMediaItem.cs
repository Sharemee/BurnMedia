//
// IMediaItem.cs
//
// by Eric Haddan
//
using System;
using System.Drawing;

using IMAPI2.Interop;


namespace IMAPI2.MediaItem
{
    interface IMediaItem
    {
        /// <summary>
        /// Returns the full path of the file or directory
        /// </summary>
        string Path { get; }

        /// <summary>
        /// Returns the size of the file or directory to the next largest sector
        /// </summary>
        long SizeOnDisc { get; }

        /// <summary>
        /// Returns the Icon of the file or directory
        /// </summary>
        Image FileIconImage { get; }

        /// <summary>
        /// Adds the file or directory to the directory item, usually the root.
        /// </summary>
        /// <param name="rootItem"></param>
        /// <returns></returns>
        bool AddToFileSystem(IFsiDirectoryItem rootItem);
    }
}
