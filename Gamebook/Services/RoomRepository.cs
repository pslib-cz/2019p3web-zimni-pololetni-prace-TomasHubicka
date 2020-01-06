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
        List<RoomTexts> Rooms { get; set; }

        public List<RoomTexts> GetAllRooms()
        {
            return Rooms = _db.roomTexts.ToList();
        }

        public RoomTexts GetRoom(int Id)
        {
            return _db.roomTexts.FirstOrDefault(x => x.Id == Id);
        }

    }
}
