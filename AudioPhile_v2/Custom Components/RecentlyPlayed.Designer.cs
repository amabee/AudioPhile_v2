namespace AudioPhile_v2.Custom_Components
{
    partial class RecentlyPlayed
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
            this.recentlyPlayedPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.pcbRecentlyPlayed = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblRecentlyPlayedSongTitle = new System.Windows.Forms.Label();
            this.lblRecentlyPlayedSongArtist = new System.Windows.Forms.Label();
            this.btnPlayRecentMusic = new Guna.UI2.WinForms.Guna2CircleButton();
            this.recentlyPlayedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRecentlyPlayed)).BeginInit();
            this.SuspendLayout();
            // 
            // recentlyPlayedPanel
            // 
            this.recentlyPlayedPanel.BackColor = System.Drawing.Color.Transparent;
            this.recentlyPlayedPanel.Controls.Add(this.btnPlayRecentMusic);
            this.recentlyPlayedPanel.Controls.Add(this.lblRecentlyPlayedSongArtist);
            this.recentlyPlayedPanel.Controls.Add(this.lblRecentlyPlayedSongTitle);
            this.recentlyPlayedPanel.Controls.Add(this.pcbRecentlyPlayed);
            this.recentlyPlayedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentlyPlayedPanel.Location = new System.Drawing.Point(0, 0);
            this.recentlyPlayedPanel.Name = "recentlyPlayedPanel";
            this.recentlyPlayedPanel.Size = new System.Drawing.Size(213, 271);
            this.recentlyPlayedPanel.TabIndex = 0;
            this.recentlyPlayedPanel.MouseLeave += new System.EventHandler(this.recentlyPlayedPanel_MouseLeave);
            this.recentlyPlayedPanel.MouseHover += new System.EventHandler(this.recentlyPlayedPanel_MouseHover);
            // 
            // pcbRecentlyPlayed
            // 
            this.pcbRecentlyPlayed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbRecentlyPlayed.BorderRadius = 10;
            this.pcbRecentlyPlayed.Image = global::AudioPhile_v2.Properties.Resources.headphones_400px;
            this.pcbRecentlyPlayed.ImageRotate = 0F;
            this.pcbRecentlyPlayed.Location = new System.Drawing.Point(26, 30);
            this.pcbRecentlyPlayed.Name = "pcbRecentlyPlayed";
            this.pcbRecentlyPlayed.Size = new System.Drawing.Size(156, 140);
            this.pcbRecentlyPlayed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbRecentlyPlayed.TabIndex = 0;
            this.pcbRecentlyPlayed.TabStop = false;
            this.pcbRecentlyPlayed.UseTransparentBackground = true;
            this.pcbRecentlyPlayed.MouseLeave += new System.EventHandler(this.pcbRecentlyPlayed_MouseLeave);
            this.pcbRecentlyPlayed.MouseHover += new System.EventHandler(this.pcbRecentlyPlayed_MouseHover);
            // 
            // lblRecentlyPlayedSongTitle
            // 
            this.lblRecentlyPlayedSongTitle.Font = new System.Drawing.Font("0xProto Nerd Font", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentlyPlayedSongTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRecentlyPlayedSongTitle.Location = new System.Drawing.Point(26, 182);
            this.lblRecentlyPlayedSongTitle.Name = "lblRecentlyPlayedSongTitle";
            this.lblRecentlyPlayedSongTitle.Size = new System.Drawing.Size(156, 23);
            this.lblRecentlyPlayedSongTitle.TabIndex = 1;
            this.lblRecentlyPlayedSongTitle.Text = "Song Title";
            this.lblRecentlyPlayedSongTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRecentlyPlayedSongTitle.MouseLeave += new System.EventHandler(this.pcbRecentlyPlayed_MouseLeave);
            this.lblRecentlyPlayedSongTitle.MouseHover += new System.EventHandler(this.pcbRecentlyPlayed_MouseHover);
            // 
            // lblRecentlyPlayedSongArtist
            // 
            this.lblRecentlyPlayedSongArtist.Font = new System.Drawing.Font("0xProto Nerd Font", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentlyPlayedSongArtist.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRecentlyPlayedSongArtist.Location = new System.Drawing.Point(26, 205);
            this.lblRecentlyPlayedSongArtist.Name = "lblRecentlyPlayedSongArtist";
            this.lblRecentlyPlayedSongArtist.Size = new System.Drawing.Size(156, 23);
            this.lblRecentlyPlayedSongArtist.TabIndex = 2;
            this.lblRecentlyPlayedSongArtist.Text = "Song Artist";
            this.lblRecentlyPlayedSongArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRecentlyPlayedSongArtist.MouseLeave += new System.EventHandler(this.pcbRecentlyPlayed_MouseLeave);
            this.lblRecentlyPlayedSongArtist.MouseHover += new System.EventHandler(this.pcbRecentlyPlayed_MouseHover);
            // 
            // btnPlayRecentMusic
            // 
            this.btnPlayRecentMusic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlayRecentMusic.Animated = true;
            this.btnPlayRecentMusic.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayRecentMusic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlayRecentMusic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlayRecentMusic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlayRecentMusic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlayRecentMusic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnPlayRecentMusic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlayRecentMusic.ForeColor = System.Drawing.Color.White;
            this.btnPlayRecentMusic.Image = global::AudioPhile_v2.Properties.Resources.play_384px;
            this.btnPlayRecentMusic.Location = new System.Drawing.Point(34, 136);
            this.btnPlayRecentMusic.Name = "btnPlayRecentMusic";
            this.btnPlayRecentMusic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPlayRecentMusic.Size = new System.Drawing.Size(30, 30);
            this.btnPlayRecentMusic.TabIndex = 3;
            this.btnPlayRecentMusic.Visible = false;
            this.btnPlayRecentMusic.MouseHover += new System.EventHandler(this.btnPlayRecentMusic_MouseHover);
            // 
            // RecentlyPlayed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.recentlyPlayedPanel);
            this.Name = "RecentlyPlayed";
            this.Size = new System.Drawing.Size(213, 271);
            this.recentlyPlayedPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbRecentlyPlayed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel recentlyPlayedPanel;
        private Guna.UI2.WinForms.Guna2CircleButton btnPlayRecentMusic;
        private System.Windows.Forms.Label lblRecentlyPlayedSongArtist;
        private System.Windows.Forms.Label lblRecentlyPlayedSongTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pcbRecentlyPlayed;
    }
}
