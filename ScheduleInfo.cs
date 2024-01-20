using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ComprogDbNetFramework
{
    public partial class ScheduleInfo : MaterialForm
    {
        private string title;
        private string description;
        private DateTime date;
        private bool isComplete;
        string filePath = System.IO.Path.Combine(Application.StartupPath, "ScheduleTextFile.txt");
        public ScheduleInfo(string title, string description, DateTime date, bool isComplete)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.isComplete = isComplete;
            InitializeComponent();
            MessageBox.Show($"{this.title},{this.description},{this.date},{this.isComplete}");
            ScheduleTitleLabel.Text = title;
            ScheduleDescriptionLabel.Text = description;
            ScheduleDescriptionTextBox.Text = description;
            isCompletedCheckBox.Checked = isComplete;
            ScheduleTitleTextBox.Text = title;
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult = MessageBox.Show("Would you like to delete?", "Delete Task", buttons);
            // get the value of the message box if yes or no
            if (DialogResult == DialogResult.Yes)
            {
                DeleteData();
                this.Close();
            }
        }
        private void UpdateData()
        {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            string searchString = $"{title},{description},{date},{isComplete}";
            int index = Array.FindIndex(lines, line => line == searchString) == -1 ? 0 : Array.FindIndex(lines, line => line == searchString);
            if (index >= 0)
            {
                // get the index
                lines.SetValue($"{ScheduleTitleTextBox.Text.Trim()},{ScheduleDescriptionTextBox.Text.Trim()},{date},{!isComplete}", index);
                System.IO.File.WriteAllLines(filePath, lines);
            }
        }
        private void DeleteData()
        {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            string searchString = $"{title},{description},{date},{isComplete}";
            int index = Array.FindIndex(lines, line => line == searchString);
            if (index != -1)
            {
                List<string> updatedLines = lines.ToList();
                updatedLines.RemoveAt(index);
                System.IO.File.WriteAllLines(filePath, updatedLines);
                this.Close();
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void ScheduleTitleTextBox_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //update the schedule info title and description
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Would you like to update?", "Edit Task", buttons);
            title = ScheduleTitleTextBox.Text;
            description = ScheduleTitleTextBox.Text;
            if (result == DialogResult.Yes)
            {
                if (ScheduleTitleTextBox.Text != "" && ScheduleTitleTextBox.Text != "Edit Schedule Title")
                {
                    UpdateData();
                    ScheduleTitleLabel.Text = ScheduleTitleTextBox.Text;
                    ScheduleTitleTextBox.Text = "Edit Schedule Title";
                }
                if (ScheduleDescriptionTextBox.Text != "" && ScheduleDescriptionTextBox.Text != "Edit the description")
                {
                    ScheduleDescriptionLabel.Text = ScheduleDescriptionTextBox.Text;
                    ScheduleDescriptionTextBox.Text = "Edit the description";
                }
            }
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void isCompletedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            isComplete = isCompletedCheckBox.Checked;
            UpdateData();
        }
    }
}
