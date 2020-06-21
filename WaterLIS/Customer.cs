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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand cmd;

        private void generate_cid()
        {

            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new OleDbCommand();
            con.Open();
            cmd.CommandText = "select cid from Customer order by cid  desc ";
            cmd.Connection = con;
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string cid = dr.GetString(0);
                int v = Convert.ToInt32(cid.Substring(1)) + 1;
                txtcid.Text = "C" + v;

            }
            else
            {
                txtcid.Text = "C100";
            }
            con.Close();


        }
        //-------------------------------------------------------------------------

        public void ShowCustomer()
        {

            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            //GlobalClass.adap = new OleDbDataAdapter("SELECT cid ,name,address,mobileno,idproof from Customer where name LIKE '" +txtsearch.Text + "%'", con);
            GlobalClass.adap = new OleDbDataAdapter("SELECT cid as CID ,name as Name,address as Address,mobileno as Mobile_No,idproof as Id_Proof,noofcans as NO_of_Can,priceofcan as Price_of_Per_Can,dates as Dates from Customer", con);
            // GlobalClass.adap = new OleDbDataAdapter("select distinct cname FROM CustomerInfo where cname LIKE '"+txtSearchCustomer.Text+"%'", con);
            OleDbCommandBuilder bui = new OleDbCommandBuilder(GlobalClass.adap);
            GlobalClass.dt = new DataTable();
            GlobalClass.adap.Fill(GlobalClass.dt);
            dgvcustomer.DataSource = GlobalClass.dt;
            dgvcustomer.ReadOnly = true;
            //  lstColonyName.Items.Clear();

        }






        private void Customer_Load(object sender, EventArgs e)
        {
            generate_cid();
            ShowCustomer();
            //validations();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void btnsave_Click(object sender, EventArgs e)
        {
            string str = "";
            str = Validation.CustomerValidation(txtname.Text, txtmobileno.Text, txtidproof.Text, txtnoofcan.Text, txtpriceofcan.Text); 

            //if (String.IsNullOrWhiteSpace(txtname.Text) || String.IsNullOrWhiteSpace(txtaddress.Text) || String.IsNullOrWhiteSpace(txtmobileno.Text) || String.IsNullOrWhiteSpace(txtnoofcan.Text) || String.IsNullOrWhiteSpace(txtpriceofcan.Text))
            if (str!="") 
            {
                MessageBox.Show(str);
            }
            else
            {
                con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
                cmd = new OleDbCommand();
                con.Open();
               // MessageBox.Show("inset");
                cmd.CommandText =  "insert into Customer(cid,name,address,mobileno,idproof,noofcans,priceofcan,dates) values( @cid,@name,@address,@mobileno,@idproof,@noofcans,@priceofcan,@dates)";
                cmd.Parameters.AddWithValue("@cid", txtcid.Text);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@mobileno", txtmobileno.Text);
                cmd.Parameters.AddWithValue("@idproof", txtidproof.Text);
                cmd.Parameters.AddWithValue("@noofcans", txtnoofcan.Text);
                cmd.Parameters.AddWithValue("@priceofcan", txtpriceofcan.Text);
                cmd.Parameters.AddWithValue("@dates", dtpdate.Value.ToShortDateString ());
                cmd.Connection = con;
                int x = cmd.ExecuteNonQuery();

                if (x > 0)
                {
                    MessageBox.Show("Record Insert Successfully..!");
                    generate_cid();
                }

                txtname.Text = "";
                txtaddress.Text = "";
                txtcid.Text = "";
                txtmobileno.Text = "";
                txtidproof.Text = "";
                txtnoofcan.Text = "";
                txtpriceofcan.Text = "";
                dtpdate.Text = DateTime.Now.ToShortDateString();


                //insert into gridview...----------------
                ShowCustomer();
                generate_cid();


            }
        }

        private void dgvcustomer_DoubleClick(object sender, EventArgs e)
        {
            txtcid.Text = this.dgvcustomer.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = this.dgvcustomer.CurrentRow.Cells[1].Value.ToString();
            txtaddress.Text = this.dgvcustomer.CurrentRow.Cells[2].Value.ToString();
            txtmobileno.Text = this.dgvcustomer.CurrentRow.Cells[3].Value.ToString();
            txtidproof.Text = this.dgvcustomer.CurrentRow.Cells[4].Value.ToString();
            txtnoofcan.Text = this.dgvcustomer.CurrentRow.Cells[5].Value.ToString();
            txtpriceofcan.Text = this.dgvcustomer.CurrentRow.Cells[6].Value.ToString();
            dtpdate.Text = this.dgvcustomer.CurrentRow.Cells[7].Value.ToString();
            btnsave.Enabled = false;
            
        }
        

    private void btnremove_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from Customer Where cid='"+txtcid.Text+"'";

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Record Deleted Successfully..!");
            }

            ShowCustomer();
            txtname.Text = "";
            txtaddress.Text = "";
            txtcid.Text = "";
            txtmobileno.Text = "";
            txtidproof.Text = "";
            txtnoofcan.Text = "";
            txtpriceofcan.Text = "";
            generate_cid();
            btnsave.Enabled = true;
        }
        //Search into gridview....................
        public void Searchcustomer()
        {

            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            //GlobalClass.adap = new OleDbDataAdapter("SELECT cid ,name,address,mobileno,idproof from Customer where name LIKE '" +txtsearch.Text + "%'", con);
            GlobalClass.adap = new OleDbDataAdapter("SELECT cid as CID ,name as Name,address as Address,mobileno as Mobile_No,idproof as Id_Proof,dates as Dates from Customer where name LIKE  '%" + txtsearch.Text + "%' ", con);
            // GlobalClass.adap = new OleDbDataAdapter("select distinct cname FROM CustomerInfo where cname LIKE '"+txtSearchCustomer.Text+"%'", con);
            OleDbCommandBuilder bui = new OleDbCommandBuilder(GlobalClass.adap);
            GlobalClass.dt = new DataTable();
            GlobalClass.adap.Fill(GlobalClass.dt);
            dgvcustomer.DataSource = GlobalClass.dt;
            dgvcustomer.ReadOnly = true;
            //  lstColonyName.Items.Clear();

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)

        {
            Searchcustomer();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new OleDbCommand();
            con.Open();
            cmd.CommandText = "update Customer set name='"+txtname.Text+ "',address='" + txtaddress.Text + "',mobileno='" +txtmobileno.Text+"',idproof='"+txtidproof.Text+"',noofcans='" +txtnoofcan.Text + "',priceofcan='" +txtpriceofcan.Text+ "',dates='" + dtpdate.Value.ToShortDateString()+"' where cid='"+txtcid.Text+"'";
        //cmd.CommandText = "update Employee set name='" + txtname.Text+ "',address='" + txtaddress.Text + "',mobileno=" + txtmobileno.Text + ",idproof='" + txtidproof.Text + "', salary='" + Convert.ToInt32(txtsalary.Text) + "', designation='" + txtdesignation.Text + "',dates='" + dtpdate.Value.ToShortDateString() + "' where eid=" + txteid.Text + "";
            cmd.Connection = con;
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Record Update Successfully..!");
            }

            
           

            txtname.Text = "";
            txtaddress.Text = "";
            txtcid.Text = "";
            txtmobileno.Text = "";
            txtidproof.Text = "";
             txtnoofcan.Text ="";
            txtpriceofcan.Text ="";


            //insert into gridview...----------------
            ShowCustomer();
            generate_cid();
            con.Close();
            btnsave.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtremainamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblremainingamt_Click(object sender, EventArgs e)
        {

        }

        private void lblidproof_Click(object sender, EventArgs e)
        {

        }

        private void lblmobileno_Click(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidproof_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmobileno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpriceofcan_Leave(object sender, EventArgs e)
        {
            
        }

        private void dgvcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtcid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
