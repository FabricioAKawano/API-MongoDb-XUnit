using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAK.Mongo.API.Models
{
    public class BookstoreDatabaseSettings : IBookstoreDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string BooksCollectionName { get; set; }
    }

    public interface IBookstoreDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string BooksCollectionName { get; set; }
    }
}
