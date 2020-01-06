using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Model
{
    public class Achievements
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool win { get; set; }
        public bool TurnAround { get; set; }
        public bool BedroomAdventure { get; set; }
        public bool FallOut { get; set; }
        public bool CrowbarsAreHeavy { get; set; }
        public bool PushingNeverWorks { get; set; }
        public bool KnifeFight { get; set; }
        public bool KungFuFight { get; set; }
        public bool ItsDark { get; set; }
        public bool DoNothingAndDie { get; set; }
    }
}
