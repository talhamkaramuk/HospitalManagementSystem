using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class Patient : Form
    {

        SqlConnection con = new SqlConnection("Data Source=CASPER;Initial Catalog=HospitalDatabase;Integrated Security=True;Pooling=False");

        int key = 0;

        public Patient()
        {
            InitializeComponent();
            DisplayRecords();
        }

        private void DisplayRecords()
        {
            con.Open();
            string query = "select * from PatientTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvPatients.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Clear()
        {
            tboxName.Text = "";
            tboxPhone.Text = "";
            dtpDOF.Text = "";
            tboxAddress.Text = "";
            tboxAllergies.Text = "";
            cboxGender.SelectedIndex = 0;
            key = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tboxName.Text == "" || dtpDOF.Text == "" || tboxPhone.Text == "" || tboxAddress.Text == "" || tboxAllergies.Text == "" || cboxGender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PatientTable (PatName, PatGender, PatDOB, PatAddress, PatPhone, PatAllergies) values (@pname, @pgender, @pdob, @paddress, @pphone, @pallergies)", con);
                    cmd.Parameters.AddWithValue("@pname", tboxName.Text);
                    cmd.Parameters.AddWithValue("@pgender", cboxGender.SelectedIndex);
                    cmd.Parameters.AddWithValue("@pdob", dtpDOF.Text);
                    cmd.Parameters.AddWithValue("@paddress", tboxAddress.Text);
                    cmd.Parameters.AddWithValue("@pphone", tboxPhone.Text);
                    cmd.Parameters.AddWithValue("@pallergies", tboxAllergies.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Added!");
                    con.Close();
                    DisplayRecords();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tboxName.Text == "" || dtpDOF.Text == "" || tboxPhone.Text == "" || tboxAddress.Text == "" || tboxAllergies.Text == "" || cboxGender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update PatientTable set PatName=@pname, PatGender=@pgender, PatDOB=@pdob, PatAddress=@paddress, PatPhone=@pphone, PatAllergies=@pallergies where PatID=@pkey", con);
                    cmd.Parameters.AddWithValue("@pname", tboxName.Text);
                    cmd.Parameters.AddWithValue("@pgender", cboxGender.Text);
                    cmd.Parameters.AddWithValue("@pdob", dtpDOF.Text);
                    cmd.Parameters.AddWithValue("@paddress", tboxAddress.Text);
                    cmd.Parameters.AddWithValue("@pphone", tboxPhone.Text);
                    cmd.Parameters.AddWithValue("@pallergies", tboxAllergies.Text);
                    cmd.Parameters.AddWithValue("@pkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated!");
                    con.Close();
                    DisplayRecords();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select a record to delete");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from PatientTable where PatID=@pkey", con);
                    cmd.Parameters.AddWithValue("@pkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted!");
                    con.Close();
                    DisplayRecords();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tboxName.Text = dgvPatients.SelectedRows[0].Cells[1].Value.ToString();
            cboxGender.SelectedItem = dgvPatients.SelectedRows[0].Cells[2].Value.ToString();
            dtpDOF.Text = dgvPatients.SelectedRows[0].Cells[3].Value.ToString();
            tboxAddress.Text = dgvPatients.SelectedRows[0].Cells[4].Value.ToString();
            tboxPhone.Text = dgvPatients.SelectedRows[0].Cells[5].Value.ToString();
            tboxAllergies.Text = dgvPatients.SelectedRows[0].Cells[6].Value.ToString();

            if (tboxName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
