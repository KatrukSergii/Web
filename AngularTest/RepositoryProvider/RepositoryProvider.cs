using Repository;

namespace RepositoryProvider
{
    public static class RepositoryProvider
    {
        public static IRepositoryProvider GetRepository()
        {
            return new NoSqlRepository.RepositoryProvider();
        }
    }
}
