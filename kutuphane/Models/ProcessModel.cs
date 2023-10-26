using System.ComponentModel.DataAnnotations;

namespace kutuphane.Models
{
    public class ProcessModel
    {
        [Key]
        public int ProcessId { get; set; }
        public int Books { get; set; }
        public int Writer { get; set; }
        public int Printery { get; set; }
        public int Unit { get; set; }
        public double Price { get; set; }
        public int BookId { get; set; }
        public BooksModel Book { get; set; }
    }
}
