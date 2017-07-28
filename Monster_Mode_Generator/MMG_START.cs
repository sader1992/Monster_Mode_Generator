using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monster_Mode_Generator
{
    public partial class MMG_START : Form
    {
        public MMG_START()
        {
            InitializeComponent();
        }
        
        private void START_Click(object sender, EventArgs e)
        {
            MMG_Hercules Hercules = new MMG_Hercules();
            MMG_OrAthena OrAthena = new MMG_OrAthena();
            MMG_rAthena rAthena = new MMG_rAthena();
            MMG_START START = new MMG_START();
            object version = VERSION_START.SelectedItem;
            if (VERSION_START.SelectedIndex == 0)
            {
                
                Hide();
                rAthena.Show();
            }
            else if (VERSION_START.SelectedIndex == 1)
            {
                Hide();
                Hercules.Show();
            }
            else if (VERSION_START.SelectedIndex == 2)
            {
                Hide();
                OrAthena.Show();
            }
            else
            {
                MessageBox.Show("Choose your Emulator");
            }
        }

        private void MMG_START_Load(object sender, EventArgs e)
        {

        }

        private void MMG_START_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go to your server files and navigate to /doc/mob_db_mode_list.txt" + Environment.NewLine + "you will find the Date at line 6");
        }
    }
}
