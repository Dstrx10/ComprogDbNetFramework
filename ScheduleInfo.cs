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
        string filePath = @"C:\Users\MHELL\source\repos\ComprogDbNetFramework\ScheduleTextFile.txt";
        public ScheduleInfo(string title, string description, DateTime date, bool isComplete)
        {
            InitializeComponent();
            this.title = title;
            this.description = description;
            this.date = date;
            this.isComplete = isComplete;
            ScheduleTitleTextBox.Text = title;
            ScheduleDescriptionTextBox.Text = description;
            isCompletedCheckBox.Checked = isComplete;
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
            string searchString = $"{title},{description},{date},{!isComplete}";
            int index = Array.FindIndex(lines, line => line == searchString);
            if (index != -1)
            {
                lines[index] = $"{ScheduleTitleTextBox.Text.Trim()},{ScheduleDescriptionTextBox.Text.Trim()},{date},{isComplete}";
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
                this.Dispose();
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
