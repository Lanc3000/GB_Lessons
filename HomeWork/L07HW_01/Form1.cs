using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L07HW_01
{
    public partial class Form1 : Form
    {
        private int count = 0;
        private int goal = 0;
        public Form1()
        {
            InitializeComponent();
        }
        // public event EventHandler WictoryEvent;
        public void GenereateGoal() {
            Random rnd = new Random();
            goal = rnd.Next(4, 4096);
        }
        public void WictoryChecker()
        {
            if (int.Parse(textBoxNumber.Text) == goal)
            {
                MessageBox.Show($"Победа! Вам потребовалось - {count} попыток.", "Wictory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        }
        public void Reset() {
            count = 0;
            textBoxNumber.Text = "1";
            textBoxCount.Text = count.ToString();
        }
        private void btnPlusOne_Click(object sender, EventArgs e)
        {
            count++;
            textBoxNumber.Text = (int.Parse(textBoxNumber.Text) + 1).ToString();
            textBoxCount.Text = count.ToString();
            WictoryChecker();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            count++;
            textBoxNumber.Text = (int.Parse(textBoxNumber.Text) * 2).ToString();
            textBoxCount.Text = count.ToString();
            WictoryChecker();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            // действия над стеком
        }

        private void игратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenereateGoal();
            MessageBox.Show($"Игра началась! \n За минимальное количество ходов получите число {goal}", "Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxGoal.Text = goal.ToString();
            btnReset.Enabled = true;
            btnReverse.Enabled = true;
            btnPlusOne.Enabled = true;
            btnDouble.Enabled = true;
            
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
