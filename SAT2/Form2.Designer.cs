namespace SAT2
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.fishnamelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StockLevelLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SerialNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search";
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(73, 12);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(128, 20);
            this.SearchTxtBox.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(221, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(253, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(253, 80);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(253, 123);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(17, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 95);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // fishnamelabel
            // 
            this.fishnamelabel.AutoSize = true;
            this.fishnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fishnamelabel.Location = new System.Drawing.Point(13, 160);
            this.fishnamelabel.Name = "fishnamelabel";
            this.fishnamelabel.Size = new System.Drawing.Size(102, 24);
            this.fishnamelabel.TabIndex = 8;
            this.fishnamelabel.Text = "Fish Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.Location = new System.Drawing.Point(12, 252);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(65, 18);
            this.LocationLabel.TabIndex = 10;
            this.LocationLabel.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "In Stock:";
            // 
            // StockLevelLabel
            // 
            this.StockLevelLabel.AutoSize = true;
            this.StockLevelLabel.Location = new System.Drawing.Point(84, 299);
            this.StockLevelLabel.Name = "StockLevelLabel";
            this.StockLevelLabel.Size = new System.Drawing.Size(13, 13);
            this.StockLevelLabel.TabIndex = 12;
            this.StockLevelLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Price: ";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(70, 346);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(13, 13);
            this.PriceLabel.TabIndex = 14;
            this.PriceLabel.Text = "0";
            // 
            // SerialNumberLabel
            // 
            this.SerialNumberLabel.AutoSize = true;
            this.SerialNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumberLabel.Location = new System.Drawing.Point(12, 384);
            this.SerialNumberLabel.Name = "SerialNumberLabel";
            this.SerialNumberLabel.Size = new System.Drawing.Size(102, 18);
            this.SerialNumberLabel.TabIndex = 15;
            this.SerialNumberLabel.Text = "Serial Number";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 451);
            this.Controls.Add(this.SerialNumberLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StockLevelLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fishnamelabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Stock Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label fishnamelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StockLevelLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label SerialNumberLabel;
    }
}