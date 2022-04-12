using AuthBasicwithDB.Context;
using AuthBasicwithDB.Models;
using AuthBasicwithDB.Repositories.IRepositories;

namespace AuthBasicwithDB.Repositories
{
    public class UserRepository : Repositorio<User>, IUserRepository
    {
        private readonly ApplicationDbContext _db;
        public UserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(User user)
        {
            var UserDb = _db.Users.Find(user.Id);
            if (user != null)
            {
                UserDb.Email = user.Email;
                UserDb.Password = user.Password;    
            }
           
        }
    }
}
