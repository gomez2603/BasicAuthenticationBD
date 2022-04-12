using AuthBasicwithDB.Context;
using AuthBasicwithDB.Models;
using AuthBasicwithDB.Repositories.IRepositories;
using AuthBasicwithDB.Services;

namespace AuthBasicwithDB.Repositories
{
    public class BeerRepository : Repositorio<Beer>, IBeerRepository
    {
        private readonly ApplicationDbContext _Db;
        public BeerRepository(ApplicationDbContext Db) : base(Db)
        {
            _Db = Db;
        }

        public void Actualizar(Beer beer)
        {
            var BeerDb = _Db.Beers.Find(beer.Id);
            if(BeerDb != null)
            {
                BeerDb.Name = beer.Name;
                BeerDb.Brand = beer.Brand;
                BeerDb.Alcohol = beer.Alcohol;
            }

        }
    }
}
