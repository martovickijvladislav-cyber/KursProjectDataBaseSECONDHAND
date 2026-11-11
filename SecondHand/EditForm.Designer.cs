namespace SecondHand
{
    partial class EditForm
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
            button_OK = new Button();
            button_Cancel = new Button();
            textBox_phone_number = new TextBox();
            textBox_supplier_email = new TextBox();
            textBox_supplier_name = new TextBox();
            comboBox_supplier_type = new ComboBox();
            Type_label = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button_OK
            // 
            button_OK.Location = new Point(213, 267);
            button_OK.Name = "button_OK";
            button_OK.Size = new Size(94, 29);
            button_OK.TabIndex = 0;
            button_OK.Text = "OK";
            button_OK.UseVisualStyleBackColor = true;
            button_OK.Click += button_OK_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(440, 267);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(94, 29);
            button_Cancel.TabIndex = 1;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            // 
            // textBox_phone_number
            // 
            textBox_phone_number.Location = new Point(200, 100);
            textBox_phone_number.Name = "textBox_phone_number";
            textBox_phone_number.Size = new Size(202, 27);
            textBox_phone_number.TabIndex = 2;
            textBox_phone_number.TextChanged += textBox1_TextChanged;
            // 
            // textBox_supplier_email
            // 
            textBox_supplier_email.Location = new Point(200, 153);
            textBox_supplier_email.Name = "textBox_supplier_email";
            textBox_supplier_email.Size = new Size(202, 27);
            textBox_supplier_email.TabIndex = 3;
            // 
            // textBox_supplier_name
            // 
            textBox_supplier_name.Location = new Point(200, 47);
            textBox_supplier_name.Name = "textBox_supplier_name";
            textBox_supplier_name.Size = new Size(202, 27);
            textBox_supplier_name.TabIndex = 4;
            // 
            // comboBox_supplier_type
            // 
            comboBox_supplier_type.FormattingEnabled = true;
            comboBox_supplier_type.Location = new Point(440, 46);
            comboBox_supplier_type.Name = "comboBox_supplier_type";
            comboBox_supplier_type.Size = new Size(151, 28);
            comboBox_supplier_type.TabIndex = 5;
            comboBox_supplier_type.Tag = "";
            // 
            // Type_label
            // 
            Type_label.AutoSize = true;
            Type_label.Location = new Point(440, 23);
            Type_label.Name = "Type_label";
            Type_label.Size = new Size(40, 20);
            Type_label.TabIndex = 6;
            Type_label.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 130);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 7;
            label1.Text = "supplier_email";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 77);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 8;
            label2.Text = "phone_number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 23);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 23);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 10;
            label4.Text = "supplier_name";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Type_label);
            Controls.Add(comboBox_supplier_type);
            Controls.Add(textBox_supplier_name);
            Controls.Add(textBox_supplier_email);
            Controls.Add(textBox_phone_number);
            Controls.Add(button_Cancel);
            Controls.Add(button_OK);
            Name = "EditForm";
            Text = "EditForm";
            Load += EditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_OK;
        private Button button_Cancel;
        private TextBox textBox_phone_number;
        private TextBox textBox_supplier_email;
        private TextBox textBox_supplier_name;
        private ComboBox comboBox_supplier_type;
        private Label Type_label;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}