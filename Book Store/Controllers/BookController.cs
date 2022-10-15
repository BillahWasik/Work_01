using Book_Store.Data;
using Book_Store.Models;
using Book_Store.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Book_Store.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _db;
        public BookController(BookRepository db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var data =await _db.getallbooks();
            
            return View(data);
        }

        public async Task<IActionResult> BookDetails(int id)
        {
            var data =await _db.searchbookbyid(id);

            return View(data);
        }
        public IActionResult Addnewbook(bool isSuccess = false, int Id = 0 )
        {
            ViewBag.IsSuccess = isSuccess;
            ViewBag.Id = Id;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Addnewbook(Book book )
        {
            if (ModelState.IsValid)
            {
                int id = await _db.AddNewBook(book);

                if (id > 0)
                {
                    return RedirectToAction("Addnewbook", new { isSuccess = true, Id = id });
                }
            }
            return View();
          
           
        }



    }
}
