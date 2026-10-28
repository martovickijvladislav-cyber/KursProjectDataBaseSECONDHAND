namespace SecondHand
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null; //231

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "Form2";
            this.Text = "Партії постачальників";
            this.ResumeLayout(false);
        }
    }
}