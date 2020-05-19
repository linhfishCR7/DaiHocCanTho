using DaiHocCanTho.Context;
using DaiHocCanTho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DaiHocCanTho.Controllers
{ 

    public class HomeController : Controller
    {
        private KhoaContext db = new KhoaContext();

        // GET: Home
        public ActionResult Index()
        {
            var data = (from p in db.Khoas.OrderByDescending(i => i.Id)
                        select p).Take(4);

            return View(data.ToList());
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult left_sidebar()
        {
            return View();
        }
        public ActionResult right_sidebar()
        {
            return View();
        }
        public ActionResult no_sidebar()
        {
            return View();
        }
        public ActionResult ChiTietKhoa( int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Khoa Khoas = db.Khoas.Find(id);
            if (Khoas == null)
            {
                return HttpNotFound();
            }
            return View(Khoas);
        }
        public ActionResult TatCaKhoa()
        {
            return View(db.Khoas.ToList());
        }
    }
    }
