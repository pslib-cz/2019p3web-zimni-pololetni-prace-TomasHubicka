using Gamebook.Model;
using Gamebook.Models;
using Gamebook.Pages;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Services
{
    public class UserLogin
    {

        UserRepository _ur = new UserRepository();
        List<User> Users = new List<User>();
        Achievements achievements { get; set; } = new Achievements();
        public bool login(SessionStorage<User> _ss, User user)
        {
            Users = _ur.GetAllUsers();
            int UserAmount = Users.Count - 1;
            foreach (var x in Users)
            {
                if (user.login.ToString() == Users[UserAmount].login.ToString())
                {
                    if (user.password.ToString() == Users[UserAmount].password.ToString())
                    {
                        _ss.Save("_User", Users[UserAmount]);
                        return true;
                    }
                }
                else
                {
                    
                }
                UserAmount--;
            }
            return true;
        }
    }
}
