using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;
using System.Diagnostics;

namespace FrindowExecutor
{
    public partial class ScriptHub : Form
    {
        public ScriptHub()
        {
            InitializeComponent();
        }

        Point lastPoint;
        ExploitAPI module = new ExploitAPI();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ScriptHubExecute_Click(object sender, EventArgs e)
        {
            if (module.isAPIAttached())
            {
                WebClient wb = new WebClient();
                string Script = wb.DownloadString(ScriptCode.Text);
                module.SendLuaScript(Script);
            }

            else
            {
                var NotAttached = MessageBox.Show("Please click the attach button before executing.",
            "Error!", MessageBoxButtons.OK);
            }
        }

        private void InfiniteYield_Click(object sender, EventArgs e)
        {

            ScriptCode.Text = "https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source";
            ScriptDescripion.Text = "Client side admin commands that allow you to fly, fling players, and more.";
            ScriptIcon.Image = FrindowExecutor.Properties.Resources.Infinite_Yield_Icon;

        }

        private void DarkDex_Click(object sender, EventArgs e)
        {
            ScriptCode.Text = "https://pastebin.com/raw/KjvjUML9";
            ScriptDescripion.Text = "Allows you to view the games explorer.";
            ScriptIcon.Image = FrindowExecutor.Properties.Resources.Dark_Dex_Icon;
        }

        private void RemoteSpy_Click(object sender, EventArgs e)
        {
            ScriptCode.Text = "https://pastebin.com/raw/7GmZyarT";
            ScriptDescripion.Text = "Allows you to view any remote events or remote functions that are called.";
            ScriptIcon.Image = FrindowExecutor.Properties.Resources.Remote_Spy_Icon;
        }

        private void MoreScripts_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("This will open a website  on your web browser, are you sure you want to continue?",
            "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            if (confirmResult == DialogResult.Yes)
            {
                Process.Start("https://wearedevs.net/scripts");
            }
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
                lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
