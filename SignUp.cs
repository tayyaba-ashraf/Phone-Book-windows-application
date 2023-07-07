using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; //for using experssion checking related classes
using System.Configuration;  // namespace of refrence system.configuration for connection with database
using System.Data.SqlClient;// namespace for database usage classes

namespace PhoneBookWindowsApplication_VisualProject
{
    public partial class SignUp : Form
    {

        string pattren = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        string passpattren = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(Submit_button, "Submit data to register yourself");

            toolTip2.ShowAlways = true;
            toolTip2.SetToolTip(Reset_button, " Reset Data ");

            toolTip3.ShowAlways = true;
            toolTip3.SetToolTip(PicBrowser_button, " Click for brwosing te picture ");



            toolTip2.ShowAlways = true;
            toolTip2.SetToolTip(Reset_button, " Reset Data ");


            toolTip3.ShowAlways = true;
            toolTip3.SetToolTip(ID_text, " Enter UserID ");

            toolTip4.ShowAlways = true;
            toolTip4.SetToolTip(FName_text, "Enter Your First Name");

            toolTip5.ShowAlways = true;
            toolTip5.SetToolTip(LName_text, "Enter Your Last Name");

            toolTip6.ShowAlways = true;
            toolTip6.SetToolTip(UName_text, "Enter   UserName");

            toolTip7.ShowAlways = true;
            toolTip7.SetToolTip(Email_text, "Enter Your Email");

            toolTip8.ShowAlways = true;
            toolTip8.SetToolTip(Gender_combo, "Select Gender ");

            toolTip9.ShowAlways = true;
            toolTip9.SetToolTip(password_text, "Enter Your Password ");

            toolTip10.ShowAlways = true;
            toolTip10.SetToolTip(CPassword_text, "Re-enter Your Password for Confirmation ");

            toolTip11.ShowAlways = true;
            toolTip11.SetToolTip(PicBrowser_button, "Picture Browser Button ");




        }

        // validation applying in case of empty text box
        private void ID_text_Leave(object sender, EventArgs e)
        {
            // if tab is pressed without filling text box 
            //then error msg will show
            if (string.IsNullOrEmpty(ID_text.Text) == true)
            {
                ID_text.Focus();
                errorProvider1.SetError(this.ID_text, "Please Fill the text Box");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        // it takes key from keyboard
        // validation for picking only digit for user id
        private void ID_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e takes key
            Char ch = e.KeyChar;
            if (Char.IsDigit(ch) == true)
            {
                // handle property will allow to enter char in digit form
                e.Handled = false;
            }
            else if (ch == 8) // back space is also allowed
            {
                e.Handled = false;
            }
            else // otherwise handle prperty will restrict 
            {
                e.Handled = true;
            }

        }
        // validation to restrict empty text box
        private void FName_text_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FName_text.Text) == true)
            {
                FName_text.Focus();
                errorProvider2.SetError(this.FName_text, "Please Fill the First Name !!");

            }
            else
            {
                errorProvider2.Clear();
            }
        }

        // validation for picking chracter,back space ,space
       private void FName_text_KeyPress(object sender, KeyPressEventArgs e)
        {

            // e takes key
            Char ch = e.KeyChar;
            if (Char.IsLetter(ch) == true)
            {
                // handle property will allow to enter char 
                //it will  not restrict
                e.Handled = false;
            }
            else if (ch == 8)  // back space is also allowed
            {
                e.Handled = false;
            }
            else if (ch == 32) // space is also allowed
            {
                e.Handled = false;
            }
            
            else // otherwise handle prperty will restrict 
            {
                e.Handled = true;
            }

        }


        private void SignUp_picBox_Click(object sender, EventArgs e)
        {

        }

        private void LName_text_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LName_text.Text) == true)
            {
                LName_text.Focus();
                errorProvider3.SetError(this.LName_text, "Please Fill the Last Name !!");

            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void LName_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e takes key
            Char ch = e.KeyChar;
            if (Char.IsLetter(ch) == true)
            {
                // handle property will allow to enter char 
                //it will  not restrict
                e.Handled = false;
            }
            else if (ch == 8)  // back space is also allowed
            {
                e.Handled = false;
            }
            else if (ch == 32) // space is also allowed
            {
                e.Handled = false;
            }

            else // otherwise handle prperty will restrict 
            {
                e.Handled = true;
            }

        }

        private void Gender_combo_Leave(object sender, EventArgs e)
        {
            if(Gender_combo.SelectedItem==null)
            {
                Gender_combo.Focus();
                errorProvider4.SetError(this.Gender_combo,"Please fill Gender");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        //validation for correct email pattren
        //Regex is class RegularExpression namespace
        private void Email_text_Leave(object sender, EventArgs e)
        {
            // if enterd email in text box is not matcing with pattren 
            //then obviusoly will return false
            if(Regex.IsMatch(Email_text.Text,pattren)==false)
            {
                Email_text.Focus();
                errorProvider5.SetError(this.Email_text, " Invalid Email !! ");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void UName_text_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(UName_text.Text)==true)
            {
                UName_text.Focus();
                errorProvider8.SetError(this.UName_text,"Please Enter UserName !!");

            }
            else
            {
                errorProvider8.Clear();
            }

        }


        private void UName_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e takes key
            Char ch = e.KeyChar;
            if (Char.IsLetter(ch) == true)
            {
                // handle property will allow to enter char 
                //it will  not restrict
                e.Handled = false;
            }
            else if (Char.IsDigit(ch) == true)
            {
                // handle property will allow to enter char 
                //in digit form and will not restrict
                e.Handled = false;
            }
            else if(ch == 64) //@ special charcter is allowed
            {
                e.Handled = false;

            }
            else if (ch == 8)  // back space is also allowed
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void password_text_Leave(object sender, EventArgs e)
        {
            // if enterd password in text box is not matcing with pattren 
            //then obviusoly will return false
            if (Regex.IsMatch(password_text.Text, passpattren) == false)
            {
                password_text.Focus();
                // this hint message will help user to enter password
                //while considerring these reqiuremts 
                errorProvider6.SetError(this.password_text, "Upercase , Lowercase , Numbers , Symbols");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        //cinfirmation password validation 
        private void CPassword_text_Leave(object sender, EventArgs e)
        {
            if(password_text.Text!=CPassword_text.Text)
            {
                CPassword_text.Focus();
                errorProvider7.SetError(this.CPassword_text, "Password is not identical !!");
            }
            else
            {
                errorProvider7.Clear();
            }


        }

        private void OpenPicbutton_Click(object sender, EventArgs e)
        {
            SignUp_picBox.Visible = true;
        }

        // validation of all text boxes selction will also applicable
        //on submit button beacuse if we enter submit without selecting text boxes
        //what would there for submit


        private void Submit_button_Click(object sender, EventArgs e)
        {
            
            
          
            // if tab is pressed without filling text box 
            //then error msg will show



            if (string.IsNullOrEmpty(ID_text.Text) == true)
            {
                ID_text.Focus();
                errorProvider1.SetError(this.ID_text, "Please Fill the text Box");

            }


            else if (string.IsNullOrEmpty(FName_text.Text) == true)
            {
                FName_text.Focus();
                errorProvider2.SetError(this.FName_text, "Please Fill the First Name !!");

            }


            else if (string.IsNullOrEmpty(LName_text.Text) == true)
            {
                LName_text.Focus();
                errorProvider3.SetError(this.LName_text, "Please Fill the Last Name !!");

            }


            else if (Gender_combo.SelectedItem == null)
            {
                Gender_combo.Focus();
                errorProvider4.SetError(this.Gender_combo, "Please fill Gender");
            }


            // if enterd email in text box is not matcing with pattren 
            //then obviusoly will return false


            else if (Regex.IsMatch(Email_text.Text, pattren) == false)
            {
                Email_text.Focus();
                errorProvider5.SetError(this.Email_text, " Invalid Email !! ");
            }


            else if (string.IsNullOrEmpty(UName_text.Text) == true)
            {
                UName_text.Focus();
                errorProvider8.SetError(this.UName_text, "Please Enter UserName !!");

            }


            // if enterd password in text box is not matcing with pattren 
            //then obviusoly will return false


            else if (Regex.IsMatch(password_text.Text, passpattren) == false)
            {
                password_text.Focus();
                // this hint message will help user to enter password
                //while considerring these reqiuremts 
                errorProvider6.SetError(this.password_text, "Upercase , Lowercase , Numbers , Symbols");
            }


            else if (password_text.Text != CPassword_text.Text)
            {
                CPassword_text.Focus();
                errorProvider7.SetError(this.CPassword_text, "Password is not identical !!");
            }


            else
            {
                // here coding     will for inserting data in database
                //when all above validation is done then data will submit

                //this below written line will store connection for database whic we
                //have created in app.config file by named as dbcs
               
                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);

                //validation if we enter data into database on same id
                //because exception occurs if insert data on same id 



                //select query

                string query1 = "select * from signuptable where USERID=@userId";
                
                //@userId Parameter name is used 
                //this will get value from ID_text textbox

                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.Parameters.AddWithValue("@userId", ID_text.Text);

                //we will newly open and close connection for select query execution

                con.Open();
                //ExecuteReader commnad is used for execution slect query
                //    SqlDataReader will read row from database table

                SqlDataReader Rd1 = cmd1.ExecuteReader();
                if (Rd1.HasRows == true)
                {
                    MessageBox.Show(ID_text.Text + " UserID already exists !! ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close(); // this connection will have to close here
                }
               

                else
                {
                    //if above condtion is not executed then we have to must close
                    //above opened connection for select query execution

                    con.Close();



                    // query for insert data into database 
                    // insert keyword
                    //values keyword
                    //cmd object is used as command to get paramters values 
                    //@ id,@fname...so on...
                    // firstly query and con are passed as paramters
                    // then statements are written to store values into cmd object
                    //by taking values from textboxes of form


                    string query2 = "insert into signuptable values(@userId,@fname,@lname,@gender,@email,@username,@pass)";
                 SqlCommand cmd2 = new SqlCommand(query2, con);


                
                
               
                     // if enterd data is not entering on already exeisting id
                    //then all below data of row will insert
                    

                    // these values are passed coulmn wise
                    cmd2.Parameters.AddWithValue("@userId", ID_text.Text);
                    cmd2.Parameters.AddWithValue("@fname", FName_text.Text);
                    cmd2.Parameters.AddWithValue("@lname", LName_text.Text);
                    cmd2.Parameters.AddWithValue("@gender", Gender_combo.SelectedItem);
                    cmd2.Parameters.AddWithValue("@email", Email_text.Text);
                    cmd2.Parameters.AddWithValue("@username", UName_text.Text);
                    cmd2.Parameters.AddWithValue("@pass", password_text.Text);



                    //now for execution of above written query
                    //connection with database should open newly
                    // and ExecuteNonQuery method will use for execution of insert query
                    //if 1 row means enterd row is inserted successfully then it will return 1
                    con.Open();

                    int a = cmd2.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show(" Registered Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // to show what email,username,password we have entered
                        
                        MessageBox.Show(" Your Email is !!" + Email_text.Text + "\n\n" + "your password is !!" + password_text.Text+"\n\n"+ "your UserName  is !! "+ UName_text.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        // now after completion of sign up
                        // to hide sign up to show login form

                        this.Hide(); // this pointing to signup
                        Login page = new Login();
                        page.ShowDialog();


                            

                    }
                    else
                    {
                        MessageBox.Show(" Registeration Failed !! ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    }

                    //close connection opend for execution of insert query

                   


                }

            }

        }

        private void PicBrowser_button_Click(object sender, EventArgs e)
        {
            //select and display image in the picture box
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";



            if (opf.ShowDialog() == DialogResult.OK)
            {
                SignUp_picBox.Image = Image.FromFile(opf.FileName);

            }


        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            ID_text.Clear();
            FName_text.Clear();
            LName_text.Clear();
            Gender_combo.SelectedItem = null;
            Email_text.Clear();
            UName_text.Clear();
            password_text.Clear();
            CPassword_text.Clear();
;
        }

        private void Gender_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
