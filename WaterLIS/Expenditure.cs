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
    public partial class Expenditure : Form
    {
        public Expenditure()
        {
            InitializeComponent();
        }
        //------------------------------functon-----------
        private void generate_exid()
        {
            // MessageBox.Show("First");
            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new OleDbCommand();
            con.Open();
            cmd.CommandText = "select exid from Expenditure order by exid  desc ";
            cmd.Connection = con;
            object obj = cmd.ExecuteScalar();
            if (obj == null)
            {
                //  MessageBox.Show("Second");
                txtexid.Text = "1";
            }
            else
            {
                // MessageBox.Show("Third");
                int n = Convert.ToInt32(obj);
                n = n + 1;
                txtexid.Text = n.ToString();
            }
            con.Close();
        //    con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
        //    cmd = new OleDbCommand();
        //    con.Open();
        //    cmd.CommandText = "select exi from Booking order by exno  desc ";
        //    cmd.Connection = con;
        //    object obj = cmd.ExecuteScalar();
        //    if (obj == null)
        //    {
        //        txtexid.Text = "100";
        //    }
        //    else
        //    {
        //        int n = Convert.ToInt32(obj);
        //        n = n + 1;
        //        txtcid.Text = "B" + n;
        //    }
        //    con.Close();
        }
        //--------------------------------------------------
        //public void ShowExpenditure()
        //{

        //    con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
        //    //GlobalClass.adap = new OleDbDataAdapter("SELECT cid ,name,address,mobileno,idproof from Customer where name LIKE '" +txtsearch.Text + "%'", con);
        //    GlobalClass.adap = new OleDbDataAdapter("SELECT etype as Etype, amount as Amount, paidto as Paidto, remark as Remark from Expenditure", con);
        //    // GlobalClass.adap = new OleDbDataAdapter("select distinct cname FROM CustomerInfo where cname LIKE '"+txtSearchCustomer.Text+"%'", con);
        //    OleDbCommandBuilder bui = new OleDbCommandBuilder(GlobalClass.adap);
        //    GlobalClass.dt = new DataTable();
        //    GlobalClass.adap.Fill(GlobalClass.dt);
        //    dgvexpenditure.DataSource = GlobalClass.dt;
        //    dgvexpenditure.ReadOnly = true;
        //    //  lstColonyName.Items.Clear();

        //}
        public void AddEtype()
        {
            ddlEType.Items.Clear();
            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select distinct(etype) from Etype";
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ddlEType.Items.Add(dr.GetString(0).ToString());

            }
            con.Close();

        }

        private void Expenditure_Load(object sender, EventArgs e)
        {
            ShowCustomer();
            //ShowExpenditure();

            generate_exid();
            AddEtype();
            SearchEmployee();
            Total();
        }
        OleDbCommand cmd;
        OleDbConnection con;


        private void button1_Click(object sender, EventArgs e)
        {
            panelExpenceType.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelExpenceType.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*  public void Total()
          {
              //con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
              //GlobalClass.adap = new OleDbDataAdapter("select amount from Expenditure where sum(amount)", con);
              //OleDbCommandBuilder bui = new OleDbCommandBuilder(GlobalClass.adap);
              //GlobalClass.dt = new DataTable();
              //GlobalClass.adap.Fill(GlobalClass.dt);
              //dgvexpenditure.DataSource = GlobalClass.dt;
              //dgvexpenditure.ReadOnly = true;
              con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
              cmd = new OleDbCommand();
              con.Open();
              cmd.Connection = con;
              cmd.CommandText = "select amount from Expenditure where sum(amount)" + Convert.ToInt32(txtamount.Text) + "')";
              OleDbCommandBuilder bui = new OleDbCommandBuilder(GlobalClass.adap);
              GlobalClass.dt = new DataTable();
              GlobalClass.adap.Fill(GlobalClass.dt);
              dgvexpenditure.DataSource = GlobalClass.dt;
              dgvexpenditure.ReadOnly = true;
              int n = cmd.ExecuteNonQuery();
              if (n > 0)
              {
                  MessageBox.Show("total successfully Successfully..!");
              }*/



        public void SearchEmployee()
        {

            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            //GlobalClass.adap = new OleDbDataAdapter("SELECT cid ,name,address,mobileno,idproof from Customer where name LIKE '" +txtsearch.Text + "%'", con);
           GlobalClass.adap = new OleDbDataAdapter("SELECT * from Expenditure WHERE dates BETWEEN  #"+dtpfrom.Value.ToString("MM/dd/yyyy")+ "# AND #" + dtpto.Value.ToString("MM/dd/yyyy") + "#", con);
           // GlobalClass.adap = new OleDbDataAdapter("SELECT * from Expenditure WHERE dates =@dates", con);
            // GlobalClass.adap = new OleDbDataAdapter("select distinct cname FROM CustomerInfo where cname LIKE '"+txtSearchCustomer.Text+"%'", con);
            OleDbCommandBuilder bui = new OleDbCommandBuilder(GlobalClass.adap);
            GlobalClass.dt = new DataTable();
            GlobalClass.adap.Fill(GlobalClass.dt);
            dgvexpenditure.DataSource = GlobalClass.dt;
            dgvexpenditure.ReadOnly = true;
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            SearchEmployee();
            Total();
        }
        public void Total()
        {
            // txttotal.Text = this.dgvexpenditure.CurrentRow.Cells[2].Value.ToString();
            int sum = 0;
            for (int i = 0; i < dgvexpenditure.Rows.Count;i++)
            {
                sum += int.Parse(dgvexpenditure.Rows[i].Cells[2].Value.ToString());

            }
           // MessageBox.Show(sum.ToString());
            txttotal.Text = sum.ToString();
        }

        public void Addetype()
        {
            ddlEType.Items.Clear();
            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select distinct(etype) from Expenditure";
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ddlEType.Items.Add(dr.GetString(0).ToString());

            }
            con.Close();

        }

        private void btnadde_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtaddexp.Text))
            {
                MessageBox.Show("Please Enter Valid data...");
            }
            else
            {
                OleDbConnection con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
                con.Open();
                OleDbCommand com = new OleDbCommand();
                com.CommandText = "insert into Etype(etype)Values('" + txtaddexp.Text + "')";
                com.Connection = con;
                int n = com.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Record insert successfully");
                }


                AddEtype();
                txtaddexp.Text="";
            }
        }

        private void btntotal_Click(object sender, EventArgs e)
        {



        }
        // *******************fun******************
        public void ShowCustomer()
        {

            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            GlobalClass.adap = new OleDbDataAdapter(" Select * from Expenditure", con);
            // GlobalClass.adap = new OleDbDataAdapter("SELECT exid as Ex_ID,etype as E_Type,amount as Amount,paidto as PaidTo,date as Date, remark as Remark from Expenditure", con);
            OleDbCommandBuilder bui = new OleDbCommandBuilder(GlobalClass.adap);
            GlobalClass.dt = new DataTable();
            GlobalClass.adap.Fill(GlobalClass.dt);
            dgvexpenditure.DataSource = GlobalClass.dt;
            dgvexpenditure.ReadOnly = true;
            //  lstColonyName.Items.Clear();
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            string exr = "";
            exr = Validation.ExpenditureValidation(txtamount.Text,txtpaidto.Text);
            if (exr!="")
            {
                MessageBox.Show(exr);
            }
            else
            {
                OleDbConnection con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
                OleDbCommand cmd = new OleDbCommand();
                con.Open();
                
             //cmd.CommandText = "insert into Expenditure(exid as Ex_Id,etype as E_Type,amount as Amount,paidto as Paid_To,dates as Dates,remark as Remark) Values(@exid,@etype,@amount,@paidto,@dates,@remark)";
              cmd.CommandText = "insert into Expenditure(exid,etype,amount,paidto,dates,remark)Values(" + txtexid.Text + ",'" + ddlEType.SelectedItem.ToString() + "'," + txtamount.Text + ",'" + txtpaidto.Text + "','" + dtpdate.Value.ToShortDateString() + "','" + txtremark.Text + "')";

                //cmd.Parameters.AddWithValue("@exid", Convert.ToInt32(txtexid.Text));
                //cmd.Parameters.AddWithValue("@etype", ddlEType.SelectedItem.ToString());
                //cmd.Parameters.AddWithValue("@amount", Convert.ToInt32( txtamount.Text));
                //cmd.Parameters.AddWithValue("@paidto", txtpaidto.Text);
                //cmd.Parameters.AddWithValue("@dates", dtpdate.Value.ToShortDateString());
                //cmd.Parameters.AddWithValue("@remark", txtremark.Text);

                 cmd.Connection = con;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Record insert successfully");
                }
                txtexid.Text = "";
                ddlEType.Text = "";
                txtamount.Text = "";
                txtpaidto.Text = "";
                dtpdate.Text = DateTime.Now.ToShortDateString();
                txtremark.Text = "";

                con.Close();
                ShowCustomer();
                generate_exid();
                Total();

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new OleDbCommand();
            con.Open();
            cmd.CommandText = "update Expenditure set etype='" + ddlEType.SelectedItem.ToString()+ "',amount=" +txtamount.Text + ",paidto='" +txtpaidto.Text + "',dates='" + dtpdate.Value.ToShortDateString() + "',remark='"+txtremark+"' where exid='" +txtexid.Text+"'";
            //cmd.CommandText = "update Expenditure set(exid=@exid,etype=@etype,amount=@amount,paidto=@paidto,dates=@dates,remark=@remark where exid=@exid)";
            cmd.Connection = con;

            //cmd.Parameters.AddWithValue("@exid", txtexid.Text);
            //cmd.Parameters.AddWithValue("@etype", ddlEType.SelectedItem.ToString());
            //cmd.Parameters.AddWithValue("@amount",txtamount.Text);
            //cmd.Parameters.AddWithValue("@paidto",txtpaidto.Text);
            //cmd.Parameters.AddWithValue("@dates", dtpdate.Value.ToShortDateString());
            //cmd.Parameters.AddWithValue("@remark", txtremark.Text);

             int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Record Update Successfully..!");
            }

            txtexid.Text = "";
            ddlEType.Text = "";
            txtamount.Text = "";
           txtpaidto.Text = "";
             dtpdate.Text = DateTime.Now.ToShortDateString();
             txtremark.Text="";

            ShowCustomer();
            generate_exid();
            btnsave.Enabled = true;

            //insert into gridview...----------------
        }

        private void dgvexpenditure_DoubleClick(object sender, EventArgs e)
        {
            txtexid.Text = this.dgvexpenditure.CurrentRow.Cells[0].Value.ToString();
            ddlEType.Text = this.dgvexpenditure.CurrentRow.Cells[1].Value.ToString();
            txtamount.Text = this.dgvexpenditure.CurrentRow.Cells[2].Value.ToString();
            txtpaidto.Text = this.dgvexpenditure.CurrentRow.Cells[3].Value.ToString();
            dtpdate.Text = this.dgvexpenditure.CurrentRow.Cells[4].Value.ToString();
            txtremark.Text = this.dgvexpenditure.CurrentRow.Cells[5].Value.ToString();
            btnsave.Enabled = false;
        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from Expenditure Where exid='" + Convert.ToInt32(txtexid.Text) + "'";

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Record Deleted Successfully..!");
            }



            txtexid.Text = "";
            ddlEType.Text = "";
            txtamount.Text = "";
            txtpaidto.Text = "";
            dtpdate.Text = DateTime.Now.ToShortDateString();
            txtremark.Text = "";

            ShowCustomer();
            generate_exid();
            Total();
        }

        private void dgvexpenditure_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txttotal.Text = this.dgvexpenditure.CurrentRow.Cells[2].Value.ToString();
           // txtAddress.Text = this.dgvexpenditure.CurrentRow.Cells[1].Value.ToString();
            //TxtMobno.Text = this.dgvexpenditure.CurrentRow.Cells[2].Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbladdexp_Click(object sender, EventArgs e)
        {

        }
    }
}



