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
            return View();
        }
    }
}