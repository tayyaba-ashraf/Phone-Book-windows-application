using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace PhoneBookWindowsApplication_VisualProject
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // for closing Main Form
        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
            ViewGroupName();

        }

        // when MainForm will load and we clik on label 
        //userdataform will show

        private void UserEditDatalabel_Click(object sender, EventArgs e)
        {
            Edit_User_Data_Form userdataform = new Edit_User_Data_Form();

            userdataform.Show(this);
        }

        //GruopClass Gobj = new GruopClass();
        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(ID_text.Text) == true)
            {
                ID_text.Focus();
                errorProvider1.SetError(ID_text, "PLEASE FILL THE ID TEXT BOX !!");
            }

            else if (string.IsNullOrEmpty(Group_text.Text) == true)
            {
                Group_text.Focus();
                errorProvider2.SetError(Group_text, "PLEASE FILL THE GROUP NAME TEXT BOX !!");
            }
            else
            {











                //Create grouptable in database

                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);


                string query2 = "select * from GROUPtableOne where GROUPID=@groupId";
                //@userId Parameter name is used 
                //this will get value from Group_text textbox

                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@groupId", Group_text.Text);


                con.Open();
                //ExecuteReader commnad is used for execution slect query
                //    SqlDataReader will read row from database table

                SqlDataReader Rd = cmd2.ExecuteReader();
                if (Rd.HasRows == true)
                {
                    MessageBox.Show(ID_text.Text + " GroupID already  exists !! ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(ID_text.Text + " ENTER ANOTHER GROUPID!! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close(); // this connection will have to close here
                }
                else
                {
                    con.Close();


                    string query = "insert into GROUPtableOne values(@GroupId,@group)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // if enterd data is not entering on already exeisting groupid
                    //then all below data of row will insert


                    // these values are passed coulmn wise
                    cmd.Parameters.AddWithValue("@GroupId", ID_text.Text);
                    cmd.Parameters.AddWithValue("@group", Group_text.Text);


                    //now for execution of above written query
                    //connection with database should open newly
                    // and ExecuteNonQuery command will use for execution of insert query


                    con.Open();

                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show(" GROUPNAME INSERTED Successfully !!", "GROUP", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // to show what email,username,password we have entered

                        MessageBox.Show(" Your GROUP is !!" + Group_text.Text);
                        ViewGroupName();
                    }

                    else
                    {
                        MessageBox.Show(" GROUPNAME ALREADY EXISTS !!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    con.Close();


                }



            }


        }



        private void ViewGroupName()
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            string query44 = "select GNAME from GROUPtableOne";
            SqlCommand cmd33 = new SqlCommand(query44, con);
            con.Open();
            SqlDataReader rd1 = cmd33.ExecuteReader();
            if (rd1.HasRows == true)
            {
                while (rd1.Read())
                {
                    Select_combo_items.Items.Add(rd1["GNAME"].ToString());
                    Delete_combo.Items.Add(rd1["GNAME"].ToString());
                }

            }

           
            // this connection will have to close here
            con.Close();

        }







        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void label4_Click(object sender, EventArgs e)
        { }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UpdateId_textBox.Text) == true)
            {
                UpdateId_textBox.Focus();
                errorProvider3.SetError(UpdateId_textBox, "PLEASE FILL ID FOR UPDATION  !! ");
            }


            else if (Select_combo_items.SelectedItem == null)
            {
                Select_combo_items.Focus();
                errorProvider4.SetError(Select_combo_items, "PLEASE FILL GROUP NAME !! ");
            }
            else if (string.IsNullOrEmpty(Name_text.Text) == true)
            {
                Name_text.Focus();
                errorProvider5.SetError(Name_text, "PLEASE FILL GROUP NAME FOR UPDATION  !! ");
            }

            else
            {

                string newGroupName = Name_text.Text;
                Select_combo_items.SelectedItem = newGroupName;

                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);


                string query = "select * from GROUPtableOne where GROUPID=@groupId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@groupId", UpdateId_textBox.Text);


                //we will newly open and close connection for select query execution

                con.Open();



                SqlDataReader Rd = cmd.ExecuteReader();
                if (Rd.HasRows == true)
                {
                    con.Close();


                    string query2 = " update  GROUPtableOne set GNAME=@gname ";
                    SqlCommand cmd2 = new SqlCommand(query2, con);


                    // if enterd data is not entering on already exeisting id
                    //then all below colmn data will insert for updation


                    cmd2.Parameters.AddWithValue("@gname", Select_combo_items.SelectedItem);





                    //now for execution of above written query
                    //connection with database should open newly
                    // and ExecuteNonQuery command will use for execution of insert query and update
                    con.Open();

                    int a = cmd2.ExecuteNonQuery();
                    if (a > 0)
                    {

                        MessageBox.Show(" EDITED SUCCESSFULLY !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ViewGroupName();
                    }
                    else
                    {
                        MessageBox.Show(" EDITED FAILED !! ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    con.Close();

                }
                else
                {
                    MessageBox.Show(" ID not found !! ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }


            }

        }

        private void Select_combo_items_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {


            if (Delete_combo.SelectedItem == null)
            {
                Delete_combo.Focus();
                errorProvider7.SetError(Delete_combo, "PLEASE FILL GROUP NAME FOR DELETION");
            }

            else 
            {

                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);


                string query = "select * from GROUPtableOne where GNAME=@gname";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@gname", Delete_combo.SelectedItem);

                //we will  open and close connection for select query execution

                con.Open();
                

                SqlDataReader Rd = cmd.ExecuteReader();
                if (Rd.HasRows == true)
                {
                    con.Close();


                    string query2 = " delete from  GROUPtableOne where GNAME=@gname";
                    SqlCommand cmd2 = new SqlCommand(query2, con);


                    cmd2.Parameters.AddWithValue("@gname", Delete_combo.SelectedItem);




                    //now for execution of above written query
                    //connection with database should open newly
                    // and ExecuteNonQuery command will use for execution of insert query and update and delete

                    con.Open();

                    int a = cmd2.ExecuteNonQuery();
                    if (a > 0)
                    {



                        MessageBox.Show(" Deleted SUCCESSFULLY !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Delete_combo.Items.RemoveAt(Delete_combo.SelectedIndex);
                        
                        //ViewGroupName();

                    }
                    else
                    {
                        MessageBox.Show(" Deletion FAILED !! ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        con.Close();
                    }

                }

                else
                {



                    MessageBox.Show("  GROUP NOT FOUND !! ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                }
                

               
            }
        }






   

        private void add_contact_button_Click(object sender, EventArgs e)
        {
            //show add contact form
            Add_Contact_Form addcontactform = new Add_Contact_Form();
            addcontactform.Show(this);


        }

        private void EDIT_contatct_button_Click(object sender, EventArgs e)
        {
            //show edit contact form

            Edit_Contact_Form editcontactform = new Edit_Contact_Form();
            editcontactform.Show(this);
        }

        private void Remove_contact_button_Click(object sender, EventArgs e)
        {
            Remove_Contact_Form removecontactform = new Remove_Contact_Form();
            removecontactform.Show(this);
        }

        private void full_contact_list_button_Click(object sender, EventArgs e)
        {
            Show_List_Contacts_Form listcontactform = new Show_List_Contacts_Form();
            listcontactform.Show(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

        



        /*public void displayUsername()
         {
             Login obj = new Login();
             string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
             SqlConnection con = new SqlConnection(cs);

             //validation if we enter data into database on same id
             string query = "select * from signuptable where userid=@id";





             SqlDataAdapter adapter = new SqlDataAdapter();

             DataTable table = new DataTable();

             SqlCommand cmd = new SqlCommand(query, con);


         }*/
    
