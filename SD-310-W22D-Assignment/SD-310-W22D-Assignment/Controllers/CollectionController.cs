using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SD_310_W22D_Assignment.Models;

namespace SD_310_W22D_Assignment.Controllers
{
    public class CollectionController : Controller
    {
        private MyTunesContext _dbContext;
        public CollectionController(MyTunesContext context)
        {
            _dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
