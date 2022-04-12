using AuthBasicwithDB.Models;

namespace AuthBasicwithDB.Repositories.IRepositories
{
    public interface IBeerRepository : IRepository<Beer>
    {
        void Actualizar(Beer beer);
    }
}
