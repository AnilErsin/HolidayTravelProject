using HolidayTravelProject.Models.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HolidayTravelProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            //var blogs = c.Blogs.ToList();

            by.Deger1 = c.Blogs.Take(8).ToList();
            by.Deger3 = c.Blogs.Take(3).ToList();

            return View(by);
        }

      
        public ActionResult BlogDetay(int id)
        {
            

            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();

            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();

            return View(by);
        }
      [HttpGet]
      public PartialViewResult YorumYap()
        {
            return PartialView();
        }

        [HttpPost]
      public PartialViewResult YorumYap(Yorumlar b)
        {
            c.Yorumlars.Add(b);
            c.SaveChanges();
            return PartialView();
        }
    }
}