using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamebook.Models;
using Gamebook.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Gamebook.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        SessionStorage<User> _ss;
        UserRepository _ur = new UserRepository();
        RoomRepository _rr = new RoomRepository();
        public int room { get; set; } = 0;
        public List<RoomTexts> roomTexts { get; set; }
        public List<User> Users = new List<User>();
        public User CurrentUser { get; set; }
        public IndexModel(ILogger<IndexModel> logger, SessionStorage<User> ss)
        {
            _logger = logger;
            _ss = ss;
        }
        public void OnGet()
        {
            CurrentUser = _ss.LoadOrCreate("_User");
            Users = _ur.GetAllUsers();
            roomTexts = _rr.GetAllRooms();
        }
    }
}
