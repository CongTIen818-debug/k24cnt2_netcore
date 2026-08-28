using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32.SafeHandles;
using System.Data;
using TctLesson03.Models;

namespace TctLesson03.Controllers
{
    [Route("/danh-sach-san-pham")]
    public class TctProductController : Controller
    {
        // Mock data
        private readonly List<TctProduct> _products = new()
        {
            new TctProduct { TctProductID = "MOB001", TctProductName = "iPhone 15 Pro Max", TctProductYearRelease = "2023", TctProductPrice = 34990000m },
            new TctProduct { TctProductID = "MOB002", TctProductName = "Samsung Galaxy S24 Ultra", TctProductYearRelease = "2024", TctProductPrice = 33990000m },
            new TctProduct { TctProductID = "MOB003", TctProductName = "Xiaomi 14 Ultra", TctProductYearRelease = "2024", TctProductPrice = 29990000m },
            new TctProduct { TctProductID = "MOB004", TctProductName = "OPPO Find N3 Flip", TctProductYearRelease = "2023", TctProductPrice = 22990000m },
            new TctProduct { TctProductID = "MOB005", TctProductName = "Google Pixel 8 Pro", TctProductYearRelease = "2023", TctProductPrice = 26500000m },
            new TctProduct { TctProductID = "MOB006", TctProductName = "iPad Pro M4 11-inch", TctProductYearRelease = "2024", TctProductPrice = 28990000m },
            new TctProduct { TctProductID = "MOB007", TctProductName = "Samsung Galaxy Z Fold5", TctProductYearRelease = "2023", TctProductPrice = 40990000m },
            new TctProduct { TctProductID = "MOB008", TctProductName = "Asus ROG Phone 8 Pro", TctProductYearRelease = "2024", TctProductPrice = 27990000m },
            new TctProduct { TctProductID = "MOB009", TctProductName = "Vivo X100 Pro", TctProductYearRelease = "2023", TctProductPrice = 21990000m },
            new TctProduct { TctProductID = "MOB010", TctProductName = "Sony Xperia 1 VI", TctProductYearRelease = "2024", TctProductPrice = 32990000m }
        };
        public IActionResult Index()
        {
            return Json(_products);
        }

        [Route("all")]
        public IActionResult TctGetAllProduct()
        {
            ViewData["products"] = _products;
            return View();
        }
    }
}
