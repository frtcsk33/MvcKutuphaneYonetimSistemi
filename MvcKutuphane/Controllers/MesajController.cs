﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;
namespace MvcKutuphane.Controllers
{
    public class MesajController : Controller
    {
        // GET: Mesaj
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Index()
        {

            var uyemail = (string)Session["Mail"].ToString();

            var mesajlar = db.TBLMESAJLAR.Where(x=> x.ALICI ==uyemail.ToString()).ToList();
            return View(mesajlar);
        }

        [HttpGet]
        public ActionResult yeniMesaj()
        {

            return View();
        }

        [HttpPost]
        public ActionResult yeniMesaj(TBLMESAJLAR p)
        {
            var uyemail = (string)Session["Mail"].ToString();
            p.GONDEREN = uyemail.ToString();
            p.TARIH = DateTime.Parse(DateTime.Now.ToShortDateString());


            db.TBLMESAJLAR.Add(p);
            db.SaveChanges();
            return RedirectToAction("Giden","Mesaj");
        }


        public ActionResult Giden()
        {

            var uyemail = (string)Session["Mail"].ToString();

            var mesajlar = db.TBLMESAJLAR.Where(x => x.GONDEREN == uyemail.ToString()).ToList();
            return View(mesajlar);
        }
    }
}