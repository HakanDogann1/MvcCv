using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcCv.Controllers
{
    public class LoginController : Controller
    {
       DbMvcCvEntities db = new DbMvcCvEntities();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TBLAdmin tbl)
        {
            
            var result = db.TBLAdmin.FirstOrDefault(m => m.KullaniciAdi == tbl.KullaniciAdi && m.Sifre == tbl.Sifre);
            if (result!=null)
            {
                FormsAuthentication.SetAuthCookie(result.KullaniciAdi, false);
                Session["KullaniciAdi"] = result.KullaniciAdi.ToString();
                return RedirectToAction("Index","Hakkimda");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
           
        }
    }
}