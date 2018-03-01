using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MusicAppLints.Models
{
    [XmlRoot("MusicAlbums")]
    public class MusicAlbums
    {
        [XmlElement("MusicAlbum")]
        public List<MusicAlbum> musicAlbums;
    }
}