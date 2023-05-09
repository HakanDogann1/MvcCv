using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class YetenekController : Controller
    {
        // GET: Yetenek
        YetenekRepository db = new YetenekRepository();
        public ActionResult Index()
        {
            var result = db.List().ToList();
            return View(result);
        }
        [HttpPost]
        public ActionResult YetenekEkle(TBLYeteneklerim tbl)
        {
            db.Add(tbl);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekEkle()
        {
            return View();
        }
        public ActionResult YetenekSil(int id)
        {
            TBLYeteneklerim result = db.Find(m=>m.Id == id);
            db.Delete(result);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekGüncelle(int id)
        {
            var result = db.Find(m => m.Id == id);
            return View(result);
        }
        [HttpPost]
        public ActionResult YetenekGüncelle(TBLYeteneklerim tbl)
        {
            TBLYeteneklerim t = db.Find(m=> m.Id == tbl.Id);
            t.Id = tbl.Id;
            t.Yetenek=tbl.Yetenek;
            t.Oran=tbl.Oran;
            db.Update(t);
            return RedirectToAction("Index");
        }

       

        

    }
}