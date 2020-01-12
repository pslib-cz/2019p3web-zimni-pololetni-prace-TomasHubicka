using Gamebook.Model;
using Gamebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Services
{
    public class RoomRepository : IRoomRepository
    {
        ApplicationDBContext _db = new ApplicationDBContext();

        public List<linkText> GetLinkTexts(int Id)
        {
            List<linkText> texts = new List<linkText>();
            foreach(linkText x in _db.linkTexts)
            {
                if(x.RoomId == Id)
                {
                    texts.Add(x);
                }
            }
            return texts;
        }

        public RoomTexts GetRoom(int Id)
        {
            return _db.roomTexts.FirstOrDefault(x => x.Id == Id);
        }

    }
}
