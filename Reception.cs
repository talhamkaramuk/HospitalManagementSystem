using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class Reception : Form
    {

        SqlConnection con = new SqlConnection("Data Source=CASPER;Initial Catalog=HospitalDatabase;Integrated Security=True;Pooling=False");

        int key = 0;

        public Reception()
        {
            InitializeComponent();
            DisplayRecords();
        }

        private void DisplayRecords()
        {
            con.Open();
            string query = "select * from RecepTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvReceps.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Clear()
        {
            tboxName.Text = "";
            tboxPhone.Text = "";
            tboxPassword.Text = "";
            tboxAddress.Text = "";
            key = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tboxName.Text == "" || tboxPassword.Text == "" || tboxPhone.Text == "" || tboxAddress.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into RecepTable (RecepName, RecepPhone, RecepAddress, RecepPassword) values (@rname, @rphone, @raddress, @rpass)", con);
                    cmd.Parameters.AddWithValue("@rname", tboxName.Text);
                    cmd.Parameters.AddWithValue("@rphone", tboxPhone.Text);
                    cmd.Parameters.AddWithValue("@raddress", tboxAddress.Text);
                    cmd.Parameters.AddWithValue("@rpass", tboxPassword.Text);
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
            if (tboxName.Text == "" || tboxPassword.Text == "" || tboxPhone.Text == "" || tboxAddress.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update RecepTable set RecepName=@rname, RecepPhone=@rphone, RecepAddress=@raddress, RecepPassword=@rpass where RecepID=@rkey", con);
                    cmd.Parameters.AddWithValue("@rname", tboxName.Text);
                    cmd.Parameters.AddWithValue("@rphone", tboxPhone.Text);
                    cmd.Parameters.AddWithValue("@raddress", tboxAddress.Text);
                    cmd.Parameters.AddWithValue("@rpass", tboxPassword.Text);
                    cmd.Parameters.AddWithValue("@rkey", key);
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
                    SqlCommand cmd = new SqlCommand("delete from RecepTable where RecepID=@rkey", con);
                    cmd.Parameters.AddWithValue("@rkey", key);
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

        private void dgvReceps_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tboxName.Text = dgvReceps.SelectedRows[0].Cells[1].Value.ToString();
            tboxPhone.Text = dgvReceps.SelectedRows[0].Cells[2].Value.ToString();
            tboxPassword.Text = dgvReceps.SelectedRows[0].Cells[3].Value.ToString();
            tboxAddress.Text = dgvReceps.SelectedRows[0].Cells[4].Value.ToString();

            if (tboxName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvReceps.SelectedRows[0].Cells[0].Value.ToString());
            }
        }


    }
}
