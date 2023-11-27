using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebThuySinh.Models;

namespace AQUA_WEB.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Admin/Product
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

                return RedirectToAction("index", "Product");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Detail(int id)
        {
            AQUADBContext db = new AQUADBContext();
            Products ProductID = db.Products.Where(de => de.ProductID == id).FirstOrDefault();
            return View(ProductID);

        }


        public ActionResult Update(int id)
        {
            AQUADBContext db = new AQUADBContext();
            Products emp = db.Products.Where(row => row.ProductID == id).FirstOrDefault();

            return View(emp);
        }
        [HttpPost]
        public ActionResult Update(Products emps)
        {
            AQUADBContext db = new AQUADBContext();
            Products emp = db.Products.Where(row => row.ProductID == emps.ProductID).FirstOrDefault();

            emp.ProductName = emps.ProductName;
            emp.Description = emps.Description;
            emp.Price = emps.Price;
            emp.QuantityInStock = emps.QuantityInStock;
            emp.CategoryID = emps.CategoryID;
            emp.Image = emps.Image;
            emp.ImageProducts = emps.ImageProducts;


            db.SaveChanges();
            return View(emp);
        }

        //xóa
        public ActionResult Delete(int id)
        {
            AQUADBContext db = new AQUADBContext();
            Products Sanpham = db.Products.Where(row => row.ProductID == id).FirstOrDefault();

            return View(Sanpham);
        }
        [HttpPost]
        public ActionResult Delete(int id, Products xoa)
        {
            AQUADBContext db = new AQUADBContext();
            Products Sanpham = db.Products.Where(row => row.ProductID == id).FirstOrDefault();
            db.Products.Remove(Sanpham);
            db.SaveChanges();
            return RedirectToAction("Index", "Product");
        }
    }
}