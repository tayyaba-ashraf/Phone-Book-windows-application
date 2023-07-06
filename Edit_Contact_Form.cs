using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PhoneBookWindowsApplication_VisualProject
{
    public partial class Edit_Contact_Form : Form
    {
        public Edit_Contact_Form()
        {
            InitializeComponent();
        }

        private void Edit_Contact_Form_Load(object sender, EventArgs e)
        {


            ViewGroupNameInComboEdit();
        }





        private void ViewGroupNameInComboEdit()
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            string query11 = "select GNAME from GROUPtableOne";
            SqlCommand cmd11 = new SqlCommand(query11, con);
            con.Open();
            SqlDataReader RD = cmd11.ExecuteReader();
            if (RD.HasRows == true)
            {
                while (RD.Read())
                {
                    Select_group_name.Items.Add(RD["GNAME"].ToString());

                }

            }

            else
            {
                MessageBox.Show(" GROUPNAMES HAVE NOT FOUND !!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close(); // this connection will have to close here
            }


        }

        // to show editForm 
        private void edit_contact_button_Click(object sender, EventArgs e)
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






                string query23 = " update CONTACTS set Fname=@Fname,Lname=@Lname,Phone=@Phone,Email=@Email,AddressContact=@AddressContact,Company=@Company,Country=@Country,Project=@Project ";
                SqlCommand cmd23 = new SqlCommand(query23, con);

               // cmd23.Parameters.AddWithValue("@id", contactId_text.Text);
                cmd23.Parameters.AddWithValue("@Fname", FName_text.Text);
                cmd23.Parameters.AddWithValue("@Lname", Lname_text.Text);
                cmd23.Parameters.AddWithValue("@Phone", Phone_text.Text);
                cmd23.Parameters.AddWithValue("@Email", Email_text.Text);
                cmd23.Parameters.AddWithValue("@AddressContact", address_text.Text);
                cmd23.Parameters.AddWithValue("@Company", company_text.Text);
                cmd23.Parameters.AddWithValue("@Country", country_text.Text);
                cmd23.Parameters.AddWithValue("@Project", project_text.Text);




                //now for execution of above written query

                // and ExecuteNonQuery command will use for execution of insert query and update
                con.Open();

                int a = cmd23.ExecuteNonQuery();
                if (a > 0)
                {

                    MessageBox.Show(" UPDATED SUCCESSFULLY !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindGridView();

                }
                else
                {
                    MessageBox.Show(" UPDATION FAILED !! ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }



            }


        }

    
            private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void Show_contacts_button_Click(object sender, EventArgs e)
        {
            bindGridView();
            
        }


        void bindGridView()
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            string query11 = "select * from CONTACTS";

            //we will pas this query to data adapter 
            //this will take data from database table

            SqlDataAdapter sda = new SqlDataAdapter(query11, con);

            // here we will use disconnected architecures.
            // so wewill use datatable class 
            // and no need to open and close connection
            //in datatable  data is in form of rows and colmns
            //so we will put data from sda in data object of data table
            DataTable data = new DataTable();
            sda.Fill(data);

            // now  we will pass this data into grid view using datasource property
            dataGridView1.DataSource = data;



        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //contactId_text.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();   
          //GroupId_text.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();   
          //Select_group_name.SelectedItem = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();   
          FName_text.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();   
          Lname_text.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();   
          Phone_text.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();   
         Email_text.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();   
         address_text.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();   
         company_text.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();   
         country_text.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();   
        project_text.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();   
        
        
        
        }
    }
}
