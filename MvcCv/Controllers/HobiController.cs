using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class HobiController : Controller
    {
        // GET: Hobi
        HobiRepository db = new HobiRepository();
        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {
           var result = db.List();
            return View(result);
        }
        [HttpPost]
        public ActionResult Index(TBLHobilerim tbl)
        {
            var t = db.Find(m=> m.Id == 1);
            t.Aciklama1 = tbl.Aciklama1;
            t.Aciklama2 = tbl.Aciklama2;
            db.Update(t);
            return View(t);
        }
    }
}