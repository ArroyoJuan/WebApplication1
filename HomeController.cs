using Microsoft.AspNetCore.Mvc;
using WebAppFormMVC.Models;
using WebApplication1.Models;

namespace WebAppFormMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Submit(ContactMessage model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            _context.ContactMessages.Add(model);
            _context.SaveChanges();

            TempData["SuccessMessage"] = "Tu mensaje ha sido enviado con éxito.";
            return RedirectToAction("Index");
        }
    }
}