using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hotels.Models;

namespace Hotels.Controllers
{
    public class HomeController : Controller
    {
        private WdaContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(WdaContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;

        }

        public IActionResult Index()
        {
            var allCities = _context.Room.Select(room => room.City).Distinct().ToArray();
            var allRoomTypes = _context.RoomType
                .Select(x => Tuple.Create(x.Id, x.RoomType1)).ToArray();
            var allGuestsCounts = _context.Room.Select(room => room.CountOfGuests).Distinct().ToArray();

            var model = new Hotels.Models.SearchFiltersModel
            {
                CountOfGuests = allGuestsCounts,
                Cities = allCities,
                RoomTypes = allRoomTypes
            };

            return View(model);
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
