using Gamebook.Models;
using Gamebook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Model
{
    interface IAchievementsRepository
    {
        void Add(ApplicationDBContext db, Achievements achievements);
        List<string> GetAchievement(int Id);
    }
}
