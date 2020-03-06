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
            var cities = _context.Room
                .Select(i => i.City)
                .Distinct();

            return View(cities);
        }
    }
}
