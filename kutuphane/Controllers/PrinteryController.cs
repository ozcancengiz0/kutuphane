using kutuphane.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kutuphane.Controllers
{
    public class PrinteryController : Controller
    {
        private readonly ContextModel _contextModel;
        public PrinteryController(ContextModel contextModel)
        {
            _contextModel = contextModel;
        }
        public async Task<IActionResult> Index()
        {
            await _contextModel.SaveChangesAsync();
            return View(await _contextModel.printeryModels.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Index(PrinteryModel printeryModel)
        {
            await _contextModel.printeryModels.AddAsync(printeryModel);
            await _contextModel.SaveChangesAsync();
            return RedirectToAction(nameof(Printeries));
        }
        [HttpGet]
        public async Task<IActionResult> Printeries()
        {
            return View(await _contextModel.printeryModels.ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> DeletePrintery(int id)
        {
            var model = await _contextModel.printeryModels.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }
            else
            {
                _contextModel.printeryModels.Remove(model);
                await _contextModel.SaveChangesAsync();
                return RedirectToAction(nameof(Printeries));
            }
        }
        [HttpGet]
        public async Task<IActionResult> EditPrintery(int id)
        {
            var model = await _contextModel.printeryModels.FindAsync(id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditPrintery(PrinteryModel printeryModel)
        {
            var model = await _contextModel.printeryModels.FindAsync(printeryModel.PrinteryId);
            model.PrinteryName = printeryModel.PrinteryName;
            model.PrinteryAdress= printeryModel.PrinteryAdress;
            model.PrinteryPhone = printeryModel.PrinteryPhone;
            model.PrinteryDescription = printeryModel.PrinteryDescription;
            model.PrinteryMail = printeryModel.PrinteryMail;
            model.PrinteryIBAN= printeryModel.PrinteryIBAN;
            _contextModel.printeryModels.Update(model);
            await _contextModel.SaveChangesAsync();
            return RedirectToAction(nameof(Printeries));
        }
    }
}
