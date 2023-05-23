using AkademiPlusAjax.DAL;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;

namespace AkademiPlusAjax.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            var values = context.Products.ToList();
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            var values = JsonConvert.SerializeObject(product);
            return Json(values);
        }
        public IActionResult DeleteProduct(int id)
        {
            var values = context.Products.Find(id);
            context.Products.Remove(values);
            context.SaveChanges();
            return NoContent();

        }
        public IActionResult GetByID(int ProductID)
        {
            var values = context.Products.Find(ProductID);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }
        public IActionResult UpdateProduct(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
            var values = JsonConvert.SerializeObject(product);
            return Json(values);
        }
    }
}
