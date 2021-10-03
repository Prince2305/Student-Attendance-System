using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance_system
{
    public partial class loginfrm : Form
    {
        DbConnect db = new DbConnect();
        public loginfrm()
        {
            InitializeComponent();
        }

        private void loginfrm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (userName.Text != "" && password.Text != "")
            {
                string sql = "select * from users where UserName='" + userName.Text + "' and UserPass='" + password.Text + "'";
                string st="";
                db.openconnection();
                MySqlDataReader dr = db.executeReader(sql);
               
                if (dr.HasRows)
                {   while(dr.Read())
                    { 
                        st = dr["status"].ToString();
                        
                    }

                    if (st == "student")
                    {
                        studentView sv = new studentView(userName.Text);
                        
                       
                        dr.Close();
                        dr.Dispose();
                        db.closeconnection();
                        this.Hide();
                        sv.Show();
                    }
                    else
                    {

                        teacherView tv = new teacherView();
                        
                        
                        dr.Close();
                        dr.Dispose();
                        db.closeconnection();
                        this.Hide();
                        tv.ShowDialog();
                    }
                    
                }
                else
                {
                    MessageBox.Show("incorrect data", "");
                    dr.Close();
                }
                

            }
            else {
                MessageBox.Show("Fill the fields", "");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            userName.Text = "";
            password.Text = "";
        }
    }
}
