using MVCNedir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNedir.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        //Genel Olarak Listeleme işlemleri kullanılan functiondır.
        //Controller'da Index function'ı olmak zorunda değildir.
        [HttpGet]
        public ActionResult Index()//View'da Index Sayfası oluşturmak için Sağ tıklayıp AddView Komutunu uyguluyoruz
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string isim)
        {
            return View();
        }
        [HttpGet]
        public ActionResult VeriTasima()
        {
            ViewBag.isim = "Murtaza";
            //Viewbag türü dinamic olan bir değişkendir. Dolayısıyla Viewbag'e istediğimiz üye elemanı veya veri varmış gibi davranabiliriz. View tarafından eğer kontroller tarafında Viewbag'e istenilen veriyi attığımızda controler tarafındada erişebiliriz. (veri iletimi çift yönlüdür).
            //Viewbag'tan sonra . işaretinden sonra istenilen isim verilebilir.
            ViewData["isim2"] = "Şuayip";
            //ViewData Viewbag ile neredeyse 1'e bir aynı işlemi yapar. Aradaki fark veriyi tutma biçimleridir. Bunun dışında herhangi bir farkı yoktur.

            TempData["isim3"] = "Selami";
            //Diğer veri taşıma yöntemlerine göre zayıf yanı sadece string integer gibi yalın tipleri taşıyabilmesidir.
            //Temp data başka viewlara'da veri taşıyabilmektedir
            return View();
        }
        [HttpPost]
        public ActionResult VeriTasima(string isim, string soyisim)
        {
            string tamisim = isim + " " + soyisim;
            return View();
        }

        [HttpGet]
        public ActionResult ModelIleVeriTasima()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ModelIleVeriTasima(Kisi k)
        {

            return View();
        }

        [HttpGet]
        public ActionResult ModelIleVeriListeleme()
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi() { Isim = "Alp", Soyisim = "Sarıkışla", TcNo = "15874524875" });
            kisiler.Add(new Kisi() { Isim = "Murtaza", Soyisim = "Karaca", TcNo = "85478458763" });
            kisiler.Add(new Kisi() { Isim = "Şuayip", Soyisim = "Gültekin", TcNo = "15847500478" });
            kisiler.Add(new Kisi() { Isim = "Süleyman", Soyisim = "Çakırkaş", TcNo = "86540047856" });
            kisiler.Add(new Kisi() { Isim = "Fatma", Soyisim = "Çakırkaş", TcNo = "10025400789" });
            return View(kisiler);
        }
        
        public ActionResult KisiSil(string id)
        {
            return View();
        }
    }
}