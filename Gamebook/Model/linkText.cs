using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Model
{
    public class linkText
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string LinkNumber { get; set; }
        public string text { get; set; }
    }
}
