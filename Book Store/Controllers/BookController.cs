using Book_Store.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Book_Store.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _db;
        public BookController()
        {
            this._db = new BookRepository();
        }
        public IActionResult Index()
        {
            var data = _db.getallbooks();
            
            return View(data);
        }

        public IActionResult BookDetails(int id)
        {
            var data = _db.searchbookbyid(id);

            return View(data);
        }


    }
}
