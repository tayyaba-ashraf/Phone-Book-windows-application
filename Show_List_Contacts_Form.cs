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
    public partial class Show_List_Contacts_Form : Form
    {
        public Show_List_Contacts_Form()
        {
            InitializeComponent();
        }

        private void Select_group_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Show_List_Contacts_Form_Load(object sender, EventArgs e)
        {
            
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
    }
}
