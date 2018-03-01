using MusicAppLints.DAL;
using MusicAppLints.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicAppLints.Controllers
{
    public class MusicAlbumController : Controller
    {
        [HttpGet]
        public ActionResult Index(string sortOrder)
        {
            //
            // instantiate a repository
            //
            MusicAlbumRepository musicAlbumRepository = new MusicAlbumRepository();

            //
            // create a distinct list of cities for the artist filter
            //
            ViewBag.Artist = ListOfArtists();

            //
            // return the data context as an enumerable
            //
            IEnumerable<MusicAlbum> musicAlbums;
            using (musicAlbumRepository)
            {
                musicAlbums = musicAlbumRepository.SelectAll() as IList<MusicAlbum>;
            }

            //
            // sort by name unless posted as a new sort
            //
            switch (sortOrder)
            {
                case "Song":
                    musicAlbums = musicAlbums.OrderBy(musicAlbum => musicAlbum.Song);
                    break;
                case "Artist":
                    musicAlbums = musicAlbums.OrderBy(musicAlbum => musicAlbum.Artist);
                    break;
                default:
                    musicAlbums = musicAlbums.OrderBy(musicAlbum => musicAlbum.Song);
                    break;
            }

            return View(musicAlbums);
        }

        [HttpPost]
        public ActionResult Index(string searchCriteria, string artistFilter)
        {
            //
            // instantiate a repository
            //
            MusicAlbumRepository musicAlbumRepository = new MusicAlbumRepository();

            //
            // create a distinct list of artists for the artist filter
            //
            //IEnumerable<string> artists = ListOfArtists();
            ViewBag.Artists = ListOfArtists();

            //
            // return the data context as an enumerable
            //
            IEnumerable<MusicAlbum> musicAlbums;
            using (musicAlbumRepository)
            {
                musicAlbums = musicAlbumRepository.SelectAll() as IList<MusicAlbum>;
            }

            //
            // if posted with a search on music album name
            //
            if (searchCriteria != null)
            {
                musicAlbums = musicAlbums.Where(musicAlbum => musicAlbum.Song.ToUpper().Contains(searchCriteria.ToUpper()));
            }

            //
            // if posted with a filter by city
            //
            if (artistFilter != "" || artistFilter == null)
            {
                musicAlbums = musicAlbums.Where(musicAlbum => musicAlbum.Artist == artistFilter);
            }

            return View(musicAlbums);
        }

        [NonAction]
        private IEnumerable<string> ListOfArtists()
        {
            //
            // instantiate a repository
            //
            MusicAlbumRepository musicAlbumRepository = new MusicAlbumRepository();

            //
            // return the data context as an enumerable
            //
            IEnumerable<MusicAlbum> musicAlbums;
            using (musicAlbumRepository)
            {
                musicAlbums = musicAlbumRepository.SelectAll() as IList<MusicAlbum>;
            }

            //
            // get a distinct list of cities
            //
            var artist = musicAlbums.Select(musicAlbum => musicAlbum.Artist).Distinct().OrderBy(x => x);

            return artist;
        }

        public ActionResult Details(int id)
        {
            MusicAlbumRepository musicAlbumRepository = new MusicAlbumRepository();
            MusicAlbum musicAlbum = new MusicAlbum();

            using (musicAlbumRepository)
            {
                musicAlbum = musicAlbumRepository.SelectOne(id);
            }

            return View(musicAlbum);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(MusicAlbum musicAlbum)
        {
            try
            {
                MusicAlbumRepository musicAlbumRepository = new MusicAlbumRepository();

                using (musicAlbumRepository)
                {
                    musicAlbumRepository.Insert(musicAlbum);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                // TODO Add view for error message
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            MusicAlbumRepository musicAlbumRepository = new MusicAlbumRepository();
            MusicAlbum musicAlbum = new MusicAlbum();

            using (musicAlbumRepository)
            {
                musicAlbum = musicAlbumRepository.SelectOne(id);
            }

            return View(musicAlbum);
        }


        [HttpPost]
        public ActionResult Edit(MusicAlbum musicAlbum)
        {
            try
            {
                MusicAlbumRepository musicAlbumRepository = new MusicAlbumRepository();

                using (musicAlbumRepository)
                {
                    musicAlbumRepository.Update(musicAlbum);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                // TODO Add view for error message
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            MusicAlbumRepository musicAlbumRepository = new MusicAlbumRepository();
            MusicAlbum musicAlbum = new MusicAlbum();

            using (musicAlbumRepository)
            {
                musicAlbum = musicAlbumRepository.SelectOne(id);
            }

            return View(musicAlbum);
        }


        [HttpPost]
        public ActionResult Delete(int id, MusicAlbum musicAlbum)
        {
            try
            {
                MusicAlbumRepository musicAlbumRepository = new MusicAlbumRepository();

                using (musicAlbumRepository)
                {
                    musicAlbumRepository.Delete(id);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                // TODO Add view for error message
                return View();
            }
        }
    }
}
