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
    public partial class frmEdit : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public frmEdit(int stuId, string first, string last, string DOB)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Students.accdb; Persist Security Info=False;";
            txtFirst.Text = first;
            txtLast.Text = last;
            string month = DOB.Substring(0, DOB.IndexOf('/'));//im trying to split p the day so i get the day alone
            if (month.Length == 1)//if its only one digit then make it two just to keep in consistant
            {
                txtMonth.Text = "0" + month;
            }
            else
            {
                txtMonth.Text = month;
            }
            string day = DOB.Substring(3, DOB.IndexOf('/'));//does the same thing here but starting for 2 instead of 0
            if (day.Length == 1)
            {
                txtDay.Text = "0" + day;
            }
            else
            {
                txtDay.Text = day;
            }
            
            string year = DOB.Substring(6, 2);
            txtYear.Text = year;
            txtStu.Text = Convert.ToString(stuId);
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT UserName, Password FROM tblStudents WHERE FirstName='" + first + "'";//gets username and password from info that was passed in
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtUser.Text = Convert.ToString(reader["UserName"]);//displays it
                    txtPass.Text = Convert.ToString(reader["Password"]);
                }
                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = connection;
                command2.CommandText = "SELECT Mark1,Mark2,Mark3,Mark4,Mark5 FROM tblMarks WHERE StuID=" + stuId;//gets marks
                OleDbDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    txtMark1.Text = Convert.ToString(reader2["Mark1"]);//displays it
                    txtMark2.Text = Convert.ToString(reader2["Mark2"]);
                    txtMark3.Text = Convert.ToString(reader2["Mark3"]);
                    txtMark4.Text = Convert.ToString(reader2["Mark4"]);
                    txtMark5.Text = Convert.ToString(reader2["Mark5"]);
                }
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Error");
                connection.Close();
            }
           
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "UPDATE tblStudents SET FirstName='" + txtFirst.Text + "' ,LastName='" + txtLast.Text + "' ,UserName='" + txtUser.Text + "' ,[Password]='" + txtPass.Text + "' where StuID=" + txtStu.Text + "";//this updates all the info
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("Data Edited");
                connection.Close();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error");
                connection.Close();
            }
            
        }

        private void btnMark1_Click(object sender, EventArgs e)
        {
            txtMark1.Text = formOpen(1);//this uses a method that would display another form adn just inputs which mark num it is
        }

        private void btnMark2_Click(object sender, EventArgs e)
        {
            txtMark2.Text = formOpen(2);
        }

        private void btnMark3_Click(object sender, EventArgs e)
        {
            txtMark3.Text = formOpen(3);
        }

        private void btnMark4_Click(object sender, EventArgs e)
        {
            txtMark4.Text = formOpen(4);
        }

        private void btnMark5_Click(object sender, EventArgs e)
        {
            txtMark5.Text = formOpen(5);
        }
        public string formOpen(int markNum)
        {
            string newMark = "";
            frmCategories frmCategories = new frmCategories(txtStu.Text, markNum);//opens new form passes that in
            if (frmCategories.ShowDialog() != DialogResult.OK)
            {
                newMark = Convert.ToString(frmCategories.returnA);//gets the newmark assigned from the other form
                connection.Close();
            }
            return newMark;//returns new mark so it can be displayed in textbox
        }

        
    }
}
