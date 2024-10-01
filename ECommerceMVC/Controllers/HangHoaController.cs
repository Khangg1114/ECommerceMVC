using Microsoft.AspNetCore.Mvc;

namespace ECommerceMVC.Controllers
{
    public class HangHoaController : Controller
    {
        public IActionResult Index(int? Loai)
        {
            return View();
        }
    }
}
