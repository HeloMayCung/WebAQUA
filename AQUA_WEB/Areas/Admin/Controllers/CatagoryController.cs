using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebThuySinh.Models;

namespace AQUA_WEB.Areas.Admin.Controllers
{
    public class CatagoryController : Controller
    {
        // GET: Admin/Catagory
        public ActionResult Index()
        {
            AQUADBContext AQ = new AQUADBContext();
            List<Catagories> CT = AQ.Catagories.ToList();
            return View(CT);
        }

        public ActionResult Create()
        {
            AQUADBContext sp = new AQUADBContext();
            ViewBag.categories = sp.Catagories.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Products p)
        {
            AQUADBContext sp = new AQUADBContext();
            ViewBag.categories = sp.Catagories.ToList();
            if (ModelState.IsValid)
            {
                sp.Products.Add(p);
                sp.SaveChanges();

                return RedirectToAction("index", "Home");
            }
            else
            {
                return View();
            }
        }



        public ActionResult Update(string id)
        {
            AQUADBContext db = new AQUADBContext();
            Catagories emp = db.Catagories.Where(row => row.CategoryID == id).FirstOrDefault();

            return View(emp);
        }
        [HttpPost]
        public ActionResult Update(Catagories emps)
        {
            AQUADBContext db = new AQUADBContext();
            Catagories emp = db.Catagories.Where(row => row.CategoryID == emps.CategoryID).FirstOrDefault();

            emp.CategoryID = emps.CategoryID;
            emp.CategoryName = emps.CategoryName;
            db.SaveChanges();
            return RedirectToAction("index", "Catagory");
        }

        //xóa
        public ActionResult Delete(string id)
        {
            AQUADBContext db = new AQUADBContext();
            Catagories LoaiSanpham = db.Catagories.Where(row => row.CategoryID == id).FirstOrDefault();

            return View(LoaiSanpham);
        }
        [HttpPost]
        public ActionResult Delete(string id, Products xoa)
        {
            AQUADBContext db = new AQUADBContext();
            Catagories Sanpham = db.Catagories.Where(row => row.CategoryID == id).FirstOrDefault();
            db.Catagories.Remove(Sanpham);
            db.SaveChanges();
            return RedirectToAction("Index", "Catagory");
        }
    }
}