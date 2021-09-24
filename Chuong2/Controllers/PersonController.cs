using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Chuong2.Models;

namespace Chuong2.Controllers
{
    public class PersonController : Controller
    {
        //khai báo db context ddeer lam viecj database
        private LapTrinhQuanLyDBcontext db = new LapTrinhQuanLyDBcontext();

        // GET: Person
        public ActionResult Index()
        {
            // trả về view index để xem danh sách xây dựng trong db
            return View(db.Persons.ToList());
        }

        // GET: Person/Details/5
        public ActionResult Details(string id)
        {
            //nếu id truyền vào bằng null thì trả về trang badrequest
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // tìm kiếm persoon theo id name
            Person person = db.Persons.Find(id);
            if (person == null)
                // không tìm thấy trả về trang not found
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // GET: Person/Create
        public ActionResult Create()
            // trả về view kèm theo person
        {
            return View();
        }

        // POST: Person/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        // quản lí làm việc giữ client và server
        [ValidateAntiForgeryToken]
        public ActionResult Create( Person person)
        {
            // nhận các giá trị client gửi lên
            // nếu thảo mãn rằng buộc về dữ liệu
            if (ModelState.IsValid)
            {
             //add đối tượng lên client vào db context  

                db.Persons.Add(person);
                // lưu thay đổi vào db
                db.SaveChanges();
                // ddieuf hướng về action index
                return RedirectToAction("Index");
            }
            // giữ nguên view về create và báo lỗi
            return View(person);
        }

        // GET: Person/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.Persons.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: Person/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonID,PersonName")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        // GET: Person/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.Persons.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: Person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Person person = db.Persons.Find(id);
            db.Persons.Remove(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
