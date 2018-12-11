namespace SOFT152_Assignment
{
    partial class frmEditLocation
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
            this.comblocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLocations = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewLocName = new System.Windows.Forms.TextBox();
            this.txtNewLocStreet = new System.Windows.Forms.TextBox();
            this.txtNewLocCountry = new System.Windows.Forms.TextBox();
            this.txtNewLocPostcode = new System.Windows.Forms.TextBox();
            this.txtNewLocLat = new System.Windows.Forms.TextBox();
            this.txtNewLocLong = new System.Windows.Forms.TextBox();
            this.btnEditLocationInfo = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comblocation
            // 
            this.comblocation.FormattingEnabled = true;
            this.comblocation.Location = new System.Drawing.Point(111, 45);
            this.comblocation.Name = "comblocation";
            this.comblocation.Size = new System.Drawing.Size(142, 21);
            this.comblocation.TabIndex = 0;
            this.comblocation.SelectedIndexChanged += new System.EventHandler(this.comblocation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Location to edit";
            // 
            // lstLocations
            // 
            this.lstLocations.FormattingEnabled = true;
            this.lstLocations.Location = new System.Drawing.Point(43, 137);
            this.lstLocations.Name = "lstLocations";
            this.lstLocations.Size = new System.Drawing.Size(210, 134);
            this.lstLocations.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New location name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Street number and street name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "New Postcode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "New Latitude";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "New Longitude";
            // 
            // txtNewLocName
            // 
            this.txtNewLocName.Location = new System.Drawing.Point(470, 41);
            this.txtNewLocName.Name = "txtNewLocName";
            this.txtNewLocName.Size = new System.Drawing.Size(180, 20);
            this.txtNewLocName.TabIndex = 4;
            // 
            // txtNewLocStreet
            // 
            this.txtNewLocStreet.Location = new System.Drawing.Point(470, 85);
            this.txtNewLocStreet.Name = "txtNewLocStreet";
            this.txtNewLocStreet.Size = new System.Drawing.Size(180, 20);
            this.txtNewLocStreet.TabIndex = 4;
            // 
            // txtNewLocCountry
            // 
            this.txtNewLocCountry.Location = new System.Drawing.Point(470, 133);
            this.txtNewLocCountry.Name = "txtNewLocCountry";
            this.txtNewLocCountry.Size = new System.Drawing.Size(180, 20);
            this.txtNewLocCountry.TabIndex = 4;
            // 
            // txtNewLocPostcode
            // 
            this.txtNewLocPostcode.Location = new System.Drawing.Point(470, 169);
            this.txtNewLocPostcode.Name = "txtNewLocPostcode";
            this.txtNewLocPostcode.Size = new System.Drawing.Size(180, 20);
            this.txtNewLocPostcode.TabIndex = 4;
            // 
            // txtNewLocLat
            // 
            this.txtNewLocLat.Location = new System.Drawing.Point(470, 206);
            this.txtNewLocLat.Name = "txtNewLocLat";
            this.txtNewLocLat.Size = new System.Drawing.Size(180, 20);
            this.txtNewLocLat.TabIndex = 4;
            // 
            // txtNewLocLong
            // 
            this.txtNewLocLong.Location = new System.Drawing.Point(470, 238);
            this.txtNewLocLong.Name = "txtNewLocLong";
            this.txtNewLocLong.Size = new System.Drawing.Size(180, 20);
            this.txtNewLocLong.TabIndex = 4;
            // 
            // btnEditLocationInfo
            // 
            this.btnEditLocationInfo.Location = new System.Drawing.Point(500, 326);
            this.btnEditLocationInfo.Name = "btnEditLocationInfo";
            this.btnEditLocationInfo.Size = new System.Drawing.Size(150, 45);
            this.btnEditLocationInfo.TabIndex = 5;
            this.btnEditLocationInfo.Text = "Edit Location info";
            this.btnEditLocationInfo.UseVisualStyleBackColor = true;
            this.btnEditLocationInfo.Click += new System.EventHandler(this.btnEditLocationInfo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 45);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEditLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditLocationInfo);
            this.Controls.Add(this.txtNewLocLong);
            this.Controls.Add(this.txtNewLocLat);
            this.Controls.Add(this.txtNewLocPostcode);
            this.Controls.Add(this.txtNewLocCountry);
            this.Controls.Add(this.txtNewLocStreet);
            this.Controls.Add(this.txtNewLocName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstLocations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comblocation);
            this.Name = "frmEditLocation";
            this.Text = "frmEditLocation";
            this.Load += new System.EventHandler(this.frmEditLocation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comblocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLocations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewLocName;
        private System.Windows.Forms.TextBox txtNewLocStreet;
        private System.Windows.Forms.TextBox txtNewLocCountry;
        private System.Windows.Forms.TextBox txtNewLocPostcode;
        private System.Windows.Forms.TextBox txtNewLocLat;
        private System.Windows.Forms.TextBox txtNewLocLong;
        private System.Windows.Forms.Button btnEditLocationInfo;
        private System.Windows.Forms.Button btnCancel;
    }
}