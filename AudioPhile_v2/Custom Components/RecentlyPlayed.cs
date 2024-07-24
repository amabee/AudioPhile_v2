using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPhile_v2.Custom_Components
{
    public partial class RecentlyPlayed : UserControl
    {
        public RecentlyPlayed(string title, string artist, Image albumArt)
        {
            InitializeComponent();

            lblRecentlyPlayedSongArtist.Text = artist;
            lblRecentlyPlayedSongTitle.Text = title;
            pcbRecentlyPlayed.Image = albumArt;
        }

        private void recentlyPlayedPanel_MouseHover(object sender, EventArgs e)
        {
            recentlyPlayedPanel.FillColor = Color.FromArgb(41, 41, 41);
            btnPlayRecentMusic.Visible = true;
        }

        private void recentlyPlayedPanel_MouseLeave(object sender, EventArgs e)
        {
            recentlyPlayedPanel.FillColor = Color.Transparent;
            btnPlayRecentMusic.Visible = false;
        }

        private void pcbRecentlyPlayed_MouseHover(object sender, EventArgs e)
        {
            recentlyPlayedPanel.FillColor = Color.FromArgb(41, 41, 41);
            btnPlayRecentMusic.Visible = true;
        }

        private void pcbRecentlyPlayed_MouseLeave(object sender, EventArgs e)
        {
            recentlyPlayedPanel.FillColor = Color.Transparent;
           
        }

        private void btnPlayRecentMusic_MouseHover(object sender, EventArgs e)
        {
            btnPlayRecentMusic.Visible = true;
        }

        

      
    }
}
