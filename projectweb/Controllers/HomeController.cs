using Microsoft.AspNetCore.Mvc;
using projectweb.Models;
using System.Diagnostics;
using userList.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace projectweb.Controllers
{
    public class HomeController : Controller
    {
        private usercontext Context { get; set; }

        public HomeController(usercontext ctx) => Context = ctx;

        
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string name, string pas)
        {
            user? usr = Context.users.Where(user => user.Username == name && user.Password == pas).FirstOrDefault();


            if (usr != null)
            {

                HttpContext.Session.SetInt32("usr", usr.userid);
                HttpContext.Session.SetString("name", usr.Username);
                return RedirectToAction("Purchase","product");

            }
            return View("login");

        }
       
        [HttpGet]
        public IActionResult Signup()
        {


            return View("signup");

        }
        [HttpPost]
        public IActionResult Signup(user us)
        {


            Context.users.Add(us);
            Context.SaveChanges();

            return View("login");

        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });



        }

        





    }




}

