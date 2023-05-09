namespace MappersBenchmark.Models.Domain;

public class Movie
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public TypeEnum Type { get; set; }
    public DateTime ReleaseDate { get; set; }
    public List<GenreEnum> Genres { get; set; }
    public int RottenTomatoesRating { get; set; }
    public int RottenTomatoesAudienceScore { get; set; }
    public Cast Cast { get; set; }
    public bool IsFamilyFriendly { get; set; }
    public PEGIEnum PEGI { get; set; }
    public List<string> Languages { get; set; }
    public string CountryOfOrigin { get; set; }
    public Company ProducingCompany { get; set; }
    public bool IsAvailableOnVOD { get; set; }
    public bool IsAvailableOnBlueRay { get; set; }
    public List<Company> SellingVODCompanies { get; set; }
    public int LengthInMinutes { get; set; }
    public string SeriesName { get; set; }
    public BoxOffice BoxOffice { get; set; }
    public bool IsBasedOnBook { get; set; }
    public string? BasedOnABookTitle { get; set; }
    public Person? BasedOnABookAuthor { get; set; }
}
