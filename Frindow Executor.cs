using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;
using System.Diagnostics;
using System.IO.Pipes;

namespace FrindowExecutor
{
    public partial class Form1 : Form
    {

        ExploitAPI module = new ExploitAPI();

        public Form1()
        {
            InitializeComponent();
        }

        Point lastPoint;

        private void Form1_Load(object sender, EventArgs e)
        {
            ScriptList.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(ScriptList, "./scripts", "*.txt");
            Functions.PopulateListBox(ScriptList, "./scripts", "*.lua");
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            if (module.isAPIAttached())
            {
                module.SendLuaScript(CodeEditor.Text);
            }

            else
            {
                var NotAttached = MessageBox.Show("Please click the attach button before executing.",
            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open File";
                CodeEditor.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Clear_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure you would like to clear the editor? You cannot undo this action.",
            "Clear Editor Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);

            if (confirmResult == DialogResult.Yes)
            {
                CodeEditor.Clear();
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

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.FileName = "New Script";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)


            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(CodeEditor.Text);
                }
            }
        }

        private void ScriptHub_Click(object sender, EventArgs e)
        {
            ScriptHub openform = new ScriptHub();
            openform.Show();
        }

        private void ScriptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CodeEditor.Text = File.ReadAllText($"./scripts/{ScriptList.SelectedItem}");
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ScriptList.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(ScriptList, "./scripts", "*.txt");
            Functions.PopulateListBox(ScriptList, "./scripts", "*.lua");

        }

        private void Minimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            JoinDiscord.Text = "Joining...";
            Process.Start("https://discord.gg/EkfXXyeVe8");
            JoinDiscord.Text = "Support Server";
            
        }

        private void Inject_Click(object sender, EventArgs e)
        {
            if (module.isAPIAttached())
            {
                var fpsUncap = MessageBox.Show("Already attached, would you like to uncap FPS?",
            "Uncap FPS", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);

                if (fpsUncap == DialogResult.Yes)
                { 
                    module.SendLuaScript("setfpscap(9999)");
                }

            }

            else
            {
                Attach.Text = "Attaching";
                module.LaunchExploit();
                System.Threading.Thread.Sleep(5000);
                if (module.isAPIAttached())
                {

                    Attach.Text = "Attached";
                    var fpsUncap = MessageBox.Show("Would you like to uncap your FPS for a smoother experience?",
            "Uncap FPS", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);

                    if (fpsUncap == DialogResult.Yes)
                    {
                        module.SendLuaScript("setfpscap(9999)");
                    }
                }
                else
                {
                    Attach.Text = "Attach";
                    var FailedToAttach = MessageBox.Show("Please make sure Roblox is running and your antivirus software is not interfering with the program. If you do not have an antivirus please check if Windows Defender didn't approve of the executor. WRD API may be patched. Would you like to open a support ticket?",
                        "Failed to attach", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                    if (FailedToAttach == DialogResult.Yes)
                    {
                        Process.Start("https://discord.gg/6kWykk4gHn");
                    }
                }
            }
        }

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
