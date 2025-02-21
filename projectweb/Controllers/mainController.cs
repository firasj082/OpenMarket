using Microsoft.AspNetCore.Mvc;
using projectweb.Models;
using System.Diagnostics;
using userList.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace projectweb.Controllers
{
    public class MainController : Controller
    {
    private usercontext Context { get; set; }

    public MainController(usercontext ctx) => Context = ctx;


    public IActionResult Logout() {

            HttpContext.Session.Clear();
            return RedirectToAction("Login","Home"); 
        
        }

    public IActionResult Main()
        {
            return View("main");
        }

        [HttpGet]
   public IActionResult Edit()
        {

            user? ur = Context.users.Where(user => user.userid == HttpContext.Session.GetInt32("usr")).FirstOrDefault();


            return View("edit",ur);
        }

        [HttpPost]
        public IActionResult Edit(user user) {
            if (ModelState.IsValid) {

            Context.users.Update(user);
            Context.SaveChanges();

            }

            return RedirectToAction("Purchase","product");
        }
    public IActionResult Delete() {
            List<product> pro = Context.products.Include(product => product.user).Where(product => product.user.userid == HttpContext.Session.GetInt32("usr")).ToList();
            if (pro != null) { 

            foreach(product product in pro) {
                    Context.products.Remove(product);
                    Context.SaveChanges();
                }
            }
            user del = Context.users.Find(HttpContext.Session.GetInt32("usr"));
            Context.users.Remove(del);
            Context.SaveChanges();
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Home");
        }
        }
    }

