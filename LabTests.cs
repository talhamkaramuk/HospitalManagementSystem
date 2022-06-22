using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class LabTests : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CASPER;Initial Catalog=HospitalDatabase;Integrated Security=True;Pooling=False");

        int key = 0;

        public LabTests()
        {
            InitializeComponent();
            DisplayRecords();
        }

        private void DisplayRecords()
        {
            con.Open();
            string query = "select * from TestTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvTests.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Clear()
        {
            tboxName.Text = "";
            tboxCost.Text = "";
            key = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tboxName.Text == "" || tboxCost.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TestTable (TestName, TestCost) values (@tname, @tcost)", con);
                    cmd.Parameters.AddWithValue("@tname", tboxName.Text);
                    cmd.Parameters.AddWithValue("@tcost", tboxCost.Text);
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
            if (tboxName.Text == "" || tboxCost.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update TestTable set TestName=@tname, TestCost=@tcost where TestNum=@tkey", con);
                    cmd.Parameters.AddWithValue("@tname", tboxName.Text);
                    cmd.Parameters.AddWithValue("@tcost", tboxCost.Text);
                    cmd.Parameters.AddWithValue("@tkey", key);
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
                    SqlCommand cmd = new SqlCommand("delete from TestTable where TestNum=@tkey", con);
                    cmd.Parameters.AddWithValue("@tkey", key);
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
            tboxName.Text = dgvTests.SelectedRows[0].Cells[1].Value.ToString();
            tboxCost.Text = dgvTests.SelectedRows[0].Cells[2].Value.ToString();

            if (tboxName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvTests.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
