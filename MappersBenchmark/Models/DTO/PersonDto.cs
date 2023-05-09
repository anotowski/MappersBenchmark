namespace MappersBenchmark.Models.DTO;

public class PersonDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public GenderEnum Gender { get; set; }
    public DateTime BornOn { get; set; }
    public int AcademyAwardsCount { get; set; }
    public int AcademyNominationsCount { get; set; }
}
