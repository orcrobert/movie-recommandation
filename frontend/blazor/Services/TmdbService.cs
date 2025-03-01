using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class TmdbService : ITmdbService
{
    private readonly HttpClient _httpClient;
    private const string ApiKey = "b7991c7f611b4271a6e8008fb9399930";
    private const string ImageBaseUrl = "https://image.tmdb.org/t/p/w500";

    public TmdbService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetMovieImageAsync(string movieTitle)
    {
        if (string.IsNullOrWhiteSpace(movieTitle))
            return "";

        var encodedTitle = Uri.EscapeDataString(movieTitle);
        var url = $"https://api.themoviedb.org/3/search/movie?query={encodedTitle}&api_key={ApiKey}";

        try
        {
            var response = await _httpClient.GetFromJsonAsync<TmdbResponse>(url);

            if (response?.Results != null && response.Results.Any())
            {
                var firstMovie = response.Results.First();
                return !string.IsNullOrEmpty(firstMovie.PosterPath) ? $"{ImageBaseUrl}{firstMovie.PosterPath}" : "";
            }

            return "";
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching TMDB image: {ex.Message}");
            return "";
        }
    }

    private class TmdbResponse
    {
        public List<Movie> Results { get; set; } = new();
    }

    private class Movie
    {
        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; }
    }
}
