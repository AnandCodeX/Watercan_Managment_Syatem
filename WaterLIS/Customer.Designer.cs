namespace WaterLIS
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvcustomer = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtidproof = new System.Windows.Forms.TextBox();
            this.txtmobileno = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpriceofcan = new System.Windows.Forms.TextBox();
            this.txtnoofcan = new System.Windows.Forms.TextBox();
            this.lblremainingamt = new System.Windows.Forms.Label();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblidproof = new System.Windows.Forms.Label();
            this.lblmobileno = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblcid = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomer)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(334, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Registration";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 60);
            this.panel1.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvcustomer);
            this.panel7.Location = new System.Drawing.Point(3, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(511, 367);
            this.panel7.TabIndex = 0;
            // 
            // dgvcustomer
            // 
            this.dgvcustomer.AllowUserToAddRows = false;
            this.dgvcustomer.AllowUserToDeleteRows = false;
            this.dgvcustomer.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvcustomer.Name = "dgvcustomer";
            this.dgvcustomer.ReadOnly = true;
            this.dgvcustomer.Size = new System.Drawing.Size(511, 367);
            this.dgvcustomer.TabIndex = 12;
            this.dgvcustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcustomer_CellContentClick);
            this.dgvcustomer.DoubleClick += new System.EventHandler(this.dgvcustomer_DoubleClick);
            // 
            // txtsearch
            // 
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.Color.Gray;
            this.txtsearch.Location = new System.Drawing.Point(167, 3);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(318, 25);
            this.txtsearch.TabIndex = 11;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnremove.FlatAppearance.BorderSize = 0;
            this.btnremove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremove.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.ForeColor = System.Drawing.Color.White;
            this.btnremove.Location = new System.Drawing.Point(252, 405);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(139, 29);
            this.btnremove.TabIndex = 14;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(61, 405);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(139, 29);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.Location = new System.Drawing.Point(124, 54);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(211, 25);
            this.txtname.TabIndex = 2;
            // 
            // txtaddress
            // 
            this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.ForeColor = System.Drawing.Color.Black;
            this.txtaddress.Location = new System.Drawing.Point(124, 94);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(211, 67);
            this.txtaddress.TabIndex = 3;
            this.txtaddress.TextChanged += new System.EventHandler(this.txtaddress_TextChanged);
            // 
            // txtidproof
            // 
            this.txtidproof.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidproof.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidproof.ForeColor = System.Drawing.Color.Black;
            this.txtidproof.Location = new System.Drawing.Point(124, 218);
            this.txtidproof.Name = "txtidproof";
            this.txtidproof.Size = new System.Drawing.Size(211, 25);
            this.txtidproof.TabIndex = 5;
            this.txtidproof.TextChanged += new System.EventHandler(this.txtidproof_TextChanged);
            // 
            // txtmobileno
            // 
            this.txtmobileno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmobileno.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobileno.ForeColor = System.Drawing.Color.Black;
            this.txtmobileno.Location = new System.Drawing.Point(124, 177);
            this.txtmobileno.Name = "txtmobileno";
            this.txtmobileno.Size = new System.Drawing.Size(211, 25);
            this.txtmobileno.TabIndex = 4;
            this.txtmobileno.TextChanged += new System.EventHandler(this.txtmobileno_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtsearch);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.btnremove);
            this.panel3.Controls.Add(this.btnupdate);
            this.panel3.Location = new System.Drawing.Point(438, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 451);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Search by name";
            // 
            // txtcid
            // 
            this.txtcid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcid.Enabled = false;
            this.txtcid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcid.ForeColor = System.Drawing.Color.Red;
            this.txtcid.Location = new System.Drawing.Point(124, 12);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(74, 25);
            this.txtcid.TabIndex = 1;
            this.txtcid.TextChanged += new System.EventHandler(this.txtcid_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtpriceofcan);
            this.panel2.Controls.Add(this.txtnoofcan);
            this.panel2.Controls.Add(this.lblremainingamt);
            this.panel2.Controls.Add(this.dtpdate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblidproof);
            this.panel2.Controls.Add(this.lblmobileno);
            this.panel2.Controls.Add(this.lbladdress);
            this.panel2.Controls.Add(this.lblname);
            this.panel2.Controls.Add(this.lblcid);
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.txtaddress);
            this.panel2.Controls.Add(this.txtidproof);
            this.panel2.Controls.Add(this.txtmobileno);
            this.panel2.Controls.Add(this.txtcid);
            this.panel2.Location = new System.Drawing.Point(1, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 451);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 312);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "price of cane";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtpriceofcan
            // 
            this.txtpriceofcan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpriceofcan.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpriceofcan.ForeColor = System.Drawing.Color.Black;
            this.txtpriceofcan.Location = new System.Drawing.Point(124, 307);
            this.txtpriceofcan.Name = "txtpriceofcan";
            this.txtpriceofcan.Size = new System.Drawing.Size(211, 25);
            this.txtpriceofcan.TabIndex = 7;
            this.txtpriceofcan.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtpriceofcan.Leave += new System.EventHandler(this.txtpriceofcan_Leave);
            // 
            // txtnoofcan
            // 
            this.txtnoofcan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnoofcan.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoofcan.ForeColor = System.Drawing.Color.Black;
            this.txtnoofcan.Location = new System.Drawing.Point(124, 267);
            this.txtnoofcan.Name = "txtnoofcan";
            this.txtnoofcan.Size = new System.Drawing.Size(211, 25);
            this.txtnoofcan.TabIndex = 6;
            this.txtnoofcan.TextChanged += new System.EventHandler(this.txtremainamount_TextChanged);
            // 
            // lblremainingamt
            // 
            this.lblremainingamt.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lblremainingamt.AutoSize = true;
            this.lblremainingamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremainingamt.Location = new System.Drawing.Point(13, 272);
            this.lblremainingamt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblremainingamt.Name = "lblremainingamt";
            this.lblremainingamt.Size = new System.Drawing.Size(88, 20);
            this.lblremainingamt.TabIndex = 43;
            this.lblremainingamt.Text = "no. of cane";
            this.lblremainingamt.Click += new System.EventHandler(this.lblremainingamt_Click);
            // 
            // dtpdate
            // 
            this.dtpdate.Location = new System.Drawing.Point(124, 356);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(211, 20);
            this.dtpdate.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 356);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Date";
            // 
            // lblidproof
            // 
            this.lblidproof.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lblidproof.AutoSize = true;
            this.lblidproof.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidproof.Location = new System.Drawing.Point(13, 223);
            this.lblidproof.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblidproof.Name = "lblidproof";
            this.lblidproof.Size = new System.Drawing.Size(68, 20);
            this.lblidproof.TabIndex = 14;
            this.lblidproof.Text = "ID Proof";
            this.lblidproof.Click += new System.EventHandler(this.lblidproof_Click);
            // 
            // lblmobileno
            // 
            this.lblmobileno.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lblmobileno.AutoSize = true;
            this.lblmobileno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmobileno.Location = new System.Drawing.Point(13, 177);
            this.lblmobileno.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblmobileno.Name = "lblmobileno";
            this.lblmobileno.Size = new System.Drawing.Size(83, 20);
            this.lblmobileno.TabIndex = 13;
            this.lblmobileno.Text = "Mobile No.";
            this.lblmobileno.Click += new System.EventHandler(this.lblmobileno_Click);
            // 
            // lbladdress
            // 
            this.lbladdress.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(13, 95);
            this.lbladdress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(68, 20);
            this.lbladdress.TabIndex = 12;
            this.lbladdress.Text = "Address";
            // 
            // lblname
            // 
            this.lblname.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(13, 59);
            this.lblname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(51, 20);
            this.lblname.TabIndex = 11;
            this.lblname.Text = "Name";
            this.lblname.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblcid
            // 
            this.lblcid.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lblcid.AutoSize = true;
            this.lblcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcid.Location = new System.Drawing.Point(13, 17);
            this.lblcid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblcid.Name = "lblcid";
            this.lblcid.Size = new System.Drawing.Size(42, 20);
            this.lblcid.TabIndex = 10;
            this.lblcid.Text = "C-ID";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(221, 405);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(97, 29);
            this.btnback.TabIndex = 10;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(73, 405);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(84, 29);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(967, 533);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvcustomer;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtidproof;
        private System.Windows.Forms.TextBox txtmobileno;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblidproof;
        private System.Windows.Forms.Label lblmobileno;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblcid;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpriceofcan;
        private System.Windows.Forms.TextBox txtnoofcan;
        private System.Windows.Forms.Label lblremainingamt;
    }
}