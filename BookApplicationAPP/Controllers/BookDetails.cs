using BookApplicationAPP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookApplicationAPP.Controllers
{
    public class BookDetails : Controller
    {
        private readonly ILogger<BookDetails> _logger;

        public BookDetails(ILogger<BookDetails> logger)
        {
            _logger = logger;
        }
        //private BookDBContext Context { get; }
        //public BookDetails(BookDBContext dBContext)
        //{
        //    this.Context = dBContext;
        //}

        [Route("BookDetails/BookDet")]
        public IActionResult BookDet()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult BookDet(BookInfo bookInfo)
        //{
        //    this.Context.BookInfo.Add(bookInfo);
        //    this.Context.SaveChanges();
        //    int id = bookInfo.BookId;

        //    return View(bookInfo);
        //}l
    }
}
