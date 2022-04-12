using AuthBasicwithDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuthBasicwithDB.Security
{
    
    public interface IUserService
    {
        public bool IsUser(string email, string pass);
        User GetUser(int id);
        User GetUserByEmail(string email);
        IEnumerable<User> GetUsers();
        void Update(User user);
        void Insert(User user);
   
    }
}
