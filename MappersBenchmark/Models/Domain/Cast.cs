namespace MappersBenchmark.Models.Domain;

public class Cast
{
    public Person Director { get; set; }
    public List<Person> Writers { get; set; }
    public List<Actor> Actors { get; set; }
    public List<Stunt> Stunts { get; set; }
}
