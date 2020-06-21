namespace WaterLIS
{
    partial class Expenditure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenditure));
            this.lbletype = new System.Windows.Forms.Label();
            this.txtpaidto = new System.Windows.Forms.TextBox();
            this.txtremark = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.ddlEType = new System.Windows.Forms.ComboBox();
            this.lblfrom = new System.Windows.Forms.Label();
            this.lblto = new System.Windows.Forms.Label();
            this.lblpaidto = new System.Windows.Forms.Label();
            this.lblremark = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvexpenditure = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelExpenceType = new System.Windows.Forms.Panel();
            this.btnadde = new System.Windows.Forms.Button();
            this.txtaddexp = new System.Windows.Forms.TextBox();
            this.lbladdexp = new System.Windows.Forms.Label();
            this.btnbacke = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtexid = new System.Windows.Forms.TextBox();
            this.lblexid = new System.Windows.Forms.Label();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvexpenditure)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelExpenceType.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbletype
            // 
            this.lbletype.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lbletype.AutoSize = true;
            this.lbletype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbletype.Location = new System.Drawing.Point(36, 80);
            this.lbletype.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbletype.Name = "lbletype";
            this.lbletype.Size = new System.Drawing.Size(59, 20);
            this.lbletype.TabIndex = 11;
            this.lbletype.Text = "E-Type";
            // 
            // txtpaidto
            // 
            this.txtpaidto.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.txtpaidto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpaidto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaidto.Location = new System.Drawing.Point(131, 172);
            this.txtpaidto.Margin = new System.Windows.Forms.Padding(5);
            this.txtpaidto.Name = "txtpaidto";
            this.txtpaidto.Size = new System.Drawing.Size(182, 26);
            this.txtpaidto.TabIndex = 4;
            // 
            // txtremark
            // 
            this.txtremark.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.txtremark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtremark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremark.Location = new System.Drawing.Point(131, 268);
            this.txtremark.Margin = new System.Windows.Forms.Padding(5);
            this.txtremark.Multiline = true;
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(182, 50);
            this.txtremark.TabIndex = 6;
            // 
            // txtamount
            // 
            this.txtamount.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.txtamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(131, 124);
            this.txtamount.Margin = new System.Windows.Forms.Padding(5);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(182, 26);
            this.txtamount.TabIndex = 3;
            // 
            // ddlEType
            // 
            this.ddlEType.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.ddlEType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlEType.FormattingEnabled = true;
            this.ddlEType.Items.AddRange(new object[] {
            "Salary"});
            this.ddlEType.Location = new System.Drawing.Point(131, 77);
            this.ddlEType.Margin = new System.Windows.Forms.Padding(5);
            this.ddlEType.Name = "ddlEType";
            this.ddlEType.Size = new System.Drawing.Size(182, 28);
            this.ddlEType.TabIndex = 1;
            this.ddlEType.Text = "Select";
            // 
            // lblfrom
            // 
            this.lblfrom.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lblfrom.AutoSize = true;
            this.lblfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrom.Location = new System.Drawing.Point(7, 17);
            this.lblfrom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(46, 20);
            this.lblfrom.TabIndex = 4;
            this.lblfrom.Text = "From";
            // 
            // lblto
            // 
            this.lblto.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lblto.AutoSize = true;
            this.lblto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblto.Location = new System.Drawing.Point(240, 18);
            this.lblto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(27, 20);
            this.lblto.TabIndex = 3;
            this.lblto.Text = "To";
            // 
            // lblpaidto
            // 
            this.lblpaidto.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lblpaidto.AutoSize = true;
            this.lblpaidto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaidto.Location = new System.Drawing.Point(32, 176);
            this.lblpaidto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblpaidto.Name = "lblpaidto";
            this.lblpaidto.Size = new System.Drawing.Size(62, 20);
            this.lblpaidto.TabIndex = 5;
            this.lblpaidto.Text = "Paid To";
            // 
            // lblremark
            // 
            this.lblremark.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lblremark.AutoSize = true;
            this.lblremark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremark.Location = new System.Drawing.Point(36, 271);
            this.lblremark.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblremark.Name = "lblremark";
            this.lblremark.Size = new System.Drawing.Size(65, 20);
            this.lblremark.TabIndex = 4;
            this.lblremark.Text = "Remark";
            // 
            // lblamount
            // 
            this.lblamount.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lblamount.AutoSize = true;
            this.lblamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(30, 127);
            this.lblamount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(65, 20);
            this.lblamount.TabIndex = 2;
            this.lblamount.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // dgvexpenditure
            // 
            this.dgvexpenditure.AllowUserToAddRows = false;
            this.dgvexpenditure.AllowUserToDeleteRows = false;
            this.dgvexpenditure.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvexpenditure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvexpenditure.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvexpenditure.Location = new System.Drawing.Point(-4, 0);
            this.dgvexpenditure.Name = "dgvexpenditure";
            this.dgvexpenditure.ReadOnly = true;
            this.dgvexpenditure.Size = new System.Drawing.Size(536, 349);
            this.dgvexpenditure.TabIndex = 10;
            this.dgvexpenditure.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvexpenditure_CellContentClick);
            this.dgvexpenditure.DoubleClick += new System.EventHandler(this.dgvexpenditure_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dgvexpenditure);
            this.panel4.Location = new System.Drawing.Point(5, 54);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(536, 353);
            this.panel4.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txttotal);
            this.panel2.Controls.Add(this.btnsearch);
            this.panel2.Controls.Add(this.dtpto);
            this.panel2.Controls.Add(this.dtpfrom);
            this.panel2.Controls.Add(this.btnprint);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblfrom);
            this.panel2.Controls.Add(this.lblto);
            this.panel2.Location = new System.Drawing.Point(463, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 451);
            this.panel2.TabIndex = 14;
            // 
            // txttotal
            // 
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotal.Enabled = false;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(244, 418);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(194, 26);
            this.txttotal.TabIndex = 24;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(473, 17);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(79, 20);
            this.btnsearch.TabIndex = 11;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dtpto
            // 
            this.dtpto.Location = new System.Drawing.Point(269, 17);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(198, 20);
            this.dtpto.TabIndex = 10;
            // 
            // dtpfrom
            // 
            this.dtpfrom.Location = new System.Drawing.Point(53, 17);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(181, 20);
            this.dtpfrom.TabIndex = 9;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnprint.FlatAppearance.BorderSize = 0;
            this.btnprint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(88, 412);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(108, 36);
            this.btnprint.TabIndex = 12;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(162, 336);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(85, 36);
            this.btnupdate.TabIndex = 23;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelet
            // 
            this.btndelet.BackColor = System.Drawing.Color.DodgerBlue;
            this.btndelet.FlatAppearance.BorderSize = 0;
            this.btndelet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btndelet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelet.ForeColor = System.Drawing.Color.White;
            this.btndelet.Location = new System.Drawing.Point(52, 396);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(81, 36);
            this.btndelet.TabIndex = 22;
            this.btndelet.Text = "Delete";
            this.btndelet.UseVisualStyleBackColor = false;
            this.btndelet.Click += new System.EventHandler(this.btndelet_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btndelet);
            this.panel1.Controls.Add(this.panelExpenceType);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.lbletype);
            this.panel1.Controls.Add(this.txtpaidto);
            this.panel1.Controls.Add(this.txtremark);
            this.panel1.Controls.Add(this.txtamount);
            this.panel1.Controls.Add(this.ddlEType);
            this.panel1.Controls.Add(this.lblpaidto);
            this.panel1.Controls.Add(this.lblremark);
            this.panel1.Controls.Add(this.lblamount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtexid);
            this.panel1.Controls.Add(this.lblexid);
            this.panel1.Controls.Add(this.dtpdate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 451);
            this.panel1.TabIndex = 13;
            // 
            // panelExpenceType
            // 
            this.panelExpenceType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExpenceType.Controls.Add(this.btnadde);
            this.panelExpenceType.Controls.Add(this.txtaddexp);
            this.panelExpenceType.Controls.Add(this.lbladdexp);
            this.panelExpenceType.Controls.Add(this.btnbacke);
            this.panelExpenceType.Location = new System.Drawing.Point(12, 29);
            this.panelExpenceType.Name = "panelExpenceType";
            this.panelExpenceType.Size = new System.Drawing.Size(322, 301);
            this.panelExpenceType.TabIndex = 15;
            this.panelExpenceType.Visible = false;
            // 
            // btnadde
            // 
            this.btnadde.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnadde.FlatAppearance.BorderSize = 0;
            this.btnadde.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnadde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadde.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadde.ForeColor = System.Drawing.Color.White;
            this.btnadde.Location = new System.Drawing.Point(38, 189);
            this.btnadde.Name = "btnadde";
            this.btnadde.Size = new System.Drawing.Size(113, 36);
            this.btnadde.TabIndex = 19;
            this.btnadde.Text = "Add";
            this.btnadde.UseVisualStyleBackColor = false;
            this.btnadde.Click += new System.EventHandler(this.btnadde_Click);
            // 
            // txtaddexp
            // 
            this.txtaddexp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaddexp.Location = new System.Drawing.Point(52, 119);
            this.txtaddexp.Name = "txtaddexp";
            this.txtaddexp.Size = new System.Drawing.Size(200, 26);
            this.txtaddexp.TabIndex = 18;
            // 
            // lbladdexp
            // 
            this.lbladdexp.AutoSize = true;
            this.lbladdexp.BackColor = System.Drawing.Color.Transparent;
            this.lbladdexp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdexp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbladdexp.Location = new System.Drawing.Point(54, 64);
            this.lbladdexp.Name = "lbladdexp";
            this.lbladdexp.Size = new System.Drawing.Size(193, 22);
            this.lbladdexp.TabIndex = 17;
            this.lbladdexp.Text = "Add New Expenditure";
            this.lbladdexp.Click += new System.EventHandler(this.lbladdexp_Click);
            // 
            // btnbacke
            // 
            this.btnbacke.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnbacke.FlatAppearance.BorderSize = 0;
            this.btnbacke.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnbacke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbacke.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbacke.ForeColor = System.Drawing.Color.White;
            this.btnbacke.Location = new System.Drawing.Point(172, 188);
            this.btnbacke.Name = "btnbacke";
            this.btnbacke.Size = new System.Drawing.Size(108, 37);
            this.btnbacke.TabIndex = 16;
            this.btnbacke.Text = "Back";
            this.btnbacke.UseVisualStyleBackColor = false;
            this.btnbacke.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(162, 396);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(85, 36);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(340, 80);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(115, 33);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtexid
            // 
            this.txtexid.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.txtexid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtexid.Enabled = false;
            this.txtexid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexid.Location = new System.Drawing.Point(131, 29);
            this.txtexid.Margin = new System.Windows.Forms.Padding(5);
            this.txtexid.Name = "txtexid";
            this.txtexid.Size = new System.Drawing.Size(86, 26);
            this.txtexid.TabIndex = 17;
            // 
            // lblexid
            // 
            this.lblexid.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lblexid.AutoSize = true;
            this.lblexid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexid.Location = new System.Drawing.Point(36, 35);
            this.lblexid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblexid.Name = "lblexid";
            this.lblexid.Size = new System.Drawing.Size(50, 20);
            this.lblexid.TabIndex = 16;
            this.lblexid.Text = "Ex_Id";
            // 
            // dtpdate
            // 
            this.dtpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate.Location = new System.Drawing.Point(131, 215);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(187, 21);
            this.dtpdate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Date";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(52, 336);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(80, 36);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(404, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Expenditure";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1018, 60);
            this.panel3.TabIndex = 15;
            // 
            // Expenditure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1018, 523);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Expenditure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenditure";
            this.Load += new System.EventHandler(this.Expenditure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvexpenditure)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelExpenceType.ResumeLayout(false);
            this.panelExpenceType.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbletype;
        private System.Windows.Forms.TextBox txtpaidto;
        private System.Windows.Forms.TextBox txtremark;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.ComboBox ddlEType;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.Label lblto;
        private System.Windows.Forms.Label lblpaidto;
        private System.Windows.Forms.Label lblremark;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvexpenditure;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.Panel panelExpenceType;
        private System.Windows.Forms.Button btnbacke;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.Button btnadde;
        private System.Windows.Forms.TextBox txtaddexp;
        private System.Windows.Forms.Label lbladdexp;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtexid;
        private System.Windows.Forms.Label lblexid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelet;
        private System.Windows.Forms.TextBox txttotal;
    }
}