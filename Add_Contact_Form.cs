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
    public partial class Add_Contact_Form : Form
    {
        public Add_Contact_Form()
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


        private void ViewGroupNameInCombo()
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            string query10 = "select GNAME from GROUPtableOne";
            SqlCommand cmd10 = new SqlCommand(query10, con);
            con.Open();
            SqlDataReader rdr = cmd10.ExecuteReader();
            if (rdr.HasRows == true)
            {
                while (rdr.Read())
                {
                    Select_group_name.Items.Add(rdr["GNAME"].ToString());

                }

            }

            else
            {
                MessageBox.Show(" GROUPNAMES HAVE NOT FOUND !!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close(); // this connection will have to close here
            }


        }








        private void add_contact_button_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(contactId_text.Text) == true)
            {
                contactId_text.Focus();
                errorProvider1.SetError(this.contactId_text, "Please Fill the text Box");

            }
            else if (string.IsNullOrEmpty(GroupId_text.Text) == true)
            {
                GroupId_text.Focus();
                errorProvider2.SetError(this.GroupId_text, "Please Fill the text Box");

            }
            else if (Select_group_name.SelectedItem == null)
            {
                Select_group_name.Focus();
                errorProvider3.SetError(this.Select_group_name, "Please Fill the text Box");

            }
            else if (string.IsNullOrEmpty(FName_text.Text) == true)
            {
                FName_text.Focus();
                errorProvider4.SetError(this.FName_text, "Please Fill the text Box");

            }
            else if (string.IsNullOrEmpty(Lname_text.Text) == true)
            {
                Lname_text.Focus();
                errorProvider5.SetError(this.Lname_text, "Please Fill the text Box");

            }

            else if (string.IsNullOrEmpty(Phone_text.Text) == true)
            {
                Phone_text.Focus();
                errorProvider6.SetError(this.Phone_text, "Please Fill the text Box");

            }
            else if (string.IsNullOrEmpty(Email_text.Text) == true)
            {
                Email_text.Focus();
                errorProvider7.SetError(this.Email_text, "Please Fill the text Box");

            }
            else if (string.IsNullOrEmpty(address_text.Text) == true)
            {
                address_text.Focus();
                errorProvider8.SetError(this.address_text, "Please Fill the text Box");

            }
            else if (string.IsNullOrEmpty(company_text.Text) == true)
            {
                company_text.Focus();
                errorProvider9.SetError(this.company_text, "Please Fill the text Box");

            }
            else if (string.IsNullOrEmpty(project_text.Text) == true)
            {
                project_text.Focus();
                errorProvider10.SetError(this.project_text, "Please Fill the text Box");

            }
            else if (string.IsNullOrEmpty(country_text.Text) == true)
            {
                country_text.Focus();
                errorProvider11.SetError(this.country_text, "Please Fill the text Box");

            }
            else
            {

                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);


                string query2 = "insert into CONTACTS values(@groupId,@ContactId,@gname,@Fname,@Lname,@Phone,@Email,@AddressContact,@Company,@Country,@Project) ";
                SqlCommand cmd1 = new SqlCommand(query2, con);

                // if enterd data is not entering  exeisting groupid and gname
                //then all below data of row will insert


                // these values are passed coulmn wise



                cmd1.Parameters.AddWithValue("@groupId", GroupId_text.Text);
                cmd1.Parameters.AddWithValue("@ContactId", contactId_text.Text);
                cmd1.Parameters.AddWithValue("@gname", Select_group_name.SelectedItem);
                cmd1.Parameters.AddWithValue("@Fname", FName_text.Text);
                cmd1.Parameters.AddWithValue("@Lname", Lname_text.Text);
                cmd1.Parameters.AddWithValue("@Phone", Phone_text.Text);
                cmd1.Parameters.AddWithValue("@Email", Email_text.Text);
                cmd1.Parameters.AddWithValue("@AddressContact", address_text.Text);
                cmd1.Parameters.AddWithValue("@Company", company_text.Text);
                cmd1.Parameters.AddWithValue("@Project", project_text.Text);
                cmd1.Parameters.AddWithValue("@Country", country_text.Text);


                //now for execution of above written query
                //connection with database should open newly
                // and ExecuteNonQuery command will use for execution of insert query
                con.Open();

                int a = cmd1.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show(" CONTACTS RECORD INSERTED Successfully !!", "CONTACT INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                else
                {

                    MessageBox.Show(" CONTACTS RECORD INSERTION FAILED !!", "FAILURE INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close(); // this connection will have to close here
                }
            }

        }


        private void Add_Contact_Form_Load(object sender, EventArgs e)
        {
            ViewGroupNameInCombo();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void contactId_text_TextChanged(object sender, EventArgs e)
        {

        }
    }


} 

