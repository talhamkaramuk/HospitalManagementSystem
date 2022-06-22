using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CASPER;Initial Catalog=HospitalDatabase;Integrated Security=True;Pooling=False");

        public static string Role;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cboxUType.SelectedIndex == -1)
            {
                MessageBox.Show("Select User Type for Login");
            }
            else if (cboxUType.SelectedItem.ToString() == "Admin")
            {
                if (tboxUsername.Text == "" || tboxPassword.Text == "")
                {
                    MessageBox.Show("Enter the login informations for Admin Login");
                }
                else if (tboxUsername.Text == "tmk" || tboxPassword.Text == "5858")
                {
                    Role = "Admin";
                    Patient frm = new Patient();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login informations!");
                }
            }
            else if (cboxUType.SelectedItem.ToString() == "Doctor")
            {
                if (tboxUsername.Text == "" || tboxPassword.Text == "")
                {
                    MessageBox.Show("Enter the login informations for Doctor Login");
                }
                else
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select count(*) from DoctorTable where DocName='" + tboxUsername.Text + "' and DocPassword='" + tboxPassword.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Doctor";
                        Prescriptions frm = new Prescriptions();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Doctor not found");
                    }
                    con.Close();
                }
            }
            else if (cboxUType.SelectedItem.ToString() == "Receptionist")
            {
                if (tboxUsername.Text == "" || tboxPassword.Text == "")
                {
                    MessageBox.Show("Enter the login informations for Receptionist Login");
                }
                else
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select count(*) from RecepTable where RecepName='" + tboxUsername.Text + "' and RecepPassword='" + tboxPassword.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Receptionist";
                        Home frm = new Home();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Receptionist not found");
                    }
                    con.Close();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboxUType.SelectedIndex = 0;
            tboxUsername.Text = "";
            tboxPassword.Text = "";
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
