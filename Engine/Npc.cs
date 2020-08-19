using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Npc: Character
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxDamage { get; set; }
        public int RewardXp { get; set; }
        public int RewardLoot { get; set; }

        //call to Loot class to genereate array data-type list for Player interaction
        //if player beats an npc, they get loot of some type.
        public List<Loot> _lootBank { get; set; }

        public Npc(int id, string name, int maxDamage, int rewardXp,
            int rewardLoot, int currentHealth, int maxHealth) : base(currentHealth, maxHealth)
        {
            ID = id;
            Name = name;
            MaxDamage = maxDamage;
            RewardXp = rewardXp;
            RewardLoot = rewardLoot;
            _lootBank = new List<Loot>();
        }
    }
}
