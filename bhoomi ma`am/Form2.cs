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
namespace bhoomi_ma_am
{
    public partial class registration : Form
    {
        string gen = "";
        string namee, pass;
        string _branch, _city;
        string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\COCO\\source\\repos\\bhoomi ma`am\\bhoomi ma`am\\bhoomi ma`am\\Database1.mdf\";Integrated Security=True";
        public registration()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string query = "insert into students values('" + namee + "','" + pass + "','" + _branch + "','" + _city + "','" + gen + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registration Successful");
            con.Close();
        }

        private void name_in_TextChanged(object sender, EventArgs e)
        {
            namee = name_in.Text;
        }

        private void pass_in_TextChanged(object sender, EventArgs e)
        {
            pass = pass_in.Text;
        }

        private void cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            _city = cities.SelectedItem.ToString();
        }

        private void male_redio_CheckedChanged(object sender, EventArgs e)
        {
            gen = "male";
        }

        private void female_radio_CheckedChanged(object sender, EventArgs e)
        {
            gen = "female";
        }

        private void branches_SelectedIndexChanged(object sender, EventArgs e)
        {
            _branch = branches.SelectedItem.ToString();
        }
    }
}
