using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fight;
using GameManager;

namespace Assessment_125
{
    public partial class Form1 : Form
    {
        SaveLoad<Unit> _SaveLoad = new SaveLoad<Unit>();
        Unit currentUser;
        GameManager.GameManager game = GameManager.GameManager.stage;
        List<Unit> stats = new List<Unit>();

        public Form1()
        {
            InitializeComponent();
            currentUser = new Unit("Ryan", 100, 100, 50, 1, 0);

            foreach (Unit u in game) // is going to show the unit that i just created.
            {
                if (stats.Contains(u))
                {
                    stats.Remove(u);
                }
                stats.Add(u);
            }
        }

        private void Display_TextChanged(object sender, EventArgs e) // will show what is happening durring the game 
        {
            
        }

        private void Attack_Click(object sender, EventArgs e) //going to be the button that will tell the users character to attack.
        {

        }

        private void Stats_Click(object sender, EventArgs e) // will show the stats of the hero on screen.
        {

        }

        private void VStats_Click(object sender, EventArgs e) // will show the villians stats on screen.
        {

        }

        private void Save_Click(object sender, EventArgs e) // saves the current progress the user has.
        {
            _SaveLoad.Serialize("UserInfo", currentUser);
        }

        private void Load_Click(object sender, EventArgs e) // loads a previous game
        {
            currentUser = _SaveLoad.Deserialize("UserInfo");
            
        }

        private void New_Game_Click(object sender, EventArgs e) // will allow the user to create a new game
        {

        }
    }
}
