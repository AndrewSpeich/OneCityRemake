using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OneCityProject.Models;

namespace OneCityProject.Controllers
{
	public class HomeController : Controller
	{
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var post = db.Post.Include(p => p.ApplicationUser).Include(p => p.PostLocation);
            var votes = db.Vote.ToList();
            List<object> information = new List<object>();
            Tuple<int, object> relationship = new Tuple<int, object>(1,2);
            foreach(var p in post)
            {
                int numofvotes = (from ID in votes where ID.PostID == p.ID select votes).Count();
                relationship = Tuple.Create<int,object>(numofvotes, p);
                information.Add(relationship);
            }
            ViewBag.data = information;
			return View(information);

    }

           
		

		public ActionResult Post()
		{

			return View();
		}


        public ActionResult PostDetailView()
        {

            return View();
        }

		public ActionResult CreatePost()
		{

			return View();
		}
	}
}