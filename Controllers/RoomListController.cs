using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hotels.Models;

namespace Hotels.Controllers
{
    public class RoomListController : Controller
    {
        private WdaContext _context;
        
        public RoomListController(WdaContext context)
        {
            _context = context;
           

        }
        public IActionResult Index()
        {
            var allCities = _context.Room.Select(room => room.City).Distinct().ToArray();
            var allRoomTypes = _context.RoomType
                .Select(x => Tuple.Create(x.Id, x.RoomType1)).ToArray();

            var model = new Hotels.Models.SearchFiltersModel
            {
                Cities = allCities,
                RoomTypes = allRoomTypes
            };

            return View(model);
         
        }
    }
}