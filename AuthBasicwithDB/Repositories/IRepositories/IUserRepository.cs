using AuthBasicwithDB.Models;

namespace AuthBasicwithDB.Repositories.IRepositories
{
    public interface IUserRepository:IRepository<User>
    {
        void Actualizar(User user);
    }
}
