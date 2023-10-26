using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace kutuphane.Models
{
    public class BooksModel
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }        
        public int BookPage { get; set; }
        public int WriterId { get; set; }
        public WriterModel Writer { get; set; }
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
        public int PrinteryId { get; set; }
        public PrinteryModel Printery { get; set; }
    }
}
