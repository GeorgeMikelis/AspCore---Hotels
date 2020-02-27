using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.Controllers
{
    public class RoomListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}