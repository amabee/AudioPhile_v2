using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPhile_v2.Props
{
    public class MusicMetaData
    {
        public String SongTitle { get; set; }
        public String SongArtist { get; set; }
        public String SongAlbum { get; set; }
        public Image AlbumArt { get; set; }

        public double SongDuration { get; set; }

        public String AudioFilePath {  get; set; }

        public String SongGenre { get; set; }

        public MusicMetaData GetMusicMetaData(string filePath) {
        
            var metadata = new MusicMetaData();

            try
            {
                var file = TagLib.File.Create(filePath);

                metadata.SongTitle = file.Tag.Title ?? "Unknown Title";
                metadata.SongArtist = file.Tag.Performers.Length > 0 ? file.Tag.Performers[0] : "Unknown Artist";
                metadata.AudioFilePath = filePath;
                metadata.SongAlbum = file.Tag.Album ?? "Unknown Album";
                metadata.SongGenre = file.Tag.Genres.Length > 0 ? file.Tag.Genres[0] : "Unknown Genre";

                metadata.SongDuration = file.Properties.Duration.TotalMinutes;

                if (file.Tag.Pictures.Length > 0) {
                    
                    var picture = file.Tag.Pictures[0];

                    using (var memoryStream = new MemoryStream(picture.Data.Data))
                    {
                        metadata.AlbumArt = Image.FromStream(memoryStream);
                    }

                }
                else
                {
                    metadata.AlbumArt = Properties.Resources.international_music_240px;
                }
            }
            catch (Exception ex) {

                MessageBox.Show($"An error occured: {ex.Message}");

                metadata.SongTitle = "Unknown Title";
                metadata.SongArtist = "Unknown Song Artist";
                metadata.SongAlbum =  "Unknown Album";
                metadata.AlbumArt = Properties.Resources.international_music_240px;
                metadata.SongDuration = 0;
                metadata.SongGenre = "null";

            }

            return metadata;
        }
    }
}
