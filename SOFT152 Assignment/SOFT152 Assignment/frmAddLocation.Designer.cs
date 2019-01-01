namespace SOFT152_Assignment
{
    partial class frmAddLocation
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
            this.txtNewLocName = new System.Windows.Forms.TextBox();
            this.txtNewLocStreet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewLocation = new System.Windows.Forms.Button();
            this.txtNewLocCountry = new System.Windows.Forms.TextBox();
            this.txtNewLocPostcode = new System.Windows.Forms.TextBox();
            this.txtNewLocLatitude = new System.Windows.Forms.TextBox();
            this.txtNewLocLongitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewLocNumYears = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNewLocName
            // 
            this.txtNewLocName.Location = new System.Drawing.Point(284, 46);
            this.txtNewLocName.Name = "txtNewLocName";
            this.txtNewLocName.Size = new System.Drawing.Size(229, 20);
            this.txtNewLocName.TabIndex = 0;
            // 
            // txtNewLocStreet
            // 
            this.txtNewLocStreet.Location = new System.Drawing.Point(284, 72);
            this.txtNewLocStreet.Name = "txtNewLocStreet";
            this.txtNewLocStreet.Size = new System.Drawing.Size(229, 20);
            this.txtNewLocStreet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "new Locaiton Name";
            // 
            // btnNewLocation
            // 
            this.btnNewLocation.Location = new System.Drawing.Point(355, 276);
            this.btnNewLocation.Name = "btnNewLocation";
            this.btnNewLocation.Size = new System.Drawing.Size(158, 49);
            this.btnNewLocation.TabIndex = 3;
            this.btnNewLocation.Text = "Create new location";
            this.btnNewLocation.UseVisualStyleBackColor = true;
            this.btnNewLocation.Click += new System.EventHandler(this.btnNewLocation_Click);
            // 
            // txtNewLocCountry
            // 
            this.txtNewLocCountry.Location = new System.Drawing.Point(284, 98);
            this.txtNewLocCountry.Name = "txtNewLocCountry";
            this.txtNewLocCountry.Size = new System.Drawing.Size(229, 20);
            this.txtNewLocCountry.TabIndex = 1;
            // 
            // txtNewLocPostcode
            // 
            this.txtNewLocPostcode.Location = new System.Drawing.Point(284, 124);
            this.txtNewLocPostcode.Name = "txtNewLocPostcode";
            this.txtNewLocPostcode.Size = new System.Drawing.Size(229, 20);
            this.txtNewLocPostcode.TabIndex = 1;
            // 
            // txtNewLocLatitude
            // 
            this.txtNewLocLatitude.Location = new System.Drawing.Point(284, 150);
            this.txtNewLocLatitude.Name = "txtNewLocLatitude";
            this.txtNewLocLatitude.Size = new System.Drawing.Size(229, 20);
            this.txtNewLocLatitude.TabIndex = 1;
            // 
            // txtNewLocLongitude
            // 
            this.txtNewLocLongitude.Location = new System.Drawing.Point(284, 176);
            this.txtNewLocLongitude.Name = "txtNewLocLongitude";
            this.txtNewLocLongitude.Size = new System.Drawing.Size(229, 20);
            this.txtNewLocLongitude.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "new Street number and Street name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "new Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "new Postcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "new Latitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "new Longitude";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(151, 276);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(158, 49);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Cancel/Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Number of years of Data";
            // 
            // txtNewLocNumYears
            // 
            this.txtNewLocNumYears.Location = new System.Drawing.Point(284, 205);
            this.txtNewLocNumYears.Name = "txtNewLocNumYears";
            this.txtNewLocNumYears.Size = new System.Drawing.Size(229, 20);
            this.txtNewLocNumYears.TabIndex = 1;
            // 
            // frmAddLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNewLocation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewLocNumYears);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewLocLongitude);
            this.Controls.Add(this.txtNewLocLatitude);
            this.Controls.Add(this.txtNewLocPostcode);
            this.Controls.Add(this.txtNewLocCountry);
            this.Controls.Add(this.txtNewLocStreet);
            this.Controls.Add(this.txtNewLocName);
            this.Name = "frmAddLocation";
            this.Text = "frmAddLocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewLocName;
        private System.Windows.Forms.TextBox txtNewLocStreet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewLocation;
        private System.Windows.Forms.TextBox txtNewLocCountry;
        private System.Windows.Forms.TextBox txtNewLocPostcode;
        private System.Windows.Forms.TextBox txtNewLocLatitude;
        private System.Windows.Forms.TextBox txtNewLocLongitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewLocNumYears;
    }
}