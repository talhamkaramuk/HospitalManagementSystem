using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class Home : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CASPER;Initial Catalog=HospitalDatabase;Integrated Security=True;Pooling=False");

        public Home()
        {
            InitializeComponent();
            if (Login.Role == "Receptionist")
            {
                btnDoctors.Enabled = false;
                btnLabTests.Enabled = false;
                btnReception.Enabled = false;
            }
            CountPatients();
            CountDoctors();
            CountTest();
        }

        private void CountPatients()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from PatientTable", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lblPatCount.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void CountDoctors()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from DoctorTable", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lblDocCount.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void CountTest()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from TestTable", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lblLabTestsCount.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            Patient frm = new Patient();
            frm.Show();
            this.Hide();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            Doctor frm = new Doctor();
            frm.Show();
            this.Hide();
        }

        private void btnLabTests_Click(object sender, EventArgs e)
        {
            LabTests frm = new LabTests();
            frm.Show();
            this.Hide();
        }

        private void btnReception_Click(object sender, EventArgs e)
        {
            Reception frm = new Reception();
            frm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
