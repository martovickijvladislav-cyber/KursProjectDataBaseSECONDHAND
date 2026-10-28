using Npgsql;
using System.Data;
namespace SecondHand    
{
    public partial class Form1 : Form
    {
        private string conString = "Host=localhost;Port=5432;Database=secondhand;Username=postgres;Password=4sdr3423#22";
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadData(string TableName)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(conString))
            {
                connection.Open();

                string quary = $"SELECT * FROM \"{TableName}\"";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(quary, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void таблиціToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData("supplier");
        }

        private void партіїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData("batch");
        }

        private void товариToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData("item");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
