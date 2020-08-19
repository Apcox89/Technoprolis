using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //base class for NPC/Player
    public class Character
    {
        //shares health attributes
        public int CurrentHealth { get; set; }
        public int MaxHealth{ get; set; }

        public Character(int currentHealth, int maxHealth)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
        }

    }
}
