using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using telefonrehberuygulaması.Models.sınıflar;
namespace telefonrehberuygulaması.Controllers
{
    public class RehberController : Controller
    {
        // GET: Rehber
        Context c = new Context();
        public ActionResult Index()
        {
            var dgerler = c.Rehbers.ToList();
            return View(dgerler);
        }
        public ActionResult KayıtSil(int id)
        {
            var degerler = c.Rehbers.Find(id);
            c.Rehbers.Remove(degerler);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KayıtGetir(int id )
        {
            var deger = c.Rehbers.Find(id);
            return View("KayıtGetir", deger);
        }
        public ActionResult KayıtGuncelle(Rehber a)
        {
            var b = c.Rehbers.Find(a.ID);
            b.ID = a.ID;
            b.AdSoyad = a.AdSoyad;
            b.numara = a.numara;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YeniKayıt()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKayıt(Rehber a)
        {
            c.Rehbers.Add(a);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}