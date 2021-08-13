using System.Collections.Generic;
using FAK.Mongo.API.Models;

namespace FAK.Mongo.API.Services
{
    public interface IBookService
    {
        List<Book> Get();
        Book GetById(string id);
    }
}
