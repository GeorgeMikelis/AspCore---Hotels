using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hotels.Models;

namespace Hotels.Controllers
{
    public class RoomInfoController : Controller
    {
        private WdaContext _context;

        public RoomInfoController(WdaContext context)
        {
            _context = context;
        }

        public IActionResult Index(Room room)
        {
            room = new Room
            {
                RoomId = room.RoomId,
                Name = room.Name,
                City = room.City

                

            };
            
            return View(room);
        }
    }
}