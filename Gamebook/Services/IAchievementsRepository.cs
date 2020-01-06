using Gamebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Model
{
    interface IAchievementsRepository
    {
        void Add(ApplicationDBContext db, Achievements achievements);
        Achievements GetAchievement(int Id);
        List<Achievements> GetAllAchievements();
    }
}
