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
using System.Xml.Serialization;
using System.IO;

namespace Assessment_125
{
    [Serializable]
    [XmlSerializerAssembly]
    public partial class Form1 : Form
    {
        SaveLoad<Unit> _SaveLoad = new SaveLoad<Unit>();
        Unit currentUser;

        public Form1()
        {
            InitializeComponent();
            currentUser = new Unit("Ryan", 100, 100, 50, 1, 0);
        }

        private void Display_TextChanged(object sender, EventArgs e) // will show what is happening durring the game 
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
            string path = Environment.CurrentDirectory + @"\UserInfo\";
            Display.Text += ("Game Saved");
        }

        private void Load_Click(object sender, EventArgs e) // loads a previous game
        {
            Display.Text = "";
            string path = Environment.CurrentDirectory + @"\UserInfo\";
            UpdateDisplay();
        }

        private void Attack_Click(object sender, EventArgs e) //going to be the button that will tell the users character to attack.
        {
            Display.Text = "";
            UpdateDisplay();
            currentUser.Health -= 5;          
        }

        private void New_Game_Click(object sender, EventArgs e) // will allow the user to create a new game
        { 
            currentUser = new Unit("Ryan", 100, 100, 50, 1, 0);
            UpdateDisplay();           
        }

        private void UpdateDisplay()
        {
            Display.Text += currentUser.Name + Environment.NewLine +
                currentUser.Health + Environment.NewLine +
                currentUser.Attack + Environment.NewLine +
                currentUser.Speed + Environment.NewLine +
                currentUser.Level + Environment.NewLine +
                currentUser.XP;
        }
    }
}
