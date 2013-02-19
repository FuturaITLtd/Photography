using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Photography.AlbumService.Interfaces;
//using Photography.AlbumService.DataContracts;
using DAL = Photography.NHibernateDAL;
using DALDomain = Photography.NHibernateDAL.Domain;

namespace Photography.AlbumService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]

    // Create a call for each of the OperationMethod in the interface

    public class AlbumService : IAlbum
    {
        DAL.AlbumRepository repo;
        public void CreateAlbum(DALDomain.Album album)
        {
           repo = new DAL.AlbumRepository();     
           repo.AddAlbum(album);
        }

        public void UpdateAlbum(DALDomain.Album album)
        {
            repo = new DAL.AlbumRepository();   
        }

        public void DeleteAlbum(DALDomain.Album album)
        {
            repo = new DAL.AlbumRepository();   
        }

        public NHibernateDAL.Domain.Album SearchAlbumByName(string albumNameToSearch)
        {
            repo = new DAL.AlbumRepository();
            DALDomain.Album album = repo.GetAlbumByName(albumNameToSearch);
            return album;
        }
    }
}
