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
    public partial class Installment : Form
    {
        public Installment()
        {
            InitializeComponent();
        }
        OleDbCommand cmd;
        OleDbConnection con;

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        public void SearchInsallmentcustomer()//on second grid view
        {

            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            //GlobalClass.adap = new OleDbDataAdapter("SELECT cid ,name,address,mobileno,idproof from Customer where name LIKE '" +txtsearch.Text + "%'", con);
            GlobalClass.adap = new OleDbDataAdapter("SELECT iid as IID,cbid as CB_ID, name as Name,idates as I_Dates,perticular as Perticular,payee as Payee,amount as Adv_Amount from Income where name LIKE  '%" + txtsearch.Text + "%' ", con);
            // GlobalClass.adap = new OleDbDataAdapter("select distinct cname FROM CustomerInfo where cname LIKE '"%"+txtSearchCustomer.Text+"%""', con);
            OleDbCommandBuilder bui = new OleDbCommandBuilder(GlobalClass.adap);
            GlobalClass.dt = new DataTable();
            GlobalClass.adap.Fill(GlobalClass.dt);
            gvCustomerBooking.DataSource = GlobalClass.dt;
            gvCustomerBooking.ReadOnly = true;

        }
        public void Dropdown()//show dropdown list to grid view on show button
        {
            if (ddlselect.SelectedItem.ToString() == "Customer")
            {

                con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
                con.Open();
                // cmd = new OleDbCommand();
                //OleDbDataReader dr = cmd.ExecuteReader();
                string ss = "select cid,name,noofcans,priceofcan,dates,remainingamount from Customer ";
                OleDbDataAdapter obj = new OleDbDataAdapter(ss, con.ConnectionString);
                DataSet ds = new DataSet();
                obj.Fill(ds, "WaterLISDB");
                con.Close();
                gvCustomerBooking.DataSource = ds;
                gvCustomerBooking.DataMember = "WaterLISDB";



            }


            if (ddlselect.SelectedItem.ToString() == "Pre_booking")
            {
                OleDbCommand cmd;
                OleDbConnection con;
                con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
                con.Open();
                cmd = new OleDbCommand();
                string ss = "select bid,name,datebooking,datedelivery,noofcane,priceofcane,totalamount,advamount,remainingamount from Booking";
                OleDbDataAdapter obj = new OleDbDataAdapter(ss, con.ConnectionString);
                DataSet ds = new DataSet();
                obj.Fill(ds, "WaterLISDB");
                con.Close();
                gvCustomerBooking.DataSource = ds;
                gvCustomerBooking.DataMember = "WaterLISDB";



            }

        }
        private void btnshow_Click(object sender, EventArgs e)
        {
            Dropdown();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tnsave_Click(object sender, EventArgs e)//ddl to customer or prebooking
        {
            string imr = "";
            imr = Validation.InstallmentValidation(txtpaidamount.Text, txtpayee.Text);
            if (imr != "")
            {
                MessageBox.Show(imr);
            }
            else
            {

                int r = Convert.ToInt32(txtremaningamount.Text);//update remaining amount in booking table
                int p = Convert.ToInt32(txtpaidamount.Text);
                if (p > r)
                {
                    MessageBox.Show("Enter Valid amount");
                }
                else { 

                r = r - p;
                if (ddlselect.SelectedItem.ToString() == "Customer")
                {
                    con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.CommandText = "update Customer set remainingamount='" + r + "' where cid='" + txtcbid.Text + "'";
                    cmd.Connection = con;
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        MessageBox.Show("Record Update Successfully..!");
                    }

                }


                if (ddlselect.SelectedItem.ToString() == "Pre_booking")
                {

                    con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.CommandText = "update Booking set remainingamount='" + r + "' where bid='" + txtcbid.Text + "'";
                    cmd.Connection = con;
                    int m = cmd.ExecuteNonQuery();
                    if (m > 0)
                    {
                        MessageBox.Show("Record Update Successfully..!");
                    }
                    con.Close();
                }

                if (ddlselect.SelectedItem.ToString() == "Customer")//2nd time entry
                {
                    con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.CommandText = "insert into Income(cbid,name,idates,perticular,payee,amount) values(@cbid,@cname,@idates,@perticular,@payee,@amount)";
                    cmd.Parameters.AddWithValue("@cbid", txtcbid.Text);
                    cmd.Parameters.AddWithValue("@cname", txtiname.Text);
                    cmd.Parameters.AddWithValue("@idates", dtpidate.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@perticular", "Customer");
                    cmd.Parameters.AddWithValue("@payee", txtpayee.Text);
                    cmd.Parameters.AddWithValue("@amount", Convert.ToInt32(txtpaidamount.Text));
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                if (ddlselect.SelectedItem.ToString() == "Pre_booking")
                {
                    con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
                    cmd = new OleDbCommand();
                    con.Open();

                    cmd.CommandText = "insert into Income(cbid,name,idates,perticular,payee,amount) values(@cbid,@name,@idates,@perticular,@payee,@amount)";
                    cmd.Parameters.AddWithValue("@cbid", txtcbid.Text);
                    cmd.Parameters.AddWithValue("@name", txtiname.Text);
                    cmd.Parameters.AddWithValue("@idates", dtpidate.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@perticular", "Pre_Booking");
                    cmd.Parameters.AddWithValue("@payee", txtpayee.Text);
                    cmd.Parameters.AddWithValue("@amount", Convert.ToInt32(txtpaidamount.Text));
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();


                }

                txtremaningamount.Text = r.ToString();
                showInstallment();
                Dropdown();
                txtpaidamount.Text = "";
                dtpidate.Text = DateTime.Now.ToShortDateString();
                txtpayee.Text = "";
            }
        }
    }
       private void dgvinstallment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//one grid view to second grid view
        {
            if (ddlselect.SelectedItem.ToString() == "Customer")
            {
                txtcbid.Text = this.gvCustomerBooking.CurrentRow.Cells[0].Value.ToString();
                txtiname.Text = this.gvCustomerBooking.CurrentRow.Cells[1].Value.ToString();
                txtremaningamount.Text = this.gvCustomerBooking.CurrentRow.Cells[5].Value.ToString();
                con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
                con.Open();
                string ss = "select cbid as Cb_Id,idates as I_Date,perticular as Pericular,payee as Payee,amount as Amount from Income where cbid='" + txtcbid.Text + "' order by cbid desc";
                OleDbDataAdapter obj = new OleDbDataAdapter(ss, con.ConnectionString);
                DataSet ds = new DataSet();
                obj.Fill(ds, "WaterLISDB");
                con.Close();
                dgvinstallment.DataSource = ds;
                dgvinstallment.DataMember = "WaterLISDB";

            }
            if (ddlselect.SelectedItem.ToString() == "Pre_booking")
            {
                txtcbid.Text = this.gvCustomerBooking.CurrentRow.Cells[0].Value.ToString();
                txtiname.Text = this.gvCustomerBooking.CurrentRow.Cells[1].Value.ToString();
                txtremaningamount.Text = this.gvCustomerBooking.CurrentRow.Cells[8].Value.ToString();
                con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
                con.Open();
                string ss = "select cbid as Cb_Id,idates as I_Date,perticular as Pericular,payee as Payee,amount as Amount from Income where cbid='" + txtcbid.Text + "' order by cbid desc";
                OleDbDataAdapter obj = new OleDbDataAdapter(ss, con.ConnectionString);
                DataSet ds = new DataSet();
                obj.Fill(ds, "WaterLISDB");
                con.Close();
                dgvinstallment.DataSource = ds;
                dgvinstallment.DataMember = "WaterLISDB";
                con.Close();
            }
        }

        public void showInstallment()
         {
            if (ddlselect.SelectedItem.ToString() == "Customer")
            {
                con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
                con.Open();
                string ss = "select cbid as Cb_Id,idates as I_Date,perticular as Pericular,payee as Payee,amount as Amount from Income where cbid='" + txtcbid.Text + "' order by cbid desc";
                OleDbDataAdapter obj = new OleDbDataAdapter(ss, con.ConnectionString);
                DataSet ds = new DataSet();
                obj.Fill(ds, "WaterLISDB");
                con.Close();
                dgvinstallment.DataSource = ds;
                dgvinstallment.DataMember = "WaterLISDB";
                
            }
            if (ddlselect.SelectedItem.ToString() == "Pre_booking")
            {
                con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
                con.Open();
                string ss = "select cbid as Cb_Id,idates as I_Date,perticular as Pericular,payee as Payee,amount as Amount from Income where cbid='" + txtcbid.Text + "' order by cbid desc";
                OleDbDataAdapter obj = new OleDbDataAdapter(ss, con.ConnectionString);
                DataSet ds = new DataSet();
                obj.Fill(ds, "WaterLISDB");
                con.Close();
                dgvinstallment.DataSource = ds;
                dgvinstallment.DataMember = "WaterLISDB";
                con.Close();
            }
        }


        public void SearchCustomer()//search customer in grid view
        {

            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);

            // GlobalClass.adap = new OleDbDataAdapter("SELECT name as Name, address as Address, mobileno as Mobile_No, idproof as Id_Proof, datebooking as Date_Booking, datedelivery as Date_Delivery, totalamount as Total_amount, advamount as Adv_Amount from Customer where name LIKE  '%" + txtsearch.Text + "%' ", con);
            GlobalClass.adap = new OleDbDataAdapter("SELECT * from Customer where name LIKE  '%" + txtsearch.Text + "%' ", con);

            OleDbCommandBuilder bui = new OleDbCommandBuilder(GlobalClass.adap);
            GlobalClass.dt = new DataTable();
            GlobalClass.adap.Fill(GlobalClass.dt);
            gvCustomerBooking.DataSource = GlobalClass.dt;
            gvCustomerBooking.ReadOnly = true;
            //  lstColonyName.Items.Clear();

        }
        public void Searchbooking()//search  booking customer in grid view from text box
        {


            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            //GlobalClass.adap = new OleDbDataAdapter("SELECT cid ,name,address,mobileno,idproof from Customer where name LIKE '" +txtsearch.Text + "%'", con);
            // GlobalClass.adap = new OleDbDataAdapter("SELECT name as Name, address as Address, mobileno as Mobile_No, idproof as Id_Proof, datebooking as Date_Booking, datedelivery as Date_Delivery, totalamount as Total_amount, advamount as Adv_Amount from Booking where name LIKE  '%" + txtsearch.Text + "%' ", con);
            GlobalClass.adap = new OleDbDataAdapter("SELECT *  from Booking where name LIKE  '%" + txtsearch.Text + "%' ", con);
            // GlobalClass.adap = new OleDbDataAdapter("select distinct cname FROM CustomerInfo where cname LIKE '"%"+txtSearchCustomer.Text+"%""', con);
            OleDbCommandBuilder bui = new OleDbCommandBuilder(GlobalClass.adap);
            GlobalClass.dt = new DataTable();
            GlobalClass.adap.Fill(GlobalClass.dt);
            gvCustomerBooking.DataSource = GlobalClass.dt;
            gvCustomerBooking.ReadOnly = true;

        }
      

        public void Search()
        {
            if (ddlselect.SelectedItem.ToString() == "Customer")
            {
                SearchCustomer();
            }
            if (ddlselect.SelectedItem.ToString() == "Pre_booking")
            {
                Searchbooking();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }


        
    }
}
