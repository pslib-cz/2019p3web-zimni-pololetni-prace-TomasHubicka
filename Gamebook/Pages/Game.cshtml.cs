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
    public class GameModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public SessionStorage<GameState> _ss;
        public SessionStorage<int> _cr;
        SessionStorage<bool> _w;
        SessionStorage<User> _u;
        UserRepository _ur = new UserRepository();
        RoomRepository _rr = new RoomRepository();
        GameLogic _gl = new GameLogic();
        public RoomTexts roomText { get; set; } = new RoomTexts();
        public User CurrentUser { get; set; }
        public GameModel(ILogger<IndexModel> logger, SessionStorage<GameState> ss, SessionStorage<int> cr, SessionStorage<bool> w, SessionStorage<User> u)
        {
            _logger = logger;
            _ss = ss;
            _cr = cr;
            _w = w;
            _u = u;
        }
        public void OnGet()
        {
            _gl.Start(_ss, _cr, _w);
            roomText = _rr.GetRoom(_cr.LoadOrCreate("_CurrentRoom"));

        }
        public IActionResult OnPostBasement()
        {
            GameState game = _ss.LoadOrCreate("_Game");
            game.EnteredBasement = true;
            _ss.Save("_Game", game);
            _gl.Run(_ss, _cr, _w, _u, 0);
            _w.Save("_Waiting", true);
            roomText = _rr.GetRoom(_cr.LoadOrCreate("_CurrentRoom"));
            return Page();

        }
        public IActionResult OnPostOne()
        {
            _gl.Run(_ss, _cr, _w, _u, 1);
            _w.Save("_Waiting", true);
            roomText = _rr.GetRoom(_cr.LoadOrCreate("_CurrentRoom"));
            return Page();

        }
        public IActionResult OnPostTwo()
        {
            _gl.Run(_ss, _cr, _w, _u, 2);
            _w.Save("_Waiting", true);
            roomText = _rr.GetRoom(_cr.LoadOrCreate("_CurrentRoom"));
            return Page();
        }
        public IActionResult OnPostThree()
        {
            _gl.Run(_ss, _cr, _w, _u, 3);
            _w.Save("_Waiting", true);
            roomText = _rr.GetRoom(_cr.LoadOrCreate("_CurrentRoom"));
            return Page();
        }
    }
}