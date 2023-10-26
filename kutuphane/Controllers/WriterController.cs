using kutuphane.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kutuphane.Controllers
{
    public class WriterController : Controller
    {
        private readonly ContextModel _contextModel;  
        public WriterController(ContextModel contextModel)
        {
            _contextModel = contextModel;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(WriterModel writerModel)
        {
            await _contextModel.writerModels.AddAsync(writerModel);
            await _contextModel.SaveChangesAsync();
            return RedirectToAction(nameof(Writers));
        }
        public async Task<IActionResult> Writers()
        {
            return View(await _contextModel.printeryModels.ToListAsync());
        }

    }
}
