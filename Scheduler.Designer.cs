namespace ComprogDbNetFramework
{
    partial class Scheduler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DescriptionTextMultiBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.TitleTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.TaskBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.ScheduleDataTable = new System.Windows.Forms.DataGridView();
            this.TitleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCompleteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.84013F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.15987F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 235);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(323, 0);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(100, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 9;
            // 
            // DescriptionTextMultiBox
            // 
            this.DescriptionTextMultiBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextMultiBox.AnimateReadOnly = false;
            this.DescriptionTextMultiBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DescriptionTextMultiBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.DescriptionTextMultiBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescriptionTextMultiBox.Depth = 0;
            this.DescriptionTextMultiBox.HideSelection = true;
            this.DescriptionTextMultiBox.Location = new System.Drawing.Point(11, 109);
            this.DescriptionTextMultiBox.MaxLength = 32767;
            this.DescriptionTextMultiBox.MouseState = MaterialSkin.MouseState.OUT;
            this.DescriptionTextMultiBox.Name = "DescriptionTextMultiBox";
            this.DescriptionTextMultiBox.PasswordChar = '\0';
            this.DescriptionTextMultiBox.ReadOnly = false;
            this.DescriptionTextMultiBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DescriptionTextMultiBox.SelectedText = "";
            this.DescriptionTextMultiBox.SelectionLength = 0;
            this.DescriptionTextMultiBox.SelectionStart = 0;
            this.DescriptionTextMultiBox.ShortcutsEnabled = true;
            this.DescriptionTextMultiBox.Size = new System.Drawing.Size(851, 113);
            this.DescriptionTextMultiBox.TabIndex = 2;
            this.DescriptionTextMultiBox.TabStop = false;
            this.DescriptionTextMultiBox.Text = "create a description...";
            this.DescriptionTextMultiBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DescriptionTextMultiBox.UseSystemPasswordChar = false;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.AllowPromptAsInput = true;
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TitleTextBox.AnimateReadOnly = false;
            this.TitleTextBox.AsciiOnly = false;
            this.TitleTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TitleTextBox.BeepOnError = false;
            this.TitleTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TitleTextBox.Depth = 0;
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TitleTextBox.HidePromptOnLeave = false;
            this.TitleTextBox.HideSelection = true;
            this.TitleTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TitleTextBox.LeadingIcon = null;
            this.TitleTextBox.Location = new System.Drawing.Point(11, 36);
            this.TitleTextBox.Mask = "";
            this.TitleTextBox.MaxLength = 32767;
            this.TitleTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.PasswordChar = '\0';
            this.TitleTextBox.PrefixSuffixText = null;
            this.TitleTextBox.PromptChar = '_';
            this.TitleTextBox.ReadOnly = false;
            this.TitleTextBox.RejectInputOnFirstFailure = false;
            this.TitleTextBox.ResetOnPrompt = true;
            this.TitleTextBox.ResetOnSpace = true;
            this.TitleTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleTextBox.SelectedText = "";
            this.TitleTextBox.SelectionLength = 0;
            this.TitleTextBox.SelectionStart = 0;
            this.TitleTextBox.ShortcutsEnabled = true;
            this.TitleTextBox.Size = new System.Drawing.Size(250, 48);
            this.TitleTextBox.SkipLiterals = true;
            this.TitleTextBox.TabIndex = 1;
            this.TitleTextBox.TabStop = false;
            this.TitleTextBox.Text = "Enter title name";
            this.TitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TitleTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TitleTextBox.TrailingIcon = null;
            this.TitleTextBox.UseSystemPasswordChar = false;
            this.TitleTextBox.ValidatingType = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(14, 87);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(81, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Description";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(14, 14);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(32, 19);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "Title";
            // 
            // TaskBtn
            // 
            this.TaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TaskBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.TaskBtn.Depth = 0;
            this.TaskBtn.HighEmphasis = true;
            this.TaskBtn.Icon = null;
            this.TaskBtn.Location = new System.Drawing.Point(11, 231);
            this.TaskBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TaskBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.TaskBtn.Name = "TaskBtn";
            this.TaskBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.TaskBtn.Size = new System.Drawing.Size(129, 36);
            this.TaskBtn.TabIndex = 3;
            this.TaskBtn.Text = "Create a task";
            this.TaskBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.TaskBtn.UseAccentColor = false;
            this.TaskBtn.UseVisualStyleBackColor = true;
            this.TaskBtn.Click += new System.EventHandler(this.TaskBtn_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel4);
            this.materialCard2.Controls.Add(this.DescriptionTextMultiBox);
            this.materialCard2.Controls.Add(this.TitleTextBox);
            this.materialCard2.Controls.Add(this.materialLabel3);
            this.materialCard2.Controls.Add(this.TaskBtn);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(6, 78);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(879, 274);
            this.materialCard2.TabIndex = 20;
            // 
            // ScheduleDataTable
            // 
            this.ScheduleDataTable.AllowUserToAddRows = false;
            this.ScheduleDataTable.AllowUserToDeleteRows = false;
            this.ScheduleDataTable.AllowUserToResizeColumns = false;
            this.ScheduleDataTable.AllowUserToResizeRows = false;
            this.ScheduleDataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduleDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ScheduleDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleCol,
            this.DescriptionCol,
            this.DateCol,
            this.IsCompleteCol});
            this.ScheduleDataTable.Location = new System.Drawing.Point(6, 387);
            this.ScheduleDataTable.Name = "ScheduleDataTable";
            this.ScheduleDataTable.ReadOnly = true;
            this.ScheduleDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ScheduleDataTable.Size = new System.Drawing.Size(879, 390);
            this.ScheduleDataTable.TabIndex = 21;
            this.ScheduleDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScheduleDataTable_CellContentClick);
            // 
            // TitleCol
            // 
            this.TitleCol.HeaderText = "Title";
            this.TitleCol.Name = "TitleCol";
            this.TitleCol.ReadOnly = true;
            // 
            // DescriptionCol
            // 
            this.DescriptionCol.HeaderText = "Description";
            this.DescriptionCol.Name = "DescriptionCol";
            this.DescriptionCol.ReadOnly = true;
            // 
            // DateCol
            // 
            this.DateCol.HeaderText = "Date";
            this.DateCol.Name = "DateCol";
            this.DateCol.ReadOnly = true;
            // 
            // IsCompleteCol
            // 
            this.IsCompleteCol.HeaderText = "Complete";
            this.IsCompleteCol.Name = "IsCompleteCol";
            this.IsCompleteCol.ReadOnly = true;
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 790);
            this.Controls.Add(this.ScheduleDataTable);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Scheduler";
            this.Text = "Task Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 DescriptionTextMultiBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox TitleTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton TaskBtn;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.DataGridView ScheduleDataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsCompleteCol;
    }
}

