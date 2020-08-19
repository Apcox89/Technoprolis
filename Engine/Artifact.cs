using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //base class for Elixer & Weapon
    public class Artifact
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NameMulti { get; set; }

        public Artifact(int id, string name, string nameMulti)
        {
            ID = id;
            Name = name;
            NameMulti = nameMulti;
        }

    }
}
