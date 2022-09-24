using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseHomework
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                login visivel = new login();
                visivel.ShowDialog();
                this.Close();
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }
    }
}
