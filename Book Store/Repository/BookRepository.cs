using Book_Store.Models;
using System.Collections.Generic;
using System.Linq;

namespace Book_Store.Repository
{
    public class BookRepository
    {
        public List<BookModel> bookModels()
        {
            return new List<BookModel>()
            {
                new BookModel() { id = 1, Title = "ASP.NET", Author = "Wasik",Description="This is for book description" },
                new BookModel() { id = 2, Title ="C#", Author = "Billah",Description="This is for book description" },
                new BookModel() { id = 3, Title ="JAVA", Author = "Farhad",Description="This is for book description" },
                new BookModel() { id = 4, Title ="C++", Author = "Mutasim",Description="This is for book description" },
                new BookModel(){ id = 5, Title ="Bishop",Author="James",Description="This is for book description"},
                new BookModel(){ id = 6, Title ="Harry Potter",Author="McKay",Description="This is for book description"},
                new BookModel (){ id = 7, Title ="Nouka Dubi",Author="RabindraNath Tagore",Description="This is for book description"},
                new BookModel() {id= 8,Title="PHP",Author="Bill Gates",Description="This is for book description" }

            };

        }

        public List<BookModel> getallbooks() 
        {
            return bookModels();
        }
        public BookModel searchbookbyid(int Id)
        {
            return bookModels().Where(x => x.id == Id).FirstOrDefault();
        }

        public List<BookModel> Searchallbooks(string author , string title)
        {
            return bookModels().Where(x => x.Author == author || x.Title == title).ToList();
        }
    }
}
