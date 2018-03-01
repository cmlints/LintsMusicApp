using MusicAppLints.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicAppLints.DAL
{
    public class MusicAlbumRepository : IMusicAlbumRepository, IDisposable
    {
        private List<MusicAlbum> _musicAlbums;

        public MusicAlbumRepository()
        {
            MusicAlbumXmlDataService musicAlbumXmlDataService = new MusicAlbumXmlDataService();

            using (musicAlbumXmlDataService)
            {
                _musicAlbums = musicAlbumXmlDataService.Read() as List<MusicAlbum>;
            }
        }

        public IEnumerable<MusicAlbum> SelectAll()
        {
            return _musicAlbums;
        }

        public MusicAlbum SelectOne(int id)
        {
            MusicAlbum selectedMusicAlbum = _musicAlbums.Where(a => a.Id == id).FirstOrDefault();

            return selectedMusicAlbum;
        }

        public void Insert(MusicAlbum musicAlbum)
        {
            musicAlbum.Id = NextIdValue();
            _musicAlbums.Add(musicAlbum);

            Save();
        }

        private int NextIdValue()
        {
            int currentMaxId = _musicAlbums.OrderByDescending(b => b.Id).FirstOrDefault().Id;
            return currentMaxId + 1;
        }

        public void Update(MusicAlbum UpdateMusicAlbum)
        {
            var oldMusicAlbum = _musicAlbums.Where(b => b.Id == UpdateMusicAlbum.Id).FirstOrDefault();

            if (oldMusicAlbum != null)
            {
                _musicAlbums.Remove(oldMusicAlbum);
                _musicAlbums.Add(UpdateMusicAlbum);
            }

            Save();
        }

        public void Save()
        {
            MusicAlbumXmlDataService musicAlbumXmlDataService = new MusicAlbumXmlDataService();

            using (musicAlbumXmlDataService)
            {
                musicAlbumXmlDataService.Write(_musicAlbums);
            }
        }

        public void Delete(int id)
        {
            var musicAlbum = _musicAlbums.Where(b => b.Id == id).FirstOrDefault();

            if (musicAlbum != null)
            {
                _musicAlbums.Remove(musicAlbum);
            }
        }

        public void Dispose()
        {
            _musicAlbums = null;
        }

    }
}