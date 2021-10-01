using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using phase3proj.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace phase3proj.Controllers
{
    public class LoginController : Controller
    {
        private readonly phase3DBContext _context;
        public List<Admin> admins { get; set; }
        public List<Seller> sellers { get; set; }
        public List<Customer> customers { get; set; }
        public List<LaptopDetails> laptops { get; set; }
        public LoginController(phase3DBContext context)
        {
            _context = context;
            admins = new List<Admin>() {
                    new Admin { Id = 1001, Aname = "admin1", Password = "1234"},
                    new Admin { Id = 1002, Aname = "admin2", Password = "1234"}
            };
            sellers = _context.Seller.ToList();
            customers = _context.Customer.ToList();
            laptops = _context.LaptopDetails.ToList();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminLogin(Admin model)
        {
            var index = admins.FindIndex(x => x.Aname == model.Aname);
            if (model.Aname == admins[index].Aname && model.Password == admins[index].Password)
            {
                //create session after login
                HttpContext.Session.SetString("aname", model.Aname);
                HttpContext.Session.SetInt32("s_count", sellers.Count());
                HttpContext.Session.SetInt32("c_count", customers.Count());
                HttpContext.Session.SetInt32("l_count", laptops.Count());
                return RedirectToAction("dashboard", "admins", new { area = "" });
            }
            else
            {
                ViewBag.msg = "invalid input credentials...";
            }
            return View();
        }

        //seller cruds
        public IActionResult SellerLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SellerLogin(Seller model)
        {
            var index = sellers.FindIndex(x => x.Sname == model.Sname);
            if (model.Sname == sellers[index].Sname && model.Password == sellers[index].Password)
            {
                //create session after login
                HttpContext.Session.SetString("sname", model.Sname);
                HttpContext.Session.SetInt32("sid", sellers[index].Id);
                ViewBag.msg = HttpContext.Session.GetString("sname");
                return RedirectToAction("dashboard", "sellerdash", new { area = "" });
            }
            else
            {
                ViewBag.msg = "invalid input credentials...";
            }

            return View();
        }
        public IActionResult RegisterSeller()
        {
            return RedirectToAction("create", "sellers", new { area = "" });
        }

        //customer cruds
        public IActionResult CustomerLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CustomerLogin(Customer model)
        {
            var index = customers.FindIndex(x => x.Cname == model.Cname);
            if (model.Cname == customers[index].Cname && model.Password == customers[index].Password)
            {
                //create session after login
                HttpContext.Session.SetString("cname", model.Cname);
                ViewBag.msg = HttpContext.Session.GetString("cname");
                return RedirectToAction("viewproducts", "laptopdetails");
            }
            else
            {
                ViewBag.msg = "invalid input credentials...";
            }
            return View();
        }
        public IActionResult RegisterCustomer()
        {
            return RedirectToAction("create", "customers", new { area = "" });
        }
    }
}
