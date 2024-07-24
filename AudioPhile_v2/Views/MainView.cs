using AudioPhile.Singleton;
using AudioPhile_v2.Custom_Components;
using AudioPhile_v2.Props;
using AudioPhile_v2.Reusable_Controls;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace AudioPhile_v2.Views
{
    public partial class MainView : Form
    {
        private LoadingDialog loadingDialog;
        public static event Action<bool> PlayStateChanged;
        private static bool currentPlayerState;

        private bool isVolumePanelShowing;

        private FlowLayoutPanel recentlyPlayedPanel;


        public MainView()
        {
            InitializeComponent();
            DefaultsOnStartUp();

            Task.Run(async () =>
            {
                await LoadAllMusicAsync();

            });

            PlayStateChanged += PlayStateChanger;

           
        }
        public static void SetButtons(bool isPlaying)
        {
            PlayStateChanged?.Invoke(isPlaying);

        }

        private void PlayStateChanger(bool isPlaying)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<bool>(PlayStateChanger), isPlaying);
                return;
            }


            btnPlayPause.Image = isPlaying
                ? Properties.Resources.pause_192px
                : Properties.Resources.play_384px;

            if (isPlaying)
            {
                currentPlayerState = isPlaying;
                btnPlayPause.Enabled = true;
            }
            else
            {
                currentPlayerState = isPlaying;
               
            }

            NowPlaying();
        }

     

        private void DefaultsOnStartUp()
        {
            btnHome.FillColor = Color.FromArgb(49, 49, 49);
            btnPanel1Colored.FillColor = Color.FromArgb(237, 117, 37);

            btnPanel2.FillColor = Color.Transparent;
            btnPanel2Colored.FillColor = Color.Transparent;

            coloredPanel1.FillColor = Color.FromArgb(237, 117, 37);


            isVolumePanelShowing = false;
            btnPlayPause.Enabled = false;

            PlaybackManager.changeVolume(musicVolumeTrackBar.Value);

            LoadRecentlyPlayedSongs();
        }

        private void LoadRecentlyPlayedSongs()
        {
            List<RecentlyPlayedSongs> allRecent = RecentlyPlayedSongs.GetAllRecentlyPlayedSongs();
            MusicMetaData metadata = new MusicMetaData(); // Create an instance

            if (allRecent.Count > 0)
            {
                homeMusicPanelMain.Controls.Clear();

                recentlyPlayedPanel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true,
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = true
                };

                foreach (var recentSong in allRecent)
                {
                    var songMetadata = metadata.GetMusicMetaData(recentSong.RecentlyPlayedAudioFilePath);

                    if (songMetadata == null)
                    {
                        Console.WriteLine($"Metadata for {recentSong.RecentlyPlayedAudioFilePath} is null.");
                        continue;
                    }

                    Console.WriteLine($"Adding: {songMetadata.SongTitle} by {songMetadata.SongArtist}");

                    Console.WriteLine($"{recentSong.RecentlyPlayedAudioFilePath}");

                    RecentlyPlayed recentlyPlayed = new RecentlyPlayed(
                        songMetadata.SongTitle,
                        songMetadata.SongArtist,
                        songMetadata.AlbumArt
                    );

                    recentlyPlayedPanel.Controls.Add(recentlyPlayed);
                }

                homeMusicPanelMain.Controls.Add(recentlyPlayedPanel);

                if (SelectFolderPanel != null)
                {
                    SelectFolderPanel.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("No recently played songs.");
                NoCurrentMedia noCurrentMedia = new NoCurrentMedia
                {
                    Dock = DockStyle.Fill
                };
                homeMusicPanelMain.Controls.Clear();
                homeMusicPanelMain.Controls.Add(noCurrentMedia);

                if (SelectFolderPanel != null)
                {
                    SelectFolderPanel.Visible = false;
                }
            }
        }



        private void nowPlayingMusicPanel_MouseHover(object sender, EventArgs e)
        {
            nowPlayingMusicPanel.FillColor = Color.FromArgb(52, 52, 52);

        }

        private void nowPlayingMusicPanel_MouseLeave(object sender, EventArgs e)
        {
            nowPlayingMusicPanel.FillColor = Color.FromArgb(39, 39, 39);
        }

        private  void openFilesBtn_Click(object sender, EventArgs e)
        {
            AddSongDirectory.AddSongDirectoryFunction();

            Task.Run(async () =>
            {
                MessageBox.Show("Is Running...");

                await LoadAllMusicAsync();

            });
        }

        private void dropDownMoreOptionsSelections_Click(object sender, EventArgs e)
        {
            ClearAllRecentPlayed();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ViewsTabControl.SelectedIndex = 0;

            btnHome.FillColor = Color.FromArgb(49, 49, 49);
            btnPanel1Colored.FillColor = Color.FromArgb(237, 117, 37);

            btnPanel2.FillColor = Color.Transparent;
            btnPanel2Colored.FillColor = Color.Transparent;

            LoadRecentlyPlayedSongs();
        }

        private void btnMusicLib_Click(object sender, EventArgs e)
        {
            try
            {
                ViewsTabControl.SelectedIndex = 1;

                btnHome.FillColor = Color.Transparent;
                btnPanel1Colored.FillColor = Color.Transparent;

                btnPanel2.FillColor = Color.FromArgb(49, 49, 49);
                btnPanel2Colored.FillColor = Color.FromArgb(237, 117, 37);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void lblSongs_Click(object sender, EventArgs e)
        {
            coloredPanel1.FillColor = Color.FromArgb(237, 117, 37);
            coloredPanel2.FillColor = Color.Transparent;
            coloredPanel3.FillColor = Color.Transparent;

            musicPageTabControl.SelectedIndex = 0;
        }

        private void lblAlbums_Click(object sender, EventArgs e)
        {

            coloredPanel1.FillColor = Color.Transparent;
            coloredPanel2.FillColor = Color.FromArgb(237, 117, 37);
            coloredPanel3.FillColor = Color.Transparent;

            musicPageTabControl.SelectedIndex = 1;
        }

        private void lblArtists_Click(object sender, EventArgs e)
        {
            coloredPanel1.FillColor = Color.Transparent;
            coloredPanel2.FillColor = Color.Transparent;
            coloredPanel3.FillColor = Color.FromArgb(237, 117, 37);

            musicPageTabControl.SelectedIndex = 2;
        }

        private void musicTabPageAddFolder_Click(object sender, EventArgs e)
        {
            AddSongDirectory.AddSongDirectoryFunction();

            Task.Run(async () =>
            {
                MessageBox.Show("Is Running...");

                await LoadAllMusicAsync();

            });
        }

        public  async Task LoadAllMusicAsync()
        {
            try
            {
                string directories = Properties.Settings.Default.SongDirectories;
                if (string.IsNullOrWhiteSpace(directories))
                {
                    MessageBox.Show("No directories configured.");
                    return;
                }

                string[] directoryList = directories.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                await UpdateLoadingStatus(true);

                List<MusicMetaData> musicData = await Task.Run(() =>
                {
                    List<MusicMetaData> data = new List<MusicMetaData>();
                    foreach (string directory in directoryList)
                    {
                        string trimmedDirectory = directory.Trim();
                        if (Directory.Exists(trimmedDirectory))
                        {
                            string[] files = Directory.GetFiles(trimmedDirectory, "*.*", SearchOption.AllDirectories)
                                .Where(file => file.EndsWith(".mp3", StringComparison.OrdinalIgnoreCase)
                                             || file.EndsWith(".wav", StringComparison.OrdinalIgnoreCase)
                                             || file.EndsWith(".aac", StringComparison.OrdinalIgnoreCase))
                                .ToArray();

                            foreach (string file in files)
                            {
                                MusicMetaData metadata = new MusicMetaData();
                                data.Add(metadata.GetMusicMetaData(file));
                                PlaybackManager.MusicList.Add(metadata.GetMusicMetaData(file));
                                Console.WriteLine(file);
                            }
                        }
                    }
                    return data;
                });
                await UpdateUIWithMusicDataAsync(musicData);
                await UpdateLoadingStatus(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async Task UpdateUIWithMusicDataAsync(List<MusicMetaData> musicData)
        {
            await Task.Run(() =>
            {
                this.Invoke((Action)(() =>
                {
                    musicListPanel.Controls.Clear();
                    foreach (var item in musicData)
                    {
                        Song_List musicListTile = new Song_List();
                        musicListTile.Dock = DockStyle.Top;
                        musicListPanel.Controls.Add(musicListTile);
                        musicListTile.SetMetaData(item);
                    }
                    musicListPanel.PerformLayout();
                    musicListPanel.Invalidate();
                    musicListPanel.Update();
                }));
            });
        }

        private async Task UpdateLoadingStatus(bool isLoading)
        {
            await Task.Run(() =>
            {
                this.Invoke((Action)(() =>
                {
                    if (isLoading)
                    {
                        loadingDialog = new LoadingDialog();
                        loadingDialog.StartPosition = FormStartPosition.CenterParent;
                        this.Enabled = false;
                        loadingDialog.Show(this);
                    }
                    else
                    {
                        if (loadingDialog != null)
                        {
                            loadingDialog.Close();
                            loadingDialog.Dispose();
                            loadingDialog = null;
                        }
                        this.Enabled = true;
                        this.Activate();
                        this.BringToFront();
                    }
                }));
            });
        }

        private void btnClearFolders_Click(object sender, EventArgs e)
        {
            ResetDirectories();
            musicListPanel.Controls.Clear();
        }

        private void ResetDirectories()
        {

            Properties.Settings.Default.SongDirectories = string.Empty;
            Properties.Settings.Default.Save();

            PlaybackManager.MusicList.Clear();

            MessageBox.Show("All directories have been cleared.");
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (currentPlayerState == true)
            {
                PlaybackManager.Pause();
                PlayStateChanger(false);
            }
            else
            {
                PlaybackManager.Resume();
                PlayStateChanger(true);
            }
        }

        private void songTimer_Tick(object sender, EventArgs e)
        {
            var currentTimeStampPosition = PlaybackManager.CurrentPosition;
            var songDuration = PlaybackManager.Duration;

            lblElapsedTime.Text = FormatTime(currentTimeStampPosition);
            lblDuration.Text = FormatTime(songDuration);


            int maxTimeInSeconds = (int)songDuration.TotalSeconds;

            if (maxTimeInSeconds > 0)
            {

                playerTrackBar.Maximum = maxTimeInSeconds;

                int currentPositionInSeconds = (int)currentTimeStampPosition.TotalSeconds;
                playerTrackBar.Value = Math.Min(currentPositionInSeconds, playerTrackBar.Maximum);
            }

            if(currentPlayerState == true &&lblElapsedTime.Text == lblDuration.Text)
            {
                songTimer.Stop();
                
                Task.Delay(2000);
                PlaybackManager.Next();
                songTimer.Start();

                NowPlaying();
            }

        }

        private string FormatTime(TimeSpan time)
        {
            return $"{time.Minutes}:{time.Seconds}";
        }

        public void NowPlaying()
        {
            try
            {
                if (
                      PlaybackManager.CurrentMusicMetaData == null
                    || PlaybackManager.CurrentMusicMetaData.SongTitle == null
                    || PlaybackManager.CurrentMusicMetaData.SongArtist == null
                    || PlaybackManager.CurrentMusicMetaData.AlbumArt == null)
                {

                    MessageBox.Show($"PlaybackManager Current Music Metadata is Empty: \n Result");
                }
                else
                {
                    lblNowPlaying.Text = PlaybackManager.CurrentMusicMetaData.SongTitle;
                    lblSongArtist.Text = $"{PlaybackManager.CurrentMusicMetaData.SongArtist}·{PlaybackManager.CurrentMusicMetaData.SongAlbum}";
                    nowPlayingImage.Image = PlaybackManager.CurrentMusicMetaData.AlbumArt;
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Exception Error caught: {ex.Message}");
            }
        }

        private void btnPlayNext_Click(object sender, EventArgs e)
        {
            PlaybackManager.Next();
            NowPlaying();
        }

        private void btnPlayPrevious_Click(object sender, EventArgs e)
        {
            PlaybackManager.Previous();
            NowPlaying();
        }

        private void btnVolumeShow_Click(object sender, EventArgs e)
        {
            if (isVolumePanelShowing == false) {

                panelVolume.Visible = true;
                isVolumePanelShowing = true;
                return;
            }

            if(isVolumePanelShowing == true)
            {
                panelVolume.Visible = false;
                isVolumePanelShowing = false;
            }
        }

        private void musicVolumeTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            PlaybackManager.changeVolume(musicVolumeTrackBar.Value);
            lblVolume.Text = musicVolumeTrackBar.Value.ToString();

            if (musicVolumeTrackBar.Value < 30) {

                btnVolumeIndicator.Image = Properties.Resources.low_volume_192px;
            }
            
            if(musicVolumeTrackBar.Value > 30 && musicVolumeTrackBar.Value < 65)
            {
                btnVolumeIndicator.Image = Properties.Resources.volume;
            }

            if(musicVolumeTrackBar.Value > 65)
            {
                btnVolumeIndicator.Image = Properties.Resources.high_volume;
            }

            if (musicVolumeTrackBar.Value == 0) {

                btnVolumeIndicator.Image = Properties.Resources.no_audio_192px;
            }


        }
    
        private void ClearAllRecentPlayed()
        {
            Properties.Settings.Default.RecentTracks = string.Empty;
            Properties.Settings.Default.Save();

            MessageBox.Show("Recent played songs removed");

            LoadRecentlyPlayedSongs();
        }

        private void playerTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            PlaybackManager.SetTrackPosition(playerTrackBar.Value);
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
