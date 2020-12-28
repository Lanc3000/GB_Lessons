using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L07HW_02
{
    public partial class Form1 : Form
    {
        public int count = 0;
        Random rnd = new Random();
        private int goal;

        public void GenereateGoal()
        {
            Random rnd = new Random();
            goal = rnd.Next(1, 100);
        }

        public Form1()
        {
            InitializeComponent();
            
        }


        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEnter.Enabled = true;
            textBoxAnswer.Enabled = true;
            MessageBox.Show($"Игра началась! \n Отгадайте задуманное число от 1 до 100.", "Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GenereateGoal();
        }

        private void textBoxAnswer_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            count++;
            var res = int.TryParse((textBoxAnswer.Text), out int i);
            if (res)
            {
                if (i == goal)
                    MessageBox.Show($"Победа! Вам потребовалось - {count} попыток.", "Wictory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    if (i < goal)
                    textBoxCheck.Text = "Больше";
                else
                    textBoxCheck.Text = "Меньше";
            }
            else
                MessageBox.Show("Некорректное число!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
