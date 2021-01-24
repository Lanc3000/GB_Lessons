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
    public partial class MainForm : Form
    {
        private TrueFalse database;
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(saveFileDialog.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Maximum = 1;
                nudNumber.Minimum = 1;
                nudNumber.Value = 1;
            }
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                database = new TrueFalse(openFileDialog.FileName);
                database.Load();
                nudNumber.Value = 1;
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                if (database.Count != 0) {
                    tbQuestion.Text = database[0].Text;
                    cbTrue.Checked = database[0].TrueFalse;
                }
            }
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
            database[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;

        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            tbQuestion.Text = database[(int)nudNumber.Value - 1].Text;
            cbTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Create new database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (database == null || nudNumber.Maximum == 1) {
                MessageBox.Show(
                    "Nothing to delete",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1)
                nudNumber.Value = nudNumber.Value - 1;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(database != null)
            {
                database.Save();
            }
            else
            {
                MessageBox.Show(
                    "Database is not created!", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                    );
            }
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                    "Честно стыренно с GB. Доработанно Тимуром С.",
                    "About",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
        }
    }
}
