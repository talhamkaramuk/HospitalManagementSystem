using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class Prescriptions : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CASPER;Initial Catalog=HospitalDatabase;Integrated Security=True;Pooling=False");

        public Prescriptions()
        {
            InitializeComponent();
            DisplayRecords();
            GetDocID();
            GetPatID();
            GetTestID();
        }

        private void DisplayRecords()
        {
            con.Open();
            string query = "select * from PrescriptionTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvPrescriptions.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Clear()
        {
            cboxDocID.Text = "";
            tboxDocName.Text = "";
            cboxPatID.Text = "";
            tboxPatName.Text = "";
            cboxTestID.Text = "";
            tboxTest.Text = "";
            tboxMedicines.Text = "";
            tboxCost.Text = "";
            //key = 0;
        }

        private void GetDocID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select DocID from DoctorTable", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DocID", typeof(int));
            dt.Load(rdr);
            cboxDocID.ValueMember = "DocID";
            cboxDocID.DataSource = dt;
            con.Close();
        }

        private void GetDocName()
        {
            con.Open();
            string query = "select * from DoctorTable where DocID=" + cboxDocID.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                tboxDocName.Text = dr["DocName"].ToString();
            }
            con.Close();
        }

        private void GetPatID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select PatID from PatientTable", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PatID", typeof(int));
            dt.Load(rdr);
            cboxPatID.ValueMember = "PatID";
            cboxPatID.DataSource = dt;
            con.Close();
        }

        private void GetPatName()
        {
            con.Open();
            string query = "select * from PatientTable where PatID=" + cboxPatID.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                tboxPatName.Text = dr["PatName"].ToString();
            }
            con.Close();
        }

        private void GetTestID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select TestNum from TestTable", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TestNum", typeof(int));
            dt.Load(rdr);
            cboxTestID.ValueMember = "TestNum";
            cboxTestID.DataSource = dt;
            con.Close();
        }

        private void GetTest()
        {
            con.Open();
            string query = "select * from TestTable where TestNum=" + cboxTestID.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                tboxTest.Text = dr["TestName"].ToString();
                tboxCost.Text = dr["TestCost"].ToString();
            }
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tboxDocName.Text == "" || tboxPatName.Text == "" || tboxTest.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PrescriptionTable (DocID, DocName, PatID, PatName, TestID, TestName, Medicines, Cost) values (@did, @dname, @pid, @pname, @tid, @tname, @medicines, @cost)", con);
                    cmd.Parameters.AddWithValue("@did", cboxDocID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@dname", tboxDocName.Text);
                    cmd.Parameters.AddWithValue("@pid", cboxPatID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@pname", tboxPatName.Text);
                    cmd.Parameters.AddWithValue("@tid", cboxTestID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@tname", tboxTest.Text);
                    cmd.Parameters.AddWithValue("@medicines", tboxMedicines.Text);
                    cmd.Parameters.AddWithValue("@cost", tboxCost.Text);
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void dgvPrescriptions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rtboxPrescription.Text = "";
            rtboxPrescription.Text = $"\t\t\tT Hospital | Prescription\r\n\r\nDate: {DateTime.Today.ToString()}\r\nPatient: {dgvPrescriptions.SelectedRows[0].Cells[4].Value.ToString()}\r\nDoctor: {dgvPrescriptions.SelectedRows[0].Cells[2].Value.ToString()}\r\nLab Tests: {dgvPrescriptions.SelectedRows[0].Cells[6].Value.ToString()}\r\nMedicines: {dgvPrescriptions.SelectedRows[0].Cells[7].Value.ToString()}\r\nCost: {dgvPrescriptions.SelectedRows[0].Cells[8].Value.ToString()}";
        }

        private void cboxDocID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDocName();
        }

        private void cboxPatID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPatName();
        }

        private void cboxTestID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTest();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtboxPrescription.Text + "\n", new Font("Averia", 18, FontStyle.Regular), Brushes.Black, new Point(95, 80));
            e.Graphics.DrawString("\n\t" + "Thanks", new Font("Averia", 15, FontStyle.Bold), Brushes.Red, new Point(200, 300));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
