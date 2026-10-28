using Npgsql;
using System.Data;

namespace SecondHand
{
    public partial class Form2 : Form
    {
        private string conString = "Host=localhost;Port=5432;Database=secondhand;Username=postgres;Password=4sdr3423#22";

        private DataSet ds = new DataSet();
        private NpgsqlDataAdapter supplierAdapter;
        private NpgsqlDataAdapter batchAdapter;
        private BindingSource bsMaster = new BindingSource();
        private BindingSource bsDetail = new BindingSource();

        private DataGridView dgvSupplier = new DataGridView();
        private DataGridView dgvBatch = new DataGridView();
        private Button btnSave = new Button();

        public Form2()
        {
            InitializeComponent();
            BuildUi();
            Load += Form2_Load;
        }

        private void BuildUi()
        {
            var layout = new TableLayoutPanel();
            layout.Dock = DockStyle.Fill;
            layout.ColumnCount = 1;
            layout.RowCount = 5;
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            var lblSupplier = new Label { Text = "Постачальники", AutoSize = true };
            var lblBatch = new Label { Text = "Партії вибраного постачальника", AutoSize = true };

            dgvSupplier.Dock = DockStyle.Fill;
            dgvBatch.Dock = DockStyle.Fill;

            btnSave.Text = "Підтвердити зміни";
            btnSave.AutoSize = true;
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Click += btnSave_Click;

            layout.Controls.Add(lblSupplier, 0, 0);
            layout.Controls.Add(dgvSupplier, 0, 1);
            layout.Controls.Add(lblBatch, 0, 2);
            layout.Controls.Add(dgvBatch, 0, 3);
            layout.Controls.Add(btnSave, 0, 4);

            Controls.Add(layout);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            supplierAdapter = new NpgsqlDataAdapter("SELECT * FROM supplier", conString);
            batchAdapter = new NpgsqlDataAdapter("SELECT * FROM batch", conString);
            new NpgsqlCommandBuilder(supplierAdapter);
            new NpgsqlCommandBuilder(batchAdapter);

            supplierAdapter.Fill(ds, "supplier");
            batchAdapter.Fill(ds, "batch");
                
            ds.Relations.Add("supplier_batch",
                ds.Tables["supplier"].Columns["supplier_id"],
                ds.Tables["batch"].Columns["supplier_id"]);

            bsMaster.DataSource = ds;
            bsMaster.DataMember = "supplier";

            bsDetail.DataSource = bsMaster;
            bsDetail.DataMember = "supplier_batch";

            dgvSupplier.DataSource = bsMaster;
            dgvBatch.DataSource = bsDetail;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Підтвердити зміни?", "Зміна даних",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgvSupplier.EndEdit();
                    dgvBatch.EndEdit();
                    bsMaster.EndEdit();
                    bsDetail.EndEdit();

                    supplierAdapter.Update(ds, "supplier");
                    batchAdapter.Update(ds, "batch");
                    MessageBox.Show("Зміни збережено");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}