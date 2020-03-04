using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Hotels.Models;

namespace Hotels.ViewComponents
{
    public class NavBarViewComponent : ViewComponent
    {
        private readonly WdaContext _context;

        public NavBarViewComponent(WdaContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}