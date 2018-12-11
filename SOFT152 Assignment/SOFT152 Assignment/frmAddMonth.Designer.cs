namespace SOFT152_Assignment
{
    partial class frmAddMonth
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaxTemp = new System.Windows.Forms.TextBox();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.txtNumAirFrost = new System.Windows.Forms.TextBox();
            this.txtMmOfRain = new System.Windows.Forms.TextBox();
            this.txthoursOfSun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max temp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Min temp ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "number of days of air frost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "milimeters of rainfall";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "hours of sunshine";
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Location = new System.Drawing.Point(405, 40);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Size = new System.Drawing.Size(167, 20);
            this.txtMaxTemp.TabIndex = 2;
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(405, 73);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(167, 20);
            this.txtMinTemp.TabIndex = 2;
            // 
            // txtNumAirFrost
            // 
            this.txtNumAirFrost.Location = new System.Drawing.Point(405, 104);
            this.txtNumAirFrost.Name = "txtNumAirFrost";
            this.txtNumAirFrost.Size = new System.Drawing.Size(167, 20);
            this.txtNumAirFrost.TabIndex = 2;
            // 
            // txtMmOfRain
            // 
            this.txtMmOfRain.Location = new System.Drawing.Point(405, 136);
            this.txtMmOfRain.Name = "txtMmOfRain";
            this.txtMmOfRain.Size = new System.Drawing.Size(167, 20);
            this.txtMmOfRain.TabIndex = 2;
            // 
            // txthoursOfSun
            // 
            this.txthoursOfSun.Location = new System.Drawing.Point(405, 168);
            this.txthoursOfSun.Name = "txthoursOfSun";
            this.txthoursOfSun.Size = new System.Drawing.Size(167, 20);
            this.txthoursOfSun.TabIndex = 2;
            // 
            // frmAddMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txthoursOfSun);
            this.Controls.Add(this.txtMmOfRain);
            this.Controls.Add(this.txtNumAirFrost);
            this.Controls.Add(this.txtMinTemp);
            this.Controls.Add(this.txtMaxTemp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddMonth";
            this.Text = "frmAddMonth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaxTemp;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.TextBox txtNumAirFrost;
        private System.Windows.Forms.TextBox txtMmOfRain;
        private System.Windows.Forms.TextBox txthoursOfSun;
    }
}