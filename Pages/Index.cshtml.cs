using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Net.WebRequestMethods;

namespace Nedflix.Pages
{
	public class IndexModel : PageModel
	{
		public class MovieList
		{
			public class Movie
			{
				public class Genres
				{
					public string genre { get; set;}
				}
				public List<Genres> genres { get; set; }
				public string nameRu { get; set; }
				//public string genre { get; set; }
				public string description { get; set; }
				//string сеансы

			}
			
			public List<Movie> items { get; set; }
			public MovieList() { }
		}
		//public string msg { get; set; }
		public IndexModel()
		{

		}

		public async void OnPost()
		{
			//Movie mov = await Request.ReadFromJsonAsync<Movie>();
		}

		public async void OnGet()
		{
			string url = "https://kinopoiskapiunofficial.tech/api/v2.2/films?/items";
			var client = new HttpClient();
			client.DefaultRequestHeaders.Add("Accept", "application/json");
			client.DefaultRequestHeaders.Add("X-API-KEY", "c278dfaf-f118-4523-8b32-831ddded96b1");
			//var result = await client.GetStringAsync(url);
			var result = await client.GetAsync(url).Result.Content.ReadFromJsonAsync<MovieList>();
			//Movie mov = await result.Content.ReadFromJsonAsync<Movie>();
		}
	}
}