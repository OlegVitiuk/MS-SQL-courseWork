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
    public partial class appeal : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=OLEH-PC\SQLEXPRESS01;Initial Catalog=myBest;Integrated Security=True");


        public appeal()
        {
            InitializeComponent();
        }

        private void appeal_Load(object sender, EventArgs e)
        {
            display();
        }
        private void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM appeal";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO appeal VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("Insertion have been finished successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM appeal WHERE id='" + id + "'";
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
                cmd.CommandText = "UPDATE appeal SET name = '" + textBox1.Text + "',surname = '" +
                    textBox2.Text + "'WHERE id='" + id + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("Updating have been finished successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            clear();
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
                textBox2.Text = row.Cells["surname"].Value.ToString();
                textBox3.Text = row.Cells["content"].Value.ToString();
            }
        }
        private bool checkTextBox()
        {
            bool rezult=true;
            if (textBox1.Text.Length == 0 ) 
            {
                MessageBox.Show("Please, input name!", "Empty field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rezult=false;
            }
            else if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Please, input surname!", "Empty field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rezult = false;
            }
            else if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Please, input content of the appeal!", "Empty field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rezult = false;
            }
            else
            {
                foreach (char ch in textBox1.Text)
                    if (Char.IsDigit(ch))
                    {
                        rezult = false;
                        MessageBox.Show("Field \"name\" can not contain digits!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                foreach (char ch in textBox2.Text)
                    if (Char.IsDigit(ch))
                    {
                        rezult = false;
                        MessageBox.Show("Field \"surname\" can not contain digits!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            return rezult;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM appeal";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("name LIKE '%{0}%' OR surname LIKE '%{0}%'", textBox4.Text);
            dataGridView1.DataSource = dv;
            con.Close();
        }
    }
}
