using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DigitalLibrary.Models;
using DigitalLibrary.Data;


namespace DigitalLibrary.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDBContext _context;
        public BookController(ApplicationDBContext context)
        {
            _context = context;
        }
        public IActionResult View()
        {
            var list = _context.Books.ToList();
            return View(list);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("View");
            }
            var book = _context.Books.Where(i=>i.BookID==id).SingleOrDefault();
            if (book == null)
            {
                return RedirectToAction("View");
            }
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Book record)
        {
            var book = _context.Books.Where(i => i.BookID == id).SingleOrDefault();
            book.DateReturned = DateTime.Now;
            _context.Books.Update(book);
            _context.SaveChanges();

            return RedirectToAction("View");
        }

    }
}
