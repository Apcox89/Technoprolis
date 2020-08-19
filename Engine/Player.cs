using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : Character
    {
        //to list properties and <T> objects for game
        public string PlayerName { get; set; }
        public int Loot { get; set; }
        public int Xp { get; set; }
        public int Level { get; set; }

        public Location UpdateLocation { get; set; }

        //add clases as list properties to generate items in inventory/missions
        public List<Inventory> InventoryCollection { get; set; }
        public List<PlayerMission> PlayMission {get; set;}       

        //constrcutor will pass values from base class here using the parameter call then call to base with matching name:
        public Player(string pName, int loot, int xp, int level, int currentHealth, int maxHealth) : base(currentHealth, maxHealth)
        {
            PlayerName = pName;
            Loot = loot;
            Xp = xp;
            Level = level;
            //correspondings list attributes added to Player class:
            InventoryCollection = new List<Inventory>();
            PlayMission = new List<PlayerMission>();
        }
     
    }
}
