using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Loot
    {
        public Artifact Details { get; set; }
        public int UnlockArtifact { get; set; }
        public bool DefaultArtifact { get; set; }

        public Loot(Artifact details, int unlockArtifact, bool defaultArtifact)
        {
            Details = details;
            UnlockArtifact = unlockArtifact;
            DefaultArtifact = defaultArtifact;
        }
    }
}
