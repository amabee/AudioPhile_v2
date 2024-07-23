namespace AudioPhile_v2.Custom_Components
{
    partial class NoCurrentMedia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoCurrentMedia));
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.audioPhileLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.subLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.SelectFolderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.openFilesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dropDownMoreOptionsSelections = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SelectFolderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 126;
            this.bunifuPictureBox1.Image = global::AudioPhile_v2.Properties.Resources.bright_cartoon_kawaii_image_call_center_specialist_girl_93995_16498_removebg_preview;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(17, 85);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(252, 252);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // audioPhileLabel
            // 
            this.audioPhileLabel.AllowParentOverrides = false;
            this.audioPhileLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.audioPhileLabel.AutoEllipsis = false;
            this.audioPhileLabel.AutoSize = false;
            this.audioPhileLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.audioPhileLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.audioPhileLabel.Font = new System.Drawing.Font("0xProto Nerd Font", 36F, System.Drawing.FontStyle.Bold);
            this.audioPhileLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.audioPhileLabel.Location = new System.Drawing.Point(287, 160);
            this.audioPhileLabel.Name = "audioPhileLabel";
            this.audioPhileLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.audioPhileLabel.Size = new System.Drawing.Size(403, 63);
            this.audioPhileLabel.TabIndex = 1;
            this.audioPhileLabel.Text = "AudioPhile V2";
            this.audioPhileLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.audioPhileLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // subLabel
            // 
            this.subLabel.AllowParentOverrides = false;
            this.subLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subLabel.AutoEllipsis = false;
            this.subLabel.AutoSize = false;
            this.subLabel.CursorType = null;
            this.subLabel.Font = new System.Drawing.Font("0xProto Nerd Font", 9.749999F, System.Drawing.FontStyle.Bold);
            this.subLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.subLabel.Location = new System.Drawing.Point(290, 229);
            this.subLabel.Name = "subLabel";
            this.subLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.subLabel.Size = new System.Drawing.Size(403, 42);
            this.subLabel.TabIndex = 2;
            this.subLabel.Text = "Use this app to play your audio files and explore your personal libraries.";
            this.subLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.subLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // SelectFolderPanel
            // 
            this.SelectFolderPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectFolderPanel.BorderRadius = 10;
            this.SelectFolderPanel.Controls.Add(this.openFilesBtn);
            this.SelectFolderPanel.Controls.Add(this.dropDownMoreOptionsSelections);
            this.SelectFolderPanel.Location = new System.Drawing.Point(290, 277);
            this.SelectFolderPanel.Name = "SelectFolderPanel";
            this.SelectFolderPanel.Size = new System.Drawing.Size(182, 36);
            this.SelectFolderPanel.TabIndex = 3;
            // 
            // openFilesBtn
            // 
            this.openFilesBtn.Animated = true;
            this.openFilesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.openFilesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.openFilesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.openFilesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.openFilesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openFilesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(117)))), ((int)(((byte)(37)))));
            this.openFilesBtn.Font = new System.Drawing.Font("0xProto Nerd Font", 9.749999F);
            this.openFilesBtn.ForeColor = System.Drawing.Color.Black;
            this.openFilesBtn.Image = global::AudioPhile_v2.Properties.Resources.opened_folder_208px;
            this.openFilesBtn.Location = new System.Drawing.Point(0, 0);
            this.openFilesBtn.Name = "openFilesBtn";
            this.openFilesBtn.Size = new System.Drawing.Size(144, 36);
            this.openFilesBtn.TabIndex = 2;
            this.openFilesBtn.Text = "Open file(s)";
            this.openFilesBtn.Click += new System.EventHandler(this.openFilesBtn_Click);
            // 
            // dropDownMoreOptionsSelections
            // 
            this.dropDownMoreOptionsSelections.Animated = true;
            this.dropDownMoreOptionsSelections.BorderColor = System.Drawing.Color.Transparent;
            this.dropDownMoreOptionsSelections.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dropDownMoreOptionsSelections.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dropDownMoreOptionsSelections.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dropDownMoreOptionsSelections.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dropDownMoreOptionsSelections.Dock = System.Windows.Forms.DockStyle.Right;
            this.dropDownMoreOptionsSelections.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(117)))), ((int)(((byte)(37)))));
            this.dropDownMoreOptionsSelections.Font = new System.Drawing.Font("0xProto Nerd Font", 9.749999F);
            this.dropDownMoreOptionsSelections.ForeColor = System.Drawing.Color.Black;
            this.dropDownMoreOptionsSelections.Image = global::AudioPhile_v2.Properties.Resources.down_button_480px;
            this.dropDownMoreOptionsSelections.Location = new System.Drawing.Point(144, 0);
            this.dropDownMoreOptionsSelections.Name = "dropDownMoreOptionsSelections";
            this.dropDownMoreOptionsSelections.Size = new System.Drawing.Size(38, 36);
            this.dropDownMoreOptionsSelections.TabIndex = 3;
            // 
            // NoCurrentMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.SelectFolderPanel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.audioPhileLabel);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Name = "NoCurrentMedia";
            this.Size = new System.Drawing.Size(693, 437);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.SelectFolderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel audioPhileLabel;
        private Bunifu.UI.WinForms.BunifuLabel subLabel;
        private Guna.UI2.WinForms.Guna2Panel SelectFolderPanel;
        private Guna.UI2.WinForms.Guna2Button openFilesBtn;
        private Guna.UI2.WinForms.Guna2Button dropDownMoreOptionsSelections;
    }
}
