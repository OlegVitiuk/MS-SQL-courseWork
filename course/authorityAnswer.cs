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
    public partial class authorityAnswer : Form
    {
        private string status;
        SqlConnection con = new SqlConnection(@"Data Source=OLEH-PC\SQLEXPRESS01;Initial Catalog=myBest;Integrated Security=True");
        public authorityAnswer()
        {
            InitializeComponent();
        }

        private void authorityAnswer_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            loadComboBox();
            this.dateTimePicker1.Value = DateTime.Now;
            display();
        }
        private void loadComboBox()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT id FROM appeal EXCEPT SELECT id_appeal FROM deputsAnswers";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["id"]);
            }
            con.Close();
            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = "SELECT DISTINCT id FROM authority";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                comboBox2.Items.Add(dr["id"]);
            }
            con.Close();
        }
        private void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM authorityAnswer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void clear()
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkTextBox())
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO authorityAnswer VALUES('" + status + "','" + dateTimePicker1.Value.ToShortDateString()+ "','" +
                textBox2.Text+"','"+ Convert.ToInt32(comboBox2.Text) + "','" + Convert.ToInt32(comboBox1.Text) + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("Insertion have been finished successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool checkTextBox()
        {
            bool rezult = true;
            if(radioButton1.Checked)
            {
                status = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                status = radioButton2.Text;
            }
            else if (!radioButton1.Checked || !!radioButton2.Checked)
            {
                MessageBox.Show("Please,check status!", "Empty field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rezult = false;
            }
            if (rezult)
            {
                if (comboBox2.Text.Length == 0)
                {
                    MessageBox.Show("Please,choose number of the authority!", "Empty field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rezult = false;
                }
                else if (comboBox1.Text.Length == 0)
                {
                    MessageBox.Show("Please,choose number of the appeal!", "Empty field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rezult = false;
                }
                else if (textBox2.Text.Length == 0)
                {
                    MessageBox.Show("Please, write an answer!", "Empty field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rezult = false;
                }
            }
            return rezult;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM authorityAnswer WHERE id='" + id + "'";
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
                cmd.CommandText = "UPDATE  authorityAnswer SET status = '" + status + "', deadline = '" + dateTimePicker1.Value.ToShortDateString() + "', answer = '" +
                textBox2.Text + "', id_authority = '" + Convert.ToInt32(comboBox2.Text) + "', id_appeal = '" + Convert.ToInt32(comboBox1.Text) + "' WHERE id = '" + id + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("Updating have been finished successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells["answer"].Value.ToString();
                comboBox1.Text = row.Cells["id_appeal"].Value.ToString();
                comboBox2.Text = row.Cells["id_authority"].Value.ToString();
                dateTimePicker1.Text = row.Cells["deadline"].Value.ToString();
                if(row.Cells["status"].Value.ToString()=="true")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM authorityAnswer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("status LIKE '%{0}%' OR deadline LIKE '%{0}%' OR answer LIKE '%{0}%'", textBox4.Text);
            dataGridView1.DataSource = dv;
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM authorityAnswer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            try
            {
                dv.RowFilter = string.Format("id_appeal= {0} OR id_authority = {0}",Convert.ToInt32(textBox1.Text));
                throw new Exception();
            }
            catch (Exception ex)
            {
                con.Close();
                display();
            }
            dataGridView1.DataSource = dv;
            con.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
