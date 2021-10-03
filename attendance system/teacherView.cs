using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class teacherView : Form
    {
        string gender="",sql;
        List<String> names = new List<string>();
        List<string> roll = new List<string>();
        DateTime dt;
        DbConnect db = new DbConnect();
        MySqlDataReader dr;
        
        public teacherView()
        {
            InitializeComponent();
            btndeletstu.Enabled = false; 
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            txtaddstuaddress.Text = "";
            txtaddstucont.Text = "";
            txtaddstuemail.Text = "";
            txtaddstuname.Text = "";
            txtaddstupass.Text = "";
        }

        private void btnshowRecord1_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(SubName.Text)))
            {
                db.openconnection();
                dr = db.executeReader("select * from attendance where subjectName='" + SubName.Text + "' and date='" + dateTimePicker1.Text + "'");
                if (dr.HasRows)
                {
                    dr.Close();
                    MessageBox.Show("Attendance with this date is already exist!!!", "");
                }
                else
                {

                    dr.Close();
                    //  MessageBox.Show(""+dateTimePicker1.Value.ToString("yyyy-MM-dd"),"");

                    
                    
                    dr = db.executeReader("select * from students");
                    while (dr.Read())
                    {
                        names.Add(dr[1].ToString());
                        roll.Add(dr[0].ToString());
                    }
                   // MessageBox.Show(String.Join(Environment.NewLine, names), "");
                    dr.Close();

                    DataSet dt = new DataSet();
                    MySqlDataAdapter sd = db.sda("select * from students");
                    sd.Fill(dt);
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.ColumnCount = 2;
                    dataGridView1.Columns[0].Name = "StudentRoll";
                    dataGridView1.Columns[0].HeaderText = "Roll NO.";
                    dataGridView1.Columns[0].DataPropertyName = "rollNo";
                    dataGridView1.Columns[1].Name = "StudentName";
                    dataGridView1.Columns[1].HeaderText = "Name";
                    dataGridView1.Columns[1].DataPropertyName = "Name";
                    dataGridView1.DataSource = dt.Tables[0];
                    DataGridViewCheckBoxColumn dgv = new DataGridViewCheckBoxColumn();
                    dgv.ValueType = typeof(bool);
                    dgv.Name = "chk";
                    dgv.HeaderText = "present";
                    dataGridView1.Columns.Add(dgv);

                }

                db.closeconnection();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            if(!(String.IsNullOrEmpty(addteaname.Text)&&String.IsNullOrEmpty(addteacont.Text)&&String.IsNullOrEmpty(addteaemail.Text)&&String.IsNullOrEmpty(addteauser.Text)&&String.IsNullOrEmpty(addteapass.Text)))
            {
                db.openconnection();
                
                sql = "INSERT INTO teacher(name,contact,email,userId,UserPass) VALUES('" + addteaname.Text + "','" + addteacont.Text + "','" + addteaemail.Text + "'," + Convert.ToInt32(addteauser.Text) + ",'" + addteapass.Text + "')";
               
                dr = db.executeReader(sql);
              
                dr.Close();
                sql = "INSERT INTO users(UserName, UserPass, status) VALUES ('" + addteaname.Text + "','" + addteapass.Text + "','teacher')";
                dr = db.executeReader(sql);
                dr.Close();
             
                dr.Dispose();
                db.closeconnection();
            }
            else
            {
                MessageBox.Show("plz fill all the field", "");
            }
        }

        private void btnSaveAttend_Click(object sender, EventArgs e)
        {
          

            foreach (DataGridViewRow roe in dataGridView1.Rows)
            {
                bool isSelect = Convert.ToBoolean(roe.Cells["chk"].Value);

                if (isSelect)
                {
                   // MessageBox.Show("" + roe.Cells["UserRoll"].Value.ToString() + "','" + roe.Cells["UserName"].Value.ToString() );
                    names.Remove(roe.Cells["StudentName"].Value.ToString());
                    roll.Remove(roe.Cells["StudentRoll"].Value.ToString());
                   db.openconnection();
                   sql = "insert into attendance(rollNo,studentName,subjectName,date,status) values('" + roe.Cells["StudentRoll"].Value.ToString() + "','" + roe.Cells["StudentName"].Value.ToString() + "','"+SubName.Text+"','" + dateTimePicker1.Text + "','present')";
                    dr = db.executeReader(sql);
                    dr.Close();
                }
                else
                {
                    
                }
                 

            }
            MessageBox.Show("data Successfully Inserted");
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

          //  MessageBox.Show("Name : "+names.Count);
            for (int i = 0; i < names.Count; i++)
            {
                sql = "insert into attendance(rollNo,studentName,subjectName,date,status) values('" + roll[i] + "','" + names[i] + "','"+SubName.Text+"','" + dateTimePicker1.Text + "','Absent')";
                dr = db.executeReader(sql);
                dr.Close();
            }
            names.Clear();
            roll.Clear();
            /*
             MessageBox.Show(String.Join(Environment.NewLine, names.Count), "");
             //for(int i=0;i<)
             MessageBox.Show(String.Join(Environment.NewLine, names.IndexOf("pravin")), "");*/
            db.closeconnection();

        }

        private void btnshowoldRecord_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(subPrevname.Text)) { } else
            {

           
            db.openconnection();

            DataSet dt = new DataSet();
            MySqlDataAdapter sd = db.sda("select * from attendance where date='"+datePrevious.Text+"' AND subjectName='"+subPrevname.Text+"'");
            sd.Fill(dt);
                dataGridViewprev.DataSource = dt.Tables[0];

                sd.Dispose();
                db.closeconnection();
            }
        }

        private void btnshowstuRecord_Click(object sender, EventArgs e)
        {
            if(!(String.IsNullOrEmpty(infoRoll.Text)))
             {
                db.openconnection();
                dr = db.executeReader("select * from students where rollNo=" + infoRoll.Text + " ");
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        infoName.Text = dr[1].ToString();
                        infoDOB.Text = DateTime.Parse(dr[2].ToString()).ToString("d/M/yyyy");
                        dt = DateTime.Parse(dr[2].ToString());
                        infoGender.Text = dr[3].ToString();
                        infoAddress.Text = dr[4].ToString();
                        infocontact.Text = dr[5].ToString();
                        infoEmail.Text = dr[6].ToString();
                    }
                    btndeletstu.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Record Not found !!!", "");
                    infoRoll.Text = "";
                    infoName.Text = "";
                    infoDOB.Text = "";
                    infoGender.Text = "";
                    infoAddress.Text = "";
                    infocontact.Text = "";
                    infoEmail.Text = "";
                }
                dr.Close();
                db.closeconnection();
              //  MessageBox.Show(""+dt.ToString("dd/mm/yyyy"),"");

            }
            else {
            }

        }

        private void clearStuInfo_Click(object sender, EventArgs e)
        {
            infoRoll.Text = "";
            infoName.Text = "";
            infoDOB.Text = "";
            infoGender.Text = "";
            infoAddress.Text = "";
            infocontact.Text = "";
            infoEmail.Text = "";
            btndeletstu.Enabled = false;
        }

        private void teacherView_Load(object sender, EventArgs e)
        {
            db.openconnection();

            DataSet dt = new DataSet();
            MySqlDataAdapter sd = db.sda("select * from leaveappliction");
            sd.Fill(dt);
            dataGridViewleave.DataSource = dt.Tables[0];

            sd.Dispose();
            db.closeconnection();
        }

        private void butdeletstu_Click(object sender, EventArgs e)
        {
            
            db.openconnection();
            dr = db.executeReader("delete from students where Name='"+infoName.Text+"'");
            dr.Close();
            dr = db.executeReader("delete from users where UserName='" + infoName.Text + "'");
            dr.Close();
            MessageBox.Show("Record deleted Successfully");
            db.closeconnection();
            infoRoll.Text = "";
            infoName.Text = "";
            infoDOB.Text = "";
            infoGender.Text = "";
            infoAddress.Text = "";
            infocontact.Text = "";
            infoEmail.Text = "";
            btndeletstu.Enabled = false;


        }

        private void addteauser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewleave_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            txtleaname.Text = dataGridViewleave.Rows[row].Cells[0].Value.ToString();
            txtleasubject.Text = dataGridViewleave.Rows[row].Cells[1].Value.ToString();
            txtleadate.Text = dataGridViewleave.Rows[row].Cells[2].Value.ToString();
            txtreason.Text = dataGridViewleave.Rows[row].Cells[3].Value.ToString();
            comleastatus.Text = dataGridViewleave.Rows[row].Cells[4].Value.ToString();
           
        }

        private void butleaupdate_Click(object sender, EventArgs e)
        {
            db.openconnection();
            MySqlDataReader dr;
            dr = db.executeReader("update leaveappliction set status='" + comleastatus.Text+"' where studentName='" + txtleaname.Text + "'");
            MessageBox.Show("Data Updated!!!", "");
            // setDataGridView();
            dr.Close();
            MySqlDataAdapter sd = db.sda("select * from leaveappliction");
            DataSet d = new DataSet();
            sd.Fill(d);
            dataGridViewleave.DataSource = d.Tables[0];
            txtleaname.Text = "";
            txtleasubject.Text = "";
            txtleadate.Text = "";
            txtreason.Text = "";
            comleastatus.Text = "";
            db.closeconnection();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnaddstudent_Click(object sender, EventArgs e)
        {
           
            
            if(!(String.IsNullOrEmpty(txtaddsturoll.Text) &&String.IsNullOrEmpty(txtaddstucont.Text) && String.IsNullOrEmpty(txtaddstuemail.Text) && String.IsNullOrEmpty(txtaddstuname.Text) && String.IsNullOrEmpty(txtaddstupass.Text) && String.IsNullOrEmpty(txtaddstuaddress.Text) && gender.Equals("")))
            {

                db.openconnection();
                 dr = db.executeReader("select * from students where rollNo="+txtaddsturoll.Text+" or Name='"+txtaddstuname.Text+"'" );

                if (dr.HasRows)
                { MessageBox.Show("change roll no. or name", ""); dr.Close(); db.closeconnection(); }
                else {
                    dr.Close();
                    //MessageBox.Show("Welldone "+txtaddstuname.Text+" "+txtaddstucont.Text+" "+txtaddstuaddress.Text+" "+txtaddstuemail.Text+" "+txtaddstupass.Text+" "+dateTimePickeraddstu.Text+" "+gender+" " , "");
                    sql = "insert into students values( "+ txtaddsturoll.Text + ",'" + txtaddstuname.Text + "','" + dateTimePickeraddstu.Text + "','" + gender + "','" + txtaddstuaddress.Text + "','" + txtaddstucont.Text + "','" + txtaddstuemail.Text + "','" + txtaddstupass.Text + "')";
                dr = db.executeReader(sql);
               
                dr.Close();
                sql = "INSERT INTO users(UserName, UserPass, status) VALUES ('"+txtaddstuname.Text+"','"+txtaddstupass.Text+"','student')";
                dr = db.executeReader(sql);
                dr.Close();
                dr.Dispose();
                db.closeconnection();
              //  MessageBox.Show("best ch bhava", "");
                }
            }
            else
            {
                MessageBox.Show("plz fill all the field", "");
            } 
       
        }
    }
}
