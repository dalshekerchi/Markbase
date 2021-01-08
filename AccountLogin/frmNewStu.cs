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
    public partial class frmNewStu : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public frmNewStu()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Students.accdb; Persist Security Info=False;";
            buttonChange(false);//disable right hand side bacuse need left first
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            int count = 0;
            int x;
            if (string.IsNullOrWhiteSpace(txtFirst.Text) || string.IsNullOrWhiteSpace(txtLast.Text) || string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text) || string.IsNullOrWhiteSpace(txtDay.Text) || string.IsNullOrWhiteSpace(txtMonth.Text) || string.IsNullOrWhiteSpace(txtYear.Text))//check if everything is full
            {
                MessageBox.Show("Not all information has been submitted. Please Try Again.");
            }
            else
            {
                if (int.TryParse(txtDay.Text, out x))//makes sure all of it is the right data type
                {
                    if (int.TryParse(txtMonth.Text, out x))
                    {
                        if (int.TryParse(txtYear.Text, out x))
                        {
                            if (int.TryParse(txtFirst.Text, out x))
                            {

                            }
                            else
                            {
                                if (int.TryParse(txtFirst.Text, out x))
                                {

                                }
                                else
                                {
                                    count = 1;
                                }
                            }
                        }

                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("Error is the data input");
                }
                if (count == 1)//if it is
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    int month = Convert.ToInt16(txtMonth.Text);
                    string DOBM = "";
                    Valid date = new Valid(Convert.ToInt16(txtDay.Text), month);//makes sure day and month is valid eg only 12 months 
                    if (date.Day == 0 || date.Month == 0)
                    {
                        MessageBox.Show("Invalid date");
                        connection.Close();
                    }
                    else
                    {
                        count++;
                        if (month == 01)//in data base its writeen with letters so change months to 3 letters
                        {
                            DOBM = "Jan";
                        }
                        else if (month == 02)
                        {
                            DOBM = "Feb";
                        }
                        else if (month == 03)
                        {
                            DOBM = "Mar";
                        }
                        else if (month == 04)
                        {
                            DOBM = "Apr";
                        }
                        else if (month == 05)
                        {
                            DOBM = "May";
                        }
                        else if (month == 06)
                        {
                            DOBM = "Jun";
                        }
                        else if (month == 07)
                        {
                            DOBM = "Jul";
                        }
                        else if (month == 08)
                        {
                            DOBM = "Aug";
                        }
                        else if (month == 09)
                        {
                            DOBM = "Sep";
                        }
                        else if (month == 10)
                        {
                            DOBM = "Oct";
                        }
                        else if (month == 11)
                        {
                            DOBM = "Nov";
                        }
                        else if (month == 12)
                        {
                            DOBM = "Dec";
                        }
                    }
                    if (count == 2)
                    {
                        try
                        {
                            string DOB = txtDay.Text + "-" + DOBM + "-" + txtYear.Text;//puts the three boxes together
                            command.CommandText = "INSERT into tblStudents (FirstName,LastName,UserName,[Password],DOB) values('" + txtFirst.Text + "','" + txtLast.Text + "','" + txtUser.Text + "','" + txtPass.Text + "','" + DOB + "')";//inserts new into into database
                            command.ExecuteNonQuery();
                            connection.Close();
                            connection.Open();

                            command.CommandText = "SELECT StuId FROM tblStudents WHERE UserName='" + txtUser.Text + "'";//gets the stuid so it can be refrensced later
                            OleDbDataReader reader = command.ExecuteReader();
                            int stuId = 0;
                            while (reader.Read())
                            {
                                stuId = Convert.ToInt16(reader["StuID"]);
                            }
                            lblStu.Text = Convert.ToString(stuId);
                            MessageBox.Show("This information has been added to the database.");
                            buttonChange(true);//unlocks the buttons
                        }
                        catch
                        {
                            MessageBox.Show("Error");
                            connection.Close();
                        }
                        
                    }

                }
            }
            
        }

        private void btnMark1_Click(object sender, EventArgs e)
        {
            txtMark1.Text = formOpen(1);//uses method to open new form passes the mark #
        }

        private void btnSave2_Click(object sender, EventArgs e)//used two differnet save buttons so i can get the stu id
        {
            if (string.IsNullOrWhiteSpace(txtMark1.Text) || string.IsNullOrWhiteSpace(txtMark2.Text) || string.IsNullOrWhiteSpace(txtMark3.Text) || string.IsNullOrWhiteSpace(txtMark4.Text) || string.IsNullOrWhiteSpace(txtMark5.Text))//makes sure nothing e=is empty
            {
                MessageBox.Show("Not all information has been submitted. Please Try Again.");
            }
            else
            {
                MessageBox.Show("This information has been added to the database.");
                this.Close();
            }
        }

        private void btnMark2_Click(object sender, EventArgs e)//same...
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
        public void buttonChange(bool value)//this enables or disables based on what bool is given
        {
            btnMark1.Enabled = value;
            btnMark2.Enabled = value;
            btnMark3.Enabled = value;
            btnMark4.Enabled = value;
            btnMark5.Enabled = value;
        }
        public string formOpen( int markNum)
        {
            string newStu = "new";
            string newMark = "";
            frmCategories frmCategories = new frmCategories(lblStu.Text, newStu, markNum);//opens new form passes that in
            if (frmCategories.ShowDialog() != DialogResult.OK)
            {
               
                newMark = Convert.ToString(frmCategories.returnA);//gets the newmark assigned from the other form
                connection.Close();
            }
            return newMark;//returns new mark so it can be displayed in textbox
        }
    }
}
