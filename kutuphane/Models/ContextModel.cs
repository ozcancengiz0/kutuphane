using Microsoft.EntityFrameworkCore;

namespace kutuphane.Models
{
    public class ContextModel:DbContext
    {
        public ContextModel(DbContextOptions<ContextModel>options):base(options)
        {
            
        }
        public DbSet<BooksModel> booksModels { get; set; }
        public DbSet<CategoryModel> categoryModels { get; set; }
        public DbSet<PrinteryModel> printeryModels { get; set; }
        public DbSet<WriterModel> writerModels { get; set; }
        public DbSet<ProcessModel> processModels { get; set; }


    }
}
