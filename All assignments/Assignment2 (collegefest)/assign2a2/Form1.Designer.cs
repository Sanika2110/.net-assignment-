namespace CollegeFestEventHandling
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtNumPeople;

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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtNumPeople = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 75);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(153, 40);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtNumPeople
            // 
            this.txtNumPeople.Location = new System.Drawing.Point(12, 40);
            this.txtNumPeople.Name = "txtNumPeople";
            this.txtNumPeople.Size = new System.Drawing.Size(100, 20);
            this.txtNumPeople.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.txtNumPeople);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "College Fest Event Handling";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
