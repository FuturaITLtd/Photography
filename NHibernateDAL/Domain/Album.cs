/*
 * Date: 19/2/2013
 * Author: Andrew Chang
 * Project: Photography
 * File: Album.cs
 * Description:
 * Defines a Domain for busines objects. The class represents a table in the database and the elements are attributes of the table.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Domain classes that represent table in database

namespace Photography.NHibernateDAL.Domain
{
    public class Album
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Genre { get; set; }
        public virtual DateTime CreationDate { get; set; }
    }
}
