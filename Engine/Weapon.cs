using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Artifact
    {
      
        public int ID { get; set; }
        public string Name { get; set; }
        public string NameMulti { get; set; }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(int id, string name, string nameMulti, int minDamage, int maxDamage) : base (id, name, nameMulti)
        {
            MinimumDamage = minDamage;
            MaximumDamage = maxDamage;
        }
    }
}
