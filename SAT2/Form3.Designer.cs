namespace SAT2
{
    partial class Form3
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFishName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxSerial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(187, 141);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(187, 25);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 59);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "FIsh Name";
            // 
            // txtBoxFishName
            // 
            this.txtBoxFishName.Location = new System.Drawing.Point(78, 25);
            this.txtBoxFishName.Name = "txtBoxFishName";
            this.txtBoxFishName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFishName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Location";
            // 
            // txtBoxLocation
            // 
            this.txtBoxLocation.Location = new System.Drawing.Point(78, 54);
            this.txtBoxLocation.Name = "txtBoxLocation";
            this.txtBoxLocation.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLocation.TabIndex = 2;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(78, 80);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price";
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.Location = new System.Drawing.Point(78, 112);
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtBoxQuantity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantity";
            // 
            // txtBoxSerial
            // 
            this.txtBoxSerial.Location = new System.Drawing.Point(78, 138);
            this.txtBoxSerial.Name = "txtBoxSerial";
            this.txtBoxSerial.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSerial.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Serial";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 174);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxSerial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtBoxLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxFishName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Name = "Form3";
            this.Text = "Database Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxFishName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxLocation;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxSerial;
        private System.Windows.Forms.Label label5;
    }
}