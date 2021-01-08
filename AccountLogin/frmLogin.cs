using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//needed to be used to make connections to the database
//Name: Dana Al Shekerchi
//Date: Before 20-12-2019 - 09-01-2020
//Assignment:Assignment5
//Description:Database login page

namespace AccountLogin
{
    public partial class frmLogin : Form
    {
        private OleDbConnection connection = new OleDbConnection();//where connection first stated
        public frmLogin()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Students.accdb; Persist Security Info=False;";//this is the location fo the database
            try
            {
                connection.Open();
                lblConnect.Text = "Connection: Available";//this makes sure that a connection between the database and the progarm can occur
                connection.Close();
            }
            catch
            {
                lblConnect.Text = "Connection: Error";//if not it will show an error at the bottom
            }
            txtPass.PasswordChar = '*';//thi changes the password while typing to stars for security reasons
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try//in case of an error
            {
                connection.Open();//the next three line will be repeated often it makes the command that will b
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT FirstName,LastName,StuID,DOB FROM tblStudents WHERE UserName='" + txtUser.Text + "' AND Password = '" + txtPass.Text + "'";//this is the query that gets the things need using the info given by the user
                OleDbDataReader reader = command.ExecuteReader();//this reader will help find the values we are looking for
                                                                    //add if incorrect username or password
                int counter = 0;
                string first = "";
                string last = "";
                string DOB = "";
                int stuId = 0;

                while (reader.Read())
                {
                    counter++;
                    first = Convert.ToString(reader["FirstName"]);//this is get the firstname change it into a string and save it onto that variable
                    last = Convert.ToString(reader["LastName"]);
                    stuId = Convert.ToInt16(reader["StuID"]);
                    DOB = Convert.ToString(reader["DOB"]);
                }
                DOB = DOB.Substring(0, DOB.IndexOf(' '));//this is so that i only get the numbers because after teh date there is a space and then the time
                if (counter == 1)//this counter is used to make sure that there is only one person with the same username and password because or else we have a problem
                {
                    this.Hide();//this hides the form
                    if (txtUser.Text == "admin")//if the username is admin it will go the the admin form
                    {
                        MessageBox.Show("Welcome Admin ");

                        frmAdmin frmAdmin = new frmAdmin();
                        frmAdmin.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Welcome " + first + " " + last);
                        frmView frmView = new frmView(first, last, stuId, DOB);//this will take a student to the regular form and im also passing things in
                        frmView.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Error. Ask teacher");//need to ask the teacher beacuae no two people should have the same username and password
                }
                reader.Close();//need to cloe these so we can open them again later
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Username or/and Password invalid. Please try again.");//this is in case or any error
            }
            finally
            {
                connection.Close();//need to make ure the connection is closed even if it goes into the catch 
            }
        }

    }
}
