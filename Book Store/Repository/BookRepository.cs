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

        public List<BookModel> getallbooks() 
        {
            return bookModels();
        }
        public BookModel searchbookbyid(int id)
        {
            return bookModels().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> Searchallbooks(string author , string title)
        {
            return bookModels().Where(x => x.Author == author || x.Title == title).ToList();
        }
    }
}
