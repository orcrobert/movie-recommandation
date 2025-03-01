using System.Threading.Tasks;

public interface ITmdbService
{
    Task<string> GetMovieImageAsync(string movieTitle);
    //Task<string?> GetMovieDescriptionAsync(string movieTitle); Later
}
