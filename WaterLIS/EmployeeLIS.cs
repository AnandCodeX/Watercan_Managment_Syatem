using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;


namespace WaterLIS
{
    public partial class EmployeeLIS : Form
    {
        public EmployeeLIS()
        {
            InitializeComponent();
        }
        //Functions..........................................................
        OleDbConnection con;
        OleDbCommand cmd;

        private void generate_eid()
        {
            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new OleDbCommand();
            con.Open();
            cmd.CommandText = "select eid from Employee order by eid  desc ";
            cmd.Connection = con;
            object obj = cmd.ExecuteScalar();
            if (obj == null)
            {
                txteid.Text = "1";
            }
            else
            {
                int n = Convert.ToInt32(obj);
                n = n + 1;
                txteid.Text = n.ToString();
            }
            con.Close();

        }
        //............................................................................................
        public void ShowEmployee()
        {

            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            //GlobalClass.adap = new OleDbDataAdapter("SELECT cid ,name,address,mobileno,idproof from Customer where name LIKE '" +txtsearch.Text + "%'", con);
            GlobalClass.adap = new OleDbDataAdapter("SELECT eid as E_id,name as Name,address as Address,mobileno as Mobile_No,idproof as Id_Proof ,salary as Salary ,designation as Designation,dates as Dates from Employee ", con);
            // GlobalClass.adap = new OleDbDataAdapter("select distinct cname FROM CustomerInfo where cname LIKE '"+txtSearchCustomer.Text+"%'", con);
            OleDbCommandBuilder bui = new OleDbCommandBuilder(GlobalClass.adap);
            GlobalClass.dt = new DataTable();
            GlobalClass.adap.Fill(GlobalClass.dt);
            dgvemployeereg.DataSource = GlobalClass.dt;
            dgvemployeereg.ReadOnly = true;
            //  lstColonyName.Items.Clear();

        }



        //.................................................................................
        public void SearchEmployee()
        {

            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            //GlobalClass.adap = new OleDbDataAdapter("SELECT cid ,name,address,mobileno,idproof from Customer where name LIKE '" +txtsearch.Text + "%'", con);
            GlobalClass.adap = new OleDbDataAdapter("SELECT name as Name,address as Address,mobileno as Mobile_No,idproof as Id_Proof, salary as Salary ,designation as Designation,dates as Dates from Employee where name LIKE  '%" + txtsearch.Text + "%' ", con);
            // GlobalClass.adap = new OleDbDataAdapter("select distinct cname FROM CustomerInfo where cname LIKE '"+txtSearchCustomer.Text+"%'", con);
            OleDbCommandBuilder bui = new OleDbCommandBuilder(GlobalClass.adap);
            GlobalClass.dt = new DataTable();
            GlobalClass.adap.Fill(GlobalClass.dt);
            dgvemployeereg.DataSource = GlobalClass.dt;
            dgvemployeereg.ReadOnly = true;
        }
            //  lstColonyName.Items.Clear();

            //...........................................................................................

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string emr = "";
            emr= Validation.EmployeeValidation(txtname.Text,txtmobileno.Text,txtidproof.Text,txtsalary.Text,txtdesignation.Text);
            if (emr!="")
            {
                MessageBox.Show(emr);
            }
            else
            {
                con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                //cmd.CommandText = "insert into Employee(name,address,mobileno,idproof,salary,designation) values('" + txtname.Text + "','" + txtaddress.Text + "','" + txtmobileno.Text + "','" + txtidproof.Text + "','"+Convert.ToInt32(txtsalary.Text)+"','" + txtdesignation.Text +"'");
                cmd.CommandText = "insert into Employee(eid,name,mobileno,address,salary,designation,dates)values(@eid,@name,@mobileno,@address,@salary,@designation,@dates)";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@eid", txteid.Text);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@mobileno", txtmobileno.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@salary", txtsalary.Text);
                cmd.Parameters.AddWithValue("@designation", txtdesignation.Text);
                cmd.Parameters.AddWithValue("@dates", dtpdate.Value.ToShortDateString());

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Record Insert Successfully..!");
                }

                txtname.Text = "";
                txtaddress.Text = "";
                txteid.Text = "";
                txtmobileno.Text = "";
                txtidproof.Text = "";
                txtsalary.Text = "";
                txtdesignation.Text = "";
                dtpdate.Text = DateTime.Now.ToShortDateString();

                //insert into gridview...----------------
                ShowEmployee();
                generate_eid();

            }      
        }

        private void EmployeeLIS_Load(object sender, EventArgs e)
        {
            generate_eid();
            ShowEmployee();
        }

        private void dgvemployeereg_DoubleClick(object sender, EventArgs e)
        {
            txteid.Text = this.dgvemployeereg.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = this.dgvemployeereg.CurrentRow.Cells[1].Value.ToString();
            txtaddress.Text = this.dgvemployeereg.CurrentRow.Cells[2].Value.ToString();
            txtmobileno.Text = this.dgvemployeereg.CurrentRow.Cells[3].Value.ToString();
            txtidproof.Text = this.dgvemployeereg.CurrentRow.Cells[4].Value.ToString();
            txtsalary.Text = this.dgvemployeereg.CurrentRow.Cells[5].Value.ToString();

            txtdesignation.Text = this.dgvemployeereg.CurrentRow.Cells[6].Value.ToString();

            btnsave.Enabled = false;

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from Employee Where eid=" + Convert.ToInt32(txteid.Text) + "";

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Record Deleted Successfully..!");
            }
            ShowEmployee();

            txtname.Text = "";
            txtaddress.Text = "";
            txteid.Text = "";
            txtmobileno.Text = "";
            txtidproof.Text = "";
            txtsalary.Text = "";
            txtdesignation.Text = "";
            dtpdate.Text = DateTime.Now.ToShortDateString();

            //.........................................................
            generate_eid();
            ShowEmployee();





        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            SearchEmployee();
        }

        private void dgvemployeereg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update Employee set name='" + txtname.Text + "',address='" + txtaddress.Text + "',mobileno=" + txtmobileno.Text + ",idproof='" + txtidproof.Text + "', salary='" + Convert.ToInt32(txtsalary.Text) + "', designation='" + txtdesignation.Text + "',dates='"+dtpdate .Value .ToShortDateString ()+"' where eid=" + txteid.Text + "";

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Record Update Successfully..!");
            }

            txtname.Text = "";
            txtaddress.Text = "";
            txteid.Text = "";
            txtmobileno.Text = "";
            txtidproof.Text = "";
            txtsalary.Text = "";
            txtdesignation.Text = "";
            dtpdate.Text = DateTime.Now.ToShortDateString();



            //insert into gridview...----------------
            ShowEmployee();
            generate_eid();
            btnsave.Enabled = true;

        }
    }

   

       
    }

