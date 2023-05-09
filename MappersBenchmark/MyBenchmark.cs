using AutoFixture;
using AutoMapper;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using MappersBenchmark.Models.Domain;
using MappersBenchmark.Models.DTO;
using Mapster;

namespace MappersBenchmark;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class MyBenchmark
{
    private readonly int _numberOfMovies = 100;
    private List<Movie> _movies;
    private Movie _movie;

    private Mapper _autoMapper;
    private MovieMapper _movieMapperlyMapper;
    
    [Params(10000)]
    public int N;

    [GlobalSetup]
    public void SetUp()
    {
        var fixture = new Fixture();
        var cast = fixture.Build<Cast>()
            .With(x => x.Actors, fixture.CreateMany<Actor>(100).ToList)
            .With(x => x.Stunts, fixture.CreateMany<Stunt>(20).ToList)
            .Create();
        _movies = fixture.Build<Movie>()
            .With(x=>x.Cast, cast)
            .With(x=>x.Description, string.Join("",fixture.CreateMany<char>(300)))
            .CreateMany(_numberOfMovies)
            .ToList();
        
        _movie = _movies.First();
        
        var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Movie, MovieDto>();
                cfg.CreateMap<Cast, CastDto>();
                cfg.CreateMap<Company, CompanyDto>();
                cfg.CreateMap<BoxOffice, BoxOfficeDto>();
                cfg.CreateMap<Person, PersonDto>();
                cfg.CreateMap<Actor, ActorDto>();
                cfg.CreateMap<Stunt, StuntDto>();
            }
        );
        
        _autoMapper = new Mapper(configuration);
        _movieMapperlyMapper = new MovieMapper();
    }

    [Benchmark]
    public MovieDto Automapper_SingleItem()
    {
        return _autoMapper.Map<MovieDto>(_movie);
    }
    
    [Benchmark(Baseline = true)]
    public MovieDto Mapster_SingleItem()
    {
        return _movie.Adapt<MovieDto>();
    }
    
    [Benchmark]
    public MovieDto Mapperly_SingleItem()
    {
        return _movieMapperlyMapper.MapMovieToDto(_movie);
    }
    
    // [Benchmark]
    // public List<MovieDto> Automapper_List()
    // {
    //     return _autoMapper.Map<List<MovieDto>>(_movies);
    // }
    //
    // [Benchmark]
    // public List<MovieDto> Mapster_List()
    // {
    //     return _movies.Adapt<List<MovieDto>>();
    // }
    //
    // [Benchmark]
    // public List<MovieDto> Mapperly_List()
    // {
    //     return _movieMapperlyMapper.MapMoviesToDtos(_movies);
    // }
}
