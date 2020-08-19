using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public static class Game
    {
        //to hold constants and methods for environment, creatures-npc's, locations
        public static readonly List<Location> Locations = new List<Location>();
        public static readonly List<Mission> Missions = new List<Mission>();
        public static readonly List<Artifact> Artifacts = new List<Artifact>();
        public static readonly List<Npc> Npcs = new List<Npc>();

        public const int LOCATION_ID_BASE_CAMP = 1;
        public const int LOCATION_ID_DESTROYED_STATUE = 2;
        public const int LOCATION_ID_ABANDONED_SATELLITE = 3;
        public const int LOCATION_ID_TERMINAL_ACCESS = 4;
        public const int LOCATION_ID__FOREST = 5;
        public const int LOCATION_ID_REBEL_OUTPOST = 6;
        public const int LOCATION_ID_ROBO_GUARD_CAMP = 7;
        public const int LOCATION_ID_OBSERVER_BATTLE = 8;
        public const int LOCATION_ID_BRIDGE = 9;
        public const int LOCATION_ID_ROBO_GUARD_MAIN_BASE = 10;

        public const int MISSION_ID_CLEAR_TERMINAL_ACCESS = 1;
        public const int MISSION_ID_CLEAR_ROBO_GUARD_CAMP = 2;
        public const int MISSION_ID_CLEAR_OBSERVER_BATTLE = 3;
        public const int MISSION_ID_CLEAR_ROBO_GUARD_MAIN_BASE = 4;

        //WEAPONS
        public const int ARTIFACT_ID_AXE_HANDLE = 1;
        public const int ARTIFACT_ID_PROGRAMETER = 2;
        public const int ARTIFACT_ID_PHASER_PISTOL = 3;
        public const int ARTIFACT_ID_PHASER_AMMO = 4;

        //QUEST-ITEMS to be obtained and collected to pass onto next area
        public const int ARTIFACT_ID_COMMS_MESSAGE = 4;
        public const int ARTIFACT_ID_COMMS_DIAGRAM = 5;
        public const int ARTIFACT_ID_ROBO_HEART = 6;
        public const int ARTIFACT_ID_OCULUS = 7;
        public const int ARTIFACT_ID_ROBO_BRAIN = 8;

        //elixer:
        public const int ARTIFACT_ID_REVIVE = 9;

        //OBTAIN THE CORRECT AMOUNT OF ARTIFACTS FROM NPC'S TO BUILD THIS UNIT AND PASS LEVEL
        //BASICALLY THIS UNIT ALLOWS ACCESS TO THE FIRST PORTAL OF TECHNOPROLIS
        public const int ARTIFACT_ID_PROGRAMETER_SIGHT_UPGRADE = 10;
        public const int ARTIFAcT_ID_BUILD_PARSY = 11;

        //npcs
        //villains
        public const int NPC_ID_ROBO_COMMS_CLIENT = 1;
        public const int NPC_ID_ROBO_COMMANDO = 2;
        public const int NPC_ID_OBSERVER = 3;
        public const int NPC_ID_ROBO_LEADER = 4;

        //Bill's Ai sidekick can be built upon completion of missions in this level, to gain access to the first portal.
        public const int NPC_ID_FRIEND_PARSY = 5;
        

        //+STATIC ENVIRON CONSTRUCTOR:
        static Game()
        {
            GenereateMissions();
            GenerateLocations();
            GenerateArtifacts();
            GenereateNpcs();
      
        }

        //private static voids here to GenereateObjects from the data here to the classes for player interaction:
        private static void GenereateMissions()
        {
            Mission clearTerminalAccess = new Mission(MISSION_ID_CLEAR_TERMINAL_ACCESS, "Terminal Access",
                "Hack the terminal to gain a comms access port to Technoprolis. " +
                " Decrypt 5 messages using your Programeter device to earn the communications skill upgrade., and earn 250xp.", 250, 25);

            clearTerminalAccess._achievement.Add(new MissionAchievement(FindArtifactByID(ARTIFACT_ID_COMMS_MESSAGE), 5));
            clearTerminalAccess.AchievementGetItem = FindArtifactByID(ARTIFACT_ID_PROGRAMETER_SIGHT_UPGRADE);
        }

        private static void GenerateLocations()
        {
            //each instance of a location now added to the object type list
            Location baseCamp = new Location(LOCATION_ID_BASE_CAMP, "Base-Camp", 
                    "Bill Gnan'ts hovel somewhere in the outskirts of Technoprolis.");
            Location destroyedStatue = new Location(LOCATION_ID_DESTROYED_STATUE, "Destroyed Statue",
                    " A statue of one of the last leaders of the human-freedom movement has fallen.");
            Location abandonedSatellite = new Location(LOCATION_ID_ABANDONED_SATELLITE, "Abandoned Satellite",
                    "Once used for inter-human telecommunication, the robots deemed this facility unusable for their purposes.");
            Location terminalAccess = new Location(LOCATION_ID_TERMINAL_ACCESS, "Terminal-Computer Access",
                    "There is an old computer terminal that works here."); terminalAccess.MissionAvailable = FindMissionByID(MISSION_ID_CLEAR_TERMINAL_ACCESS);
            //pick up here: once you figure out direction button display or not depending on if the user completes the first level or not

            //connect the first set of locations for the first mission:
            baseCamp.MoveNorth = destroyedStatue;

            destroyedStatue.MoveNorth = abandonedSatellite;

            abandonedSatellite.MoveNorth = terminalAccess;

            Locations.Add(baseCamp);
            Locations.Add(destroyedStatue);
            Locations.Add(terminalAccess);
        }

        private static void GenerateArtifacts()
        {
            //set consts data value to object-class properties
            //Player starts with a melee weapon and also a tech-hacking weapon
            Artifacts.Add(new Weapon(ARTIFACT_ID_AXE_HANDLE, " Blunt-Axe-Handle", "Blunt axe handles", 1, 3));
            Artifacts.Add(new Weapon(ARTIFACT_ID_PROGRAMETER, " Progra-meter", " Progra-meters", 1, 3));

        }

        private static void GenereateNpcs()
        {
            //set the consts data value to object-class properties
            //each roboMessage can send a zap to the Player if they enter buggy code that doesn't compute. - deals damage
            //                                      id,                 "name",   maxDamage , reward-loot, currenthealth, maxhealth      
            Npc roboMessageClient = new Npc(NPC_ID_ROBO_COMMS_CLIENT, " Robo Message Client", 3, 20, 10, 7, 7);
            //now if the player defeats the roboMessageClient, deal 7+ damage, they unlock a Comm's diagram.
            roboMessageClient._lootBank.Add(new Loot(FindArtifactByID(ARTIFACT_ID_COMMS_DIAGRAM), 7, false));

            Npcs.Add(roboMessageClient);

            //now add the artifacts, and test the code to move to this section of the game^
        }

        //aggregegate appropriate missions to their location find by id        
        public static Mission FindMissionByID(int id)
        {
            foreach (Mission _mission in Missions)
            {
                if (_mission.ID == id)
                {
                    return _mission;
                }
            }
            return null;
        }

        public static Artifact FindArtifactByID(int id)
        {
            foreach (Artifact _artifact in Artifacts)
            {
                if (_artifact.ID == id)
                {
                    return _artifact;
                }
            }
            return null;
        }

        public static Npc FindNpcByID(int id)
        {
            foreach (Npc _npc in Npcs)
            {
                if (_npc.ID == id)
                {
                    return _npc;
                }
            }
            return null;
        }

        public static Location FindLocationByID(int id)
        {
            foreach (Location _location in Locations)
            {
                if (_location.ID == id)
                {
                    return _location;
                }                
            }
            return null;
        }

    }
}
