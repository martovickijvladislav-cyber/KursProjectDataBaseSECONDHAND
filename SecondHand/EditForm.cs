using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SecondHand
{
    public partial class EditForm : Form
    {
        private string conString = "Host=localhost;Port=5432;Database=secondhand;Username=postgres;Password=4sdr3423#22";
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            NpgsqlConnection sqlconn = new NpgsqlConnection(conString);
            try
            {
                sqlconn.Open();
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO supplier " +
                    "(supplier_name, phone_number, supplier_email, supplier_type) " +
                    "VALUES (@supplier_name, @phone_number, @supplier_email, @supplier_type)",
                    sqlconn);

                command.Parameters.AddWithValue("supplier_name", textBox_supplier_name.Text);
                command.Parameters.AddWithValue("phone_number", textBox_phone_number.Text);
                command.Parameters.AddWithValue("supplier_email", textBox_supplier_email.Text);
                command.Parameters.AddWithValue("supplier_type", comboBox_supplier_type.Text);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"ERORR: " + ex.Message);
            }
            finally
            {
                sqlconn.Close();
            }
        }
    }
}
