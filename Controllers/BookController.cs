﻿using bookDemo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bookDemo.Controllers
{
    //ApiController bize hata bildirimlerinde falan kolayca bilgi fırlatmasını sağlar o yüzden eklenmesi çok önemlidir
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllBook()
        {
            var books = ApplicationContext.Books;
            return Ok(books);
        }

        //Aynı anda 2 tane get direkt olarak kullanılamaz o yüzden parametre kullanıyoruz
        //FromeRoute eklenmesi mecbur birşey değildir ama bazı karışıklıkları eklenebilir
        [HttpGet("{id:int}")]
        public IActionResult GetOneBook([FromRoute(Name ="id")] int id)
        {
            var book = ApplicationContext.
                Books.Where(x => x.Id.Equals(id)).SingleOrDefault();
            //SingleOrDefault LINQ içerisinde arama metodudur (sadece 1 tane olanı getir yada defualt değeri döndür demek)

            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }


    }
}
