namespace AccountLogin
{
    partial class frmView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblStu = new System.Windows.Forms.Label();
            this.txtStu = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstMarks = new System.Windows.Forms.ListBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.chartMarks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(46, 60);
            this.lblFirst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(90, 20);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First Name ";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(45, 106);
            this.lblLast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(86, 20);
            this.lblLast.TabIndex = 1;
            this.lblLast.Text = "Last Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(46, 154);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "DOB";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(46, 191);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(68, 20);
            this.lblAverage.TabIndex = 13;
            this.lblAverage.Text = "Average";
            // 
            // lblStu
            // 
            this.lblStu.AutoSize = true;
            this.lblStu.Location = new System.Drawing.Point(45, 20);
            this.lblStu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStu.Name = "lblStu";
            this.lblStu.Size = new System.Drawing.Size(91, 20);
            this.lblStu.TabIndex = 14;
            this.lblStu.Text = "Student ID ";
            // 
            // txtStu
            // 
            this.txtStu.Location = new System.Drawing.Point(165, 20);
            this.txtStu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStu.Name = "txtStu";
            this.txtStu.ReadOnly = true;
            this.txtStu.Size = new System.Drawing.Size(148, 26);
            this.txtStu.TabIndex = 15;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(165, 60);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.ReadOnly = true;
            this.txtFirst.Size = new System.Drawing.Size(148, 26);
            this.txtFirst.TabIndex = 16;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(165, 95);
            this.txtLast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLast.Name = "txtLast";
            this.txtLast.ReadOnly = true;
            this.txtLast.Size = new System.Drawing.Size(148, 26);
            this.txtLast.TabIndex = 17;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(165, 142);
            this.txtDOB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(148, 26);
            this.txtDOB.TabIndex = 18;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(165, 186);
            this.txtAverage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(148, 26);
            this.txtAverage.TabIndex = 19;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(482, 26);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lstMarks
            // 
            this.lstMarks.FormattingEnabled = true;
            this.lstMarks.ItemHeight = 20;
            this.lstMarks.Location = new System.Drawing.Point(50, 285);
            this.lstMarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstMarks.Name = "lstMarks";
            this.lstMarks.Size = new System.Drawing.Size(264, 344);
            this.lstMarks.TabIndex = 21;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(46, 238);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(46, 20);
            this.lblLevel.TabIndex = 24;
            this.lblLevel.Text = "Level";
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(165, 228);
            this.txtLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(148, 26);
            this.txtLevel.TabIndex = 25;
            // 
            // chartMarks
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMarks.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMarks.Legends.Add(legend1);
            this.chartMarks.Location = new System.Drawing.Point(405, 285);
            this.chartMarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartMarks.Name = "chartMarks";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Marks";
            this.chartMarks.Series.Add(series1);
            this.chartMarks.Size = new System.Drawing.Size(472, 346);
            this.chartMarks.TabIndex = 23;
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 691);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.chartMarks);
            this.Controls.Add(this.lstMarks);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtStu);
            this.Controls.Add(this.lblStu);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmView";
            this.Text = "View";
            ((System.ComponentModel.ISupportInitialize)(this.chartMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblStu;
        private System.Windows.Forms.TextBox txtStu;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstMarks;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMarks;
    }
}