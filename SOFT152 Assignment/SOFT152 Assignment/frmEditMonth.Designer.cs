namespace SOFT152_Assignment
{
    partial class frmEditMonth
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
            this.combYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combMonth = new System.Windows.Forms.ComboBox();
            this.lstCurrentmonth = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnewMaxTemp = new System.Windows.Forms.TextBox();
            this.txtNewMinTemp = new System.Windows.Forms.TextBox();
            this.txtNumFrostDays = new System.Windows.Forms.TextBox();
            this.txtNewMmOfRain = new System.Windows.Forms.TextBox();
            this.txtNewHoursOfSun = new System.Windows.Forms.TextBox();
            this.btnEditAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combLocation
            // 
            this.combLocation.FormattingEnabled = true;
            this.combLocation.Location = new System.Drawing.Point(97, 49);
            this.combLocation.Name = "combLocation";
            this.combLocation.Size = new System.Drawing.Size(96, 21);
            this.combLocation.TabIndex = 0;
            this.combLocation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // combYear
            // 
            this.combYear.FormattingEnabled = true;
            this.combYear.Location = new System.Drawing.Point(97, 99);
            this.combYear.Name = "combYear";
            this.combYear.Size = new System.Drawing.Size(96, 21);
            this.combYear.TabIndex = 1;
            this.combYear.SelectedIndexChanged += new System.EventHandler(this.combYear_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Month to Edit";
            // 
            // combMonth
            // 
            this.combMonth.FormattingEnabled = true;
            this.combMonth.Location = new System.Drawing.Point(97, 146);
            this.combMonth.Name = "combMonth";
            this.combMonth.Size = new System.Drawing.Size(96, 21);
            this.combMonth.TabIndex = 5;
            this.combMonth.SelectedIndexChanged += new System.EventHandler(this.combMonth_SelectedIndexChanged);
            // 
            // lstCurrentmonth
            // 
            this.lstCurrentmonth.FormattingEnabled = true;
            this.lstCurrentmonth.Location = new System.Drawing.Point(15, 219);
            this.lstCurrentmonth.Name = "lstCurrentmonth";
            this.lstCurrentmonth.Size = new System.Drawing.Size(170, 160);
            this.lstCurrentmonth.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "new Min Temp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "new Max temp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "new Number of days with air frost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "new millimetres of rainfall ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "new hours of sunshine";
            // 
            // txtnewMaxTemp
            // 
            this.txtnewMaxTemp.Location = new System.Drawing.Point(487, 52);
            this.txtnewMaxTemp.Name = "txtnewMaxTemp";
            this.txtnewMaxTemp.Size = new System.Drawing.Size(100, 20);
            this.txtnewMaxTemp.TabIndex = 8;
            // 
            // txtNewMinTemp
            // 
            this.txtNewMinTemp.Location = new System.Drawing.Point(487, 96);
            this.txtNewMinTemp.Name = "txtNewMinTemp";
            this.txtNewMinTemp.Size = new System.Drawing.Size(100, 20);
            this.txtNewMinTemp.TabIndex = 8;
            // 
            // txtNumFrostDays
            // 
            this.txtNumFrostDays.Location = new System.Drawing.Point(487, 142);
            this.txtNumFrostDays.Name = "txtNumFrostDays";
            this.txtNumFrostDays.Size = new System.Drawing.Size(100, 20);
            this.txtNumFrostDays.TabIndex = 8;
            // 
            // txtNewMmOfRain
            // 
            this.txtNewMmOfRain.Location = new System.Drawing.Point(487, 194);
            this.txtNewMmOfRain.Name = "txtNewMmOfRain";
            this.txtNewMmOfRain.Size = new System.Drawing.Size(100, 20);
            this.txtNewMmOfRain.TabIndex = 8;
            // 
            // txtNewHoursOfSun
            // 
            this.txtNewHoursOfSun.Location = new System.Drawing.Point(487, 235);
            this.txtNewHoursOfSun.Name = "txtNewHoursOfSun";
            this.txtNewHoursOfSun.Size = new System.Drawing.Size(100, 20);
            this.txtNewHoursOfSun.TabIndex = 8;
            // 
            // btnEditAll
            // 
            this.btnEditAll.Location = new System.Drawing.Point(452, 291);
            this.btnEditAll.Name = "btnEditAll";
            this.btnEditAll.Size = new System.Drawing.Size(135, 37);
            this.btnEditAll.TabIndex = 9;
            this.btnEditAll.Text = "Edit all this months values";
            this.btnEditAll.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(243, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 36);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEditMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditAll);
            this.Controls.Add(this.txtNewHoursOfSun);
            this.Controls.Add(this.txtNewMmOfRain);
            this.Controls.Add(this.txtNumFrostDays);
            this.Controls.Add(this.txtNewMinTemp);
            this.Controls.Add(this.txtnewMaxTemp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstCurrentmonth);
            this.Controls.Add(this.combMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combYear);
            this.Controls.Add(this.combLocation);
            this.Name = "frmEditMonth";
            this.Text = "frmEditMonth";
            this.Load += new System.EventHandler(this.frmEditMonth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combLocation;
        private System.Windows.Forms.ComboBox combYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combMonth;
        private System.Windows.Forms.ListBox lstCurrentmonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnewMaxTemp;
        private System.Windows.Forms.TextBox txtNewMinTemp;
        private System.Windows.Forms.TextBox txtNumFrostDays;
        private System.Windows.Forms.TextBox txtNewMmOfRain;
        private System.Windows.Forms.TextBox txtNewHoursOfSun;
        private System.Windows.Forms.Button btnEditAll;
        private System.Windows.Forms.Button btnCancel;
    }
}