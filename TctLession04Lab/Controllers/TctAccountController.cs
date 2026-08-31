using Microsoft.AspNetCore.Mvc;
using TctLession04Lab.Models;

namespace TctLession04Lab.Controllers
{
    public class TctAccountController : Controller
    {
        private readonly List<TctAccount> tctAccounts = new()
        {

            new TctAccount
            {
                Id = 1, Name = "Nguyễn Văn An", Email = "an.nguyen@example.com", Phone = "0901234567",
                Avatar = "/images/1.webp", Address = "123 Lê Lợi, Quận 1, TP.HCM",
                Bio = "Lập trình viên C# / .NET nhiệt huyết", Gender = 1, Birthday = new DateTime(1995, 5, 15)
            },
            new TctAccount
            {
                Id = 2, Name = "Trần Thị Bích", Email = "bich.tran@example.com", Phone = "0912345678",
                Avatar = "/images/2.webp", Address = "456 Nguyễn Huệ, Quận 1, TP.HCM",
                Bio = "Chuyên viên thiết kế UI/UX", Gender = 0, Birthday = new DateTime(1998, 8, 22)
            },
            new TctAccount
            {
                Id = 3, Name = "Lê Hoàng Cường", Email = "cuong.le@example.com", Phone = "0923456789",
                Avatar = "/images/3.jpg", Address = "789 Hoàng Hoa Thám, Ba Đình, Hà Nội",
                Bio = "Quản lý dự án phần mềm", Gender = 1, Birthday = new DateTime(1990, 12, 10)
            },
            new TctAccount
            {
                Id = 4, Name = "Phạm Thị Dung", Email = "dung.pham@example.com", Phone = "0934567890",
                Avatar = "/images/4.jpg", Address = "12 Trần Phú, Hải Châu, Đà Nẵng",
                Bio = "Chuyên viên Marketing & Nội dung", Gender = 0, Birthday = new DateTime(2001, 3, 5)
            }

        };
        public IActionResult TctIndex()
        {
            ViewBag.TctAccounts = tctAccounts;
            return View();
        }
        [Route("ho-so-cua-toi", Name = "TctProfile")]
        public IActionResult TctProfile(int? id)
        {
            
            TctAccount tctAccount = new TctAccount
             {
                 Id = 4,
                 Name = "Phạm Thị Dung",
                 Email = "dung.pham@example.com",
                 Phone = "0934567890",
                 Avatar = "/images/4.jpg",
                 Address = "12 Trần Phú, Hải Châu, Đà Nẵng",
                 Bio = "Chuyên viên Marketing & Nội dung",
                 Gender = 0,
                 Birthday = new DateTime(2001, 3, 5)
             };
            if(id==null)
                tctAccount = tctAccounts.FirstOrDefault(x => x.Id == id);
            ViewBag.TctAccount = tctAccount;
            return View();
        }
    }
}
