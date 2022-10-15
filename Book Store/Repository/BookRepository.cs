using Book_Store.Data;
using Book_Store.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Book_Store.Repository
{
    public class BookRepository
    {
        public List<BookModel> bookModels()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "ASP.NET", Author = "Wasik",Description="This is for book description",Category="Programming",Language="English",TotalPages=1022},
                new BookModel() { Id = 2, Title ="C#", Author = "Billah",Description="This is for book description",Category="Programming",Language="English",TotalPages=122},
                new BookModel() { Id = 3, Title ="JAVA", Author = "Farhad",Description="This is for book description",Category="Story",Language="Bangla",TotalPages=1111 },
                new BookModel() { Id = 4, Title ="C++", Author = "Mutasim",Description="This is for book description",Category="History",Language="Hindi",TotalPages=1022},
                new BookModel(){ Id = 5, Title ="Bishop",Author="James",Description="This is for book description" ,Category="Programming",Language="English",TotalPages=1222},
                new BookModel(){ Id = 6, Title ="Harry Potter",Author="McKay",Description="This is for book description",Category="Game",Language="Hebrew",TotalPages=1212},
                new BookModel (){ Id = 7, Title ="Nouka Dubi",Author="RabindraNath Tagore",Description="This is for book description",Category="Programming",Language="English",TotalPages=1022},
                new BookModel() {Id= 8,Title="PHP",Author="Bill Gates",Description="This is for book description",Category="Programming",Language="English",TotalPages=1022},
                new BookModel() { Id = 9, Title ="Human Psychology",Author ="Muntahid",Description="This is a medical book",Category="Programming",Language="English",TotalPages=1022}

            };

        }

        public async Task <List<BookModel>>  getallbooks() 
        {
            var books = new List<BookModel>();

            var data = await _db.Books.ToListAsync();

            if (data?.Any() == true)
            {
                foreach (var item in data)
                {
                    books.Add(new BookModel()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Author = item.Author,
                        Description = item.Description,
                        Category = item.Category,
                        Language = item.Language,
                        TotalPages = item.TotalPages.HasValue ? item.TotalPages.Value : 0
                    });
                }
            }


            return books;
            
        }
        public async Task<BookModel> searchbookbyid(int id)
        {
            var data =await _db.Books.FirstOrDefaultAsync(x => x.Id == id);

            if (data != null) 
            {
                var books = new BookModel()
                {
                    Title = data.Title,
                    Id = data.Id,
                    Author = data.Author,
                    Category = data.Category,
                    Description = data.Description,
                    Language = data.Language,
                    TotalPages = data.TotalPages.HasValue ? data.TotalPages.Value : 0

                };
                return books;
            }
            else 
            { 
                return null; 
            }

           
        }

        public List<BookModel> Searchallbooks(string author , string title)
        {
            return bookModels().Where(x => x.Author == author || x.Title == title).ToList();
        }

        private readonly ApplicationDbContext _db;

        public BookRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<int> AddNewBook(Book data)
        {
            var books = new Book()
            {
                Title = data.Title,
                Author = data.Author,
                Description = data.Description,
                Category = data.Category,
                Language = data.Language,
                TotalPages = data.TotalPages.HasValue ? data.TotalPages.Value : 0

            };
              await  _db.Books.AddAsync(books);
               await _db.SaveChangesAsync();
            
            return books.Id;
        }
    }
}
