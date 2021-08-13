using System.Collections.Generic;
using System.Linq;
using FAK.Mongo.API.Models;
using MongoDB.Driver;

namespace FAK.Mongo.API.Services
{
    public class BookService : IBookService
    {
        private readonly IMongoCollection<Book> _books;

        public BookService(IBookstoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var db = client.GetDatabase(settings.DatabaseName);
            _books = db.GetCollection<Book>(settings.BooksCollectionName);
        }

        public List<Book> Get() => _books.Find(b => true).ToList();

        public Book GetById(string id)
        {
            var filter = Builders<Book>.Filter.Eq(b => b.Id, id);
            return _books.Find(filter).FirstOrDefault();
        }
    }
}
