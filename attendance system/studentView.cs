using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance_system
{
    public partial class studentView : Form
    {
        String name;
        DbConnect db = new DbConnect();
        MySqlDataReader dr;
        string leavestatus= "confirmation Pending";
        public studentView()
        {
            InitializeComponent();
        }

        public studentView(string text)
        {
            InitializeComponent();
            name = text;
        }

        private void studentView_Load(object sender, EventArgs e)
        {
            lblname.Text = "Login : "+name;

            db.openconnection();

            DataSet dt = new DataSet();
            MySqlDataAdapter sd = db.sda("select * from leaveappliction where studentName='"+name+"'");
            sd.Fill(dt);
            dataGridViewleave.DataSource = dt.Tables[0];

            sd.Dispose();
            db.closeconnection();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void btnshowRecord1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SubName.Text)) { }
            else
            {


                db.openconnection();

                DataSet dt = new DataSet();
                MySqlDataAdapter sd = db.sda("select * from attendance where date='" + dateTimePicker1.Text + "' and studentName='"+name+"' and subjectName='"+SubName.Text+"'");
                sd.Fill(dt);
                
                dataGridView1.DataSource = dt.Tables[0];

                sd.Dispose();
                db.closeconnection();
            }
        }

        private void btnshowstud_Click(object sender, EventArgs e)
        {
            
            
                db.openconnection();
                dr = db.executeReader("select * from students where Name='" + name + "' ");
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                    txtaddsturoll.Text = dr[0].ToString();
                    txtaddstuname.Text = dr[1].ToString();
                   // dateTimePicker1.Value= Convert.ToDateTime(dr[2]);
                    dateTimePickeraddstu.Value= Convert.ToDateTime(dr[2]);
                    // dateTimePicker1.Text = dr[2].ToString();
                    //  infoGender.Text = dr[3].ToString();
                    txtaddstuaddress.Text = dr[4].ToString();
                        txtaddstucont.Text = dr[5].ToString();
                        txtaddstuemail.Text = dr[6].ToString();
                    txtaddstupass.Text = dr[7].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record Not found !!!", "");
                }
                dr.Close();
                db.closeconnection();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtaddstuaddress.Text)&& String.IsNullOrEmpty(txtaddstucont.Text)&& String.IsNullOrEmpty(txtaddstuemail.Text)&& String.IsNullOrEmpty(txtaddstuname.Text)&& String.IsNullOrEmpty(txtaddstupass.Text)))
            {
                db.openconnection();
                dr = db.executeReader("update students set Name='"+txtaddstuname.Text+"',dob='"+dateTimePickeraddstu.Text+"',address='"+txtaddstuaddress.Text+"',contact='"+txtaddstucont.Text+"',email='"+txtaddstuemail.Text+"',password='"+txtaddstupass.Text+"' where name='"+name+"'");
                MessageBox.Show("Data Updated!!!", "");
                name = txtaddstuname.Text;
                lblname.Text = "Login : " + name;

                dr.Close();
                db.closeconnection();

            }
            else
            {
                MessageBox.Show("Plz do not leave Fields Empty!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtaddstuaddress.Text = "";
            txtaddstucont.Text = "";
            txtaddstuemail.Text = "";
            txtaddstuname.Text = "";
            txtaddstupass.Text = "";
            txtaddsturoll.Text = "";
            dateTimePickeraddstu.Value = DateTimePicker.MinimumDateTime;
       //     dateTimePickeraddstu.CustomFormat = "";
        }

        private void studentView_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            
        }

        private void btnleave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxleave.Text) && !string.IsNullOrEmpty(txtreason.Text)) {

                db.openconnection();
                
                string sql = "INSERT INTO leaveappliction(studentName,subjectName,date,reason,status) VALUES('" + name + "','" + comboBoxleave.Text + "','" + dateTimePickerleave.Value.Date.ToString("yyyyMMdd") + "','" + txtreason.Text + "','"+ leavestatus + "')";

                dr = db.executeReader(sql);

                dr.Close();

                MySqlDataAdapter sd = db.sda("select * from leaveappliction where studentName='"+name+"'");
                DataSet d = new DataSet();
                sd.Fill(d);
                dataGridViewleave.DataSource = d.Tables[0];
                db.closeconnection();
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
 }

