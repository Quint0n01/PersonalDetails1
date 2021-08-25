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

namespace PersonalDetails1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            string ID = txtID.Text;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            string FirstName = txtFirstName.Text;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            string Surname = txtSurname.Text;
        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {
            string Gender = txtGender.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=LAPTOP-9F8GCKKS;Initial Catalog=Personal_Info;Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            cnn.Open();
            MessageBox.Show("Data submitted!");

            cnn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
