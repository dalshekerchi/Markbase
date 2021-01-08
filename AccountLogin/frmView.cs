using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AccountLogin
{
    public partial class frmView : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public frmView(string first, string last, int stuId, string DOB)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Students.accdb; Persist Security Info=False;";
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT Mark1,Mark2,Mark3,Mark4,Mark5 FROM tblMarks WHERE StuID=" + stuId;//gets the maeks using the stuID
                OleDbDataReader reader = command.ExecuteReader();
                int mark1 = 0;
                int mark2 = 0;
                int mark3 = 0;
                int mark4 = 0;
                int mark5 = 0;
                while (reader.Read())//saves the marks
                {
                    mark1 = Convert.ToInt16(reader["Mark1"]);
                    mark2 = Convert.ToInt16(reader["Mark2"]);
                    mark3 = Convert.ToInt16(reader["Mark3"]);
                    mark4 = Convert.ToInt16(reader["Mark4"]);
                    mark5 = Convert.ToInt16(reader["Mark5"]);
                }
                txtStu.Text = Convert.ToString(stuId);
                txtFirst.Text = first;
                txtLast.Text = last;
                txtDOB.Text = DOB;
                int average = (mark1 + mark2 + mark3 + mark4 + mark5) / 5;//gets the average of the 5 marks
                txtAverage.Text = Convert.ToString(average);
                string level = "";

                if (average < 50)//this displays which level a person is in
                {
                    level = "R";
                }
                else if (average >= 50 && average <= 52)
                {
                    level = "1-";
                }
                else if (average >= 53 && average <= 56)
                {
                    level = "1";
                }
                else if (average >= 57 && average <= 59)
                {
                    level = "1+";
                }
                else if (average >= 60 && average <= 62)
                {
                    level = "2-";
                }
                else if (average >= 63 && average <= 66)
                {
                    level = "2";
                }
                else if (average >= 67 && average <= 69)
                {
                    level = "2+";
                }
                else if (average >= 70 && average <= 72)
                {
                    level = "3-";
                }
                else if (average >= 73 && average <= 76)
                {
                    level = "3";
                }
                else if (average >= 77 && average <= 79)
                {
                    level = "3+";
                }
                else if (average >= 80 && average <= 86)
                {
                    level = "4-";
                }
                else if (average >= 87 && average <= 94)
                {
                    level = "4";
                }
                else if (average >= 94 && average <= 100)
                {
                    level = "4+";
                }
                txtLevel.Text = level;//displays everything on the list and the chart
                lstMarks.Items.Add(mark1);
                lstMarks.Items.Add(mark2);
                lstMarks.Items.Add(mark3);
                lstMarks.Items.Add(mark4);
                lstMarks.Items.Add(mark5);
                this.chartMarks.Series["Marks"].Points.AddXY("Mark 1", mark1);
                this.chartMarks.Series["Marks"].Points.AddXY("Mark 2", mark2);
                this.chartMarks.Series["Marks"].Points.AddXY("Mark 3", mark3);
                this.chartMarks.Series["Marks"].Points.AddXY("Mark 4", mark4);
                this.chartMarks.Series["Marks"].Points.AddXY("Mark 5", mark5);
            }
            catch
            {
                MessageBox.Show("Error");
                connection.Close();
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();//closes the form
        }
    }
}
