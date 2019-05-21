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

namespace iliekbarangay
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
          
                this.AcceptButton = adminLgn;
                    
        }



        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private String fname;
        private String mname;
        private String lname;
                                
        private String id;
                                
        public void getTheName(String username)
        {
            Connection con = new Connection();
            con.Connect();
            SqlCommand cmd = new SqlCommand(); 
            if (metroTabControl1.SelectedTab == metroTabPage1)
            {
                    
                cmd.CommandText = "SELECT admin_fname AS a, admin_mname AS b, admin_lname AS c , admin_id as d FROM admin WHERE admin_username = @username";

                try
                {

                    cmd.Connection = Connection.con;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteScalar();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        fname = rdr["a"].ToString();
                        mname = rdr["b"].ToString();
                        lname = rdr["c"].ToString();
                        id = rdr["d"].ToString();
                       
                    }
                    rdr.Close();
                }
                catch (Exception)
                {
                }
                finally
                {
                   
                }
            
            
            }

        }                          

        private void adminLgn_Click(object sender, EventArgs e)
        {

            try
            {
                string pass;
                pass = Eramake.eCryptography.Encrypt(admnPass.Text);
                admnPass.Text = Eramake.eCryptography.Decrypt(pass.ToString());
                if (admnUname.Text == "Username" || admnPass.Text == "Password")
                {
                    MessageBox.Show("Please fillup al fields.");
                    return;
                }

                else
                {
                    AdminMain sm = new AdminMain();
                    Connection con = new Connection();
                    con.Connect();
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "Select * from admin where admin_username=@username AND admin_password=@password";
                    cmd.Parameters.AddWithValue("@username", admnUname.Text);
                    cmd.Parameters.AddWithValue("@password", pass);
                    cmd.Connection = Connection.con;
                    
                    SqlCommand admCMD = new SqlCommand();                    
                    admCMD.CommandText = "update admin set admin_age = datediff(YY, admin_dob,GETDATE())";
                    admCMD.Connection = Connection.con;
                    admCMD.ExecuteNonQuery();

                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;
                    string str;

                    str = "select * from ADMIN";
                    SqlCommand com = new SqlCommand();
                    com.Connection = Connection.con;
                    com.CommandText = str;

                    if (count == 1)
                    {
                        this.getTheName(admnUname.Text);
                        sm.ID = id.Trim();
                        this.Hide();
                        sm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Login Failed!!! Try Again.");
                        admnPass.Text = "";
                        admnPass.Focus();
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid Server Settings!");
                iliekbarangay.settings set = new settings();
                set.ShowDialog();
            }
        }

        private void admnUname_Enter(object sender, EventArgs e)
        {
            if (admnUname.Text == "Username")
            {
                admnUname.Text = "";
                admnUname.ForeColor = Color.Black;
            }
        }

        private void admnUname_Leave(object sender, EventArgs e)
        {
            if (admnUname.Text == "")
            {
                admnUname.Text = "Username";
                admnUname.ForeColor = Color.DarkGray;
            }
        }

        private void admnPass_Enter(object sender, EventArgs e)
        {
            if (admnPass.Text == "Password")
            {
                admnPass.Text = "";
                admnPass.ForeColor = Color.Black;
                admnPass.PasswordChar = '*';
            }
        }

        private void admnPass_Leave(object sender, EventArgs e)
        {
            if (admnPass.Text == "")
            {
                admnPass.Text = "Password";
                admnPass.ForeColor = Color.DarkGray;
                admnPass.PasswordChar = Char.Parse("\0") ;
            }
        }

        
        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            iliekbarangay.settings set = new settings();
            set.ShowDialog();
        }

        private void fpA_Click(object sender, EventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.ShowDialog();
        }

        private void fpS_Click(object sender, EventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.ShowDialog();
        }
    }
}
