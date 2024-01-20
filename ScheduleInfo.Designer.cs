namespace ComprogDbNetFramework
{
    partial class ScheduleInfo
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.UpdateBtn = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ScheduleDescriptionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ScheduleDescriptionTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.DeleteBtn = new MaterialSkin.Controls.MaterialButton();
            this.ScheduleTitleTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.ScheduleTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.GoBackBtn = new MaterialSkin.Controls.MaterialButton();
            this.ScheduleDescriptionTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdateBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.AutoScroll = true;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.isCompletedCheckBox);
            this.materialCard1.Controls.Add(this.UpdateBtn);
            this.materialCard1.Controls.Add(this.panel1);
            this.materialCard1.Controls.Add(this.ScheduleDescriptionTextBox);
            this.materialCard1.Controls.Add(this.DeleteBtn);
            this.materialCard1.Controls.Add(this.ScheduleTitleTextBox);
            this.materialCard1.Controls.Add(this.ScheduleTitleLabel);
            this.materialCard1.Controls.Add(this.GoBackBtn);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 64);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1013, 583);
            this.materialCard1.TabIndex = 0;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.UpdateBtn.Depth = 0;
            this.UpdateBtn.HighEmphasis = true;
            this.UpdateBtn.Icon = null;
            this.UpdateBtn.Location = new System.Drawing.Point(919, 527);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UpdateBtn.Size = new System.Drawing.Size(77, 36);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateBtn.UseAccentColor = false;
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ScheduleDescriptionLabel);
            this.panel1.Location = new System.Drawing.Point(14, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 126);
            this.panel1.TabIndex = 8;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteBtn.Depth = 0;
            this.DeleteBtn.HighEmphasis = true;
            this.DeleteBtn.Icon = null;
            this.DeleteBtn.Location = new System.Drawing.Point(109, 527);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteBtn.Size = new System.Drawing.Size(73, 36);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteBtn.UseAccentColor = false;
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ScheduleTitleTextBox
            // 
            this.ScheduleTitleTextBox.AllowPromptAsInput = true;
            this.ScheduleTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ScheduleTitleTextBox.AnimateReadOnly = false;
            this.ScheduleTitleTextBox.AsciiOnly = false;
            this.ScheduleTitleTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ScheduleTitleTextBox.BeepOnError = false;
            this.ScheduleTitleTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.ScheduleTitleTextBox.Depth = 0;
            this.ScheduleTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ScheduleTitleTextBox.HidePromptOnLeave = false;
            this.ScheduleTitleTextBox.HideSelection = true;
            this.ScheduleTitleTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.ScheduleTitleTextBox.LeadingIcon = null;
            this.ScheduleTitleTextBox.Location = new System.Drawing.Point(14, 100);
            this.ScheduleTitleTextBox.Mask = "";
            this.ScheduleTitleTextBox.MaxLength = 32767;
            this.ScheduleTitleTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ScheduleTitleTextBox.Name = "ScheduleTitleTextBox";
            this.ScheduleTitleTextBox.PasswordChar = '\0';
            this.ScheduleTitleTextBox.PrefixSuffixText = null;
            this.ScheduleTitleTextBox.PromptChar = '_';
            this.ScheduleTitleTextBox.ReadOnly = false;
            this.ScheduleTitleTextBox.RejectInputOnFirstFailure = false;
            this.ScheduleTitleTextBox.ResetOnPrompt = true;
            this.ScheduleTitleTextBox.ResetOnSpace = true;
            this.ScheduleTitleTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScheduleTitleTextBox.SelectedText = "";
            this.ScheduleTitleTextBox.SelectionLength = 0;
            this.ScheduleTitleTextBox.SelectionStart = 0;
            this.ScheduleTitleTextBox.ShortcutsEnabled = true;
            this.ScheduleTitleTextBox.Size = new System.Drawing.Size(372, 48);
            this.ScheduleTitleTextBox.SkipLiterals = true;
            this.ScheduleTitleTextBox.TabIndex = 1;
            this.ScheduleTitleTextBox.TabStop = false;
            this.ScheduleTitleTextBox.Text = "Edit Schedule Title";
            this.ScheduleTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ScheduleTitleTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ScheduleTitleTextBox.TrailingIcon = null;
            this.ScheduleTitleTextBox.UseSystemPasswordChar = false;
            this.ScheduleTitleTextBox.ValidatingType = null;
            this.ScheduleTitleTextBox.Click += new System.EventHandler(this.ScheduleTitleTextBox_Click);
            // 
            // ScheduleTitleLabel
            // 
            this.ScheduleTitleLabel.AutoSize = true;
            this.ScheduleTitleLabel.Depth = 0;
            this.ScheduleTitleLabel.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ScheduleTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.ScheduleTitleLabel.Location = new System.Drawing.Point(17, 14);
            this.ScheduleTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ScheduleTitleLabel.Name = "ScheduleTitleLabel";
            this.ScheduleTitleLabel.Size = new System.Drawing.Size(369, 72);
            this.ScheduleTitleLabel.TabIndex = 3;
            this.ScheduleTitleLabel.Text = "Schedule Title";
            this.ScheduleTitleLabel.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // GoBackBtn
            // 
            this.GoBackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBackBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GoBackBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.GoBackBtn.Depth = 0;
            this.GoBackBtn.HighEmphasis = true;
            this.GoBackBtn.Icon = null;
            this.GoBackBtn.Location = new System.Drawing.Point(18, 527);
            this.GoBackBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GoBackBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.GoBackBtn.Size = new System.Drawing.Size(83, 36);
            this.GoBackBtn.TabIndex = 2;
            this.GoBackBtn.Text = "Go Back";
            this.GoBackBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.GoBackBtn.UseAccentColor = false;
            this.GoBackBtn.UseVisualStyleBackColor = true;
            this.GoBackBtn.Click += new System.EventHandler(this.GoBackBtn_Click);
            // 
            // ScheduleDescriptionTextBox
            // 
            this.ScheduleDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduleDescriptionTextBox.AnimateReadOnly = false;
            this.ScheduleDescriptionTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ScheduleDescriptionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ScheduleDescriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ScheduleDescriptionTextBox.Depth = 0;
            this.ScheduleDescriptionTextBox.HideSelection = true;
            this.ScheduleDescriptionTextBox.Location = new System.Drawing.Point(14, 325);
            this.ScheduleDescriptionTextBox.MaxLength = 32767;
            this.ScheduleDescriptionTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ScheduleDescriptionTextBox.Name = "ScheduleDescriptionTextBox";
            this.ScheduleDescriptionTextBox.PasswordChar = '\0';
            this.ScheduleDescriptionTextBox.ReadOnly = false;
            this.ScheduleDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ScheduleDescriptionTextBox.SelectedText = "";
            this.ScheduleDescriptionTextBox.SelectionLength = 0;
            this.ScheduleDescriptionTextBox.SelectionStart = 0;
            this.ScheduleDescriptionTextBox.ShortcutsEnabled = true;
            this.ScheduleDescriptionTextBox.Size = new System.Drawing.Size(982, 100);
            this.ScheduleDescriptionTextBox.TabIndex = 7;
            this.ScheduleDescriptionTextBox.TabStop = false;
            this.ScheduleDescriptionTextBox.Text = "Edit the description";
            this.ScheduleDescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ScheduleDescriptionTextBox.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ScheduleDescriptionLabel);
            this.panel1.Location = new System.Drawing.Point(14, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 126);
            this.panel1.TabIndex = 8;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.UpdateBtn.Depth = 0;
            this.UpdateBtn.HighEmphasis = true;
            this.UpdateBtn.Icon = null;
            this.UpdateBtn.Location = new System.Drawing.Point(919, 527);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UpdateBtn.Size = new System.Drawing.Size(77, 36);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateBtn.UseAccentColor = false;
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ScheduleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 650);
            this.Controls.Add(this.materialCard1);
            this.Name = "ScheduleInfo";
            this.Text = "Schedule information";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton GoBackBtn;
        private MaterialSkin.Controls.MaterialButton DeleteBtn;
        private MaterialSkin.Controls.MaterialMaskedTextBox ScheduleTitleTextBox;
        private MaterialSkin.Controls.MaterialLabel ScheduleDescriptionLabel;
        private MaterialSkin.Controls.MaterialLabel ScheduleTitleLabel;
        private MaterialSkin.Controls.MaterialButton UpdateBtn;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 ScheduleDescriptionTextBox;
        private MaterialSkin.Controls.MaterialCheckbox isCompletedCheckBox;
    }
}