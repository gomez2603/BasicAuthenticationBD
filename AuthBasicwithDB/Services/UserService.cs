using AuthBasicwithDB.Models;
using AuthBasicwithDB.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace AuthBasicwithDB.Security
{
    public class UserService : IUserService
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public UserService(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }

        public User GetUser(int id)
        {
            return _unidadTrabajo.User.Obtener(id);
        }

        public User GetUserByEmail(string email)
        {
            return _unidadTrabajo.User.ObtenerPrimero(e => e.Email == email);
        }

        public IEnumerable<User> GetUsers()
        {
            return _unidadTrabajo.User.ObtenerTodos();
        }

        public void Insert(User user)
        {
            _unidadTrabajo.User.Agregar(user);
            _unidadTrabajo.Guardar();

        }

        public  bool IsUser(string email, string pass)
        {
            var users =  _unidadTrabajo.User.ObtenerTodos();
            return users.Where(u => u.Email == email && u.Password == pass).Count() > 0;

        }

        public void Update(User user)
        {
            var userBd = _unidadTrabajo.User.Obtener(user.Id);
            if(userBd != null)
            {
                _unidadTrabajo.User.Actualizar(user);
            }
            
        }
    }
}
