//using Lab3_NguyenTranDau.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3_NguyenTranDau.Controllers
{
    public class HomeController : Controller
    {
        //public ApplicationDbContext _dbContext;
        //public HomeController()
        //{
        //    _dbContext = new ApplicationDbContext();
        //}
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}