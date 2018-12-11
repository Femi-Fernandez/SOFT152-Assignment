namespace SOFT152_Assignment
{
    partial class frmAddYear
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
            this.combLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstYears = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewYear = new System.Windows.Forms.TextBox();
            this.txtNewYearDesc = new System.Windows.Forms.TextBox();
            this.btnAddYear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combLocation
            // 
            this.combLocation.FormattingEnabled = true;
            this.combLocation.Location = new System.Drawing.Point(97, 52);
            this.combLocation.Name = "combLocation";
            this.combLocation.Size = new System.Drawing.Size(121, 21);
            this.combLocation.TabIndex = 0;
            this.combLocation.SelectedIndexChanged += new System.EventHandler(this.combLocation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Location";
            // 
            // lstYears
            // 
            this.lstYears.FormattingEnabled = true;
            this.lstYears.Location = new System.Drawing.Point(15, 121);
            this.lstYears.Name = "lstYears";
            this.lstYears.Size = new System.Drawing.Size(204, 264);
            this.lstYears.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "New year Description";
            // 
            // txtNewYear
            // 
            this.txtNewYear.Location = new System.Drawing.Point(408, 52);
            this.txtNewYear.Name = "txtNewYear";
            this.txtNewYear.Size = new System.Drawing.Size(128, 20);
            this.txtNewYear.TabIndex = 4;
            // 
            // txtNewYearDesc
            // 
            this.txtNewYearDesc.Location = new System.Drawing.Point(408, 104);
            this.txtNewYearDesc.Name = "txtNewYearDesc";
            this.txtNewYearDesc.Size = new System.Drawing.Size(128, 20);
            this.txtNewYearDesc.TabIndex = 4;
            // 
            // btnAddYear
            // 
            this.btnAddYear.Location = new System.Drawing.Point(408, 191);
            this.btnAddYear.Name = "btnAddYear";
            this.btnAddYear.Size = new System.Drawing.Size(128, 47);
            this.btnAddYear.TabIndex = 5;
            this.btnAddYear.Text = "Add year and months";
            this.btnAddYear.UseVisualStyleBackColor = true;
            this.btnAddYear.Click += new System.EventHandler(this.btnAddYear_Click);
            // 
            // frmAddYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddYear);
            this.Controls.Add(this.txtNewYearDesc);
            this.Controls.Add(this.txtNewYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstYears);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combLocation);
            this.Name = "frmAddYear";
            this.Text = "frmAddYear";
            this.Load += new System.EventHandler(this.frmAddYear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstYears;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewYear;
        private System.Windows.Forms.TextBox txtNewYearDesc;
        private System.Windows.Forms.Button btnAddYear;
    }
}