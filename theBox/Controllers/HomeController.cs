using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using theBox.Entity;

namespace theBox.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            return View(_context.Products.Where(i=>i.IsHome).ToList());
        }

        public ActionResult Details(int id)
        {
            var product = _context.Products.FirstOrDefault(i => i.Id == id);

            if (product == null)
            {
                // Ürün bulunamadıysa, isteğe bağlı olarak bir hata sayfasına yönlendirme yapabilirsiniz.
                return HttpNotFound();
            }

            return View(product);
        }

        public ActionResult List(int? id)
        {
            var urunler = _context.Products
                          .Where(i => i.IsApproved)
                          .AsQueryable();
            if (id != null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);
            }

            return View(urunler.ToList());
        }

        public PartialViewResult GetCategories()
        {
            return PartialView(_context.Categories.ToList());
        }

    }
}