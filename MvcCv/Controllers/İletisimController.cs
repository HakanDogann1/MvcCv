using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class İletisimController : Controller
    {
        // GET: İletişim
       GenericRepository<TBLİletisim> db = new GenericRepository<TBLİletisim> ();
        public ActionResult Index()
        {
            var result = db.List();
            return View(result);
        }
    }
}