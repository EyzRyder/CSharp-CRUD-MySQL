using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace DataBaseHomework
{
    public partial class login : Form
    {
        string cs = "datasource=localhost;port=3306;username=root;password=raizV2toorU2;database=nossobanco;";

        private void autenticaUser()
        {
            string name = textBox1.Text;
            string paswrd = textBox4.Text;
            string query = "SELECT * from admin where user_name = '" + name + "' and user_password = '" + paswrd + "' ";

            MySqlConnection databaseConnection = new MySqlConnection(cs);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (textBox1.Text != "" || textBox4.Text != "") { 

                if (reader.HasRows)
                {
                        main_form();
                }
                else
                {
                    MessageBox.Show("Nada foi encontrado");
                }
            }
                else
                {
                    MessageBox.Show("coloque seus dados");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            autenticaUser();
        }
        private void main_form()
        {
            this.Visible = false;
            DBCShape visib = new DBCShape();
            visib.ShowDialog();
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
