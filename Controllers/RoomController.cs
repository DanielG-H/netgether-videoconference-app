using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using VideoconferenceApp.Database;
using VideoconferenceApp.Models;

namespace VideoconferenceApp.Controllers
{
	public class RoomController : Controller
	{
		private readonly DatabaseContext _databaseContext;
		private readonly ILogger<RoomController> _logger;

		public RoomController(DatabaseContext databaseContext, ILogger<RoomController> logger) 
		{
			_databaseContext = databaseContext; 
			_logger = logger;
		}

        public IActionResult Index()
		{
			try
			{
                string signedUser = HttpContext.Session.GetString("SignedUser");
                User? user = JsonConvert.DeserializeObject<User>(signedUser);

                if (user != null)
                {
                    return View("Index", user);
                }
            }
            catch (Exception ex) {
				_logger.LogError(ex.Message);
			}
            return NotFound();
        }
    }
}