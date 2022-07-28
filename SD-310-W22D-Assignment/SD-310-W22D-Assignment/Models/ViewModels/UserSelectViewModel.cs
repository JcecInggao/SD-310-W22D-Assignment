using Microsoft.AspNetCore.Mvc.Rendering;

namespace SD_310_W22D_Assignment.Models.ViewModels
{
    public class UserSelectViewModel
    {
        public List<SelectListItem> UserSelectItem { get; set; }
        public string PageTitle { get; set; }

        public UserSelectViewModel(List<Song> artists)
        {
            UserSelectItem = new List<SelectListItem>();

            artists.ForEach(s =>
            {
                UserSelectItem.Add(new SelectListItem(s.Title, s.ArtistId.ToString()));
            });
        }

    }
}
