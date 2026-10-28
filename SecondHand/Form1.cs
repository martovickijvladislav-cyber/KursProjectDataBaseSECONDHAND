using Npgsql;
using System.Data;
namespace SecondHand    
{
    public partial class Form1 : Form
    {
        private string conString = "Host=localhost;Port=5432;Database=secondhand;Username=postgres;Password=4sdr3423#22";
        private NpgsqlDataAdapter adapter;
        private DataTable table;
        private BindingSource bs = new BindingSource();
        private BindingNavigator navigator;

        public Form1()
        {
            InitializeComponent();

            navigator = new BindingNavigator(true);
            navigator.Dock = DockStyle.Bottom;
            Controls.Add(navigator);
            navigator.BindingSource = bs;
        }
        private void LoadData(string TableName)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(conString))
            {
                adapter = new NpgsqlDataAdapter($"SELECT * FROM \"{TableName}\"", conString);
                new NpgsqlCommandBuilder(adapter);

                table = new DataTable();
                adapter.Fill(table);

                bs.DataSource = table;
                dataGridView1.DataSource = bs;
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bs.EndEdit();
                adapter.Update(table);
                MessageBox.Show("Зміни збережено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void партіїПостачальниківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
