using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SD_310_W22D_Assignment.Models;
using SD_310_W22D_Assignment.Models.ViewModels;


namespace SD_310_W22D_Assignment.Controllers
{
    public class SongController : Controller
    {
        private MyTunesContext _dbContext;
        public SongController(MyTunesContext context)
        {
            _dbContext = context;
        }

        public IActionResult Index(int? artistId)
        {
            try
            {
                // find artist 
                var artistName =
                    from artist in _dbContext.Artists
                    where artist.Id == artistId
                    select artist.Name;

                if (artistId != null)
                {
                    return View(artistName);
                }
                else
                {
                    throw new Exception("Artist not found");
                }

            }
            catch (Exception ex)
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult Index()
        {
            SongSelectViewModel vm = new SongSelectViewModel(_dbContext.Songs.ToList());
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
