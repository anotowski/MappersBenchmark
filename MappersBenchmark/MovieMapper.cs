using MappersBenchmark.Models.Domain;
using MappersBenchmark.Models.DTO;
using Riok.Mapperly.Abstractions;

namespace MappersBenchmark;

[Mapper]
public partial class MovieMapper
{
    public partial MovieDto MapMovieToDto(Movie movie);
    public partial List<MovieDto> MapMoviesToDtos(List<Movie> movie);
}
