using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        //properties
        public int ID { get; set; }
        public string LocationName { get; set; }
        public string LocationDescription { get; set; }

        //call to classes that will act as datatypes, since player moving to a specific location will invoke certain data
        public Artifact ArtifactRequired { get; set; } //artifact is needed or not to enter a certain area
        public Mission MissionAvailable { get; set; } //there is either a mission available here or not
        public Npc NpcInteraction { get; set; } //npc's are available to interact with or not
        //directions to invoke certain data with button clicks:
        public Location MoveNorth { get; set; }
        public Location MoveEast { get; set; }
        public Location MoveWest { get; set; }
        public Location MoveSouth { get; set; }

        //where is the player currently property?
        public Location CurrentLocation { get; set; }

        //constructor + nulls for locations that don't have those aspects available
        public Location(int locID, string locName, string locDescription, 
                Artifact artifactrequired = null, Mission missionAvailable = null, Npc npcInteraction = null)
        {
            //property = parameter
            ID = locID;
            LocationName = locName;
            LocationDescription = locDescription;
            ArtifactRequired = artifactrequired;
            MissionAvailable = missionAvailable;
            NpcInteraction = npcInteraction;
        }

    }
}
