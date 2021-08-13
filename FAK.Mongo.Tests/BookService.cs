using FAK.Mongo.API.Models;
using Moq;
using Xunit;

namespace FAK.Mongo.Tests
{
    public class BookService
    {
        private readonly Mock<IBookstoreDatabaseSettings> _settings;

        public BookService()
        {
            _settings = new Mock<IBookstoreDatabaseSettings>();
            _settings.Setup(s => s.ConnectionString).Returns("mongodb://localhost:27017");
            _settings.Setup(s => s.DatabaseName).Returns("BookstoreDb");
            _settings.Setup(s => s.BooksCollectionName).Returns("Books");
        }

        [Fact]
        public void ObterTodosOsLivrosDeveraRetornarDois()
        {
            //arrange
            API.Services.BookService bookRepositorio = new API.Services.BookService(_settings.Object);

            //action
            var result = bookRepositorio.Get();

            //assert
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void ObterPassandoIdDeveraRetornarUm()
        {
            //arrange
            API.Services.BookService bookRepositorio = new API.Services.BookService(_settings.Object);
            string id = "6108a3e82ced48f406b80f66";

            //action
            var result = bookRepositorio.GetById(id);

            //assert            
            Assert.Equal(id, result.Id);
        }
    }
}
