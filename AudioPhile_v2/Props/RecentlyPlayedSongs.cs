using System;
using System.Collections.Generic;
using System.Linq;

namespace AudioPhile_v2.Props
{
    public class RecentlyPlayedSongs
    {
        public string RecentlyPlayedAudioFilePath { get; set; }

        private const int MaxRecentSongs = 10;

        public static void AddRecentlyPlayedSong(string audioFilePath)
        {
            List<RecentlyPlayedSongs> recentSongs = GetAllRecentlyPlayedSongs();
            recentSongs.Insert(0, new RecentlyPlayedSongs { RecentlyPlayedAudioFilePath = audioFilePath });
            if (recentSongs.Count > MaxRecentSongs)
            {
                recentSongs.RemoveAt(recentSongs.Count - 1);
            }

            string serializedSongs = string.Join("|", recentSongs.Select(s => s.RecentlyPlayedAudioFilePath));

            Properties.Settings.Default.RecentTracks = serializedSongs;
            Properties.Settings.Default.Save();
        }

        public static List<RecentlyPlayedSongs> GetAllRecentlyPlayedSongs()
        {
            string serializedSongs = Properties.Settings.Default.RecentTracks;

            if (string.IsNullOrEmpty(serializedSongs))
            {
                return new List<RecentlyPlayedSongs>();
            }

            return serializedSongs.Split('|')
                .Select(filePath => new RecentlyPlayedSongs
                {
                    RecentlyPlayedAudioFilePath = filePath
                })
                .ToList();
        }
    }
}
