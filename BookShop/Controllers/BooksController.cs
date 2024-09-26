using BookShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    public class BooksController : Controller
    {
        private static List<Book> books = new List<Book>
        {
        new Book { Id = 1, Title = "C# for Beginners", Author = "John Doe", Price = 19.99M, Description = "A great introduction to C#" },
        new Book { Id = 2, Title = "ASP.NET Core", Author = "Jane Smith", Price = 24.99M, Description = "Learn how to build web apps with ASP.NET Core" },
        new Book { Id = 3, Title = "Entity Framework Core", Author = "James Brown", Price = 29.99M, Description = "Master database interactions with EF Core" }

        };

        public IActionResult Index()
        {
            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = books.Find(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        //public IActionResult AddToCart(int id)
        //{
        //    // voeg boek toe aan winkelwagen
        //    return RedirectToAction(Index());
        //}
    }
}
