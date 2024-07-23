namespace AudioPhile_v2.Custom_Components
{
    partial class LoadingDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingDialog));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.audioPhileLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.subLabel = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 125;
            this.bunifuPictureBox1.Image = global::AudioPhile_v2.Properties.Resources.Loading_Screen_Anime;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(12, 42);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(250, 250);
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
            this.audioPhileLabel.Font = new System.Drawing.Font("0xProto Nerd Font", 26.25F, System.Drawing.FontStyle.Bold);
            this.audioPhileLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.audioPhileLabel.Location = new System.Drawing.Point(268, 110);
            this.audioPhileLabel.Name = "audioPhileLabel";
            this.audioPhileLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.audioPhileLabel.Size = new System.Drawing.Size(299, 91);
            this.audioPhileLabel.TabIndex = 2;
            this.audioPhileLabel.Text = "Loading Directories";
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
            this.subLabel.Font = new System.Drawing.Font("0xProto Nerd Font", 12F, System.Drawing.FontStyle.Bold);
            this.subLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.subLabel.Location = new System.Drawing.Point(283, 202);
            this.subLabel.Name = "subLabel";
            this.subLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.subLabel.Size = new System.Drawing.Size(272, 30);
            this.subLabel.TabIndex = 3;
            this.subLabel.Text = "This might take a while.";
            this.subLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.subLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LoadingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(571, 328);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.audioPhileLabel);
            this.Controls.Add(this.bunifuPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingDialog";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel audioPhileLabel;
        private Bunifu.UI.WinForms.BunifuLabel subLabel;
    }
}