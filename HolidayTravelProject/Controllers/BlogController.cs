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

        public ActionResult BlogDetay(int id)
        {
            var blogbul = c.Blogs.Where(x => x.ID == id).ToList();

            return View(blogbul);
        }
    }
}