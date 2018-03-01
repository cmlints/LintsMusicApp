using MusicAppLints.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicAppLints.DAL
{
    public class DataService
    {
        public IEnumerable<MusicAlbum> InitializeData()
        {
            IEnumerable<MusicAlbum>
                musicAlbums = new List<MusicAlbum>()
                {
                    new MusicAlbum()
                    {
                        Id = 1,
                        Genre = "Country",
                        AlbumName = "",                       
                        Song = "You broke up with me",
                        Artist = "Walker Hayes"
                    },

                    new MusicAlbum()
                    {
                        Id = 2,
                        Genre = "Country",
                        AlbumName = "",
                        Song = "Shut Up and Fish",
                        Artist = "Maddie and Tae"
                    },

                    new MusicAlbum()
                    {
                        Id = 3,
                        AlbumName = "Raiser",
                        Genre = "Country",
                        Song = "Drunk on a Plane",
                        Artist = "Dierks Bently"
                    },

                     new MusicAlbum()
                     {
                        Id = 4,
                        Genre = "Country",
                        AlbumName = "",
                        Song = "It Ain't My Fault",
                        Artist = "Brothers Osbone"
                     },

                    new MusicAlbum()
                    {
                        Id = 5,
                        Genre = "Country",
                        AlbumName = "",
                        Song = "Everybody" +
                        "s Got Somebody But Me",
                        Artist = ""
                    },

                    new MusicAlbum()
                    {
                        Id = 6,
                        Genre = "Country",
                        AlbumName = "",
                        Song = "Cop Car",
                        Artist = "Sam Hunt"
                    },

                    new MusicAlbum()
                    {
                        Id = 7,
                        Genre = "Country",
                        AlbumName = "",
                        Song = "Pray For You",
                        Artist = ""
                    },

                    new MusicAlbum()
                    {
                        Id = 8,
                        Genre = "Country",
                        AlbumName = "",
                        Song = "Wild at Heart",
                        Artist = ""
                    },

                    new MusicAlbum()
                    {
                        Id = 9,
                        Genre = "Country",
                        AlbumName = "",
                        Song = "Cheater Cheater",
                        Artist = "Joey & Rory"
                    },

                    new MusicAlbum()
                    {
                        Id = 10,
                        Genre = "Country",
                        AlbumName = "",
                        Song = "Man! I Feel Like a Women",
                        Artist = ""
                    },

                    new MusicAlbum()
                    {
                        Id = 11,
                        Genre = "Country",
                        AlbumName = "",
                        Song = "Sky Full of Angels",
                        Artist = "Reba McEntire"
                    },

                    new MusicAlbum()
                    {
                        Id = 12,
                        Genre = "Country",
                        AlbumName = "",
                        Song = "Play It Again",
                        Artist = "Luke Bryan"
                    },

                    new MusicAlbum()
                    {
                        Id = 13,
                        Genre = "Country",
                        AlbumName = "",
                        Song = "Good Time",
                        Artist = "Allen Jackson"
                    },

                    new MusicAlbum()
                    {
                        Id = 14,
                        Genre = "Country",
                        AlbumName = "",
                        Song = "Courtesy of the Red White and Blue",
                        Artist = "Toby Keith"
                    },

                    new MusicAlbum()
                    {
                        Id = 15,
                        Genre = "Country",
                        AlbumName = "",
                        Song = "Break Up With Him",
                        Artist = "Old Dominion"
                    },                    
                };

            return musicAlbums;

        }
    }
}