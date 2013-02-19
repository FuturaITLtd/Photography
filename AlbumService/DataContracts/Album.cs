using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Photography.AlbumService.DataContracts
{
    [DataContract]
    public class Album
    {
        [DataMember]
        public String Name;

        [DataMember]
        public String Genre;

        [DataMember]
        public DateTime CreationDate;
    }
}