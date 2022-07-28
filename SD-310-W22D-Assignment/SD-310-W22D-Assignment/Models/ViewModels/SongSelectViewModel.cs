using Microsoft.AspNetCore.Mvc.Rendering;

namespace SD_310_W22D_Assignment.Models.ViewModels
{
    public class SongSelectViewModel
    {
        public List<SelectListItem> SongSelectItems { get; set; }
        public string PageTitle { get; set; }

        public SongSelectViewModel(List<Song> artists)
        {
            SongSelectItems = new List<SelectListItem>();

            artists.ForEach(s =>
            {
                SongSelectItems.Add(new SelectListItem(s.Title, s.ArtistId.ToString()));
            });
        }
    }
}
