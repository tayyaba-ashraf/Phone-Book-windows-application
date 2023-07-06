using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;  // namespace of refrence system.configuration for connection with database
using System.Data.SqlClient;

namespace PhoneBookWindowsApplication_VisualProject
{
    public partial class Edit_User_Data_Form : Form
    {
        public Edit_User_Data_Form()
        {
            InitializeComponent();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID_text.Text) == true)
            {
                ID_text.Focus();
                errorProvider1.SetError(this.ID_text, "Please Fill the ID !!");

            }
            else if (string.IsNullOrEmpty(FName_text.Text) == true)
            {
                FName_text.Focus();
                errorProvider2.SetError(this.FName_text, "Please Fill the First Name !!");

            }
            else if (string.IsNullOrEmpty(Email_text.Text) == true)
            {
                Email_text.Focus();
                errorProvider3.SetError(this.Email_text, "Please Fill the EMAIL !!");

            }
            else if (string.IsNullOrEmpty(UName_text.Text) == true)
            {
                UName_text.Focus();
                errorProvider4.SetError(this.UName_text, "Please Fill the USERNAME !!");

            }
            else if (string.IsNullOrEmpty(password_text.Text) == true)
            {
                password_text.Focus();
                errorProvider5.SetError(this.password_text, "Please Fill the PASSWORD!!");

            }
         

            else
            {

                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);


                string query = "select * from signuptable where USERID=@userId";
                //@userId Parameter name is used 
                //this will get value from ID_text textbox

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userId", ID_text.Text);

                //we will newly open and close connection for select query execution

                con.Open();
                //ExecuteReader commnad is used for execution slect query
                //    SqlDataReader will read row from database table

                SqlDataReader Rd = cmd.ExecuteReader();
                if (Rd.HasRows == true)
                {
                    con.Close();


                    string query2 = " update  signuptable set Fname=@fname,Email=@email,username=@username,pass=@pass where USERID=@userId";
                    SqlCommand cmd2 = new SqlCommand(query2, con);


                    // if enterd data is not entering on already exeisting id
                    //then all below data of row will insert


                    // these values are passed coulmn wise

                    cmd2.Parameters.AddWithValue("@userId", ID_text.Text);
                    cmd2.Parameters.AddWithValue("@fname", FName_text.Text);
                    cmd2.Parameters.AddWithValue("@email", Email_text.Text);
                    cmd2.Parameters.AddWithValue("@username", UName_text.Text);
                    cmd2.Parameters.AddWithValue("@pass", password_text.Text);




                    //now for execution of above written query
                    //connection with database should open newly
                    // and ExecuteNonQuery command will use for execution of insert query and update

                    con.Open();

                    int a = cmd2.ExecuteNonQuery();
                    if (a > 0)
                    {



                        MessageBox.Show(" EDITED SUCCESSFULLY !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(" EDITED FAILED !! ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //close connection opend for execution of insert query

                    con.Close();
                }

                /* private void label2_Click(object sender, EventArgs e)
                 {

                 }*/

            }

        }

        private void ID_text_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}

