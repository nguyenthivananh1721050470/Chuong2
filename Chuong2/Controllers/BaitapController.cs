using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chuong2.Models;

namespace Chuong2.Controllers
{
    public class BaitapController : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        // GET: Baitap
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hello()
        {
            return View();
        }
        public ActionResult GiaiPTB1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GiaiPTB1(double heSoA, double heSoB)
        {

            double x = gpt.GiaiPhuongTrinhBacNhat(heSoA, heSoB);
            ViewBag.NghiemPT = x;
            return View();

        }
    }
}