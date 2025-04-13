using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using blazor.Models;

public class TmdbService : ITmdbService
{
    private readonly HttpClient _httpClient;
    private const string ApiKey = "b7991c7f611b4271a6e8008fb9399930";
    private const string ImageBaseUrl = "https://image.tmdb.org/t/p/w500";

    public TmdbService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<MovieDetails> GetMovieDetailsAsync(string movieTitle)
    {
        // Construct the API URL
        var apiUrl = $"https://api.themoviedb.org/3/search/movie?api_key={ApiKey}&query={movieTitle}";

        // Get the response from TMDb API
        var response = await _httpClient.GetFromJsonAsync<ApiResponse>(apiUrl);

        // If there are results, fetch the first movie's details
        if (response?.Results != null && response.Results.Any())
        {
            var movieId = response.Results.First().Id;
            var detailsUrl = $"https://api.themoviedb.org/3/movie/{movieId}?api_key={ApiKey}";

            var movieDetails = await _httpClient.GetFromJsonAsync<MovieDetails>(detailsUrl);

            if (!string.IsNullOrEmpty(movieDetails?.PosterPath))
            {
                movieDetails.PosterUrl = $"{ImageBaseUrl}{movieDetails.PosterPath}";
            }

            return movieDetails;
        }

        return null;
    }
}

public class TmdbResponse
{
    public List<Movie> Results { get; set; } = new();
}

public class Movie
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("poster_path")]
    public string PosterPath { get; set; }
}

public class MovieDetails
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("genres")]
    public List<Genre> Genres { get; set; }

    [JsonPropertyName("release_date")]
    public string ReleaseDate { get; set; }

    [JsonPropertyName("vote_average")]
    public double VoteAverage { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }

    [JsonPropertyName("poster_path")]
    public string PosterPath { get; set; }

    // To store the full image URL (concatenated with base URL)
    public string PosterUrl { get; set; }

    [JsonPropertyName("review")]
    public string Review { get; set; } // If available in the API
}

public class Genre
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
