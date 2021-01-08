namespace AccountLogin
{
    partial class frmAdmin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMark = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtStu = new System.Windows.Forms.TextBox();
            this.lblStu = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lstMarks = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmbNames = new System.Windows.Forms.ComboBox();
            this.txtClassAv = new System.Windows.Forms.TextBox();
            this.lblClassA = new System.Windows.Forms.Label();
            this.lstAverage = new System.Windows.Forms.ListBox();
            this.lstDifference = new System.Windows.Forms.ListBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.lblStuMark = new System.Windows.Forms.Label();
            this.lblClassMark = new System.Windows.Forms.Label();
            this.lblDifference = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMark)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMark
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMark.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMark.Legends.Add(legend2);
            this.chartMark.Location = new System.Drawing.Point(622, 241);
            this.chartMark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartMark.Name = "chartMark";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Marks";
            this.chartMark.Series.Add(series2);
            this.chartMark.Size = new System.Drawing.Size(611, 394);
            this.chartMark.TabIndex = 0;
            this.chartMark.Text = "chart1";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(170, 174);
            this.txtDOB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(148, 26);
            this.txtDOB.TabIndex = 28;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(170, 128);
            this.txtLast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLast.Name = "txtLast";
            this.txtLast.ReadOnly = true;
            this.txtLast.Size = new System.Drawing.Size(148, 26);
            this.txtLast.TabIndex = 27;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(170, 92);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.ReadOnly = true;
            this.txtFirst.Size = new System.Drawing.Size(148, 26);
            this.txtFirst.TabIndex = 26;
            // 
            // txtStu
            // 
            this.txtStu.Location = new System.Drawing.Point(170, 52);
            this.txtStu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStu.Name = "txtStu";
            this.txtStu.ReadOnly = true;
            this.txtStu.Size = new System.Drawing.Size(148, 26);
            this.txtStu.TabIndex = 25;
            // 
            // lblStu
            // 
            this.lblStu.AutoSize = true;
            this.lblStu.Location = new System.Drawing.Point(51, 52);
            this.lblStu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStu.Name = "lblStu";
            this.lblStu.Size = new System.Drawing.Size(91, 20);
            this.lblStu.TabIndex = 24;
            this.lblStu.Text = "Student ID ";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(51, 218);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(68, 20);
            this.lblAverage.TabIndex = 23;
            this.lblAverage.Text = "Average";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(51, 174);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "DOB:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(50, 128);
            this.lblLast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(86, 20);
            this.lblLast.TabIndex = 21;
            this.lblLast.Text = "Last Name";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(50, 92);
            this.lblFirst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(90, 20);
            this.lblFirst.TabIndex = 20;
            this.lblFirst.Text = "First Name ";
            // 
            // lstMarks
            // 
            this.lstMarks.FormattingEnabled = true;
            this.lstMarks.ItemHeight = 20;
            this.lstMarks.Location = new System.Drawing.Point(49, 331);
            this.lstMarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstMarks.Name = "lstMarks";
            this.lstMarks.Size = new System.Drawing.Size(160, 304);
            this.lstMarks.TabIndex = 30;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(622, 52);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 35);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(786, 52);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(623, 133);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 35);
            this.btnNew.TabIndex = 35;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // cmbNames
            // 
            this.cmbNames.FormattingEnabled = true;
            this.cmbNames.Location = new System.Drawing.Point(384, 52);
            this.cmbNames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNames.Name = "cmbNames";
            this.cmbNames.Size = new System.Drawing.Size(180, 28);
            this.cmbNames.TabIndex = 37;
            this.cmbNames.SelectedIndexChanged += new System.EventHandler(this.CmbNames_SelectedIndexChanged_1);
            // 
            // txtClassAv
            // 
            this.txtClassAv.Location = new System.Drawing.Point(170, 257);
            this.txtClassAv.Name = "txtClassAv";
            this.txtClassAv.ReadOnly = true;
            this.txtClassAv.Size = new System.Drawing.Size(148, 26);
            this.txtClassAv.TabIndex = 38;
            // 
            // lblClassA
            // 
            this.lblClassA.AutoSize = true;
            this.lblClassA.Location = new System.Drawing.Point(45, 257);
            this.lblClassA.Name = "lblClassA";
            this.lblClassA.Size = new System.Drawing.Size(111, 20);
            this.lblClassA.TabIndex = 39;
            this.lblClassA.Text = "Class Average";
            // 
            // lstAverage
            // 
            this.lstAverage.FormattingEnabled = true;
            this.lstAverage.ItemHeight = 20;
            this.lstAverage.Location = new System.Drawing.Point(246, 331);
            this.lstAverage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstAverage.Name = "lstAverage";
            this.lstAverage.Size = new System.Drawing.Size(160, 304);
            this.lstAverage.TabIndex = 40;
            // 
            // lstDifference
            // 
            this.lstDifference.FormattingEnabled = true;
            this.lstDifference.ItemHeight = 20;
            this.lstDifference.Location = new System.Drawing.Point(443, 331);
            this.lstDifference.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDifference.Name = "lstDifference";
            this.lstDifference.Size = new System.Drawing.Size(160, 304);
            this.lstDifference.TabIndex = 41;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(170, 218);
            this.txtAverage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(148, 26);
            this.txtAverage.TabIndex = 42;
            // 
            // lblStuMark
            // 
            this.lblStuMark.AutoSize = true;
            this.lblStuMark.Location = new System.Drawing.Point(78, 306);
            this.lblStuMark.Name = "lblStuMark";
            this.lblStuMark.Size = new System.Drawing.Size(105, 20);
            this.lblStuMark.TabIndex = 43;
            this.lblStuMark.Text = "Student Mark";
            // 
            // lblClassMark
            // 
            this.lblClassMark.AutoSize = true;
            this.lblClassMark.Location = new System.Drawing.Point(251, 306);
            this.lblClassMark.Name = "lblClassMark";
            this.lblClassMark.Size = new System.Drawing.Size(150, 20);
            this.lblClassMark.TabIndex = 44;
            this.lblClassMark.Text = "Class Average Mark";
            // 
            // lblDifference
            // 
            this.lblDifference.AutoSize = true;
            this.lblDifference.Location = new System.Drawing.Point(481, 306);
            this.lblDifference.Name = "lblDifference";
            this.lblDifference.Size = new System.Drawing.Size(83, 20);
            this.lblDifference.TabIndex = 45;
            this.lblDifference.Text = "Difference";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 692);
            this.Controls.Add(this.lblDifference);
            this.Controls.Add(this.lblClassMark);
            this.Controls.Add(this.lblStuMark);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.lstDifference);
            this.Controls.Add(this.lstAverage);
            this.Controls.Add(this.lblClassA);
            this.Controls.Add(this.txtClassAv);
            this.Controls.Add(this.cmbNames);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lstMarks);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtStu);
            this.Controls.Add(this.lblStu);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.chartMark);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMark;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtStu;
        private System.Windows.Forms.Label lblStu;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.ListBox lstMarks;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbNames;
        private System.Windows.Forms.TextBox txtClassAv;
        private System.Windows.Forms.Label lblClassA;
        private System.Windows.Forms.ListBox lstAverage;
        private System.Windows.Forms.ListBox lstDifference;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Label lblStuMark;
        private System.Windows.Forms.Label lblClassMark;
        private System.Windows.Forms.Label lblDifference;
    }
}