using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class Doctor : Form
    {

        SqlConnection con = new SqlConnection("Data Source=CASPER;Initial Catalog=HospitalDatabase;Integrated Security=True;Pooling=False");

        int key = 0;

        public Doctor()
        {
            InitializeComponent();
            DisplayRecords();
        }

        private void DisplayRecords()
        {
            con.Open();
            string query = "select * from DoctorTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvDoctors.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Clear()
        {
            tboxName.Text = "";
            tboxPhone.Text = "";
            tboxPassword.Text = "";
            tboxAddress.Text = "";
            cboxGender.SelectedIndex = 0;
            cboxProfession.SelectedIndex = 0;
            key = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tboxName.Text == "" || tboxPassword.Text == "" || tboxPhone.Text == "" || tboxAddress.Text == "" || dtpDOF.Text == "" || cboxGender.SelectedIndex == -1 || cboxProfession.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DoctorTable (DocName, DocDOB, DocGender, DocProfession, DocPhone, DocAddress, DocPassword) values (@dname, @ddob, @dgender, @dprof, @dphone, @daddress, @dpass)", con);
                    cmd.Parameters.AddWithValue("@dname", tboxName.Text);
                    cmd.Parameters.AddWithValue("@ddob", dtpDOF.Text);
                    cmd.Parameters.AddWithValue("@dgender", cboxGender.Text);
                    cmd.Parameters.AddWithValue("@dprof", cboxProfession.Text);
                    cmd.Parameters.AddWithValue("@dphone", tboxPhone.Text);
                    cmd.Parameters.AddWithValue("@daddress", tboxAddress.Text);
                    cmd.Parameters.AddWithValue("@dpass", tboxPassword.Text);
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
            if (tboxName.Text == "" || tboxPassword.Text == "" || tboxPhone.Text == "" || tboxAddress.Text == "" || dtpDOF.Text == "" || cboxGender.SelectedIndex == -1 || cboxProfession.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update DoctorTable set DocName=@dname, DocDOB=@ddob, DocGender=@dgender, DocProfession=@dprof, DocPhone=@dphone, DocAddress=@daddress, DocPassword=@dpass where DocID=@dkey", con);
                    cmd.Parameters.AddWithValue("@dname", tboxName.Text);
                    cmd.Parameters.AddWithValue("@ddob", dtpDOF.Text);
                    cmd.Parameters.AddWithValue("@dgender", cboxGender.Text);
                    cmd.Parameters.AddWithValue("@dprof", cboxProfession.Text);
                    cmd.Parameters.AddWithValue("@dphone", tboxPhone.Text);
                    cmd.Parameters.AddWithValue("@daddress", tboxAddress.Text);
                    cmd.Parameters.AddWithValue("@dpass", tboxPassword.Text);
                    cmd.Parameters.AddWithValue("@dkey", key);
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
                    SqlCommand cmd = new SqlCommand("delete from DoctorTable where DocID=@dkey", con);
                    cmd.Parameters.AddWithValue("@dkey", key);
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

        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tboxName.Text = dgvDoctors.SelectedRows[0].Cells[1].Value.ToString();
            dtpDOF.Text = dgvDoctors.SelectedRows[0].Cells[2].Value.ToString();
            cboxGender.SelectedItem = dgvDoctors.SelectedRows[0].Cells[3].Value.ToString();
            cboxProfession.SelectedItem = dgvDoctors.SelectedRows[0].Cells[4].Value.ToString();
            tboxPhone.Text = dgvDoctors.SelectedRows[0].Cells[5].Value.ToString();
            tboxAddress.Text = dgvDoctors.SelectedRows[0].Cells[6].Value.ToString();
            tboxPassword.Text = dgvDoctors.SelectedRows[0].Cells[7].Value.ToString();

            if (tboxName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvDoctors.SelectedRows[0].Cells[0].Value.ToString());
            }
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
