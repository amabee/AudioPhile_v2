using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPhile_v2.Reusable_Controls
{
    public class AddSongDirectory
    {
        public static void AddSongDirectoryFunction()
        {
            string directories = Properties.Settings.Default.SongDirectories;

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderBrowserDialog.SelectedPath;
                    MessageBox.Show($"Selected folder: {folderPath}");
                    if (!string.IsNullOrWhiteSpace(folderPath))
                    {
                        string[] directoryList = directories.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        List<string> updateDirectory = new List<string>(directoryList);


                        if (!updateDirectory.Contains(folderPath.Trim()))
                        {
                            updateDirectory.Add(folderPath.Trim());
                        }

                        AddSelectedDirectories(updateDirectory);


                        foreach (var directory in directoryList)
                        {

                            MessageBox.Show($"Directory: {directory.Trim()}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Directories");
                    }
                }
            }

        }

        private static void AddSelectedDirectories(List<string> directories)
        {
            Properties.Settings.Default.SongDirectories = string.Join(",", directories);
            Properties.Settings.Default.Save();
        }
    }

}
