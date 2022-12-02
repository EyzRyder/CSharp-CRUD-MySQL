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
    public partial class DBCShape : Form
    {
        Registro registro = new Registro();
        public DBCShape()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxfrstNm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxLstNm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxDress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registro.SaveUser(txtBoxfrstNm.Text, txtBoxLstNm.Text, txtBoxDress.Text);
            
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            registro.updateUser();
        }


        private void listView1_SelSectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void DBCShape_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var reader = registro.listUsers();

            while (reader.Read())
            {
                //                                ID                    First name                     Last Name                        Address
                Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3));
                string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            registro.deleteUser(listView1.SelectedItems[0].Text.ToString());
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var reader = registro.listUsers();

            while (reader.Read())
            {
                //                                 ID                    First name                     Last Name                        Address
                Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3));
                string[]  row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
           
        }
    }
}
