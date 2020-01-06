using Gamebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Model
{
    interface IUserRepository
    {
        User GetUser(int Id);
        List<User> GetAllUsers();
        void Add(ApplicationDBContext db, User user);
    }
}
