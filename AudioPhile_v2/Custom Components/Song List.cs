using AudioPhile.Singleton;
using AudioPhile_v2.Props;
using AudioPhile_v2.Views;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib.Flac;

namespace AudioPhile_v2.Custom_Components
{
    public partial class Song_List : UserControl
    {
        private MusicMetaData _metaData;
        private string _audioFilePath;
        private IWavePlayer _wavePlayer;
        private AudioFileReader _audioFileReader;
        public Song_List()
        {
            InitializeComponent();
        }

        public void SetMetaData(MusicMetaData metaData)
        {
            _metaData = metaData;
            UpdateUI();
        }

     

        private void UpdateUI()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateUI));
                return;
            }

            albumImage.Image = _metaData.AlbumArt;
            lblMusicSongTitle.Text = _metaData.SongTitle;
            lblSongArtist.Text = _metaData.SongArtist;
            _audioFilePath = _metaData.AudioFilePath;
            lblSongAlbum.Text = _metaData.SongAlbum ?? "Unknown Album";
        }

        private void lblMusicSongTitle_Click(object sender, EventArgs e)
        {
            PlayAudio();

            MainView.SetButtons(true);

        }

        private void PlayAudio()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_audioFilePath))
                {
                    MessageBox.Show($"Invalid music name or file path: {_audioFilePath}");
                    return;
                }
                
                int index = PlaybackManager.MusicList.FindIndex(m => m.AudioFilePath == _audioFilePath);

                if (index != -1)
                {
                    PlaybackManager.Play(index);
                }
                else
                {
                    MessageBox.Show("The selected audio file is not in the current playlist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while playing the audio: {ex.Message}");
                Console.WriteLine($"An error occurred while playing the audio: {ex.Message}");
            }
        }

        private void lblMusicSongTitle_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void lblMusicSongTitle_MouseLeave(object sender, EventArgs e)
        {
            Cursor= Cursors.Default;
        }
    }
}