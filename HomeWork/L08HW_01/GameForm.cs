using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L08HW_01
{
    public partial class GameForm : Form
    {
        private Game game;
        public GameForm()
        {
            InitializeComponent();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemEdit_Click(object sender, EventArgs e)
        {
            MainForm mForm = new MainForm();
            mForm.Show();
        }

        private void menuItemStart_Click(object sender, EventArgs e)
        {
            
        }
    }
}
