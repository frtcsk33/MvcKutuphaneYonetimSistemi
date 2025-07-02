using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;

namespace MvcKutuphane.Controllers
{
    public class IstatistikController : Controller
    {
        // GET: Istatistik
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Index()
        {
            var dgr1 = db.TBLUYELER.Count();
            ViewBag.dgr1 = dgr1;


            var dgr2 = db.TBLKITAP.Count();
            ViewBag.dgr2 = dgr2;

            var dgr3 = db.TBLKITAP.Where(x => x.DURUM == false).Count();
            ViewBag.dgr3 = dgr3;

            var dgr4 = db.TBLCEZALAR.Sum(x => x.PARA);
            ViewBag.dgr4 = dgr4;
            return View();
        }

        public ActionResult Hava()
        {

            return View();
        }

        public ActionResult HavaKart()
        {
            return View();
        }


        public ActionResult Galeri()
        {


            return View();
        }

        [HttpPost]
        public ActionResult resimYukle(HttpPostedFileBase dosya)
        {
            if (dosya.ContentLength > 0)
            {
                string dosyaYolu = Path.Combine(Server.MapPath("~/web2/resimler/"), Path.GetFileName(dosya.FileName));
                dosya.SaveAs(dosyaYolu);

            }


            return RedirectToAction("Galeri");
        }

        public ActionResult LinqKart()
        {
            var deger1 = db.TBLKITAP.Count();
            var deger2 = db.TBLUYELER.Count();
            var deger3 = db.TBLCEZALAR.Sum(x => x.PARA);
            var deger4 = db.TBLKITAP.Where(x => x.DURUM == false).Count();
            var deger5 = db.TBLKATEGORI.Count();
            var deger6 = db.EnAktifUye().FirstOrDefault();
            var deger7 = db.EnCokOkunanKitap().FirstOrDefault();
            var deger8 = db.EnFazlaKitapYazar().FirstOrDefault();
            var deger9 = db.TBLKITAP.GroupBy(x => x.YAYINEVI).OrderByDescending(z => z.Count()).Select(y=> y.Key).FirstOrDefault();
            var deger10 = db.EnBasariliEleman().FirstOrDefault();
            var deger11 = db.TBLILETISIM.Count();
            var deger12 = db.BugunVerilenEmanetKitaplar().FirstOrDefault();
            ViewBag.dgr1 = deger1;

            ViewBag.dgr2 = deger2;

            ViewBag.dgr3 = deger3;

            ViewBag.dgr4 = deger4;
            ViewBag.dgr5 = deger5;
            ViewBag.dgr6 = deger6;
            ViewBag.dgr7 = deger7;
            ViewBag.dgr8 = deger8;
            ViewBag.dgr9 = deger9;
            ViewBag.dgr10 = deger10;
            ViewBag.dgr11 = deger11;
            ViewBag.dgr12 = deger12;
            return View();
        }
    }
}