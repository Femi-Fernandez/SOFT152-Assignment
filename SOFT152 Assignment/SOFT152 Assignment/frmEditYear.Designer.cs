namespace SOFT152_Assignment
{
    partial class frmEditYear
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
            this.button2 = new System.Windows.Forms.Button();
            this.combLocation = new System.Windows.Forms.ComboBox();
            this.combYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstCurrentYearDesc = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewYearDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(318, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 42);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Change years data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // combLocation
            // 
            this.combLocation.FormattingEnabled = true;
            this.combLocation.Location = new System.Drawing.Point(128, 68);
            this.combLocation.Name = "combLocation";
            this.combLocation.Size = new System.Drawing.Size(120, 21);
            this.combLocation.TabIndex = 2;
            this.combLocation.SelectedIndexChanged += new System.EventHandler(this.combLocation_SelectedIndexChanged);
            // 
            // combYear
            // 
            this.combYear.FormattingEnabled = true;
            this.combYear.Location = new System.Drawing.Point(128, 132);
            this.combYear.Name = "combYear";
            this.combYear.Size = new System.Drawing.Size(120, 21);
            this.combYear.TabIndex = 2;
            this.combYear.SelectedIndexChanged += new System.EventHandler(this.combYear_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current year decription";
            // 
            // lstCurrentYearDesc
            // 
            this.lstCurrentYearDesc.FormattingEnabled = true;
            this.lstCurrentYearDesc.Location = new System.Drawing.Point(128, 215);
            this.lstCurrentYearDesc.Name = "lstCurrentYearDesc";
            this.lstCurrentYearDesc.Size = new System.Drawing.Size(170, 69);
            this.lstCurrentYearDesc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "New year Description";
            // 
            // txtNewYearDesc
            // 
            this.txtNewYearDesc.Location = new System.Drawing.Point(407, 71);
            this.txtNewYearDesc.Name = "txtNewYearDesc";
            this.txtNewYearDesc.Size = new System.Drawing.Size(205, 20);
            this.txtNewYearDesc.TabIndex = 8;
            // 
            // frmEditYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNewYearDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstCurrentYearDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combYear);
            this.Controls.Add(this.combLocation);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmEditYear";
            this.Text = "frmEditYear";
            this.Load += new System.EventHandler(this.frmEditYear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox combLocation;
        private System.Windows.Forms.ComboBox combYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCurrentYearDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewYearDesc;
    }
}