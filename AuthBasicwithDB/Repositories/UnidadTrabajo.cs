using AuthBasicwithDB.Context;
using AuthBasicwithDB.Repositories.IRepositories;

namespace AuthBasicwithDB.Repositories
{
    public class UnidadTrabajo:IUnidadTrabajo
    {
        private readonly ApplicationDbContext _Db;
        public IUserRepository User { get; private set; }  
        public IBeerRepository Beer { get; private set; }
        
        public IStockRepository Stock { get; private set; }

        public UnidadTrabajo(ApplicationDbContext db)
        {
            _Db = db;
            User = new UserRepository(db);
            Beer = new BeerRepository(db);
            Stock = new StockRepository(db);
        }


          public  void Guardar()
        {
            _Db.SaveChanges();
        }

        public void Dispose()
        {
          _Db.Dispose();
        }
    }
}
