using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotels.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.ViewComponents
{
    public class RoomBoxViewComponent : ViewComponent
    {
        private readonly WdaContext _context;

        public RoomBoxViewComponent(WdaContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(string city, int roomType)
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
