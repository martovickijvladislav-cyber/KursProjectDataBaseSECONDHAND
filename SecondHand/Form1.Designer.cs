namespace SecondHand
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            таблиціToolStripMenuItem = new ToolStripMenuItem();
            поставщикиToolStripMenuItem = new ToolStripMenuItem();
            партіїToolStripMenuItem = new ToolStripMenuItem();
            товариToolStripMenuItem = new ToolStripMenuItem();
            партіїПостачальниківToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { вихідToolStripMenuItem, таблиціToolStripMenuItem, партіїПостачальниківToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(60, 24);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // таблиціToolStripMenuItem
            // 
            таблиціToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поставщикиToolStripMenuItem, партіїToolStripMenuItem, товариToolStripMenuItem });
            таблиціToolStripMenuItem.Name = "таблиціToolStripMenuItem";
            таблиціToolStripMenuItem.Size = new Size(78, 24);
            таблиціToolStripMenuItem.Text = "Таблиці";
            таблиціToolStripMenuItem.Click += таблиціToolStripMenuItem_Click;
            // 
            // поставщикиToolStripMenuItem
            // 
            поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            поставщикиToolStripMenuItem.Size = new Size(178, 26);
            поставщикиToolStripMenuItem.Text = "Поставщики";
            поставщикиToolStripMenuItem.Click += поставщикиToolStripMenuItem_Click;
            // 
            // партіїToolStripMenuItem
            // 
            партіїToolStripMenuItem.Name = "партіїToolStripMenuItem";
            партіїToolStripMenuItem.Size = new Size(178, 26);
            партіїToolStripMenuItem.Text = "Партії";
            партіїToolStripMenuItem.Click += партіїToolStripMenuItem_Click;
            // 
            // товариToolStripMenuItem
            // 
            товариToolStripMenuItem.Name = "товариToolStripMenuItem";
            товариToolStripMenuItem.Size = new Size(178, 26);
            товариToolStripMenuItem.Text = "Товари";
            товариToolStripMenuItem.Click += товариToolStripMenuItem_Click;
            // 
            // партіїПостачальниківToolStripMenuItem
            // 
            партіїПостачальниківToolStripMenuItem.Name = "партіїПостачальниківToolStripMenuItem";
            партіїПостачальниківToolStripMenuItem.Size = new Size(175, 24);
            партіїПостачальниківToolStripMenuItem.Text = "партії постачальників";
            партіїПостачальниківToolStripMenuItem.Click += партіїПостачальниківToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(630, 377);
            button1.Name = "button1";
            button1.Size = new Size(170, 41);
            button1.TabIndex = 1;
            button1.Text = "Зберегти зміни";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 340);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private ToolStripMenuItem таблиціToolStripMenuItem;
        private ToolStripMenuItem поставщикиToolStripMenuItem;
        private ToolStripMenuItem партіїToolStripMenuItem;
        private ToolStripMenuItem товариToolStripMenuItem;
        private Button button1;
        private DataGridView dataGridView1;
        private ToolStripMenuItem партіїПостачальниківToolStripMenuItem;
    }
}
