using MusicAppLints.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicAppLints.DAL
{
    public interface IMusicAlbumRepository
    {
        IEnumerable<MusicAlbum> SelectAll();
        MusicAlbum SelectOne(int id);
        void Insert(MusicAlbum musicAlbum);
        void Update(MusicAlbum musicAlbum);
        void Delete(int id);
    }
}