using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deputs deputsobj = new deputs();
            deputsobj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            appeal appealobj = new appeal();
            appealobj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was developed by Oleg Vitiuk","About program",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            deputAnswer dea = new deputAnswer();
            dea.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            deputs d = new deputs();
            d.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            authority a = new authority();
            a.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            authorityAnswer aa = new authorityAnswer();
            aa.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            group g = new group();
            g.Show();
        }
    }
}
