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

        public Form1()
        {
            InitializeComponent();
            currentUser = new Unit("Ryan", 100, 100, 50, 1, 0);
        }
        
        private void Display_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Attack_Click(object sender, EventArgs e)
        {

        }

        private void Skip_Click(object sender, EventArgs e)
        {

        }

        private void hTurn_Click(object sender, EventArgs e)
        {

        }

        private void vTurn_Click(object sender, EventArgs e)
        {

        }

        private void Stats_Click(object sender, EventArgs e)
        {

        }

        private void VStats_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            _SaveLoad.Serialize("UserInfo", currentUser);
        }

        private void Load_Click(object sender, EventArgs e)
        {
            currentUser = _SaveLoad.Deserialize("UserInfo");
            
        }

        private void New_Game_Click(object sender, EventArgs e)
        {

        }

        private void Block_Click(object sender, EventArgs e)
        {

        }
    }
}
