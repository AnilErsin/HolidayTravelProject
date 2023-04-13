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
        public ActionResult Index()
        {
            var blogs = c.Blogs.ToList();

            return View(blogs);
        }

        BlogYorum by = new BlogYorum();
        public ActionResult BlogDetay(int id)
        {
            

            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();

            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();

            return View(by);
        }
    }
}