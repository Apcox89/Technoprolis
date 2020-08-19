using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class PlayerMission
    {
        public Mission Details { get; set; }
        public bool AccomplishedMission { get; set; }

        public PlayerMission(Mission details)
        {
            Details = details;
            AccomplishedMission = false;
        }
    }
}
