using System.Threading.Tasks;
using blazor.Models;

public interface ITmdbService
{
    Task<MovieDetails> GetMovieDetailsAsync(string movieTitle);
    //Task<string?> GetMovieDescriptionAsync(string movieTitle); Later
}
