namespace MappersBenchmark.Models.DTO;

public class MovieDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public TypeEnumDto Type { get; set; }
    public DateTime ReleaseDate { get; set; }
    public List<GenreEnum> Genres { get; set; }
    public int RottenTomatoesRating { get; set; }
    public int RottenTomatoesAudienceScore { get; set; }
    public CastDto Cast { get; set; }
    public bool IsFamilyFriendly { get; set; }
    public PEGIEnumDto PEGI { get; set; }
    public List<string> Languages { get; set; }
    public string CountryOfOrigin { get; set; }
    public CompanyDto ProducingCompany { get; set; }
    public bool IsAvailableOnVOD { get; set; }
    public bool IsAvailableOnBlueRay { get; set; }
    public List<CompanyDto> SellingVODCompanies { get; set; }
    public int LengthInMinutes { get; set; }
    public string SeriesName { get; set; }
    public BoxOfficeDto BoxOffice { get; set; }
    public bool IsBasedOnBook { get; set; }
    public string? BasedOnABookTitle { get; set; }
    public PersonDto? BasedOnABookAuthor { get; set; }
}
