using MvcCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbMvcCvEntities db = new DbMvcCvEntities();
        public ActionResult Index()
        {
            var result = db.TBLHakkimda.ToList();
            return View(result);
        }

        public PartialViewResult Deneyim()
        {
            var result = db.TBLDeneyimlerim.ToList();
            return PartialView(result);
        }
        public PartialViewResult SosyalMedya()
        {
            var result = db.TBLSosyalMedya.ToList();
            return PartialView(result);
        }
        public PartialViewResult Egitimlerim()
        {
            var result = db.TBLEgitimlerim.ToList();
            return PartialView(result);
        }
        public PartialViewResult Yeteneklerim()
        {
            var result = db.TBLYeteneklerim.ToList();
            return PartialView(result);
        }
        public PartialViewResult Hobilerim()
        {
            var result = db.TBLHobilerim.ToList();
            return PartialView(result);
        }
        public PartialViewResult Sertifikalarım()
        {
            var result = db.TBLSertifikalarım.ToList();
            return PartialView(result);
        }
        [HttpGet]
        public PartialViewResult İletisim()
        {
            var result = db.TBLİletisim.ToList();
            return PartialView(result);
        }
        [HttpPost]
        public PartialViewResult İletisim(TBLİletisim t1)
        {
            t1.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TBLİletisim.Add(t1);
            db.SaveChanges();
            return PartialView();
        }
    }
}