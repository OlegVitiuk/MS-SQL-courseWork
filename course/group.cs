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
    public partial class group : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=OLEH-PC\SQLEXPRESS01;Initial Catalog=myBest;Integrated Security=True");
        public group()
        {
            InitializeComponent();
        }

        private void group_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myBestDataSet2.authority' table. You can move, or remove it, as needed.
            this.authorityTableAdapter.Fill(this.myBestDataSet2.authority);
            // TODO: This line of code loads data into the 'myBestDataSet.autrhority' table. You can move, or remove it, as needed.
            this.deputsTableAdapter.Fill(this.myBestDataSet.deputs);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length == 0)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT d.[name],d.surname,COUNT(*) amountOfAnswers FROM deputs d LEFT JOIN deputsAnswers da ON(d.id=da.id_deput) GROUP BY d.[name],d.surname";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = string.Format("SELECT d.[name],d.surname,COUNT(*) amountOfAnswers FROM deputs d LEFT JOIN deputsAnswers da ON(d.id=da.id_deput) WHERE d.[name] = '{0}' AND d.surname = '{1}' GROUP BY d.[name],d.surname",comboBox1.Text,comboBox2.Text);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text.Length == 0)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT aa.answer FROM authorityAnswer aa LEFT JOIN authority a ON(a.id=aa.id_authority)";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = string.Format("SELECT aa.answer FROM authorityAnswer aa LEFT JOIN authority a ON(a.id=aa.id_authority) WHERE name='{0}' AND type = '{1}' AND region ='{2}'", comboBox3.Text, comboBox4.Text,comboBox5.Text);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
        }
    }
}
