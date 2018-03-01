using MusicAppLints.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicAppLints.DAL
{
    /// <summary>
    /// Data service interface to read and write an entire file based on the MusicAlbum Class
    /// </summary>
    public interface IMusicAlbumDataService
    {
        List<MusicAlbum> Read();
        void Write(List<MusicAlbum> MusicAlbums);
    }
}