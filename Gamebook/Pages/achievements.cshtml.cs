using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamebook.Model;
using Gamebook.Models;
using Gamebook.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Gamebook.Pages
{
    public class achievementsModel : PageModel
    {
        private readonly ILogger<achievementsModel> _logger;
        SessionStorage<User> _ss;
        AchievementsRepository _ar = new AchievementsRepository();
        public Achievements achievements;
        public achievementsModel(ILogger<achievementsModel> logger, SessionStorage<User> ss)
        {
            _logger = logger;
            _ss = ss;
        }
        public void OnGet()
        {
            achievements = _ar.GetAchievement(_ss.LoadOrCreate("_User").Id);
        }
    }
}