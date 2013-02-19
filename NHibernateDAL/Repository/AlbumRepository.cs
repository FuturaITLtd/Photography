/*
 * Date: 19/2/2013
 * Author: Andrew Chang
 * Project: Photography
 * File: AlbumRepository.cs
 * Description:
 * Repository of CRUD operations used in the Album domain 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using Photography.NHibernateDAL.Domain;

namespace Photography.NHibernateDAL
{
    public class AlbumRepository
    {
        // Method to Create a new album in database
        public void AddAlbum(Album newAlbum)
         {
            // Session to Database
            using (ISession session = NHibernateHelper.OpenSession())
            {
                // Transaction in Database
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(newAlbum);
                    transaction.Commit();
                }
            }
        }

        // Method to get Album based on Name
        public Album GetAlbumByName(string albumName)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                // May return match or null
                var result = session.QueryOver<Album>().Where(x => x.Name == albumName).SingleOrDefault();

                // If it result is null, return empty album
                return result ?? new Album();
            }
        }

        // Method to Updating an existing album in database
        public void UpdateAlbum(Album albumToUpdate)
        {
            // Session to Database
            using (ISession session = NHibernateHelper.OpenSession())
            {
                // Transaction in Database
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(albumToUpdate);
                    transaction.Commit();
                }
            }
        }

        // Method to Delete an existing album in database
        public void DeleteAlbum(Album albumToDelete)
        {
            // Session to Database
            using (ISession session = NHibernateHelper.OpenSession())
            {
                // Transaction in Database
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(albumToDelete);
                    transaction.Commit();
                }
            }
        }

    }
}
