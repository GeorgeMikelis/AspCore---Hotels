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
       

        public IActionResult Index(string city)
        {
            if (!string.IsNullOrEmpty(city))
                return View(_context.Room.Where(room => room.City == city));
            else
                return View(_context.Room);
        }

    }
}