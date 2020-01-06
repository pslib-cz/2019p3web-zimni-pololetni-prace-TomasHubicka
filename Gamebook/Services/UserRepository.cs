using Gamebook.Model;
using Gamebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Services
{
    public class UserRepository : IUserRepository
    {
        ApplicationDBContext _db = new ApplicationDBContext();
        List<User> Users { get; set; }
        public void Add(ApplicationDBContext db,  User user)
        {
            db.users.Add(user);       
        }

        public List<User> GetAllUsers()
        {
            return Users = _db.users.ToList();
        }

        public User GetUser(int Id)
        {
            return _db.users.FirstOrDefault(x => x.Id == Id);
        }
    }
}
