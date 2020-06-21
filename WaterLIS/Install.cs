using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace WaterLIS
{
    public partial class Install : Form
    {
        public Install()
        {
            InitializeComponent();
        }
        OleDbCommand cmd;
        OleDbConnection con;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Install_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            con.Open();
            //cmd = new OleDbCommand();
            //OleDbDataReader dr = cmd.ExecuteReader();
            string ss = "select cid,name, totalamount,advamount,remainingamount,amount from Booking,Expenditure ";

            OleDbDataAdapter obj = new OleDbDataAdapter(ss, con.ConnectionString);
            DataSet ds = new DataSet();
            obj.Fill(ds, "WaterLISDB");
            con.Close();
            dgvinstallment.DataSource = ds;
            dgvinstallment.DataMember = "WaterLISDB";

            // cmd.Connection = con;



        }

        private void lbleid_Click(object sender, EventArgs e)
        {

        }


        private void btnsave_Click(object sender, EventArgs e)
        {
             con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new OleDbCommand();
            con.Open();
            
            cmd.Connection = con;
            cmd.CommandText = "insert into Income(iid,idate,perticular,amount,remark) values(@iid,@idate,@perticular,@amount,)";
            cmd.Parameters.AddWithValue("@iid",txtiid.Text);
            cmd.Parameters.AddWithValue("@idate",dtpdate.Text);
           // cmd.Parameters.AddWithValue("@perticular",.Text);
           // cmd.Parameters.AddWithValue("@amount",txta.Text);
            //cmd.Parameters.AddWithValue("@datebooking", dtpbooking.Value .ToShortDateString ());
            //cmd.Parameters.AddWithValue("@datedelivery", dtpdelivery.Value.ToShortDateString());
            //cmd.Parameters.AddWithValue("@totalamount", txttotalamount.Text);
            //cmd.Parameters.AddWithValue("@advamount", txtadvamount.Text);
            //cmd.Parameters.AddWithValue("@remainingamount", txtremainamount.Text);
            //cmd.Parameters.AddWithValue("@cid", txtcid.Text);

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Record Insert Successfully..!");
            }
            //txtcid.Text = "";
            //txtname.Text = "";
            //txtaddress.Text = "";
            //dtpbooking.Text = DateTime.Now.ToShortDateString();
            //dtpdelivery.Text = DateTime.Now.ToShortDateString();
            //txtmobileno.Text = "";
            //txtidproof.Text = "";
            //txttotalamount.Text = "";
            //txtadvamount.Text = "";
            //txtnoofcan.Text = "";

            //cmd.CommandText = "update Booking set name='" + txtname.Text + "',mobileno=" + txtmobileno.Text + ",address='" + txtaddress.Text + "',idproof='" + txtidproof.Text + "',datebooking='" + dtpbooking.Value.ToShortDateString() + "', where cid=" + txtcid.Text + "";

            //int n = cmd.ExecuteNonQuery();
            //if (n > 0)
            //{
            //    MessageBox.Show("Record Update Successfully..!");
            //}

            //txtcid.Text = "";
            //txtname.Text = "";
            //txtaddress.Text = "";
            //dtpbooking.Text = DateTime.Now.ToShortDateString();
            //dtpdelivery.Text = DateTime.Now.ToShortDateString();
            //txtmobileno.Text = "";
            //txtidproof.Text = "";
            //txttotalamount.Text = "";
            //txtadvamount.Text = "";
            //txtnoofcan.Text = "";

        }
    }
}
