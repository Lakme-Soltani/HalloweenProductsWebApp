using HalloweenProductsApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Configuration;



namespace HalloweenProductsApp.Controllers
{
    public class HomeController : Controller
    {
        HalloweenProducts db = new HalloweenProducts();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Products()
        {

        // GET: display list of products
            
            List<Product> products = db.Products.ToList(); // context object

            return View(products);
        }

        // GET: Products/Details
        [HttpGet]
        public ActionResult Details(string id)
        {
            Product p = db.Products.Find(id);

            return View(p);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}