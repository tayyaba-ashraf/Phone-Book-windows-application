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
using System.Data.SqlClient;// namespace for database usage classes

namespace PhoneBookWindowsApplication_VisualProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void password_label_Click(object sender, EventArgs e)
        {

        }

        // following event is to show password characters 
        private void password_checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = password_checkBox1.Checked;
            switch (check)
            {
                case true:

                    Password_text.UseSystemPasswordChar = false; // characters will  show if checked is done
                    break;

                default:
                    // default case obviusoly is of false option 
                    Password_text.UseSystemPasswordChar = true; // characters will not show if checked is not done
                    break;

            }
        }

        // when this lable will clicked sign up form will show
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // when we will run firstly login page will show
            // if we have not account yet
            //then we will clik on label 
            //sign up form will shown
            //login will hidden

            this.Hide();   // here this pointing login form
            SignUp sign = new SignUp();
           
               sign.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        //login button functionality
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Email_text.Text) == true)
            {

                Email_text.Focus();
                errorProvider1.SetError(this.Email_text, "Please Fill the email text Box");
            }

            else if (string.IsNullOrEmpty(Password_text.Text) == true)
            {

                Password_text.Focus();
                errorProvider2.SetError(this.Password_text, "Please Fill the passsword text Box");
            }

            else if (string.IsNullOrEmpty(UserName_text.Text) == true)
            {

                UserName_text.Focus();
                errorProvider3.SetError(this.UserName_text, "Please Fill the username text Box");
            }
            else
            {







                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);

                //validation if we enter data into database on same id
                //because exception occurs if insert data on same id 



                //select query
                //@email and @pass @username parameter is for receiving value from email and password  text box
                //then will transfer data to column name of database table for matching

                string query22 = "select * from signuptable where email=@email and pass=@pass and username=@username";

                //this will get value from ID_text textbox

                SqlCommand cmd22 = new SqlCommand(query22, con);
                cmd22.Parameters.AddWithValue("@email", Email_text.Text);
                cmd22.Parameters.AddWithValue("@pass", Password_text.Text);
                cmd22.Parameters.AddWithValue("@username", UserName_text.Text);

                //now to execute query connection opening
                con.Open();

                //now smd2 will read data from text boxex 
                //means itb has rows having coulmns email,username,password
                //then it will return 1 to dataRd

                SqlDataReader dataRd = cmd22.ExecuteReader();

                DataTable table = new DataTable();//for database table usage refrence

                if (dataRd.HasRows == true)
                {
                    // means this will show that account of user has already formed 
                    //he has no need to signup
                    //he can login now

                    MessageBox.Show(" LOGIN SUCCESSFULLY !!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);





                    //now when login will successfull then Main Form will display
                    this.DialogResult = DialogResult.OK;


                }
                else
                {
                    MessageBox.Show(" LOGIN FAILED !!", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }

               
            }

            
        }
    }
}
