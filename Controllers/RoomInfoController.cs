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

        
        public IActionResult Index(int roomId)
        {
            var room = _context.Room.Where(r => r.RoomId == roomId).FirstOrDefault(); 

            return View(room);
        }
    }
}