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
    public partial class frmAdmin : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            disableUpdate();//this is so the user can only reach certain buttons when this form loads
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Students.accdb; Persist Security Info=False;";//gets the file from the debug bin
            Populate();//this adds all the names from the dataname to the combox
            ResetAv();//this calculates the average of all the marks from all the students
        }
        public void disableUpdate()//disables buttons
        {
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            txtFirst.Enabled = false;
            txtLast.Enabled = false;
            txtStu.Enabled = false;
            txtDOB.Enabled = false;
            txtAverage.Enabled = false;
            txtClassAv.Enabled = false;
        }

        private void CmbNames_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            lstMarks.Items.Clear();//clear to avoid them getting added on incase you pick another name
            chartMark.Series.Clear();
            chartMark.Series.Add("Marks");//this is to make a chart for the marks because when it clears it resets the whole chart
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            try
            {
                command.Connection = connection;
                string fullName = cmbNames.Text;//gets the name from the combobox that user picked
                string first = fullName.Substring(0, fullName.IndexOf(' '));//get the first name by seperaating first and last name
                string query = "SELECT StuID, FirstName, LastName, DOB FROM tblStudents WHERE FirstName='" + first + "'";//gets the info using the name found
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                int stuId = 0;
                string DOB = " ";
                while (reader.Read())//bellow gets all the information needed and displays t
                {
                    stuId = Convert.ToInt16(reader["StuID"]);
                    txtStu.Text = Convert.ToString(stuId);
                    txtFirst.Text = Convert.ToString(reader["FirstName"]);
                    txtLast.Text = Convert.ToString(reader["LastName"]);
                    DOB = Convert.ToString(reader["DOB"]);
                    txtDOB.Text = DOB.Substring(0, DOB.IndexOf(' '));//this is to stop aftem the space becuadse i only need the date not the time
                }
                connection.Close();
                Refresh(Convert.ToInt16(txtStu.Text));//this refreahses for all the marks will be displayed in the list and the chart will habe the students graph
            }
            catch
            {
                MessageBox.Show("Error. Not all information available");
            }
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmNewStu frmNewStu = new frmNewStu();
            if (frmNewStu.ShowDialog() != DialogResult.OK)//if this button is clickrd it will take you to the new form and if it works then the things in the bracket will happen
            {
                Populate();
                ResetAv();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query1 = "DELETE from tblTest1 WHERE StuID=" + txtStu.Text;//this will delete all the data on the student using the id from all the tables in the database
                command.CommandText = query1;
                command.ExecuteNonQuery();
                string query2 = "DELETE from tblTest2 WHERE StuID=" + txtStu.Text;
                command.CommandText = query2;
                command.ExecuteNonQuery();
                string query3 = "DELETE from tblTest3 WHERE StuID=" + txtStu.Text;
                command.CommandText = query3;
                command.ExecuteNonQuery();
                string query4 = "DELETE from tblTest4 WHERE StuID=" + txtStu.Text;
                command.CommandText = query4;
                command.ExecuteNonQuery();
                string query5 = "DELETE from tblTest5 WHERE StuID=" + txtStu.Text;
                command.CommandText = query5;
                command.ExecuteNonQuery();
                string query6 = "DELETE from tblMarks WHERE StuID=" + txtStu.Text;
                command.CommandText = query6;
                command.ExecuteNonQuery();
                string query7 = "DELETE from tblStudents WHERE StuID=" + txtStu.Text;
                command.CommandText = query7;
                command.ExecuteNonQuery();
                MessageBox.Show("Data Deleted");
                connection.Close();
                Populate();//takes the name out of the drop down list 
            }
            catch
            {
                MessageBox.Show("Error deleting");
            }
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            frmEdit frmEdit = new frmEdit(Convert.ToInt16(txtStu.Text), txtFirst.Text, txtLast.Text, txtDOB.Text);//opens new form and passes all the info to it
            if (frmEdit.ShowDialog() != DialogResult.OK)//same as before
            {
                Populate();
                Refresh(Convert.ToInt16(txtStu.Text));
            }
        }
        public void Populate()
        {
            connection.Open();
            cmbNames.Items.Clear();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "SELECT FirstName, LastName FROM tblStudents WHERE tblStudents.UserName NOT IN ('admin') ORDER BY FirstName";//this is to add all the first names and last names not including admin
            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbNames.Items.Add(Convert.ToString(reader[0]) + " " + Convert.ToString(reader[1]));//this is adding the first and last name to combobox
            }
            connection.Close();
        }
        public void Refresh(int stuId)
        {
            connection.Open();
            lstMarks.Items.Clear();//clears everything so that we dont needetwo of things
            lstAverage.Items.Clear();
            lstDifference.Items.Clear();
            chartMark.Series.Clear();
            chartMark.Series.Add("Marks");
            connection.Close();
            ResetAv();//calls another methid, sometimes that method is needed to be used alone therefore not in here
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "SELECT Mark1,Mark2,Mark3,Mark4,Mark5 FROM tblMarks WHERE StuID=" + Convert.ToString(stuId);//gets all the marks for the student id
            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();
            int mark1 = 0;
            int mark2 = 0;
            int mark3 = 0;
            int mark4 = 0;
            int mark5 = 0;
            while (reader.Read())//gets all the marks
            {
                mark1 = Convert.ToInt16(reader["Mark1"]);
                mark2 = Convert.ToInt16(reader["Mark2"]);
                mark3 = Convert.ToInt16(reader["Mark3"]);
                mark4 = Convert.ToInt16(reader["Mark4"]);
                mark5 = Convert.ToInt16(reader["Mark5"]);
            }
            int average = (mark1 + mark2 + mark3 + mark4 + mark5) / 5;//takes the average 
            txtAverage.Text = Convert.ToString(average);//use to display average of the class
            lstMarks.Items.Add(mark1);//displays all the marks in the list
            lstMarks.Items.Add(mark2);
            lstMarks.Items.Add(mark3);
            lstMarks.Items.Add(mark4);
            lstMarks.Items.Add(mark5);
            this.chartMark.Series["Marks"].Points.AddXY("Mark 1", mark1);//displays the makes in the chart
            this.chartMark.Series["Marks"].Points.AddXY("Mark 2", mark2);
            this.chartMark.Series["Marks"].Points.AddXY("Mark 3", mark3);
            this.chartMark.Series["Marks"].Points.AddXY("Mark 4", mark4);
            this.chartMark.Series["Marks"].Points.AddXY("Mark 5", mark5);
            //differnce
            int av1 = Convert.ToInt16(lstAverage.Items[0]);//gets all the marks from the average list
            int av2 = Convert.ToInt16(lstAverage.Items[1]);
            int av3 = Convert.ToInt16(lstAverage.Items[2]);
            int av4 = Convert.ToInt16(lstAverage.Items[3]);
            int av5 = Convert.ToInt16(lstAverage.Items[4]);
            int dfc1 = mark1 - av1;//finds the difference
            int dfc2 = mark2 - av2;
            int dfc3 = mark3 - av3;
            int dfc4 = mark4 - av4;
            int dfc5 = mark5 - av5;
            lstDifference.Items.Add(dfc1);
            lstDifference.Items.Add(dfc2);
            lstDifference.Items.Add(dfc3);
            lstDifference.Items.Add(dfc4);
            lstDifference.Items.Add(dfc5);
            connection.Close();
        }
        public void ResetAv()
        {
            try
            {
                lstAverage.Items.Clear();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = "SELECT AVG(Mark1) FROM tblMarks";//this gets the aveage of each column
                int avgM1 = Convert.ToInt16(command.ExecuteScalar());//this retrives the value from the database
                lstAverage.Items.Add(avgM1);//and displays it
                command.CommandText = "SELECT AVG(Mark2) FROM tblMarks";
                int avgM2 = Convert.ToInt16(command.ExecuteScalar());
                lstAverage.Items.Add(avgM2);
                command.CommandText = "SELECT AVG(Mark3) FROM tblMarks";
                int avgM3 = Convert.ToInt16(command.ExecuteScalar());
                lstAverage.Items.Add(avgM3);
                command.CommandText = "SELECT AVG(Mark4) FROM tblMarks";
                int avgM4 = Convert.ToInt16(command.ExecuteScalar());
                lstAverage.Items.Add(avgM4);
                command.CommandText = "SELECT AVG(Mark5) FROM tblMarks";
                int avgM5 = Convert.ToInt16(command.ExecuteScalar());
                lstAverage.Items.Add(avgM5);
                int totalAvg = (avgM1 + avgM2 + avgM3 + avgM4 + avgM5) / 5;
                txtClassAv.Text = Convert.ToString(totalAvg);
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Error getting average");
            }
        }
    }
}
