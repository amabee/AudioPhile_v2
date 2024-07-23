using AudioPhile_v2.Reusable_Controls;
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
    public partial class NoCurrentMedia : UserControl
    {
        public NoCurrentMedia()
        {
            InitializeComponent();
        }

        private void openFilesBtn_Click(object sender, EventArgs e)
        {
            AddSongDirectory.AddSongDirectoryFunction();
        }
    }
}
