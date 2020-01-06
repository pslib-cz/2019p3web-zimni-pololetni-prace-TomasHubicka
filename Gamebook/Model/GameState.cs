using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Model
{
    public class GameState
    {

        public int Start { get; set; }
        public int CrowbarYN { get; set; }
        public int KitchenHall2 { get; set; }
        public int KnifeYN { get; set; }
        public int BedroomHall3 { get; set; }
        public int LivingRoomBasementWindow { get; set; }
        public int KeepCrowbarYN { get; set; }
        public int RunFight { get; set; }
        public int PushPull { get; set; }
        public bool CrowbarInv { get; set; }
        public bool KnifeInv { get; set; }
        public bool FlashlightInv { get; set; }
        public bool EnteredBasement { get; set; }
    }
}
