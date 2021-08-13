using System.Collections.Generic;
using FAK.Mongo.API.Models;
using FAK.Mongo.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace FAK.Mongo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookSerice;

        public BookController(IBookService bookService)
        {
            _bookSerice = bookService;
        }

        [HttpGet]
        public ActionResult<List<Book>> Get()
        {
            return _bookSerice.Get();
        }
    }
}
