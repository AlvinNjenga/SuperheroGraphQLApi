using SuperHeroGraphqlApi.Data;
using SuperHeroGraphqlApi.Interfaces;

namespace SuperHeroGraphqlApi.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public MovieRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
