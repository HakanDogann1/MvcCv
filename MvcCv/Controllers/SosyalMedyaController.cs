using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class SosyalMedyaController : Controller
    {
       GenericRepository<TBLSosyalMedya> db = new GenericRepository<TBLSosyalMedya>();
        public ActionResult Index()
        {
            var result = db.List();
            return View(result);
        }
        [HttpPost]
        public ActionResult Ekle(TBLSosyalMedya t1)
        {
            db.Add(t1);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Güncelle(int id)
        {
            var result = db.Find(x=>x.Id == id);
            return View(result);
        }

        [HttpPost]
        public ActionResult Güncelle(TBLSosyalMedya tbl)
        {
            var t = db.Find(x=>x.Id == tbl.Id);
            t.Id = tbl.Id;
            t.Ad=tbl.Ad;
            t.Link=tbl.Link;
            db.Update(t);
            return RedirectToAction("Index");
        }
    }
}