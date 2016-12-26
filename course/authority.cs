using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace course
{
    public partial class authority : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=OLEH-PC\SQLEXPRESS01;Initial Catalog=myBest;Integrated Security=True");
        public authority()
        {
            InitializeComponent();
        }
        private void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM authority";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["name"].Value.ToString();
                textBox2.Text = row.Cells["type"].Value.ToString();
                textBox3.Text = row.Cells["region"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO authority VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("Insertion have been finished successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool checkTextBox()
        {
            bool rezult = true;
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please, input name!", "Empty field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rezult = false;
            }
            else if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Please, input type of the appeal!", "Empty field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rezult = false;
            }
            else if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Please, input region of the authority!", "Empty field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rezult = false;
            }
            else
            {
                foreach (char ch in textBox1.Text)
                    if (Char.IsDigit(ch))
                    {
                        rezult = false;
                        MessageBox.Show("Field \"name\" can not contain digits!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                foreach (char ch in textBox2.Text)
                    if (Char.IsDigit(ch))
                    {
                        rezult = false;
                        MessageBox.Show("Field \"type\" can not contain digits!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                foreach (char ch in textBox3.Text)
                    if (Char.IsDigit(ch))
                    {
                        rezult = false;
                        MessageBox.Show("Field \"region\" can not contain digits!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            return rezult;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM authority WHERE id='" + id + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            display();
            MessageBox.Show("Removal have been finished successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                string id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE authority SET name = '" + textBox1.Text + "',type = '" +
                    textBox2.Text +"',region = '"+textBox3.Text+ "'WHERE id='" + id + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("Updating have been finished successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM authority";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("name LIKE '%{0}%' OR type LIKE '%{0}%' OR region LIKE '%{0}%'", textBox4.Text);
            dataGridView1.DataSource = dv;
            con.Close();
        }

        private void authority_Load(object sender, EventArgs e)
        {
            display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
