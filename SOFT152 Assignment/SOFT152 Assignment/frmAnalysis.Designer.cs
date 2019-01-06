namespace SOFT152_Assignment
{
    partial class frmAnalysis
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
            this.combMonth1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combYear1 = new System.Windows.Forms.ComboBox();
            this.combLocation1 = new System.Windows.Forms.ComboBox();
            this.combMonth2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combYear2 = new System.Windows.Forms.ComboBox();
            this.combLocation2 = new System.Windows.Forms.ComboBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.picChart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picChart)).BeginInit();
            this.SuspendLayout();
            // 
            // combMonth1
            // 
            this.combMonth1.FormattingEnabled = true;
            this.combMonth1.Location = new System.Drawing.Point(105, 134);
            this.combMonth1.Name = "combMonth1";
            this.combMonth1.Size = new System.Drawing.Size(96, 21);
            this.combMonth1.TabIndex = 11;
            this.combMonth1.SelectedIndexChanged += new System.EventHandler(this.combMonth1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Month #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Year #1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Location #1";
            // 
            // combYear1
            // 
            this.combYear1.FormattingEnabled = true;
            this.combYear1.Location = new System.Drawing.Point(105, 87);
            this.combYear1.Name = "combYear1";
            this.combYear1.Size = new System.Drawing.Size(96, 21);
            this.combYear1.TabIndex = 7;
            this.combYear1.SelectedIndexChanged += new System.EventHandler(this.combYear1_SelectedIndexChanged);
            // 
            // combLocation1
            // 
            this.combLocation1.FormattingEnabled = true;
            this.combLocation1.Location = new System.Drawing.Point(105, 37);
            this.combLocation1.Name = "combLocation1";
            this.combLocation1.Size = new System.Drawing.Size(96, 21);
            this.combLocation1.TabIndex = 6;
            this.combLocation1.SelectedIndexChanged += new System.EventHandler(this.combLocation1_SelectedIndexChanged);
            // 
            // combMonth2
            // 
            this.combMonth2.FormattingEnabled = true;
            this.combMonth2.Location = new System.Drawing.Point(374, 134);
            this.combMonth2.Name = "combMonth2";
            this.combMonth2.Size = new System.Drawing.Size(96, 21);
            this.combMonth2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Month #2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Year #2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Location #2";
            // 
            // combYear2
            // 
            this.combYear2.FormattingEnabled = true;
            this.combYear2.Location = new System.Drawing.Point(374, 87);
            this.combYear2.Name = "combYear2";
            this.combYear2.Size = new System.Drawing.Size(96, 21);
            this.combYear2.TabIndex = 13;
            this.combYear2.SelectedIndexChanged += new System.EventHandler(this.combYear2_SelectedIndexChanged);
            // 
            // combLocation2
            // 
            this.combLocation2.FormattingEnabled = true;
            this.combLocation2.Location = new System.Drawing.Point(374, 37);
            this.combLocation2.Name = "combLocation2";
            this.combLocation2.Size = new System.Drawing.Size(96, 21);
            this.combLocation2.TabIndex = 12;
            this.combLocation2.SelectedIndexChanged += new System.EventHandler(this.combLocation2_SelectedIndexChanged);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(535, 121);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(175, 33);
            this.btnCompare.TabIndex = 18;
            this.btnCompare.Text = "Compare data";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // picChart
            // 
            this.picChart.Location = new System.Drawing.Point(291, 188);
            this.picChart.Name = "picChart";
            this.picChart.Size = new System.Drawing.Size(500, 250);
            this.picChart.TabIndex = 19;
            this.picChart.TabStop = false;
            // 
            // frmAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picChart);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.combMonth2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combYear2);
            this.Controls.Add(this.combLocation2);
            this.Controls.Add(this.combMonth1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combYear1);
            this.Controls.Add(this.combLocation1);
            this.Name = "frmAnalysis";
            this.Text = "frmAnalysis";
            this.Load += new System.EventHandler(this.frmAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combMonth1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combYear1;
        private System.Windows.Forms.ComboBox combLocation1;
        private System.Windows.Forms.ComboBox combMonth2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combYear2;
        private System.Windows.Forms.ComboBox combLocation2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.PictureBox picChart;
    }
}