using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using phase3proj.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace phase3proj.Controllers
{
    public class customerdashController : Controller
    {
        private readonly phase3DBContext _context;

        public customerdashController(phase3DBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Checkout(int? id)
        {
            var laptopDetails = await _context.LaptopDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            ViewBag.price = laptopDetails.Price;
            return View();
        }
        public IActionResult Success()
        {
            return View();
        }
    }
}
