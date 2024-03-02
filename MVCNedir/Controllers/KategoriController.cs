using MVCNedir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNedir.Controllers
{
    public class KategoriController : Controller
    {
        List<Category> kategoriler = new List<Category>();

        public KategoriController()
        {
            kategoriler.Add(new Category() { ID = 1, Name = "Atıştırmalık", Description = "Çikolata Bisküvi", IsActive = true });
            kategoriler.Add(new Category() { ID = 2, Name = "Şarküteri", Description = "Peynir Zeytin", IsActive = false });
            kategoriler.Add(new Category() { ID = 3, Name = "İçecek", Description = "Kola Fanta", IsActive = true });
            kategoriler.Add(new Category() { ID = 4, Name = "Giyim", Description = "Erkek, Kadın Giyim", IsActive = true });
        }
        // GET: Kategori
        public ActionResult Index()
        {
            return View(kategoriler);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Category category)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Duzenle(int id)
        {
            Category cat = kategoriler.FirstOrDefault(s=> s.ID== id);
            return View(cat);
        }
        [HttpPost]
        public ActionResult Duzenle(Category kategori)
        {
            return RedirectToAction("Index");
        }
    }
}