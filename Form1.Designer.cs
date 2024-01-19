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
            this.ScheduleToggleBtn = new MaterialSkin.Controls.MaterialButton();
            this.ScheduleTitle = new MaterialSkin.Controls.MaterialLabel();
            this.ScheduleDeleteBtn = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ScheduleDescription = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DescriptionTextMultiBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.TitleTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.TaskBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScheduleToggleBtn
            // 
            this.ScheduleToggleBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ScheduleToggleBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ScheduleToggleBtn.Depth = 0;
            this.ScheduleToggleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScheduleToggleBtn.HighEmphasis = true;
            this.ScheduleToggleBtn.Icon = null;
            this.ScheduleToggleBtn.Location = new System.Drawing.Point(16, 18);
            this.ScheduleToggleBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ScheduleToggleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ScheduleToggleBtn.Name = "ScheduleToggleBtn";
            this.ScheduleToggleBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ScheduleToggleBtn.Size = new System.Drawing.Size(73, 36);
            this.ScheduleToggleBtn.TabIndex = 1;
            this.ScheduleToggleBtn.Text = "Done";
            this.ScheduleToggleBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ScheduleToggleBtn.UseAccentColor = false;
            this.ScheduleToggleBtn.UseVisualStyleBackColor = true;
            // 
            // ScheduleTitle
            // 
            this.ScheduleTitle.AutoSize = true;
            this.ScheduleTitle.Depth = 0;
            this.ScheduleTitle.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ScheduleTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.ScheduleTitle.Location = new System.Drawing.Point(15, 12);
            this.ScheduleTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.ScheduleTitle.Name = "ScheduleTitle";
            this.ScheduleTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScheduleTitle.Size = new System.Drawing.Size(95, 58);
            this.ScheduleTitle.TabIndex = 2;
            this.ScheduleTitle.Text = "Title";
            // 
            // ScheduleDeleteBtn
            // 
            this.ScheduleDeleteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ScheduleDeleteBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ScheduleDeleteBtn.Depth = 0;
            this.ScheduleDeleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScheduleDeleteBtn.HighEmphasis = true;
            this.ScheduleDeleteBtn.Icon = null;
            this.ScheduleDeleteBtn.Location = new System.Drawing.Point(16, 66);
            this.ScheduleDeleteBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ScheduleDeleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ScheduleDeleteBtn.Name = "ScheduleDeleteBtn";
            this.ScheduleDeleteBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ScheduleDeleteBtn.Size = new System.Drawing.Size(73, 36);
            this.ScheduleDeleteBtn.TabIndex = 3;
            this.ScheduleDeleteBtn.Text = "Delete";
            this.ScheduleDeleteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ScheduleDeleteBtn.UseAccentColor = false;
            this.ScheduleDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.ScheduleToggleBtn);
            this.flowLayoutPanel1.Controls.Add(this.ScheduleDeleteBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(818, 14);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(105, 140);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // ScheduleDescription
            // 
            this.ScheduleDescription.AutoSize = true;
            this.ScheduleDescription.Depth = 0;
            this.ScheduleDescription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ScheduleDescription.Location = new System.Drawing.Point(15, 70);
            this.ScheduleDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.ScheduleDescription.Name = "ScheduleDescription";
            this.ScheduleDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScheduleDescription.Size = new System.Drawing.Size(81, 19);
            this.ScheduleDescription.TabIndex = 5;
            this.ScheduleDescription.Text = "Description";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.ScheduleTitle);
            this.flowLayoutPanel2.Controls.Add(this.ScheduleDescription);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(14, 14);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(12);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(125, 140);
            this.flowLayoutPanel2.TabIndex = 6;
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
            this.DescriptionTextMultiBox.Size = new System.Drawing.Size(906, 113);
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
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.flowLayoutPanel1);
            this.materialCard1.Controls.Add(this.flowLayoutPanel2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(6, 380);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(937, 168);
            this.materialCard1.TabIndex = 19;
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
            this.materialCard2.Size = new System.Drawing.Size(934, 274);
            this.materialCard2.TabIndex = 20;
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 790);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Scheduler";
            this.Text = "Task Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton ScheduleToggleBtn;
        private MaterialSkin.Controls.MaterialLabel ScheduleTitle;
        private MaterialSkin.Controls.MaterialButton ScheduleDeleteBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel ScheduleDescription;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 DescriptionTextMultiBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox TitleTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton TaskBtn;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
    }
}

