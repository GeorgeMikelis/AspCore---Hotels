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

        public IActionResult Index(string city, int roomType)
        {
            IQueryable<Hotels.Models.Room> result = _context.Room;
            if (!string.IsNullOrEmpty(city))
            {
                ViewData["city"] = city;
                result = result.Where(room => room.City == city);
            }
            if (roomType != 0)
            {
                result = result.Where(room => room.RoomType == roomType);
            }

            return View(result);
        }
    }
}