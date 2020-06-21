using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using MetroFramework.Forms;

namespace WaterLIS
{
    public partial class LoginLIS : Form
    {
        public LoginLIS()
        {
            InitializeComponent();
        }

        private void LoginLIS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if(txtusername.Text=="admin"&& txtpassword.Text=="super")
            {
                MainFormLIS M = new MainFormLIS();
                M.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show ( "Enter correct Username and Password");
            }



            //============================================================================================

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
