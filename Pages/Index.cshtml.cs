using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Nedflix.Pages
{
    public class IndexModel : PageModel
    {
        public class Movie
        {
            //string name { get; set; }
            //string director { get; set; }
            //string genre { get; set; }
            //string description { get; set; }
            //string сеансы
            Movie() { }
        }
        //public string msg { get; set; }
        public IndexModel()
        {

        }

        public async void OnGet()
        {
            
            //https://kinopoiskapiunofficial.tech/api/films/get_api_v2_2_films_filters
        }
    }
}