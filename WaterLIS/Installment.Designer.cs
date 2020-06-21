namespace WaterLIS
{
    partial class Installment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnshow = new System.Windows.Forms.Button();
            this.ddlselect = new System.Windows.Forms.ComboBox();
            this.lblselect = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.gvCustomerBooking = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvinstallment = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtpayee = new System.Windows.Forms.TextBox();
            this.lblpayee = new System.Windows.Forms.Label();
            this.dtpidate = new System.Windows.Forms.DateTimePicker();
            this.lblidate = new System.Windows.Forms.Label();
            this.txtcbid = new System.Windows.Forms.TextBox();
            this.txtiname = new System.Windows.Forms.TextBox();
            this.lbliname = new System.Windows.Forms.Label();
            this.lblcbid = new System.Windows.Forms.Label();
            this.tnsave = new System.Windows.Forms.Button();
            this.txtpaidamount = new System.Windows.Forms.TextBox();
            this.txtremaningamount = new System.Windows.Forms.TextBox();
            this.lbliremainingamount = new System.Windows.Forms.Label();
            this.lblpaidamount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerBooking)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnshow);
            this.panel1.Controls.Add(this.ddlselect);
            this.panel1.Controls.Add(this.lblselect);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 121);
            this.panel1.TabIndex = 0;
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnshow.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(194, 77);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(96, 30);
            this.btnshow.TabIndex = 2;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // ddlselect
            // 
            this.ddlselect.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlselect.FormattingEnabled = true;
            this.ddlselect.Items.AddRange(new object[] {
            "Customer",
            "Pre_booking"});
            this.ddlselect.Location = new System.Drawing.Point(150, 31);
            this.ddlselect.Name = "ddlselect";
            this.ddlselect.Size = new System.Drawing.Size(199, 30);
            this.ddlselect.TabIndex = 1;
            // 
            // lblselect
            // 
            this.lblselect.AutoSize = true;
            this.lblselect.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselect.Location = new System.Drawing.Point(39, 39);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(64, 22);
            this.lblselect.TabIndex = 0;
            this.lblselect.Text = "Select";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtsearch);
            this.panel2.Controls.Add(this.gvCustomerBooking);
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 397);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(279, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "Search by name";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(43, 20);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(203, 20);
            this.txtsearch.TabIndex = 3;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // gvCustomerBooking
            // 
            this.gvCustomerBooking.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.gvCustomerBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomerBooking.Location = new System.Drawing.Point(0, 71);
            this.gvCustomerBooking.Name = "gvCustomerBooking";
            this.gvCustomerBooking.Size = new System.Drawing.Size(485, 323);
            this.gvCustomerBooking.TabIndex = 5;
            this.gvCustomerBooking.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinstallment_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dgvinstallment);
            this.panel3.Location = new System.Drawing.Point(491, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 187);
            this.panel3.TabIndex = 0;
            // 
            // dgvinstallment
            // 
            this.dgvinstallment.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvinstallment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinstallment.Location = new System.Drawing.Point(0, 0);
            this.dgvinstallment.Name = "dgvinstallment";
            this.dgvinstallment.Size = new System.Drawing.Size(464, 187);
            this.dgvinstallment.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.txtpayee);
            this.panel4.Controls.Add(this.lblpayee);
            this.panel4.Controls.Add(this.dtpidate);
            this.panel4.Controls.Add(this.lblidate);
            this.panel4.Controls.Add(this.txtcbid);
            this.panel4.Controls.Add(this.txtiname);
            this.panel4.Controls.Add(this.lbliname);
            this.panel4.Controls.Add(this.lblcbid);
            this.panel4.Controls.Add(this.tnsave);
            this.panel4.Controls.Add(this.txtpaidamount);
            this.panel4.Controls.Add(this.txtremaningamount);
            this.panel4.Controls.Add(this.lbliremainingamount);
            this.panel4.Controls.Add(this.lblpaidamount);
            this.panel4.Location = new System.Drawing.Point(490, 193);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(464, 326);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txtpayee
            // 
            this.txtpayee.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpayee.Location = new System.Drawing.Point(231, 232);
            this.txtpayee.Name = "txtpayee";
            this.txtpayee.Size = new System.Drawing.Size(141, 29);
            this.txtpayee.TabIndex = 10;
            // 
            // lblpayee
            // 
            this.lblpayee.AutoSize = true;
            this.lblpayee.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayee.Location = new System.Drawing.Point(39, 235);
            this.lblpayee.Name = "lblpayee";
            this.lblpayee.Size = new System.Drawing.Size(64, 22);
            this.lblpayee.TabIndex = 12;
            this.lblpayee.Text = "Payee";
            // 
            // dtpidate
            // 
            this.dtpidate.Location = new System.Drawing.Point(231, 191);
            this.dtpidate.Name = "dtpidate";
            this.dtpidate.Size = new System.Drawing.Size(181, 20);
            this.dtpidate.TabIndex = 8;
            // 
            // lblidate
            // 
            this.lblidate.AutoSize = true;
            this.lblidate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidate.Location = new System.Drawing.Point(39, 191);
            this.lblidate.Name = "lblidate";
            this.lblidate.Size = new System.Drawing.Size(67, 22);
            this.lblidate.TabIndex = 10;
            this.lblidate.Text = "I_Date";
            // 
            // txtcbid
            // 
            this.txtcbid.Enabled = false;
            this.txtcbid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcbid.Location = new System.Drawing.Point(231, 13);
            this.txtcbid.Name = "txtcbid";
            this.txtcbid.Size = new System.Drawing.Size(141, 29);
            this.txtcbid.TabIndex = 5;
            // 
            // txtiname
            // 
            this.txtiname.Enabled = false;
            this.txtiname.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiname.Location = new System.Drawing.Point(231, 58);
            this.txtiname.Name = "txtiname";
            this.txtiname.Size = new System.Drawing.Size(141, 29);
            this.txtiname.TabIndex = 6;
            // 
            // lbliname
            // 
            this.lbliname.AutoSize = true;
            this.lbliname.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliname.Location = new System.Drawing.Point(39, 61);
            this.lbliname.Name = "lbliname";
            this.lbliname.Size = new System.Drawing.Size(60, 22);
            this.lbliname.TabIndex = 7;
            this.lbliname.Text = "Name";
            // 
            // lblcbid
            // 
            this.lblcbid.AutoSize = true;
            this.lblcbid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcbid.Location = new System.Drawing.Point(39, 16);
            this.lblcbid.Name = "lblcbid";
            this.lblcbid.Size = new System.Drawing.Size(66, 22);
            this.lblcbid.TabIndex = 6;
            this.lblcbid.Text = "Cb_ID";
            // 
            // tnsave
            // 
            this.tnsave.BackColor = System.Drawing.Color.DodgerBlue;
            this.tnsave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnsave.Location = new System.Drawing.Point(161, 278);
            this.tnsave.Name = "tnsave";
            this.tnsave.Size = new System.Drawing.Size(117, 37);
            this.tnsave.TabIndex = 11;
            this.tnsave.Text = "Save";
            this.tnsave.UseVisualStyleBackColor = false;
            this.tnsave.Click += new System.EventHandler(this.tnsave_Click);
            // 
            // txtpaidamount
            // 
            this.txtpaidamount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaidamount.Location = new System.Drawing.Point(231, 144);
            this.txtpaidamount.Name = "txtpaidamount";
            this.txtpaidamount.Size = new System.Drawing.Size(141, 29);
            this.txtpaidamount.TabIndex = 8;
            // 
            // txtremaningamount
            // 
            this.txtremaningamount.Enabled = false;
            this.txtremaningamount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremaningamount.Location = new System.Drawing.Point(231, 104);
            this.txtremaningamount.Name = "txtremaningamount";
            this.txtremaningamount.Size = new System.Drawing.Size(141, 29);
            this.txtremaningamount.TabIndex = 7;
            // 
            // lbliremainingamount
            // 
            this.lbliremainingamount.AutoSize = true;
            this.lbliremainingamount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliremainingamount.Location = new System.Drawing.Point(39, 107);
            this.lbliremainingamount.Name = "lbliremainingamount";
            this.lbliremainingamount.Size = new System.Drawing.Size(165, 22);
            this.lbliremainingamount.TabIndex = 2;
            this.lbliremainingamount.Text = "Remaning Amount";
            // 
            // lblpaidamount
            // 
            this.lblpaidamount.AutoSize = true;
            this.lblpaidamount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaidamount.Location = new System.Drawing.Point(39, 147);
            this.lblpaidamount.Name = "lblpaidamount";
            this.lblpaidamount.Size = new System.Drawing.Size(117, 22);
            this.lblpaidamount.TabIndex = 1;
            this.lblpaidamount.Text = "Paid Amount";
            // 
            // Installment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(954, 520);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Installment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerBooking)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.ComboBox ddlselect;
        private System.Windows.Forms.Label lblselect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gvCustomerBooking;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lbliremainingamount;
        private System.Windows.Forms.Label lblpaidamount;
        private System.Windows.Forms.Button tnsave;
        private System.Windows.Forms.TextBox txtpaidamount;
        private System.Windows.Forms.TextBox txtremaningamount;
        private System.Windows.Forms.DataGridView dgvinstallment;
        private System.Windows.Forms.Label lbliname;
        private System.Windows.Forms.Label lblcbid;
        private System.Windows.Forms.TextBox txtcbid;
        private System.Windows.Forms.TextBox txtiname;
        private System.Windows.Forms.Label lblidate;
        private System.Windows.Forms.TextBox txtpayee;
        private System.Windows.Forms.Label lblpayee;
        private System.Windows.Forms.DateTimePicker dtpidate;
    }
}