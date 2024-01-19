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
        public ScheduleInfo()
        {
            InitializeComponent();
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult = MessageBox.Show("Would You like to edit?", "Delete Task", buttons);
            // get the value of the message box if yes or no
            if (DialogResult == DialogResult.No)
            {
                // do nothing
                return;
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
            if(ScheduleTitleTextBox.Text != "" && ScheduleTitleTextBox.Text != "Edit Schedule Title")
            {
                ScheduleTitleLabel.Text = ScheduleTitleTextBox.Text;
                ScheduleTitleTextBox.Text = "Edit Schedule Title";
            }
            if(ScheduleDescriptionTextBox.Text != "" && ScheduleDescriptionTextBox.Text != "Edit the description")
            {
                ScheduleDescriptionLabel.Text = ScheduleDescriptionTextBox.Text;
                ScheduleDescriptionTextBox.Text = "Edit the description";
            }
        }
    }
}
