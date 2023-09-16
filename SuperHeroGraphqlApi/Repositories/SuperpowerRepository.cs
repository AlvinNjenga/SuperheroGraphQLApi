using SuperHeroGraphqlApi.Data;
using SuperHeroGraphqlApi.Interfaces;

namespace SuperHeroGraphqlApi.Repositories
{
    public class SuperpowerRepository : ISuperpowerRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public SuperpowerRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
