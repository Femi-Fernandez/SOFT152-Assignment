namespace SOFT152_Assignment
{
    partial class DisplayInfo
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
            this.lstMonthInfo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisplayInfo = new System.Windows.Forms.Button();
            this.btnEditMonthInfo = new System.Windows.Forms.Button();
            this.btnEditYearInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combLocation
            // 
            this.combLocation.FormattingEnabled = true;
            this.combLocation.Location = new System.Drawing.Point(94, 49);
            this.combLocation.Name = "combLocation";
            this.combLocation.Size = new System.Drawing.Size(150, 21);
            this.combLocation.TabIndex = 0;
            this.combLocation.SelectedIndexChanged += new System.EventHandler(this.combLocation_SelectedIndexChanged);
            // 
            // combYear
            // 
            this.combYear.FormattingEnabled = true;
            this.combYear.Location = new System.Drawing.Point(94, 92);
            this.combYear.Name = "combYear";
            this.combYear.Size = new System.Drawing.Size(150, 21);
            this.combYear.TabIndex = 1;
            // 
            // lstMonthInfo
            // 
            this.lstMonthInfo.FormattingEnabled = true;
            this.lstMonthInfo.Location = new System.Drawing.Point(420, 49);
            this.lstMonthInfo.Name = "lstMonthInfo";
            this.lstMonthInfo.Size = new System.Drawing.Size(355, 368);
            this.lstMonthInfo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "year";
            // 
            // btnDisplayInfo
            // 
            this.btnDisplayInfo.Location = new System.Drawing.Point(94, 136);
            this.btnDisplayInfo.Name = "btnDisplayInfo";
            this.btnDisplayInfo.Size = new System.Drawing.Size(150, 35);
            this.btnDisplayInfo.TabIndex = 5;
            this.btnDisplayInfo.Text = "Show Year\'s Month info";
            this.btnDisplayInfo.UseVisualStyleBackColor = true;
            this.btnDisplayInfo.Click += new System.EventHandler(this.btnDisplayInfo_Click);
            // 
            // btnEditMonthInfo
            // 
            this.btnEditMonthInfo.Location = new System.Drawing.Point(94, 212);
            this.btnEditMonthInfo.Name = "btnEditMonthInfo";
            this.btnEditMonthInfo.Size = new System.Drawing.Size(150, 38);
            this.btnEditMonthInfo.TabIndex = 6;
            this.btnEditMonthInfo.Text = "Edit a month\'s Info";
            this.btnEditMonthInfo.UseVisualStyleBackColor = true;
            this.btnEditMonthInfo.Click += new System.EventHandler(this.btnEditMonthInfo_Click);
            // 
            // btnEditYearInfo
            // 
            this.btnEditYearInfo.Location = new System.Drawing.Point(94, 265);
            this.btnEditYearInfo.Name = "btnEditYearInfo";
            this.btnEditYearInfo.Size = new System.Drawing.Size(150, 38);
            this.btnEditYearInfo.TabIndex = 7;
            this.btnEditYearInfo.Text = "Edit a Years info";
            this.btnEditYearInfo.UseVisualStyleBackColor = true;
            this.btnEditYearInfo.Click += new System.EventHandler(this.btnEditYearInfo_Click);
            // 
            // DisplayInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditYearInfo);
            this.Controls.Add(this.btnEditMonthInfo);
            this.Controls.Add(this.btnDisplayInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMonthInfo);
            this.Controls.Add(this.combYear);
            this.Controls.Add(this.combLocation);
            this.Name = "DisplayInfo";
            this.Text = "Display year info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combLocation;
        private System.Windows.Forms.ComboBox combYear;
        private System.Windows.Forms.ListBox lstMonthInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisplayInfo;
        private System.Windows.Forms.Button btnEditMonthInfo;
        private System.Windows.Forms.Button btnEditYearInfo;
    }
}

