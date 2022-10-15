using System;
using System.ComponentModel.DataAnnotations;

namespace Book_Store.Data
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter a Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter a Author")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Please enter a Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter Total Pages")]
        public int? TotalPages { get; set; }
        [Required(ErrorMessage = "Please enter a Category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Please enter a Language")]
        public string Language { get; set; }
        public DateTime OnArrive { get; set; } = DateTime.Now;

        public DateTime OnTaken { get; set; } = DateTime.UtcNow;
    }
}
