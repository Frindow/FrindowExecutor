using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrindowExecutor
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 6;
            if (panel1.Width >= 522) {
                timer1.Stop();
                Form1 f2 = new Form1();
                f2.Show();
                this.Hide();
            }
        }
    }
}
