using AuthBasicwithDB.Models;

namespace AuthBasicwithDB.Services
{
    public interface IBeerServices
    {
        public IEnumerable<Beer> Get();

        public Beer GetbyId(int id);

        public void Insert(Beer beer);
        public void Update(Beer beer);  
        public void Delete(int id);
    }
}
