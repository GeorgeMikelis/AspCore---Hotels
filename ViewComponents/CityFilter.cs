using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Hotels.Models;

namespace Hotels.ViewComponents
{
    public class CityFilterViewComponent : ViewComponent
    {
        private readonly WdaContext _context;

        public CityFilterViewComponent(WdaContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var cities = _context.Room
                .Select(i => i.City)
                .Distinct();

            return View(cities);
        }
    }
}