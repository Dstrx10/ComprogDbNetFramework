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
        string filePath = @"C:\Users\MHELL\source\repos\ComprogDbNetFramework\ScheduleTextFile.txt";
        public Scheduler()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            ScheduleDataTable.CellClick += ScheduleDataTable_CellClick;
            TitleTextBox.GotFocus += TitleTextBox_GotFocus;
            TitleTextBox.LostFocus += TitleTextBox_LostFocus;
            DescriptionTextMultiBox.GotFocus += DescriptionTextMultiBox_GotFocus;
            DescriptionTextMultiBox.LostFocus += DescriptionTextMultiBox_LostFocus;
        }
        private void SaveDataToFile(string title, string description, DateTime date, bool isComplete)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true))
            {
                string line = $"{title},{description},{date},{isComplete}";
                file.WriteLine(line);
            }
        }

        private void LoadDataFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                ScheduleDataTable.Rows.Add(values);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ScheduleDataTable.Rows.Clear();
            LoadDataFromFile();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TaskBtn_Click(object sender, EventArgs e)
        {
            TaskBtn.Enabled = false;
            string title = TitleTextBox.Text.Trim();
            string description = DescriptionTextMultiBox.Text.Trim();
            DateTime date = DateTime.Now; 
            bool isComplete = false;

            if (TitleTextBox.Text == "Enter title name" && DescriptionTextMultiBox.Text == "Create a description...")
            {
                MessageBox.Show("Title and Description cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(description))
            {
                SaveDataToFile(title, description, date, isComplete);
                ScheduleDataTable.Rows.Clear(); //clear data in datagrid before loading data from txt file fuck u
                LoadDataFromFile();
            }           
            else
            {
                MessageBox.Show("Title and Description cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TaskBtn.Enabled = true;
        }

        private void ScheduleDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void ScheduleDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // check if the clicked cell is in the row header
            if (e.RowIndex >= 0 && e.ColumnIndex < 0)
            {
                // row header clicked, get the row index
                int rowIndex = e.RowIndex;

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Would you like to edit?", "Edit Task", buttons);

                if (result == DialogResult.Yes)
                {
                    string title = ScheduleDataTable.Rows[rowIndex].Cells[0].Value.ToString();
                    string description = ScheduleDataTable.Rows[rowIndex].Cells[1].Value.ToString();
                    DateTime date = Convert.ToDateTime(ScheduleDataTable.Rows[rowIndex].Cells[2].Value);
                    bool isComplete = Convert.ToBoolean(ScheduleDataTable.Rows[rowIndex].Cells[3].Value);
                    // Redirect to form 2 
                    ScheduleInfo form2 = new ScheduleInfo(title, description, date, isComplete);
                    form2.Show();
                    ScheduleDataTable.Rows.Clear();
                    LoadDataFromFile();
                }
                else 
                {
                    return;
                }
            }
        }
        private void TitleTextBox_GotFocus(object sender, EventArgs e)
        {
            if (TitleTextBox.Text == "Enter title name")
            {
                TitleTextBox.Text = "";
            }
        }

        private void TitleTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TitleTextBox.Text))
            {
                TitleTextBox.Text = "Enter title name";
            }
        }
        private void DescriptionTextMultiBox_GotFocus(object sender, EventArgs e)
        {
            if (DescriptionTextMultiBox.Text == "Create a description...")
            {
                DescriptionTextMultiBox.Text = "";
            }
        }

        private void DescriptionTextMultiBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DescriptionTextMultiBox.Text))
            {
                DescriptionTextMultiBox.Text = "Create a description...";
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ScheduleDataTable.Rows.Clear();
            LoadDataFromFile();
        }
    }
}
