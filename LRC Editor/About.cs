using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyrics_Editor
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "mailto:tozecerdeira@gmail.com?subject=LRC%20Editor&body=Hello",
                UseShellExecute = true
            });
        }
    }
}
