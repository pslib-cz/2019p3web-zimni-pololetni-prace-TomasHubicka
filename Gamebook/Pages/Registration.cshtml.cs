using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Gamebook.Model;
using Gamebook.Models;
using Gamebook.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gamebook.Pages
{
    public class RegistrationModel : PageModel
    {
        AchievementsRepository _ar = new AchievementsRepository();
        UserRepository _ur = new UserRepository();
        public ApplicationDBContext _db = new ApplicationDBContext();
        public void OnGet()
        {

        }
        [BindProperty]
        public User user { get; set; }
        public Achievements achievements { get; set; } = new Achievements();
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _ur.Add(_db, user);
            await _db.SaveChangesAsync();
            return RedirectToPage("./login");
        }
    }
}