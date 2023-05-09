using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    [Authorize]
    public class DeneyimController : Controller
    {
        // GET: Deneyim
        DeneyimRepository repo = new DeneyimRepository();

        
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult NewExperience()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewExperience(TBLDeneyimlerim t)
        {
            repo.Add(t);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteExperience(int id)
        {
            TBLDeneyimlerim t = repo.Find(m => m.Id == id);
            repo.Delete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult ModifiedExperience(int id)
        {
            TBLDeneyimlerim t = repo.Find(m=>m.Id == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult ModifiedExperience(TBLDeneyimlerim p)
        {
            TBLDeneyimlerim t = repo.Find(m => m.Id == p.Id);
            t.Tarih=p.Tarih;
            t.Aciklama=p.Aciklama;
            t.AltBaslik=p.AltBaslik;
            t.Baslik=p.Baslik;
            t.Id=p.Id;
            repo.Update(t);
            return RedirectToAction("Index");
        }
    }
}