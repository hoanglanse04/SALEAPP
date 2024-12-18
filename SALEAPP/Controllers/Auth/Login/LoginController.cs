using Microsoft.AspNetCore.Mvc;

namespace SALEAPP.Controllers.Auth.Login
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
