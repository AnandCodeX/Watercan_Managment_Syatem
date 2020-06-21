using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WaterLIS
{
    public partial class MainFormLIS : Form
    {
        public MainFormLIS()
        {
            InitializeComponent();
        }

        private void MainFormLIS_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Installment I1 = new Installment();
            I1.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer C1 = new Customer();
            C1.ShowDialog();
        }

        private void employeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeLIS E = new EmployeeLIS();
            E.ShowDialog();
        }

        private void expendictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expenditure EC = new Expenditure();
            EC.ShowDialog();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Learn To Fight Alone...!");
        }

        private void installmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void preBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking B = new Booking();
            B.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Install i = new Install();
            i.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
