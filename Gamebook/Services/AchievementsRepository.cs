using Gamebook.Model;
using Gamebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Services
{
    public class AchievementsRepository : IAchievementsRepository
    {
        ApplicationDBContext _db = new ApplicationDBContext();
        List<Achievements> achievements { get; set; }
        public void Add(ApplicationDBContext db, Achievements achievements)
        {
            db.achievements.Add(achievements);
        }
        public List<Achievements> GetAllAchievements()
        {
            return achievements = _db.achievements.ToList();
        }

        public Achievements GetAchievement(int Id)
        {
            return _db.achievements.FirstOrDefault(x => x.UserId == Id);
        }
        public void Update(Achievements achievementsChanges)
        {
            Achievements achievements = _db.achievements.FirstOrDefault(x => x.Id == achievementsChanges.Id);
            if (achievements != null)
            {
                achievements.win = achievementsChanges.win;
                achievements.TurnAround = achievementsChanges.TurnAround;
                achievements.BedroomAdventure = achievementsChanges.BedroomAdventure;
                achievements.FallOut = achievementsChanges.FallOut;
                achievements.CrowbarsAreHeavy = achievementsChanges.CrowbarsAreHeavy;
                achievements.PushingNeverWorks = achievementsChanges.PushingNeverWorks;
                achievements.KnifeFight = achievementsChanges.KnifeFight;
                achievements.KungFuFight = achievementsChanges.KungFuFight;
                achievements.ItsDark = achievementsChanges.ItsDark;
                achievements.DoNothingAndDie = achievementsChanges.DoNothingAndDie;
                _db.SaveChanges();
            }
        }
    }
}
