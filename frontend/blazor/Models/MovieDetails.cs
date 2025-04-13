namespace blazor.Models {
    public class MovieDetails
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Genres { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double VoteAverage { get; set; }
        public string Overview { get; set; }
        public string Review { get; set; }
    }

    public class ApiResponse
    {
        public List<MovieResult> Results { get; set; } = new List<MovieResult>();
    }

    public class MovieResult
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}