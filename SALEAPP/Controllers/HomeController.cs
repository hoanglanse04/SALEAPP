using Microsoft.AspNetCore.Mvc;
using SALEAPP.Models;
using System.Diagnostics;

namespace SALEAPP.Controllers
{
	public class HomeController : Controller
	{
		QuanLyCuaHangSachContext db = new QuanLyCuaHangSachContext();
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			var lsnxb=db.NhaXuatBans.ToList();
			var listg=db.TacGia.ToList();
			return View(listg);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
