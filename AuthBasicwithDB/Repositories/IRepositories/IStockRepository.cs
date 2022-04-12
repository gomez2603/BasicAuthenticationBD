

using AuthBasicwithDB.Models;

namespace AuthBasicwithDB.Repositories.IRepositories
{
    public interface IStockRepository:IRepository<Stock>
    {
        void Actualizar(Stock stock);
    }
}
