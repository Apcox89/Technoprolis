using System;
using Engine;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* A.Cox - Summer 20'
 * SD-725 Final Project 
 * Technoprolis Text-RPG Port
 * Template using Scott-Lilly's C# RPG
 */

namespace Technoprolis
{
    public partial class Technoprolis : Form
    {
        //instance of Player object:
        private Player _player;

        public Technoprolis()
        {
            InitializeComponent();

            //set instance of _player object to work with in form
            //property order: name, loot, Xp, Level, CurrentHealth, Maxhealth
            //1000 xp to earn next level, 250 for each of the 4 quests
            _player = new Player(" ", 10, 0, 1, 100, 100);

            //initialize player start Location
            MovePlayer(Game.FindLocationByID(Game.LOCATION_ID_BASE_CAMP));

            //initialize weapons to the player inventory:
            _player.InventoryCollection.Add(new Inventory(Game.FindArtifactByID(Game.ARTIFACT_ID_AXE_HANDLE), 1));
            _player.InventoryCollection.Add(new Inventory(Game.FindArtifactByID(Game.ARTIFACT_ID_PROGRAMETER), 2));

            lblHealth.Text = _player.CurrentHealth.ToString();
            lblLoot.Text = _player.Loot.ToString();
            lblExperience.Text = _player.Xp.ToString();
            lblLevel.Text = _player.Level.ToString();           

        }

        private void Technoprolis_Load(object sender, EventArgs e)
        {
            //create welcome prompt form that leads to this page.
        }            

        private void btnName_Click(object sender, EventArgs e)
        {
            //output the playerName typed in + jsSon validation      
            _player.PlayerName = txtPlayerName.Text;
            lblName.Text = _player.PlayerName + " playing as Bill Gnant";
            //newline?
        }

        //class constructor where most of the action takes place:
        private void MovePlayer(Location newLocation)
        {
            _player.UpdateLocation = newLocation;

            rtbLocations.Text = newLocation.LocationName + Environment.NewLine;
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            MovePlayer(_player.UpdateLocation.MoveNorth);
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            MovePlayer(_player.UpdateLocation.MoveWest);
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            MovePlayer(_player.UpdateLocation.MoveEast);
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            MovePlayer(_player.UpdateLocation.MoveSouth);
        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
            
    }
}
