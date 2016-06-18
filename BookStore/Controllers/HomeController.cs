using BookStore.DAL.Model;
using BookStore.Services;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAuthorService _authorService;
        private readonly IBookService _bookService;

        public HomeController()
        {
            _authorService = new AuthorService();
            _bookService = new BookService();
        }


        public ActionResult Index()
        {
            var authors = _authorService.GetAuthors();
            var books = _bookService.GetBooks();

            ViewBag.Authors = authors;
            ViewBag.Books = books;

            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Author author)
        {
            if (ModelState.IsValid)
            {
                var products = _authorService.Create(author);

                return RedirectToAction("Index");
            }
            return PartialView(author);
        }

        [HttpGet]
        public ActionResult CreateBook()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult CreateBook(int id, Book book)
        {
            if (ModelState.IsValid)
            {
                book.AuthorId = id;

                var books = _bookService.Create(book);

                return RedirectToAction("Index");
            }
            return PartialView(book);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var author = _authorService.Delete(id);

            return PartialView(author);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var author = _authorService.DeleteConfirmed(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var author = _authorService.Edit(id);

            return PartialView(author);
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult EditComplite(Author author)
        {
            _authorService.EditComplite(author);

            return RedirectToAction("Index");
        }
    }
}