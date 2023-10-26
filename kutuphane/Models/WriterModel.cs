using System.ComponentModel.DataAnnotations;

namespace kutuphane.Models
{
    public class WriterModel
    {
        [Key]
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterPhone { get; set; }
        public string WriterAbout { get; set; }
        public string WriterAdress { get; set; }
    }
}
