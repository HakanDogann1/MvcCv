using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda
        HakkimdaRepository db = new HakkimdaRepository();

        [HttpGet]
        public ActionResult Index()
        {
            var result = db.List().ToList();
            return View(result);
        }
        [HttpPost]
        public ActionResult Index(TBLHakkimda tbl)
        {
            var result = db.Find(m => m.Id == 1);
            result.Adres = tbl.Adres;
            result.Aciklama = tbl.Aciklama;
            result.İsim = tbl.İsim;
            result.Resim = tbl.Resim;
            result.Mail = tbl.Mail;
            result.Soyad = tbl.Soyad;
            result.Telefon = tbl.Telefon;
            db.Update(result);
            return RedirectToAction("Index");
        }
    }
}