using Microsoft.AspNetCore.Mvc;
using VideoconferenceApp.Database;
using VideoconferenceApp.Models;

namespace VideoconferenceApp.Controllers
{
	public class RoomController : Controller
	{
		private readonly DatabaseContext _databaseContext;

		public RoomController(DatabaseContext databaseContext) { _databaseContext = databaseContext; }

		public IActionResult Create(User obj)
		{
			return View();
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
