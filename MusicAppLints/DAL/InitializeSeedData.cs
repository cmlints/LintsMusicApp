using MusicAppLints.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicAppLints.DAL
{
    public static class InitializeSeedData
    {
        public static IEnumerable<MusicAlbum> GetAllMusicAlbums()
        {
            IList<MusicAlbum> musicAlbums = new List<MusicAlbum>();

            musicAlbums.Add(new MusicAlbum
            {
                Id = 1,
                Genre = "Country",
                AlbumName = "Boom",
                Song = "You broke up with me",
                Artist = "Walker Hayes and Allen Jackson"
            });

            musicAlbums.Add(new MusicAlbum
            {
                Id = 2,
                Genre = "Country",
                AlbumName = "Start Here",
                Song = "Shut up and fish",
                Artist = "Maddie and Tae"
            });

            musicAlbums.Add(new MusicAlbum
            {
                Id = 3,
                Genre = "Country",
                AlbumName = "Riser",
                Song = "Drunk on a plane",
                Artist = "Dierks Bentley"
            });

            musicAlbums.Add(new MusicAlbum
            {
                Id = 4,
                Genre = "Country",
                AlbumName = "Pawn Shop",
                Song = "It ain't my fault",
                Artist = "Brothers Osborne"
            });

            musicAlbums.Add(new MusicAlbum
            {
                Id = 5,
                Genre = "Country",
                AlbumName = "Hunter Hayes",
                Song = "Everybodys got someone but me",
                Artist = "Hunter Hayes"
            });

            musicAlbums.Add(new MusicAlbum
            {
                Id = 6,
                Genre = "Country",
                AlbumName = "Montevallo",
                Song = "Break up in a small town",
                Artist = "Sam Hunt"
            });

            musicAlbums.Add(new MusicAlbum
            {
                Id = 7,
                Genre = "Country",
                AlbumName = "Getting Dressed in the Dark",
                Song = "Pray for you",
                Artist = "Jaron and the Long Road to Love"
            });

            musicAlbums.Add(new MusicAlbum
            {
                Id = 8,
                Genre = "Country",
                AlbumName = "Gloriana",
                Song = "Wild at heart",
                Artist = "Gloriana"
            });

            musicAlbums.Add(new MusicAlbum
            {
                Id = 9,
                Genre = "Country",
                AlbumName = "The Life of a Song",
                Song = "Cheater Cheater",
                Artist = "Joey and Rory"
            });

            musicAlbums.Add(new MusicAlbum
            {
                Id = 10,
                Genre = "Country",
                AlbumName = "Unleashed",
                Song = "Courtesy of the red white and blue",
                Artist = "Toby Keith"
            });

            musicAlbums.Add(new MusicAlbum
            {
                Id = 11,
                Genre = "Country",
                AlbumName = "Come on Over",
                Song = "Man! I feel like a women",
                Artist = "Shania Twain"
            });

            musicAlbums.Add(new MusicAlbum
            {
                Id = 12,
                Genre = "Country",
                AlbumName = "Room to Breathe",
                Song = "I'm gonna take that mountain",
                Artist = "Reba McEntire"
            });

            musicAlbums.Add(new MusicAlbum
            {
                Id = 13,
                Genre = "Country",
                AlbumName = "Meat and Candy",
                Song = "Break up with him",
                Artist = "Old Dominion"
            });

            musicAlbums.Add(new MusicAlbum
            {
                Id = 14,
                Genre = "Country",
                AlbumName = "Crash my party",
                Song = "Crash my party",
                Artist = "Luke Bryan"
            });

            musicAlbums.Add(new MusicAlbum
            {
                Id = 15,
                Genre = "Country",
                AlbumName = "Good Time",
                Song = "Good time",
                Artist = "Allen Jackson"
            });

            return musicAlbums;
        }
    }
}