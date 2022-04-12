using AuthBasicwithDB.Models;

namespace AuthBasicwithDB.Services
{
    public interface IStockService
    {
        public IEnumerable<Stock> Get();
        public Stock GetbyId(int id);
        public void Insert(Stock stock);
        public void Update(Stock stock);
        public void Delete(int id);
    }
}
