using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class MissionAchievement
    {
        //to give the Player a reward item upon achieving a mission
        public Artifact Details { get; set; }
        public int Quantity { get; set; }

        public MissionAchievement(Artifact details, int qty)
        {
            Details = details;
            Quantity = qty;
        }
    }
}
