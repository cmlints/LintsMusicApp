using MusicAppLints.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Xml.Serialization;

namespace MusicAppLints.DAL
{
    public class MusicAlbumXmlDataService : IMusicAlbumDataService, IDisposable
    {
        public List<MusicAlbum> Read()
        {
            // A MusicAlbums model is defined to pass a type to the XmlSerializer object
            MusicAlbums musicAlbumsObject;

            // initiallze a filestream object for reading
            string xmlFilePath = HttpContext.Current.Application["dataFilePath"].ToString();
            StreamReader sReader = new StreamReader(xmlFilePath);

            // initalize an XML serializer object
            XmlSerializer deserializer = new XmlSerializer(typeof(MusicAlbums));

            using (sReader)
            {
                //deserialize the XML data set into a generic object
                object xmlObject = deserializer.Deserialize(sReader);

                // cast the generic object to the list class
                musicAlbumsObject = (MusicAlbums)xmlObject;
            }

            return musicAlbumsObject.musicAlbums;
        }

        public void Write(List<MusicAlbum> musicAlbums)
        {
            // initalize a FileStream object for reading
            string xmlFilePath = HttpContext.Current.Application["dataFilePath"].ToString();

            StreamWriter sWriter = new StreamWriter(xmlFilePath, false);

            XmlSerializer serializer = new XmlSerializer (typeof(List<MusicAlbum>), new XmlRootAttribute("MusicAlbums"));

            using (sWriter)
            {
                serializer.Serialize(sWriter, musicAlbums);
            }
        }

        public void Dispose()
        {

        }

    }
}