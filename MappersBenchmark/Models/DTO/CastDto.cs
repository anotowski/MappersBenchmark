namespace MappersBenchmark.Models.DTO;

public class CastDto
{
    public PersonDto Director { get; set; }
    public List<PersonDto> Writers { get; set; }
    public List<ActorDto> Actors { get; set; }
    public List<StuntDto> Stunts { get; set; }
}
