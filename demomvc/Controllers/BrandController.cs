using demomvc.Data;
using demomvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace demomvc.Controllers
{
    public class BrandController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;

        public BrandController (ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IActionResult Index()
        {
            List<Brand> brands=_dbcontext.Brand.ToList();
            return View(brands);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }


}

