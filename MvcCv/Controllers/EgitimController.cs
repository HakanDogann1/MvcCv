using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class EgitimController : Controller
    {
        // GET: Egitim
        EgitimRepository db = new EgitimRepository();
        
        public ActionResult Index()
        {
            var result = db.List().ToList();
            return View(result);
        }
        [HttpPost]
        public ActionResult EgitimEkle(TBLEgitimlerim tbl)
        {
            if (!ModelState.IsValid)
            {
                return View("EgitimEkle");
            }
            db.Add(tbl);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EgitimEkle()
        {
            return View();
        }
        public ActionResult EgitimSil(int id)
        {
            var result = db.Find(m=>m.Id == id);
            db.Delete(result);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult EgitimGüncelle(TBLEgitimlerim tbl)
        {
            TBLEgitimlerim t = db.Find(db=>db.Id == tbl.Id);
            t.Tarih=tbl.Tarih;
            t.AltBaslik1= tbl.AltBaslik1;
            t.Baslik=tbl.Baslik;
            t.AltBaslik2=tbl.AltBaslik2;
            t.GNO=tbl.GNO;
            db.Update(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EgitimGüncelle(int id)
        {
            var result = db.Find(m=>m.Id==id);
            return View(result);
        }
    }
}