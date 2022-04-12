using AuthBasicwithDB.Context;
using AuthBasicwithDB.Models;
using AuthBasicwithDB.Repositories.IRepositories;
using System.Linq.Expressions;

namespace AuthBasicwithDB.Repositories
{
    public class StockRepository : Repositorio<Stock>, IStockRepository
    {
        private readonly ApplicationDbContext _db;
        public StockRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Actualizar(Stock stock)
        {
            var StockDb = _db.Stock.Find(stock.Id);
            if (StockDb != null)
            {
                StockDb.Quantity = stock.Quantity;
                StockDb.BeerId = stock.BeerId;
                
            }
        }

     
    }
}
