﻿namespace SOFT152_Assignment
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
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisplayMonthInfo = new System.Windows.Forms.Button();
            this.btnEditMonthInfo = new System.Windows.Forms.Button();
            this.btnEditYearInfo = new System.Windows.Forms.Button();
            this.btnShowLocationData = new System.Windows.Forms.Button();
            this.btnEditLocationInfo = new System.Windows.Forms.Button();
            this.btnUpdateFile = new System.Windows.Forms.Button();
            this.btnAddYearInfo = new System.Windows.Forms.Button();
            this.txtLocationSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddLocationInfo = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combLocation
            // 
            this.combLocation.FormattingEnabled = true;
            this.combLocation.Location = new System.Drawing.Point(123, 80);
            this.combLocation.Name = "combLocation";
            this.combLocation.Size = new System.Drawing.Size(150, 21);
            this.combLocation.TabIndex = 0;
            this.combLocation.SelectedIndexChanged += new System.EventHandler(this.combLocation_SelectedIndexChanged);
            // 
            // combYear
            // 
            this.combYear.FormattingEnabled = true;
            this.combYear.Location = new System.Drawing.Point(123, 123);
            this.combYear.Name = "combYear";
            this.combYear.Size = new System.Drawing.Size(150, 21);
            this.combYear.TabIndex = 1;
            this.combYear.SelectedIndexChanged += new System.EventHandler(this.combYear_SelectedIndexChanged);
            // 
            // lstInfo
            // 
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.Location = new System.Drawing.Point(420, 49);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(355, 368);
            this.lstInfo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "year";
            // 
            // btnDisplayMonthInfo
            // 
            this.btnDisplayMonthInfo.Location = new System.Drawing.Point(22, 169);
            this.btnDisplayMonthInfo.Name = "btnDisplayMonthInfo";
            this.btnDisplayMonthInfo.Size = new System.Drawing.Size(150, 35);
            this.btnDisplayMonthInfo.TabIndex = 5;
            this.btnDisplayMonthInfo.Text = "Show Year\'s Month info";
            this.btnDisplayMonthInfo.UseVisualStyleBackColor = true;
            this.btnDisplayMonthInfo.Click += new System.EventHandler(this.btnDisplayInfo_Click);
            // 
            // btnEditMonthInfo
            // 
            this.btnEditMonthInfo.Location = new System.Drawing.Point(22, 232);
            this.btnEditMonthInfo.Name = "btnEditMonthInfo";
            this.btnEditMonthInfo.Size = new System.Drawing.Size(150, 38);
            this.btnEditMonthInfo.TabIndex = 6;
            this.btnEditMonthInfo.Text = "Edit a month\'s Info";
            this.btnEditMonthInfo.UseVisualStyleBackColor = true;
            this.btnEditMonthInfo.Click += new System.EventHandler(this.btnEditMonthInfo_Click);
            // 
            // btnEditYearInfo
            // 
            this.btnEditYearInfo.Location = new System.Drawing.Point(22, 276);
            this.btnEditYearInfo.Name = "btnEditYearInfo";
            this.btnEditYearInfo.Size = new System.Drawing.Size(150, 38);
            this.btnEditYearInfo.TabIndex = 7;
            this.btnEditYearInfo.Text = "Edit a Years info";
            this.btnEditYearInfo.UseVisualStyleBackColor = true;
            this.btnEditYearInfo.Click += new System.EventHandler(this.btnEditYearInfo_Click);
            // 
            // btnShowLocationData
            // 
            this.btnShowLocationData.Location = new System.Drawing.Point(237, 169);
            this.btnShowLocationData.Name = "btnShowLocationData";
            this.btnShowLocationData.Size = new System.Drawing.Size(150, 35);
            this.btnShowLocationData.TabIndex = 8;
            this.btnShowLocationData.Text = "Show location data";
            this.btnShowLocationData.UseVisualStyleBackColor = true;
            this.btnShowLocationData.Click += new System.EventHandler(this.btnShowLocationData_Click);
            // 
            // btnEditLocationInfo
            // 
            this.btnEditLocationInfo.Location = new System.Drawing.Point(22, 320);
            this.btnEditLocationInfo.Name = "btnEditLocationInfo";
            this.btnEditLocationInfo.Size = new System.Drawing.Size(150, 38);
            this.btnEditLocationInfo.TabIndex = 9;
            this.btnEditLocationInfo.Text = "Edit a Location\'s info";
            this.btnEditLocationInfo.UseVisualStyleBackColor = true;
            this.btnEditLocationInfo.Click += new System.EventHandler(this.btnEditLocationInfo_Click);
            // 
            // btnUpdateFile
            // 
            this.btnUpdateFile.Location = new System.Drawing.Point(22, 364);
            this.btnUpdateFile.Name = "btnUpdateFile";
            this.btnUpdateFile.Size = new System.Drawing.Size(150, 38);
            this.btnUpdateFile.TabIndex = 10;
            this.btnUpdateFile.Text = "Update input file";
            this.btnUpdateFile.UseVisualStyleBackColor = true;
            this.btnUpdateFile.Click += new System.EventHandler(this.btnUpdateFile_Click);
            // 
            // btnAddYearInfo
            // 
            this.btnAddYearInfo.Location = new System.Drawing.Point(237, 232);
            this.btnAddYearInfo.Name = "btnAddYearInfo";
            this.btnAddYearInfo.Size = new System.Drawing.Size(150, 38);
            this.btnAddYearInfo.TabIndex = 11;
            this.btnAddYearInfo.Text = "Add a year to an existing location";
            this.btnAddYearInfo.UseVisualStyleBackColor = true;
            this.btnAddYearInfo.Click += new System.EventHandler(this.btnAddYearInfo_Click);
            // 
            // txtLocationSearch
            // 
            this.txtLocationSearch.Location = new System.Drawing.Point(123, 22);
            this.txtLocationSearch.Name = "txtLocationSearch";
            this.txtLocationSearch.Size = new System.Drawing.Size(150, 20);
            this.txtLocationSearch.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Search for a location";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(279, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 20);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddLocationInfo
            // 
            this.btnAddLocationInfo.Location = new System.Drawing.Point(237, 276);
            this.btnAddLocationInfo.Name = "btnAddLocationInfo";
            this.btnAddLocationInfo.Size = new System.Drawing.Size(150, 38);
            this.btnAddLocationInfo.TabIndex = 15;
            this.btnAddLocationInfo.Text = "Add a new Location";
            this.btnAddLocationInfo.UseVisualStyleBackColor = true;
            this.btnAddLocationInfo.Click += new System.EventHandler(this.btnAddLocationInfo_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(237, 364);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(150, 38);
            this.btnAnalysis.TabIndex = 16;
            this.btnAnalysis.Text = "Analyse data";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(279, 78);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh location list";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // DisplayInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAnalysis);
            this.Controls.Add(this.btnAddLocationInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocationSearch);
            this.Controls.Add(this.btnAddYearInfo);
            this.Controls.Add(this.btnUpdateFile);
            this.Controls.Add(this.btnEditLocationInfo);
            this.Controls.Add(this.btnShowLocationData);
            this.Controls.Add(this.btnEditYearInfo);
            this.Controls.Add(this.btnEditMonthInfo);
            this.Controls.Add(this.btnDisplayMonthInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstInfo);
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
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisplayMonthInfo;
        private System.Windows.Forms.Button btnEditMonthInfo;
        private System.Windows.Forms.Button btnEditYearInfo;
        private System.Windows.Forms.Button btnShowLocationData;
        private System.Windows.Forms.Button btnEditLocationInfo;
        private System.Windows.Forms.Button btnUpdateFile;
        private System.Windows.Forms.Button btnAddYearInfo;
        private System.Windows.Forms.TextBox txtLocationSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddLocationInfo;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button btnRefresh;
    }
}

