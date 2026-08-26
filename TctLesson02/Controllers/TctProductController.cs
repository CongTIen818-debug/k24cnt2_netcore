using Microsoft.AspNetCore.Mvc;
using TctLesson02.Models;

namespace TctLesson02.Controllers
{
    public class TctProductController : Controller
    {
        public IActionResult TctIndex()
        {
            ViewBag.name = "Truong Cong Tien";
            ViewData["productVD"] = "Laptop Lenovo Legion";
            TempData["Uni"] = "Truong Dai hoc Nguyen Trai - NTU";

            return View();
        }

        public IActionResult GetProduct()
        {
            TctProduct tctProduct = new TctProduct()
            {
                ProductID = "2410900074",
                ProductName = "Truong Cong Tien",
                YearRelease=2003,
                Price = 1000
            };
            ViewBag.product = tctProduct;
            ViewData["product"] = tctProduct;

            return View("product");
        }
    }
}
