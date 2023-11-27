using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebThuySinh.Models;

namespace AQUA_WEB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string search = "", int page = 1)
        {
            AQUADBContext AQ = new AQUADBContext();
          
            List<Products> sp = AQ.Products.Where(row => row.ProductName.Contains(search)).ToList();
            ViewBag.Search = search;

            int NoOfRecordPerPage = 4;
            int NoOfPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(sp.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecordToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.Page = page;
            ViewBag.NoOfPages = NoOfPages;
            sp = sp.Skip(NoOfRecordToSkip).Take(NoOfRecordPerPage).ToList();

            return View(sp);
        }

        public ActionResult AboutUs() 
        { 
            return View();
        }
    }
}