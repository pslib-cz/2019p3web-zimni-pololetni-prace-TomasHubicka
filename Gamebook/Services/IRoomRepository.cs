using Gamebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Model
{
    interface IRoomRepository
    {
        RoomTexts GetRoom(int Id);
        List<linkText> GetLinkTexts(int Id);
    }
}
