namespace SecondHand
{
    partial class QueryEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewQueryEdit = new DataGridView();
            TestInput = new RichTextBox();
            button1 = new Button();
            cancelButtonQueryEdit = new Button();
            exitButtonQueryEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQueryEdit).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewQueryEdit
            // 
            dataGridViewQueryEdit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewQueryEdit.Location = new Point(12, 107);
            dataGridViewQueryEdit.Name = "dataGridViewQueryEdit";
            dataGridViewQueryEdit.RowHeadersWidth = 51;
            dataGridViewQueryEdit.Size = new Size(776, 331);
            dataGridViewQueryEdit.TabIndex = 0;
            // 
            // TestInput
            // 
            TestInput.Location = new Point(12, 12);
            TestInput.Name = "TestInput";
            TestInput.Size = new Size(681, 89);
            TestInput.TabIndex = 1;
            TestInput.Text = "SELECT";
            TestInput.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(699, 2);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Do SQL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cancelButtonQueryEdit
            // 
            cancelButtonQueryEdit.Location = new Point(699, 37);
            cancelButtonQueryEdit.Name = "cancelButtonQueryEdit";
            cancelButtonQueryEdit.Size = new Size(94, 29);
            cancelButtonQueryEdit.TabIndex = 3;
            cancelButtonQueryEdit.Text = "Cancel";
            cancelButtonQueryEdit.UseVisualStyleBackColor = true;
            cancelButtonQueryEdit.Click += cancelButtonQueryEdit_Click;
            // 
            // exitButtonQueryEdit
            // 
            exitButtonQueryEdit.Location = new Point(699, 72);
            exitButtonQueryEdit.Name = "exitButtonQueryEdit";
            exitButtonQueryEdit.Size = new Size(94, 29);
            exitButtonQueryEdit.TabIndex = 4;
            exitButtonQueryEdit.Text = "Exit";
            exitButtonQueryEdit.UseVisualStyleBackColor = true;
            exitButtonQueryEdit.Click += exitButtonQueryEdit_Click;
            // 
            // QueryEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButtonQueryEdit);
            Controls.Add(cancelButtonQueryEdit);
            Controls.Add(button1);
            Controls.Add(TestInput);
            Controls.Add(dataGridViewQueryEdit);
            Name = "QueryEdit";
            Text = "QueryEdit";
            ((System.ComponentModel.ISupportInitialize)dataGridViewQueryEdit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewQueryEdit;
        private RichTextBox TestInput;
        private Button button1;
        private Button cancelButtonQueryEdit;
        private Button exitButtonQueryEdit;
    }
}