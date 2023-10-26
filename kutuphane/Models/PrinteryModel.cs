using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

namespace kutuphane.Models
{
    public class PrinteryModel
    {
        [Key]
        public int PrinteryId { get; set; }
        public string PrinteryName { get; set;}
        public string PrinteryAdress { get; set;}
        public string PrinteryDescription { get; set;}
        public string PrinteryPhone { get; set; }
        public string PrinteryMail { get; set; }
        public string PrinteryIBAN { get; set; }
    }
}
