using Microsoft.AspNetCore.Mvc;
using projectweb.Models;
using System.Diagnostics;
using userList.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace projectweb.Controllers
{
    public class productController : Controller
    {

        private usercontext Context { get; set; }

        public productController(usercontext ctx) { Context = ctx; }

        public IActionResult ShowMy()
        {
            if (HttpContext.Session.GetInt32("usr") == null)
            {
                return RedirectToAction("Login", "Home");
            }
            List<product> pro = Context.products.Include(product => product.user).Where(product => product.user.userid == HttpContext.Session.GetInt32("usr")).OrderBy(product => product.productname).ToList();

            return View("ShowMy",pro);
        }
        [HttpGet]
        public IActionResult Add()
        {

            ViewBag.Key = HttpContext.Session.GetInt32("usr");
            return View("AddPro");

        }
        [HttpPost]
        public IActionResult Add(product pro)
        {


            Context.products.Add(pro);
            Context.SaveChanges();

            return RedirectToAction("ShowMy");

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Key = HttpContext.Session.GetInt32("usr");
            product? pro = Context.products.Find(id);
            return View("edit",pro);
        }
        [HttpPost]
        public IActionResult Edit(product pro)
        {
            if (pro!=null)
            {

                Context.products.Update(pro);
                Context.SaveChanges();

            }

            return RedirectToAction("ShowMy");

        }

        
        public IActionResult Purchase() {
            if (HttpContext.Session.GetInt32("usr") == null)
            {
               return RedirectToAction("Login", "Home");
            }
            
                ViewBag.con = HttpContext.Session.GetInt32("usr");
                List<product> pro = Context.products.Include(product => product.user).Where(product => product.user.userid != HttpContext.Session.GetInt32("usr")).OrderBy(product => product.productname).ToList();
                return View("Purchase", pro);
            
        }
       
        public IActionResult Search(string name)
        {
            List<product> pro = Context.products.Include(product=> product.user).Where(product => product.productname.Contains(name) && product.user.userid != HttpContext.Session.GetInt32("usr")).ToList();
            return View("Purchase",pro);
        }
        public IActionResult Delete(int id)
        {
            product? product = Context.products.Find(id);
            if (product != null)
            {
                Context.products.Remove(product);
                Context.SaveChanges();
            }
            return RedirectToAction("ShowMy");
        }
        public IActionResult Buy(int id)
        {
            product? pro= Context.products.Find(id);
            return View(pro);

        }
    }
}
