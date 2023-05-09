using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class SertifikaController : Controller
    {
        // GET: Sertifika
        GenericRepository<TBLSertifikalarım> db = new GenericRepository<TBLSertifikalarım> ();
        public ActionResult Index()
        {
            var result = db.List().ToList();
           
            return View(result);
        }
        [HttpPost]
        public ActionResult SertifikaGüncelle(TBLSertifikalarım tbl)
        {
            TBLSertifikalarım t = db.Find(m=>m.Id == tbl.Id);
            t.Tarih=tbl.Tarih;
            t.Aciklama=tbl.Aciklama;
            db.Update(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult SertifikaGüncelle(int id)
        {
            var result = db.Find (m => m.Id == id);
            return View(result);
        }
        [HttpPost]
        public ActionResult SertifikaEkle(TBLSertifikalarım tbl)
        {
            db.Add(tbl);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult SertifikaEkle()
        {

            return View();
        }
        public ActionResult SertifikaSil(TBLSertifikalarım tbl)
        {
            var result = db.Find(m=> m.Id == tbl.Id);
            db.Delete(result);
            return RedirectToAction("Index");
        }

    }
}