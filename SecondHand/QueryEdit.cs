using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace SecondHand
{
    public partial class QueryEdit : Form
    {
        private DataTable dt = new DataTable();
        private BindingNavigator navigator = new BindingNavigator();
        private string conString = "Host=localhost;Port=5432;Database=secondhand;Username=postgres;Password=4sdr3423#22";
        public QueryEdit()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // DO SQL button
        {
            NpgsqlConnection sqlconn = new NpgsqlConnection(conString);
            try
            {
                sqlconn.Open();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(TestInput.Text, sqlconn);
                adapter.Fill(dt);
                dataGridViewQueryEdit.DataSource = dt;
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

       



        private void exitButtonQueryEdit_Click(object sender, EventArgs e) // Exit Button
        {

        }

        private void cancelButtonQueryEdit_Click(object sender, EventArgs e)
        {
            TestInput.Text = "SELECT";
        }
    }
}
