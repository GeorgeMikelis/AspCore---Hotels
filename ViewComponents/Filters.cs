using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotels.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.ViewComponents
{
    public class FiltersViewComponent : ViewComponent
    {
        private readonly WdaContext _context;
        
        public FiltersViewComponent(WdaContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
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

    }
}
