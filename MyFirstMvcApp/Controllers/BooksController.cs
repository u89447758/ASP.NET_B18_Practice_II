using Microsoft.AspNetCore.Mvc;

namespace MyFirstMvcApp.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the book index page.");
        }

        // Do the same for the other two methods
        public IActionResult All()
        {
            return Content("<h1>Here is a list of ALL books!</h1>", "text/html");
            // Note: We can even return basic HTML this way by specifying the content type.
        }

        public IActionResult Details(int id)
        {
            // For now, just display the ID that was passed in.
            return Content($"Showing details for book with ID: {id}");
        }

        public IActionResult OldCatalog()
        {
            //Thistells the browser to make a new request to the "/Books/All" URL.
            return RedirectToAction("All", "Books");
        }



    }
}
