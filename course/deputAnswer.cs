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
    public partial class deputAnswer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=OLEH-PC\SQLEXPRESS01;Initial Catalog=myBest;Integrated Security=True");
        private int selectedCombobox1;
        private int selectedCombobox2;
        public deputAnswer()
        {
            InitializeComponent();
            selectedCombobox1 = 0;
            selectedCombobox2 = 0;
        }

        private void deputAnswer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myBestDataSet.deputsAnswers' table. You can move, or remove it, as needed.
            //this.deputsAnswersTableAdapter.Fill(this.myBestDataSet.deputsAnswers);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            loadComboBox();
            display();
        }
        private void loadComboBox(){
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT DISTINCT id_appeal FROM deputsAnswers";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["id_appeal"]);
            }
            con.Close();
            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = "SELECT DISTINCT id_deput FROM deputsAnswers";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                comboBox2.Items.Add(dr["id_deput"]);
            }
            con.Close();
        }
        private void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM deputsAnswers";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private bool checkTextBox()
        {
            bool rezult = true;
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please, input answer!", "Empty field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rezult = false;
            }
            else if (comboBox2.Text.Length == 0)
            {
                MessageBox.Show("Please,choose number of the deput!", "Empty field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rezult = false;
            }
            else if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Please,choose number of the appeal!", "Empty field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rezult = false;
            }
            return rezult;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO deputsAnswers VALUES('" + textBox1.Text + "','" + Convert.ToInt32(comboBox2.Text) + "','" + Convert.ToInt32(comboBox1.Text) + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("Insertion have been finished successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void clear()
        {
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM deputsAnswers WHERE id='" + id + "'";
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
                cmd.CommandText = "UPDATE deputsAnswers SET answer = '" + textBox1.Text + "',id_deput = '" +
                    comboBox2.Text +"',id_appeal = '" +
                    comboBox1.Text + "'WHERE id='" + id + "'";
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
                textBox1.Text = row.Cells["answer"].Value.ToString();
                comboBox1.Text = row.Cells["id_appeal"].Value.ToString();
                comboBox2.Text = row.Cells["id_deput"].Value.ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM deputsAnswers";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            try{
                dv.RowFilter = string.Format("id_appeal ={0} OR id_deput={0}", Convert.ToInt32(textBox4.Text));
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

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT  FROM deputsAnswers";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
