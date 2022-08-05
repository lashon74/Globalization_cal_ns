namespace Globalization_cal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblYear = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.tbMonth = new System.Windows.Forms.TextBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.lblDisplayMonth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDayOfWeek = new System.Windows.Forms.TextBox();
            this.pCal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDay2 = new System.Windows.Forms.Label();
            this.lblDayOfWeek2 = new System.Windows.Forms.Label();
            this.lblMonth2 = new System.Windows.Forms.Label();
            this.lblYear2 = new System.Windows.Forms.Label();
            this.btnHijri = new System.Windows.Forms.Button();
            this.btnChin = new System.Windows.Forms.Button();
            this.pCal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(266, 29);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year:";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(304, 22);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(224, 20);
            this.tbYear.TabIndex = 1;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(258, 55);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(40, 13);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Month:";
            // 
            // tbMonth
            // 
            this.tbMonth.Location = new System.Drawing.Point(304, 48);
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(118, 20);
            this.tbMonth.TabIndex = 1;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(266, 81);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(29, 13);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Day:";
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(304, 74);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(224, 20);
            this.tbDay.TabIndex = 1;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(351, 145);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(106, 23);
            this.btnGetInfo.TabIndex = 2;
            this.btnGetInfo.Text = "Get Info";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // lblDisplayMonth
            // 
            this.lblDisplayMonth.Location = new System.Drawing.Point(428, 45);
            this.lblDisplayMonth.Name = "lblDisplayMonth";
            this.lblDisplayMonth.Size = new System.Drawing.Size(100, 23);
            this.lblDisplayMonth.TabIndex = 3;
            this.lblDisplayMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Day of week:";
            // 
            // tbDayOfWeek
            // 
            this.tbDayOfWeek.Location = new System.Drawing.Point(304, 100);
            this.tbDayOfWeek.Name = "tbDayOfWeek";
            this.tbDayOfWeek.Size = new System.Drawing.Size(224, 20);
            this.tbDayOfWeek.TabIndex = 1;
            // 
            // pCal
            // 
            this.pCal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCal.Controls.Add(this.panel1);
            this.pCal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pCal.Location = new System.Drawing.Point(0, 0);
            this.pCal.Name = "pCal";
            this.pCal.Size = new System.Drawing.Size(204, 345);
            this.pCal.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblDay2);
            this.panel1.Controls.Add(this.lblDayOfWeek2);
            this.panel1.Controls.Add(this.lblMonth2);
            this.panel1.Controls.Add(this.lblYear2);
            this.panel1.Location = new System.Drawing.Point(11, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 131);
            this.panel1.TabIndex = 0;
            // 
            // lblDay2
            // 
            this.lblDay2.AutoSize = true;
            this.lblDay2.BackColor = System.Drawing.Color.Transparent;
            this.lblDay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay2.Location = new System.Drawing.Point(61, 58);
            this.lblDay2.Name = "lblDay2";
            this.lblDay2.Size = new System.Drawing.Size(0, 31);
            this.lblDay2.TabIndex = 3;
            // 
            // lblDayOfWeek2
            // 
            this.lblDayOfWeek2.AutoSize = true;
            this.lblDayOfWeek2.BackColor = System.Drawing.Color.Transparent;
            this.lblDayOfWeek2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayOfWeek2.Location = new System.Drawing.Point(82, 22);
            this.lblDayOfWeek2.Name = "lblDayOfWeek2";
            this.lblDayOfWeek2.Size = new System.Drawing.Size(0, 20);
            this.lblDayOfWeek2.TabIndex = 2;
            // 
            // lblMonth2
            // 
            this.lblMonth2.AutoSize = true;
            this.lblMonth2.BackColor = System.Drawing.Color.Transparent;
            this.lblMonth2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth2.Location = new System.Drawing.Point(3, 22);
            this.lblMonth2.Name = "lblMonth2";
            this.lblMonth2.Size = new System.Drawing.Size(0, 20);
            this.lblMonth2.TabIndex = 1;
            // 
            // lblYear2
            // 
            this.lblYear2.BackColor = System.Drawing.Color.Transparent;
            this.lblYear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear2.ForeColor = System.Drawing.Color.Black;
            this.lblYear2.Location = new System.Drawing.Point(14, 97);
            this.lblYear2.Name = "lblYear2";
            this.lblYear2.Size = new System.Drawing.Size(65, 23);
            this.lblYear2.TabIndex = 0;
            this.lblYear2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHijri
            // 
            this.btnHijri.Location = new System.Drawing.Point(351, 174);
            this.btnHijri.Name = "btnHijri";
            this.btnHijri.Size = new System.Drawing.Size(106, 23);
            this.btnHijri.TabIndex = 5;
            this.btnHijri.Text = "Get Hijri";
            this.btnHijri.UseVisualStyleBackColor = true;
            this.btnHijri.Click += new System.EventHandler(this.btnHijri_Click);
            // 
            // btnChin
            // 
            this.btnChin.Location = new System.Drawing.Point(351, 204);
            this.btnChin.Name = "btnChin";
            this.btnChin.Size = new System.Drawing.Size(106, 23);
            this.btnChin.TabIndex = 6;
            this.btnChin.Text = "Get Chinese";
            this.btnChin.UseVisualStyleBackColor = true;
            this.btnChin.Click += new System.EventHandler(this.btnChin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 345);
            this.Controls.Add(this.btnChin);
            this.Controls.Add(this.btnHijri);
            this.Controls.Add(this.pCal);
            this.Controls.Add(this.lblDisplayMonth);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.tbDayOfWeek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.tbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.lblYear);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Globalization";
            this.pCal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox tbMonth;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Label lblDisplayMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDayOfWeek;
        private System.Windows.Forms.Panel pCal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDay2;
        private System.Windows.Forms.Label lblDayOfWeek2;
        private System.Windows.Forms.Label lblMonth2;
        private System.Windows.Forms.Label lblYear2;
        private System.Windows.Forms.Button btnHijri;
        private System.Windows.Forms.Button btnChin;
    }
}

