using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Mission
    {
        public int ID { get; set; }
        public string MissionName { get; set; }
        public string MissionDescription { get; set; }
        public int AwardXp { get; set; }
        public int AwardLoot { get; set; }

        //need to call to the Artifact class for a player who gains an achievement
        public Artifact AchievementGetItem { get; set; }

        //call to MissionAchievemt to generate list object array data type
        public List<MissionAchievement> _achievement { get; set; }

        public Mission(int missionID, string missionName, string missionDescript, int missionXp, int missionLoot)
        {
            ID = missionID;
            MissionName = missionName;
            MissionDescription = missionDescript;
            AwardXp = missionXp;
            AwardLoot = missionLoot;
            _achievement = new List<MissionAchievement>();
        }

    }


}
