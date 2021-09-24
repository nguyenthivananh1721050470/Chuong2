using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chuong2.Models;

namespace Chuong2.Controllers
{
    public class StudentController : Controller
    {
        LapTrinhQuanLyDBcontext db = new LapTrinhQuanLyDBcontext();
        // GET: Student
        public ActionResult Index()
        {
            var model = db.Students.ToList();
            return View(model);
        }
        // tạo action create trả về view cho phép ngời dùng trả về thông tin
        public ActionResult Create ()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student std)
        {
            if(ModelState.IsValid)
            {
                db.Students.Add(std);
                db.SaveChanges();
                return RedirectToAction("Index");
            }    
            return View();
        }
    }
}