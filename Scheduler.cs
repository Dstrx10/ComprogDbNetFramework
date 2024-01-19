using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ComprogDbNetFramework
{
    public partial class Scheduler : MaterialForm
    {
        public Scheduler()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ScheduleToggleBtn_Click(object sender, EventArgs e)
        {

        }

        private void TaskBtn_Click(object sender, EventArgs e)
        {
            String title = TitleTextBox.Text;
            String description = DescriptionTextMultiBox.Text;
            DateTime date = DateTime.Now; 
            bool iscomplete = false;
            ScheduleDataTable.Rows.Add(title, description, date, iscomplete);
            // save data to database
        }

        private void ScheduleDeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void ScheduleDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // get the row index and the column index
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult = MessageBox.Show("Would You like to edit?", "Delete Task", buttons);
            // get the value of the message box if yes or no
            if(DialogResult == DialogResult.No)
            {
                // do nothing
                return;
            }
            // redirect to form 2
            ScheduleInfo form2 = new ScheduleInfo();
            form2.Show();
            // hide the current form

        }
    }
}
