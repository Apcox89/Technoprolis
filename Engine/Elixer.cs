using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Elixer : Artifact
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NameMulti { get; set; }
        public int Revive { get; set; }

        //hmm masked names to matc inherited classes, probably better with an interface
        public Elixer(int id, string name, string nameMulti, int revive) : base(id, name, nameMulti)
        {
            Revive = revive;
        }

    }
}
