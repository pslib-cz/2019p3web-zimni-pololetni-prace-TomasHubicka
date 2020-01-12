using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamebook.Models;
using Gamebook.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Gamebook.Services;
using Microsoft.Extensions.Logging;
using Gamebook.Model;

namespace Gamebook.Pages
{
    public class loginModel : PageModel
    {
        private readonly ILogger<loginModel> _logger;
        SessionStorage<User> _ss;
        UserLogin _ul = new UserLogin();
        AchievementsRepository _ar = new AchievementsRepository();
        ApplicationDBContext _db = new ApplicationDBContext();
        [BindProperty]
        public User user { get; set; }
        public int Error { get; set; }
        public Achievements achievements { get; set; } = new Achievements();
        public loginModel(ILogger<loginModel> logger, SessionStorage<User> ss)
        {
            _logger = logger;
            _ss = ss;
        }
        public void OnGet()
        {
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (_ul.login(_ss, user) == true)
            {
                return RedirectToPage("./index");
            }
            else
            {
                Error = 1;
                return Page();
            }
        }
    }
}