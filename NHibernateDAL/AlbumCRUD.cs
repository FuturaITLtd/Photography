/*
 * Date: 19/2/2013
 * Author: Andrew Chang
 * Project: Photography
 * File: AlbumCRUD.cs
 * Description:
 * Console Application for testing dal repository methods. To run change the assembly properties output from to Console Application.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using Photography.NHibernateDAL.Domain;

namespace Photography.NHibernateDAL
{
    class AlbumCRUD
    {
        static void Main(string[] args)
        {
            NHibernateHelper.LoadNHiberateConfig("");

            AlbumRepository rep = new AlbumRepository();

            // Create Albums
            var LandscapeAlbum = new Album {Name = "Italy", Genre = "Landscape", CreationDate = DateTime.Now};
            rep.AddAlbum(LandscapeAlbum);
      
            var AlbumToDeleteAlbum = new Album { Name = "AlbumToDelete", Genre = "Wildlife", CreationDate = DateTime.Now };
            rep.AddAlbum(AlbumToDeleteAlbum);

            // Read Album
            Album album = rep.GetAlbumByName("Italy");

            // Update Album
            album.Name = "Germany";
            rep.UpdateAlbum(album);

            // Delete Album
            rep.DeleteAlbum(AlbumToDeleteAlbum);
            Console.ReadKey();
        }
    }
}
