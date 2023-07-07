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
    public partial class Remove_Contact_Form : Form
    {
        public Remove_Contact_Form()
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

        private void remove_contact_button_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(contactId_text.Text) == true)
            {
                contactId_text.Focus();
                errorProvider1.SetError(contactId_text, "PLEASE FILL contactId_text BOX");
            }

            else if (string.IsNullOrEmpty(GroupId_text.Text) == true)
            {
                GroupId_text.Focus();
                errorProvider2.SetError(GroupId_text, "PLEASE FILL GroupId_text BOX");
            }

            else if (Select_group_name.SelectedItem == null)
            {
                Select_group_name.Focus();
                errorProvider3.SetError(Select_group_name, "PLEASE FILL GroupName  ");
            }
            else if (string.IsNullOrEmpty(FName_text.Text) == true)
            {
                FName_text.Focus();
                errorProvider4.SetError(FName_text, "PLEASE FILL First name BOX");
            }
            else if (string.IsNullOrEmpty(Lname_text.Text) == true)
            {
                Lname_text.Focus();
                errorProvider5.SetError(Lname_text, "PLEASE FILL Last Name BOX");
            }
            else if (string.IsNullOrEmpty(Phone_text.Text) == true)
            {
                Phone_text.Focus();
                errorProvider6.SetError(Phone_text, "PLEASE FILL PHONE NUMBER BOX");
            }

            else if (string.IsNullOrEmpty(Email_text.Text) == true)
            {
                Email_text.Focus();
                errorProvider7.SetError(Email_text, "PLEASE FILL EMAIL BOX");
            }

            else if (string.IsNullOrEmpty(address_text.Text) == true)
            {
                address_text.Focus();
                errorProvider8.SetError(address_text, "PLEASE FILL ADDRRESS BOX");
            }

            else if (string.IsNullOrEmpty(company_text.Text) == true)
            {
                company_text.Focus();
                errorProvider9.SetError(company_text, "PLEASE FILL COMPANY NAME BOX");
            }

            else if (string.IsNullOrEmpty(project_text.Text) == true)
            {
                project_text.Focus();
                errorProvider10.SetError(project_text, "PLEASE FILL PROJECT NAME BOX");
            }
            else if (string.IsNullOrEmpty(country_text.Text) == true)
            {
                country_text.Focus();
                errorProvider11.SetError(country_text, "PLEASE FILL COUNTRY NAME BOX");
            }

            else
            {




                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);






                string query23 = " delete from CONTACTS  where ContactId=@id ";
                SqlCommand cmd23 = new SqlCommand(query23, con);

                cmd23.Parameters.AddWithValue("@id", contactId_text.Text);





                //now for execution of above written query

                // and ExecuteNonQuery command will use for execution of insert query and update
                con.Open();

                int a = cmd23.ExecuteNonQuery();
                if (a > 0)
                {

                    MessageBox.Show(" DELETED SUCCESSFULLY !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindGridView();



                }
                else
                {
                    MessageBox.Show(" DELETION FAILED !! ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }


            }

        }

    


        

        private void Show_contacts_button_Click(object sender, EventArgs e)
        {
            bindGridView();
        }


        void bindGridView()
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            string query12 = "select * from CONTACTS";

            //we will pas this query to data adapter 
            //this will take data from database table

            SqlDataAdapter sda = new SqlDataAdapter(query12, con);

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
            GroupId_text.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Select_group_name.SelectedItem = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            FName_text.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Lname_text.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Phone_text.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            Email_text.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            address_text.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            company_text.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            country_text.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            project_text.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void Remove_Contact_Form_Load(object sender, EventArgs e)
        {
            ViewGroupName();
        }


        private void ViewGroupName()
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            string query44 = "select GNAME from GROUPtableOne";
            SqlCommand cmd33 = new SqlCommand(query44, con);
            con.Open();
            SqlDataReader rd33 = cmd33.ExecuteReader();
            if (rd33.HasRows == true)
            {
                while (rd33.Read())
                {
                    Select_group_name.Items.Add(rd33["GNAME"].ToString());
                   
                }

            }

            else
            {
                MessageBox.Show(" GROUPNAMES HAVE NOT FOUND !!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close(); // this connection will have to close here
            }


        }

    }
}

