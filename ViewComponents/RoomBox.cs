﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotels.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.ViewComponents
{
    public class RoomBoxComponent : ViewComponent
    {
        private readonly WdaContext _context;

        public RoomBoxComponent(WdaContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
