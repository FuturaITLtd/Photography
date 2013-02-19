using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using Photography.AlbumService.DataContracts;
using DAL = Photography.NHibernateDAL.Domain; 

namespace Photography.AlbumService.Interfaces
{
    [ServiceContract]
    public interface IAlbum
    {
        [OperationContract]
        void CreateAlbum(DAL.Album newAlbum);

        [OperationContract]
        void UpdateAlbum(DAL.Album updateAlbum);

        [OperationContract]
        void DeleteAlbum(DAL.Album deleteAlbum);

        [OperationContract]
        DAL.Album SearchAlbumByName(String albumNameToSearchBy);
    }
}