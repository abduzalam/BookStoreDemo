using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BooksOldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            Book book = new Book()
            {
                Id = 1,
                Title = "Learning ASP.NET Core 6.0",
                Genre = "Programming & Software Developement",
                Price = 45,
                PublishDate = new DateTime(2012, 04, 23),
                //Authors = new List<string> { "Json De Oliveira", "Michel Bruchet" }
            };

            return View(book);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                // Logic to add the book to DB
                return RedirectToAction("Index");
            }
            return View(book);
        }
    }
}
