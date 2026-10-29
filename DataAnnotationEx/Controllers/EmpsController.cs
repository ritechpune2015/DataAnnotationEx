using DataAnnotationEx.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataAnnotationEx.Controllers
{
    public class EmpsController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Emp rec)
        {
            if (ModelState.IsValid)
            {
                //write a save code 
                return RedirectToAction("Index");
            }

           return View(rec);
        }
    }
}
