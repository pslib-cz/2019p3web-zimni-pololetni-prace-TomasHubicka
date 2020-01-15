using Gamebook.Model;
using Gamebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Services
{
    public class AchievementsRepository // : IAchievementsRepository
    {


        ApplicationDBContext _db = new ApplicationDBContext();

        public AchievementsRepository(ApplicationDBContext db)
        {
            _db = db;
        }

        public void Add(Achievements achievements)
        {
            bool adding = true;

            foreach(Achievements x in _db.achievements)
            {
                if (x.UserId == achievements.UserId && x.AchievementId == achievements.AchievementId)
                {
                    adding = false;
                    break;
                }
            }
            if (adding)
            {
                _db.achievements.Add(achievements);
            }
            
        }

        public List<string> GetAchievement(int Id)
        {
            List<Achievements> achievements = new List<Achievements>();
            //return _db.achievements.Where(a => a.UserId == Id).ToList();
            foreach (Achievements x in _db.achievements.Where(a => a.UserId == Id))
            {
                if (x.UserId == Id)
                {
                    achievements.Add(x);
                }
            }
            List<string> completion = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                if (achievements.Count != 0)
                {
                    int g = 0;
                    for (int o = 0; o < achievements.Count; o++)
                    {
                        g = o;
                        if (achievements[o].AchievementId == i)
                        {
                            completion.Add("Completed");
                            break;
                        }
                    }
                    if (achievements[g].AchievementId != i)
                    {
                        completion.Add("Not Completed");
                    }
                }
                else
                {
                        completion.Add("Not Completed");
                }
            }
            return completion;
        }
    }
}
