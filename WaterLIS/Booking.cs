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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand cmd;
        //Functions------------------------------------------------------------------------------
        public void Total()
        {
            // txttotal.Text = this.dgvexpenditure.CurrentRow.Cells[2].Value.ToString();
            int sum = 0;
            for (int i = 0; i < dgvprebooking.Rows.Count; i++)
            {
                sum += int.Parse(dgvprebooking.Rows[i].Cells[10].Value.ToString());

            }
            // MessageBox.Show(sum.ToString());
           // txtbtotal .Text = sum.ToString();
        }
        public void showBooking()
        {
            //Show All Booking
            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            //GlobalClass.adap = new OleDbDataAdapter("SELECT cid ,name,address,mobileno,idproof from Customer where name LIKE '" +txtsearch.Text + "%'", con);
            //  GlobalClass.adap = new OleDbDataAdapter("SELECT bid as B_ID,name as Name,address as Address,mobileno as Mobile_No,idproof as Id_Proof,datebooking as Date_Booking, datedelivery as Date_Delivery,noofcans as No_Of_Cane,priceofcan as Price_Of_Cans, totalamount as Total_amount, advamount as Adv_Amount,remainingamount as Remaining_amount from Booking", con);
            GlobalClass.adap = new OleDbDataAdapter("SELECT * from Booking", con);
            // GlobalClass.adap = new OleDbDataAdapter("select distinct cname FROM CustomerInfo where cname LIKE '"+txtSearchCustomer.Text+"%'", con);
            OleDbCommandBuilder bui = new OleDbCommandBuilder(GlobalClass.adap);
            GlobalClass.dt = new DataTable();
            GlobalClass.adap.Fill(GlobalClass.dt);
            dgvprebooking.DataSource = GlobalClass.dt;
            dgvprebooking.ReadOnly = true;
            //  lstColonyName.Items.Clear();



            //show Total Amount
            int ta = 0, adva = 0, ra = 0;
            int sum = 0;
            for (int i = 0; i < dgvprebooking.Rows.Count; i++)
            {
                ta += int.Parse(dgvprebooking.Rows[i].Cells[9].Value.ToString());
                adva += int.Parse(dgvprebooking.Rows[i].Cells[10].Value.ToString());
                ra += int.Parse(dgvprebooking.Rows[i].Cells[11].Value.ToString());
                lblttotal .Text = "" + ta;
                lblaadv .Text = "" + adva;
                lblrremain .Text = "" + ra;

            }


        }
        //---------------------------------------------------------------------------------------------------
        public void Searchcustomer()
        {
            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
           GlobalClass.adap = new OleDbDataAdapter("SELECT name as Name, address as Address, mobileno as Mobile_No, idproof as Id_Proof, datebooking as Date_Booking, datedelivery as Date_Delivery, totalamount as Total_amount, advamount as Adv_Amount from Booking where name LIKE  '%" + txtsearch.Text + "%' ", con);
           OleDbCommandBuilder bui = new OleDbCommandBuilder(GlobalClass.adap);
            GlobalClass.dt = new DataTable();
            GlobalClass.adap.Fill(GlobalClass.dt);
            dgvprebooking.DataSource = GlobalClass.dt;
            dgvprebooking.ReadOnly = true;
        }
        //------------------------------------------------------------------------------------------------------------
        //private void Remainingamount()
        //{
        //    int r, t, a;
        //    r = Convert.ToInt32(txtremainamount.Text);
        //    t = Convert.ToInt32(txttotalamount.Text);
        //    a = Convert.ToInt32(txtadvamount.Text);
        //    r = t - a;
        //    txtnoofcan.Text = "" + r;
        //}
        private void generate_id()
        {
            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new OleDbCommand();
            con.Open();
            cmd.CommandText = "select bid from Booking order by bid  desc ";
            cmd.Connection = con;
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string bid = dr.GetString(0);
                int v = Convert.ToInt32(bid.Substring(1)) + 1;
                txtbid.Text = "B" + v;

            }
            else
            {
                txtbid.Text = "B100";
            }
            con.Close();

        }
        //Function Close----------------------------------------------------------------------------

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string bmr = "";
            bmr = Validation.BookingValidation(txtname.Text, txtmobileno.Text, txtidproof.Text, txtnoofcan.Text, txtpriceofcane.Text,txttotalamount.Text,txtadvamount.Text,txtremainamount.Text);
            if (bmr != "")
            {
                MessageBox.Show(bmr);
            }
            else
            {


                // Booking table
                int ra = Convert.ToInt32(txttotalamount.Text) - Convert.ToInt32(txtadvamount.Text);

                con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                //  MessageBox.Show("inset");
                // cmd.CommandText = "insert into Booking(bid,name,address,mobileno,idproof,noofcans,priceofcan,dates) values( @bid,@name,@address,@mobileno,@idproof,@noofcans,@priceofcan,@dates)";
                cmd.CommandText = "insert into Booking(bid,name,address,mobileno,idproof,datebooking,datedelivery,noofcane,priceofcane,totalamount,advamount,remainingamount) values( @bid,@name,@address,@mobileno,@idproof,@dtpbooking,@dtpdelivery,@noofcane,@priceofcane,@totalamount,@advamount,@remainingamount)";
                cmd.Parameters.AddWithValue("@bid", txtbid.Text);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@mobileno", txtmobileno.Text);
                cmd.Parameters.AddWithValue("@idproof", txtidproof.Text);

                cmd.Parameters.AddWithValue("@datebooking", dtpbooking.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@datedelivery", dtpdelivery.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@noofcane", Convert.ToInt32(txtnoofcan.Text));
                cmd.Parameters.AddWithValue("@priceofcane", Convert.ToInt32(txtpriceofcane.Text));
                cmd.Parameters.AddWithValue("@totalamount", Convert.ToInt32(txttotalamount.Text));
                cmd.Parameters.AddWithValue("@advamount", Convert.ToInt32(txtadvamount.Text));
                cmd.Parameters.AddWithValue("@remainingamount", Convert.ToInt32(txtremainamount.Text));

                int x = cmd.ExecuteNonQuery();

                if (x > 0)
                {
                    MessageBox.Show("Record Insert Successfully in Booking..!");
                    // generate_id();
                }


                con.Close();


                //}

                //insert data into Income Table from booking
                if (Convert.ToInt32(txtadvamount.Text) > 0)
                {
                    con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
                    cmd = new OleDbCommand();
                    con.Open();
                    //  MessageBox.Show("insert in income");

                    cmd.Connection = con;
                    cmd.CommandText = "insert into Income(cbid,name,idates,perticular,amount) values(@cbid,@name,@idates,@perticular,@amount)";
                    // cmd.Parameters.AddWithValue("@iid", Convert.ToInt32(txtbid.Text));
                    cmd.Parameters.AddWithValue("@cbid", txtbid.Text);
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@idates", dtpbooking.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@perticular", "Pre-Booking");
                    //cmd.Parameters.AddWithValue("@payee", txtname.Text);
                    cmd.Parameters.AddWithValue("@amount", txtadvamount.Text);

                    int k = cmd.ExecuteNonQuery();

                    if (k > 0)
                    {
                        MessageBox.Show("Record Insert Successfully in Income..!");

                    }
                    txtname.Text = "";
                    txtaddress.Text = "";
                    txtmobileno.Text = "";
                    txtidproof.Text = "";
                    dtpbooking.Text = DateTime.Now.ToShortDateString();
                    dtpdelivery.Text = DateTime.Now.ToShortDateString();
                    txtnoofcan.Text = "";
                    txtpriceofcane.Text = "";
                    txttotalamount.Text = "";
                    txtadvamount.Text = "";
                    txtremainamount.Text = "";
                    con.Close();
                    generate_id();
                }




                //txtiid.Text = "";
                txtname.Text = "";
                txtaddress.Text = "";
                dtpbooking.Text = DateTime.Now.ToShortDateString();
                dtpdelivery.Text = DateTime.Now.ToShortDateString();
                txtmobileno.Text = "";
                txtidproof.Text = "";
                //txttotalamount.Text = "";
                //txtadvamount.Text = "";
                //txtnoofcan.Text = "";

                showBooking();
                generate_id();



            } 
        
       
        }
        private void Booking_Load(object sender, EventArgs e)
        {
            Total();
            generate_id();
            showBooking();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd;
            OleDbConnection con;
            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new OleDbCommand();
            con.Open();
           cmd.CommandText = "update Booking set name='"+ txtname.Text + "',address='"+txtaddress .Text +"',mobileno=" + txtmobileno.Text + ",idproof='" + txtidproof.Text + "',datebooking='"+dtpbooking .Value .ToShortDateString ()+ "',datedelivery='"+dtpdelivery .Value .ToShortDateString ()+"',noofcane="+txtnoofcan .Text+",priceofcane="+txtpriceofcane .Text +",totalamount="+txttotalamount .Text +",advamount="+txtadvamount.Text +",remainingamount="+txtremainamount .Text +" where bid='" + txtbid.Text + "' ";
            //cmd.CommandText = "update Booking set(name=@name,address=@address,mobileno=@mobileno,idproof=@idproof,datebooking=@datebooking,datedelivery=@datedelivery,noofcane= @noofcane,priceofcane=@priceofcane where bid=@bid)";
            //cmd.Parameters.AddWithValue("@name", txtname.Text);
            //cmd.Parameters.AddWithValue("@address", txtaddress.Text);
            //cmd.Parameters.AddWithValue("@mobileno", txtmobileno.Text);
            //cmd.Parameters.AddWithValue("@idproof", txtidproof.Text);
            //cmd.Parameters.AddWithValue("@datebooking", dtpbooking.Value.ToShortDateString());
            //cmd.Parameters.AddWithValue("@datedelivery", dtpdelivery.Value.ToShortDateString());
            //cmd.Parameters.AddWithValue("@noofcane",txtnoofcan.Text);
            //cmd.Parameters.AddWithValue("@priceofcane", txtpriceofcane.Text);
            //cmd.Parameters.AddWithValue("@totalamount", Convert.ToInt32 (txttotalamount.Text));
            //cmd.Parameters.AddWithValue("@advamount", txtadvamount.Text);
            //cmd.Parameters.AddWithValue("@remainingamount", txtremainamount.Text);
            // cmd.Parameters.AddWithValue("@cid", txtbid.Text);
            cmd.Connection = con;

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Record Update Successfully..!");
            }

            txtname.Text = "";
            txtaddress.Text = "";
            dtpbooking.Text = DateTime.Now.ToShortDateString();
            dtpdelivery.Text = DateTime.Now.ToShortDateString();
            txtmobileno.Text = "";
            txtidproof.Text = "";
            txttotalamount.Text = "";
            txtadvamount.Text = "";
            txtnoofcan.Text = "";
            txtpriceofcane.Text = "";
            txtremainamount.Text = "";
            //insert into gridview...----------------

            showBooking();
            generate_id();
            btnsave.Enabled = true;
        }


        private void btnremove_Click(object sender, EventArgs e)
        {

            con = new OleDbConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from Booking Where bid='" + txtbid.Text + "'";

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Record Deleted Successfully..!");
            }

            txtbid.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            dtpbooking.Text = DateTime.Now.ToShortDateString();
            dtpdelivery.Text = DateTime.Now.ToShortDateString();
            txtmobileno.Text = "";
            txtidproof.Text = "";
            txttotalamount.Text = "";
            txtadvamount.Text = "";
            txtnoofcan.Text = "";
            txtpriceofcane.Text = "";
            txtremainamount.Text = "";

            showBooking();
            generate_id();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            Searchcustomer();
        }

        private void dgvprebooking_DoubleClick(object sender, EventArgs e)
        {

            txtbid.Text = this.dgvprebooking.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = this.dgvprebooking.CurrentRow.Cells[1].Value.ToString();
            txtaddress.Text = this.dgvprebooking.CurrentRow.Cells[2].Value.ToString();
            txtmobileno.Text = this.dgvprebooking.CurrentRow.Cells[3].Value.ToString();
            txtidproof.Text = this.dgvprebooking.CurrentRow.Cells[4].Value.ToString();
            dtpbooking.Text = this.dgvprebooking.CurrentRow.Cells[5].Value.ToString();
            dtpdelivery.Text = this.dgvprebooking.CurrentRow.Cells[6].Value.ToString();
            txtnoofcan .Text =this.dgvprebooking.CurrentRow.Cells[7].Value.ToString();
            txtpriceofcane .Text =this .dgvprebooking.CurrentRow.Cells[8].Value.ToString();
            txttotalamount.Text = this.dgvprebooking.CurrentRow.Cells[9].Value.ToString();
            txtadvamount.Text = this.dgvprebooking.CurrentRow.Cells[10].Value.ToString();
            txtremainamount .Text= this.dgvprebooking.CurrentRow.Cells[11].Value.ToString();
            btnsave.Enabled = false;
        }

        private void dgvprebooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            int p, n, t;
            p = Convert.ToInt32(txtnoofcan.Text);
            n = Convert.ToInt32(txtpriceofcane.Text);
            t = p * n;
            txttotalamount.Text = t.ToString();
        }

        private void txtnoofcan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttotalamount_TextChanged(object sender, EventArgs e)
        {
            //int p,n,t;
            //p = Convert.ToInt32(txtnoofcan.Text);
            //n=Convert.ToInt32(txtpriceofcane.Text);
            //t = p * n;
            //txttotalamount.Text = t.ToString();
        }

        private void txtremainamount_Leave(object sender, EventArgs e)
        { int r, t, a;
            //r = Convert.ToInt32(txtremainamount.Text);
             t = Convert.ToInt32(txttotalamount.Text);
            a=Convert .ToInt32 (txtadvamount.Text);
            r = t - a;
            txtremainamount.Text = r.ToString();

        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            Total();
        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


