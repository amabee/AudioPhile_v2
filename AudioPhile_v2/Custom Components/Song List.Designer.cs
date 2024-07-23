namespace AudioPhile_v2.Custom_Components
{
    partial class Song_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Song_List));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSongAlbum = new Bunifu.UI.WinForms.BunifuLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSongArtist = new Bunifu.UI.WinForms.BunifuLabel();
            this.albumImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMusicSongTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumImage)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.albumImage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(999, 92);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.lblSongAlbum);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(723, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(273, 86);
            this.guna2Panel3.TabIndex = 3;
            // 
            // lblSongAlbum
            // 
            this.lblSongAlbum.AllowParentOverrides = false;
            this.lblSongAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSongAlbum.AutoEllipsis = false;
            this.lblSongAlbum.AutoSize = false;
            this.lblSongAlbum.CursorType = null;
            this.lblSongAlbum.Font = new System.Drawing.Font("0xProto Nerd Font", 14.25F);
            this.lblSongAlbum.ForeColor = System.Drawing.Color.White;
            this.lblSongAlbum.Location = new System.Drawing.Point(3, 3);
            this.lblSongAlbum.Name = "lblSongAlbum";
            this.lblSongAlbum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSongAlbum.Size = new System.Drawing.Size(267, 80);
            this.lblSongAlbum.TabIndex = 2;
            this.lblSongAlbum.Text = "Song Album";
            this.lblSongAlbum.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSongAlbum.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.lblSongArtist);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(446, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(271, 86);
            this.guna2Panel2.TabIndex = 2;
            // 
            // lblSongArtist
            // 
            this.lblSongArtist.AllowParentOverrides = false;
            this.lblSongArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSongArtist.AutoEllipsis = false;
            this.lblSongArtist.AutoSize = false;
            this.lblSongArtist.CursorType = null;
            this.lblSongArtist.Font = new System.Drawing.Font("0xProto Nerd Font", 14.25F);
            this.lblSongArtist.ForeColor = System.Drawing.Color.White;
            this.lblSongArtist.Location = new System.Drawing.Point(3, 3);
            this.lblSongArtist.Name = "lblSongArtist";
            this.lblSongArtist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSongArtist.Size = new System.Drawing.Size(265, 80);
            this.lblSongArtist.TabIndex = 2;
            this.lblSongArtist.Text = "Song Artist";
            this.lblSongArtist.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSongArtist.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // albumImage
            // 
            this.albumImage.AllowFocused = false;
            this.albumImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.albumImage.AutoSizeHeight = true;
            this.albumImage.BorderRadius = 43;
            this.albumImage.Image = global::AudioPhile_v2.Properties.Resources.bright_cartoon_kawaii_image_call_center_specialist_girl_93995_16498;
            this.albumImage.IsCircle = true;
            this.albumImage.Location = new System.Drawing.Point(40, 3);
            this.albumImage.Name = "albumImage";
            this.albumImage.Size = new System.Drawing.Size(86, 86);
            this.albumImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.albumImage.TabIndex = 0;
            this.albumImage.TabStop = false;
            this.albumImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblMusicSongTitle);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(169, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(271, 86);
            this.guna2Panel1.TabIndex = 1;
            // 
            // lblMusicSongTitle
            // 
            this.lblMusicSongTitle.AllowParentOverrides = false;
            this.lblMusicSongTitle.AutoEllipsis = true;
            this.lblMusicSongTitle.AutoSize = false;
            this.lblMusicSongTitle.CursorType = null;
            this.lblMusicSongTitle.Font = new System.Drawing.Font("0xProto Nerd Font", 14.25F);
            this.lblMusicSongTitle.ForeColor = System.Drawing.Color.White;
            this.lblMusicSongTitle.Location = new System.Drawing.Point(3, 3);
            this.lblMusicSongTitle.Name = "lblMusicSongTitle";
            this.lblMusicSongTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMusicSongTitle.Size = new System.Drawing.Size(265, 80);
            this.lblMusicSongTitle.TabIndex = 2;
            this.lblMusicSongTitle.Text = "Song Title";
            this.lblMusicSongTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMusicSongTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblMusicSongTitle.Click += new System.EventHandler(this.lblMusicSongTitle_Click);
            // 
            // Song_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Song_List";
            this.Size = new System.Drawing.Size(999, 92);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.albumImage)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox albumImage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Bunifu.UI.WinForms.BunifuLabel lblSongAlbum;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Bunifu.UI.WinForms.BunifuLabel lblSongArtist;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Bunifu.UI.WinForms.BunifuLabel lblMusicSongTitle;
    }
}
