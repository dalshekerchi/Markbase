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
    public partial class frmCategories : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public double returnA;
        public frmCategories(string stuId, int markNum)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Students.accdb; Persist Security Info=False;";
            btnSave2.Visible = false;//diferent save buttons for differnt tasks
            lblStu.Text = stuId;//this is so it can be used as reference later
            lblMarkNum.Text = Convert.ToString(markNum);
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                if (markNum == 1)//gets all the makes from the tbltest1
                {
                    command.CommandText = "SELECT Knowledge, Application, Thinking, Communication FROM tblTest1 WHERE StuID=" + lblStu.Text;
                }
                else if (markNum == 2)//gets mark2 and so on
                {
                    command.CommandText = "SELECT Knowledge, Application, Thinking, Communication FROM tblTest2 WHERE StuID=" + lblStu.Text;
                }
                else if (markNum == 3)
                {
                    command.CommandText = "SELECT Knowledge, Application, Thinking, Communication FROM tblTest3 WHERE StuID=" + lblStu.Text;
                }
                else if (markNum == 4)
                {
                    command.CommandText = "SELECT Knowledge, Application, Thinking, Communication FROM tblTest4 WHERE StuID=" + lblStu.Text;
                }
                else if (markNum == 5)
                {
                    command.CommandText = "SELECT Knowledge, Application, Thinking, Communication FROM tblTest5 WHERE StuID=" + lblStu.Text;
                }
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())//displays them in the differnct textboxes
                {
                    txtKn.Text = Convert.ToString(reader["Knowledge"]);
                    txtApp.Text = Convert.ToString(reader["Application"]);
                    txtCom.Text = Convert.ToString(reader["Thinking"]);
                    txtTh.Text = Convert.ToString(reader["Communication"]);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            
            if (string.IsNullOrWhiteSpace(txtWK.Text))//if all of the weights are blank assume it 25%
            {
                txtWK.Text = Convert.ToString(25);
            }
            if (string.IsNullOrWhiteSpace(txtWT.Text))
            {
                txtWT.Text = Convert.ToString(25);
            }
            if (string.IsNullOrWhiteSpace(txtWC.Text))
            {
                txtWC.Text = Convert.ToString(25);
            }
            if (string.IsNullOrWhiteSpace(txtWA.Text))
            {
                txtWA.Text = Convert.ToString(25);
            }
            connection.Close();
        }
        public frmCategories(string stuId, string newStu,int markNum)//in a way this is one of the oop poli... it has the same name but does something different
        {
            InitializeComponent();
            lblStu.Text = stuId;
            lblMarkNum.Text = Convert.ToString(markNum);
            btnSave.Visible = false;//different save buttons for differnt tasks
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Valid mark = new Valid(Convert.ToInt16(txtKn.Text), Convert.ToInt16(txtApp.Text), Convert.ToInt16(txtTh.Text), Convert.ToInt16(txtCom.Text));//uses enpasulation to figure out if mark is valid or not
            if (mark.Mark == 0)
            {
                MessageBox.Show("Invalid Mark");
                connection.Close();
            }
            else
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "UPDATE tblTest1 SET Knowledge='" + txtKn.Text + "' ,Application='" + txtApp.Text + "' ,Thinking='" + txtCom.Text + "' ,Communication='" + txtTh.Text + "' where StuID=" + lblStu.Text + "";//update the data in the database
                command.CommandText = query;
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Edited");
                double average = weighting();
                if (average != -1)//this uses the method to check basically what -1 means is that the numbers dont add up to 100
                {
                    try
                    {
                        connection.Open();
                        command.Connection = connection;
                        int editMark = Convert.ToInt16(lblMarkNum.Text);
                        if (editMark == 1)//updating all the marks in the main mark book
                        {
                            command.CommandText = "UPDATE tblMarks SET Mark1=" + average + " where StuID =" + lblStu.Text + "";
                        }
                        else if (editMark == 2)
                        {
                            command.CommandText = "UPDATE tblMarks SET Mark2=" + average + " where StuID =" + lblStu.Text + "";
                        }
                        else if (editMark == 3)
                        {
                            command.CommandText = "UPDATE tblMarks SET Mark3=" + average + " where StuID =" + lblStu.Text + "";
                        }
                        else if (editMark == 4)
                        {
                            command.CommandText = "UPDATE tblMarks SET Mark4=" + average + " where StuID =" + lblStu.Text + "";
                        }
                        else if (editMark == 5)
                        {
                            command.CommandText = "UPDATE tblMarks SET Mark5=" + average + " where StuID =" + lblStu.Text + "";
                        }
                        command.ExecuteNonQuery();
                        connection.Close();

                        this.returnA = average;//passes it back fo it can be displayed instead of opening another connection
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Weightings do not equal 100");
                    connection.Close();
                }
                this.Close();
            }
           
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            Valid mark = new Valid(Convert.ToInt16(txtKn.Text), Convert.ToInt16(txtApp.Text), Convert.ToInt16(txtTh.Text), Convert.ToInt16(txtCom.Text));//same ass above
            if (mark.Mark == 0)
            {
                MessageBox.Show("Invalid Mark");
                connection.Close();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtKn.Text) || string.IsNullOrWhiteSpace(txtApp.Text) || string.IsNullOrWhiteSpace(txtCom.Text) || string.IsNullOrWhiteSpace(txtTh.Text))//makes sure all info is filled out
                {
                    MessageBox.Show("Not all information has been submitted. Please Try Again.");
                }
                else
                {
                    int count = 0;
                    int x;
                    if (int.TryParse(txtKn.Text, out x))//try parse all the info to make sure its the right type that is inputed
                    {
                        if (int.TryParse(txtApp.Text, out x))
                        {
                            if (int.TryParse(txtCom.Text, out x))
                            {
                                if (int.TryParse(txtTh.Text, out x))
                                {
                                    count = 1;
                                }
                            }
                        }
                    }
                    if (count == 0)
                    {
                        MessageBox.Show("Error is the data input");
                    }
                    if (count == 1)//if iit is then it will continue the code
                    {
                        try
                        {
                            connection.Close();
                            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Students.accdb; Persist Security Info=False;";
                            connection.Open();
                            OleDbCommand command = new OleDbCommand();
                            command.Connection = connection;
                            int markNum = Convert.ToInt16(lblMarkNum.Text);
                            if (markNum == 1)
                            {
                                command.CommandText = "INSERT into tblTest1 (StuID,Knowledge,Application,Thinking,Communication) values('" + lblStu.Text + "','" + txtKn.Text + "','" + txtApp.Text + "','" + txtCom.Text + "','" + txtTh.Text + "')";//this inserts all the info in the category
                            }
                            else if (markNum == 2)
                            {

                                command.CommandText = "INSERT into tblTest2 (StuID,Knowledge,Application,Thinking,Communication)values('" + lblStu.Text + "','" + txtKn.Text + "','" + txtApp.Text + "','" + txtCom.Text + "','" + txtTh.Text + "')";
                            }
                            else if (markNum == 3)
                            {
                                command.CommandText = "INSERT into tblTest3 (StuID,Knowledge,Application,Thinking,Communication) values('" + lblStu.Text + "','" + txtKn.Text + "','" + txtApp.Text + "','" + txtCom.Text + "','" + txtTh.Text + "')";
                            }
                            else if (markNum == 4)
                            {
                                command.CommandText = "INSERT into tblTest4 (StuID,Knowledge,Application,Thinking,Communication) values('" + lblStu.Text + "','" + txtKn.Text + "','" + txtApp.Text + "','" + txtCom.Text + "','" + txtTh.Text + "')";
                            }
                            else if (markNum == 5)
                            {
                                command.CommandText = "INSERT into tblTest5 (StuID,Knowledge,Application,Thinking,Communication) values('" + lblStu.Text + "','" + txtKn.Text + "','" + txtApp.Text + "','" + txtCom.Text + "','" + txtTh.Text + "')";
                            }
                            command.ExecuteNonQuery();
                            connection.Close();
                            if (weighting() != -1)
                            {
                                double average = weighting();
                                connection.Open();
                                if (markNum == 1)
                                {
                                    command.CommandText = "INSERT into tblMarks(StuID,Mark1) values('" + lblStu.Text + "','" + average + "')";//inserts the data so it can creat the row
                                }
                                if (markNum == 2)
                                {
                                    command.CommandText = "UPDATE tblMarks SET Mark2='" + average + "'where StuID=" + lblStu.Text + "";//then it updates it to avoid zerosing it out
                                }
                                else if (markNum == 3)
                                {
                                    command.CommandText = "UPDATE tblMarks SET Mark3='" + average + "'where StuID=" + lblStu.Text + "";
                                }
                                else if (markNum == 4)
                                {
                                    command.CommandText = "UPDATE tblMarks SET Mark4='" + average + "'where StuID=" + lblStu.Text + "";
                                }
                                else if (markNum == 5)
                                {
                                    command.CommandText = "UPDATE tblMarks SET Mark5='" + average + "'where StuID=" + lblStu.Text + "";
                                }

                                command.ExecuteNonQuery();
                                connection.Close();
                                this.returnA = weighting();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Weightings do not equal 100");
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Error");
                        }


                    }
                }
            }
        }
        public double weighting()
        {
            double average = -1;
            double wKn = Convert.ToDouble(txtWK.Text);//gets all the weightings
            double wApp = Convert.ToDouble(txtWA.Text);
            double wTh = Convert.ToDouble(txtWT.Text);
            double wCom = Convert.ToDouble(txtWC.Text);
            double check = Convert.ToDouble(txtWC.Text) + Convert.ToDouble(txtWK.Text) + Convert.ToDouble(txtWT.Text) + Convert.ToDouble(txtWA.Text);
            if (check == 100)//make sure that it all adds up to 100
            {
                average = ((Convert.ToDouble(txtKn.Text) * (wKn / 100)) + (Convert.ToDouble(txtApp.Text) * (wApp / 100)) + (Convert.ToDouble(txtCom.Text) * (wCom / 100)) + (Convert.ToDouble(txtTh.Text) * (wTh / 100)));//calcualates the averages
            }
            return average;
        }
    }
}
