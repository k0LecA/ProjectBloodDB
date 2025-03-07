namespace ProjectBlood
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lblBankInfo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lstDonors = new System.Windows.Forms.ListBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panelSideMenu = new System.Windows.Forms.Panel();
			this.pnlInfo = new System.Windows.Forms.Panel();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.btnSInfo = new System.Windows.Forms.Button();
			this.pnlManage = new System.Windows.Forms.Panel();
			this.btnSRemove = new System.Windows.Forms.Button();
			this.btnSAdd = new System.Windows.Forms.Button();
			this.btnSManage = new System.Windows.Forms.Button();
			this.pnlBlood = new System.Windows.Forms.Panel();
			this.btnSList = new System.Windows.Forms.Button();
			this.btnSMap = new System.Windows.Forms.Button();
			this.btnSBlood = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnlMap = new System.Windows.Forms.Panel();
			this.lblBI = new System.Windows.Forms.Label();
			this.pnlList = new System.Windows.Forms.Panel();
			this.lstAll = new System.Windows.Forms.ListBox();
			this.panelWeb = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panelContact = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.picPoint2 = new System.Windows.Forms.PictureBox();
			this.picPoint1 = new System.Windows.Forms.PictureBox();
			this.picMap = new System.Windows.Forms.PictureBox();
			this.picBank = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panelSideMenu.SuspendLayout();
			this.pnlInfo.SuspendLayout();
			this.pnlManage.SuspendLayout();
			this.pnlBlood.SuspendLayout();
			this.panel1.SuspendLayout();
			this.pnlMap.SuspendLayout();
			this.pnlList.SuspendLayout();
			this.panelWeb.SuspendLayout();
			this.panelContact.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPoint2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPoint1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBank)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBankInfo
			// 
			this.lblBankInfo.AutoSize = true;
			this.lblBankInfo.Location = new System.Drawing.Point(696, 279);
			this.lblBankInfo.Name = "lblBankInfo";
			this.lblBankInfo.Size = new System.Drawing.Size(0, 13);
			this.lblBankInfo.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(551, 319);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Available blood in bank";
			// 
			// lstDonors
			// 
			this.lstDonors.FormattingEnabled = true;
			this.lstDonors.Location = new System.Drawing.Point(554, 335);
			this.lstDonors.Name = "lstDonors";
			this.lstDonors.ScrollAlwaysVisible = true;
			this.lstDonors.Size = new System.Drawing.Size(260, 186);
			this.lstDonors.TabIndex = 5;
			// 
			// comboBox1
			// 
			this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
			this.comboBox1.Location = new System.Drawing.Point(147, 23);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(58, 21);
			this.comboBox1.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Location = new System.Drawing.Point(29, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Select your blood type:";
			// 
			// panelSideMenu
			// 
			this.panelSideMenu.AutoScroll = true;
			this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.panelSideMenu.Controls.Add(this.pnlInfo);
			this.panelSideMenu.Controls.Add(this.btnSInfo);
			this.panelSideMenu.Controls.Add(this.pnlManage);
			this.panelSideMenu.Controls.Add(this.btnSManage);
			this.panelSideMenu.Controls.Add(this.pnlBlood);
			this.panelSideMenu.Controls.Add(this.btnSBlood);
			this.panelSideMenu.Controls.Add(this.panel1);
			this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
			this.panelSideMenu.Name = "panelSideMenu";
			this.panelSideMenu.Size = new System.Drawing.Size(218, 591);
			this.panelSideMenu.TabIndex = 9;
			// 
			// pnlInfo
			// 
			this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
			this.pnlInfo.Controls.Add(this.button5);
			this.pnlInfo.Controls.Add(this.button6);
			this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlInfo.Location = new System.Drawing.Point(0, 405);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new System.Drawing.Size(218, 75);
			this.pnlInfo.TabIndex = 5;
			this.pnlInfo.Visible = false;
			// 
			// button5
			// 
			this.button5.AutoSize = true;
			this.button5.Dock = System.Windows.Forms.DockStyle.Top;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.button5.Location = new System.Drawing.Point(0, 35);
			this.button5.Name = "button5";
			this.button5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.button5.Size = new System.Drawing.Size(218, 35);
			this.button5.TabIndex = 1;
			this.button5.Text = "Website";
			this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Dock = System.Windows.Forms.DockStyle.Top;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.button6.Location = new System.Drawing.Point(0, 0);
			this.button6.Name = "button6";
			this.button6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.button6.Size = new System.Drawing.Size(218, 35);
			this.button6.TabIndex = 0;
			this.button6.Text = "Contact Info";
			this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// btnSInfo
			// 
			this.btnSInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSInfo.FlatAppearance.BorderSize = 0;
			this.btnSInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
			this.btnSInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSInfo.Location = new System.Drawing.Point(0, 360);
			this.btnSInfo.Name = "btnSInfo";
			this.btnSInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnSInfo.Size = new System.Drawing.Size(218, 45);
			this.btnSInfo.TabIndex = 4;
			this.btnSInfo.Text = "Info";
			this.btnSInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSInfo.UseVisualStyleBackColor = true;
			this.btnSInfo.Click += new System.EventHandler(this.btnInfo_Click);
			// 
			// pnlManage
			// 
			this.pnlManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
			this.pnlManage.Controls.Add(this.btnSRemove);
			this.pnlManage.Controls.Add(this.btnSAdd);
			this.pnlManage.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlManage.Location = new System.Drawing.Point(0, 285);
			this.pnlManage.Name = "pnlManage";
			this.pnlManage.Size = new System.Drawing.Size(218, 75);
			this.pnlManage.TabIndex = 3;
			this.pnlManage.Visible = false;
			// 
			// btnSRemove
			// 
			this.btnSRemove.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSRemove.FlatAppearance.BorderSize = 0;
			this.btnSRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSRemove.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSRemove.Location = new System.Drawing.Point(0, 35);
			this.btnSRemove.Name = "btnSRemove";
			this.btnSRemove.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnSRemove.Size = new System.Drawing.Size(218, 35);
			this.btnSRemove.TabIndex = 1;
			this.btnSRemove.Text = "Remove";
			this.btnSRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSRemove.UseVisualStyleBackColor = true;
			this.btnSRemove.Click += new System.EventHandler(this.btnSRemove_Click);
			// 
			// btnSAdd
			// 
			this.btnSAdd.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSAdd.FlatAppearance.BorderSize = 0;
			this.btnSAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSAdd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSAdd.Location = new System.Drawing.Point(0, 0);
			this.btnSAdd.Name = "btnSAdd";
			this.btnSAdd.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnSAdd.Size = new System.Drawing.Size(218, 35);
			this.btnSAdd.TabIndex = 0;
			this.btnSAdd.Text = "Add";
			this.btnSAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSAdd.UseVisualStyleBackColor = true;
			this.btnSAdd.Click += new System.EventHandler(this.btnSAdd_Click);
			// 
			// btnSManage
			// 
			this.btnSManage.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSManage.FlatAppearance.BorderSize = 0;
			this.btnSManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
			this.btnSManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSManage.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSManage.Location = new System.Drawing.Point(0, 240);
			this.btnSManage.Name = "btnSManage";
			this.btnSManage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnSManage.Size = new System.Drawing.Size(218, 45);
			this.btnSManage.TabIndex = 2;
			this.btnSManage.Text = "Manage";
			this.btnSManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSManage.UseVisualStyleBackColor = true;
			this.btnSManage.Click += new System.EventHandler(this.btnManage_Click);
			// 
			// pnlBlood
			// 
			this.pnlBlood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
			this.pnlBlood.Controls.Add(this.btnSList);
			this.pnlBlood.Controls.Add(this.btnSMap);
			this.pnlBlood.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlBlood.Location = new System.Drawing.Point(0, 165);
			this.pnlBlood.Name = "pnlBlood";
			this.pnlBlood.Size = new System.Drawing.Size(218, 75);
			this.pnlBlood.TabIndex = 1;
			this.pnlBlood.Visible = false;
			// 
			// btnSList
			// 
			this.btnSList.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSList.FlatAppearance.BorderSize = 0;
			this.btnSList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSList.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSList.Location = new System.Drawing.Point(0, 35);
			this.btnSList.Name = "btnSList";
			this.btnSList.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnSList.Size = new System.Drawing.Size(218, 35);
			this.btnSList.TabIndex = 1;
			this.btnSList.Text = "Full list";
			this.btnSList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSList.UseVisualStyleBackColor = true;
			this.btnSList.Click += new System.EventHandler(this.btnSList_Click);
			// 
			// btnSMap
			// 
			this.btnSMap.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSMap.FlatAppearance.BorderSize = 0;
			this.btnSMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSMap.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSMap.Location = new System.Drawing.Point(0, 0);
			this.btnSMap.Name = "btnSMap";
			this.btnSMap.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnSMap.Size = new System.Drawing.Size(218, 35);
			this.btnSMap.TabIndex = 0;
			this.btnSMap.Text = "Map";
			this.btnSMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSMap.UseVisualStyleBackColor = true;
			this.btnSMap.Click += new System.EventHandler(this.btnSMap_Click);
			// 
			// btnSBlood
			// 
			this.btnSBlood.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSBlood.FlatAppearance.BorderSize = 0;
			this.btnSBlood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
			this.btnSBlood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSBlood.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSBlood.Location = new System.Drawing.Point(0, 120);
			this.btnSBlood.Name = "btnSBlood";
			this.btnSBlood.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnSBlood.Size = new System.Drawing.Size(218, 45);
			this.btnSBlood.TabIndex = 0;
			this.btnSBlood.Text = "Blood";
			this.btnSBlood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSBlood.UseVisualStyleBackColor = true;
			this.btnSBlood.Click += new System.EventHandler(this.btnBlood_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(218, 120);
			this.panel1.TabIndex = 0;
			// 
			// pnlMap
			// 
			this.pnlMap.Controls.Add(this.lblBI);
			this.pnlMap.Controls.Add(this.picPoint2);
			this.pnlMap.Controls.Add(this.picPoint1);
			this.pnlMap.Controls.Add(this.picMap);
			this.pnlMap.Controls.Add(this.comboBox1);
			this.pnlMap.Controls.Add(this.label1);
			this.pnlMap.Controls.Add(this.lstDonors);
			this.pnlMap.Controls.Add(this.label2);
			this.pnlMap.Controls.Add(this.picBank);
			this.pnlMap.Location = new System.Drawing.Point(224, 12);
			this.pnlMap.Name = "pnlMap";
			this.pnlMap.Size = new System.Drawing.Size(834, 537);
			this.pnlMap.TabIndex = 10;
			// 
			// lblBI
			// 
			this.lblBI.AutoSize = true;
			this.lblBI.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblBI.Location = new System.Drawing.Point(551, 53);
			this.lblBI.Name = "lblBI";
			this.lblBI.Size = new System.Drawing.Size(0, 13);
			this.lblBI.TabIndex = 10;
			// 
			// pnlList
			// 
			this.pnlList.Controls.Add(this.lstAll);
			this.pnlList.Location = new System.Drawing.Point(1075, 12);
			this.pnlList.Name = "pnlList";
			this.pnlList.Size = new System.Drawing.Size(734, 537);
			this.pnlList.TabIndex = 11;
			// 
			// lstAll
			// 
			this.lstAll.FormattingEnabled = true;
			this.lstAll.Location = new System.Drawing.Point(17, 53);
			this.lstAll.Name = "lstAll";
			this.lstAll.ScrollAlwaysVisible = true;
			this.lstAll.Size = new System.Drawing.Size(618, 407);
			this.lstAll.TabIndex = 0;
			// 
			// panelWeb
			// 
			this.panelWeb.Controls.Add(this.label3);
			this.panelWeb.Controls.Add(this.pictureBox2);
			this.panelWeb.Location = new System.Drawing.Point(242, 586);
			this.panelWeb.Name = "panelWeb";
			this.panelWeb.Size = new System.Drawing.Size(792, 439);
			this.panelWeb.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Location = new System.Drawing.Point(53, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(155, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Click here! Definitely not virus ;)";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// panelContact
			// 
			this.panelContact.Controls.Add(this.label6);
			this.panelContact.Controls.Add(this.label7);
			this.panelContact.Controls.Add(this.label5);
			this.panelContact.Controls.Add(this.label4);
			this.panelContact.Controls.Add(this.pictureBox3);
			this.panelContact.Location = new System.Drawing.Point(1051, 586);
			this.panelContact.Name = "panelContact";
			this.panelContact.Size = new System.Drawing.Size(758, 439);
			this.panelContact.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label4.Location = new System.Drawing.Point(36, 210);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(169, 25);
			this.label4.TabIndex = 1;
			this.label4.Text = "Address:    Vilnius";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(36, 244);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(239, 25);
			this.label5.TabIndex = 1;
			this.label5.Text = "Tel.:           +37066666666";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label6.Location = new System.Drawing.Point(36, 313);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(489, 25);
			this.label6.TabIndex = 1;
			this.label6.Text = "Also check our website https://www.notworkinglink.com";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::ProjectBlood.Properties.Resources.contact_us;
			this.pictureBox3.Location = new System.Drawing.Point(3, 3);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(354, 182);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::ProjectBlood.Properties.Resources.bloodCompat;
			this.pictureBox2.Location = new System.Drawing.Point(47, 62);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(587, 358);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// picPoint2
			// 
			this.picPoint2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picPoint2.Image = global::ProjectBlood.Properties.Resources.map_marker_icon;
			this.picPoint2.Location = new System.Drawing.Point(116, 238);
			this.picPoint2.Name = "picPoint2";
			this.picPoint2.Size = new System.Drawing.Size(39, 35);
			this.picPoint2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picPoint2.TabIndex = 9;
			this.picPoint2.TabStop = false;
			this.picPoint2.Click += new System.EventHandler(this.picPoint2_Click);
			// 
			// picPoint1
			// 
			this.picPoint1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picPoint1.Image = global::ProjectBlood.Properties.Resources.map_marker_icon;
			this.picPoint1.Location = new System.Drawing.Point(276, 180);
			this.picPoint1.Name = "picPoint1";
			this.picPoint1.Size = new System.Drawing.Size(39, 35);
			this.picPoint1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picPoint1.TabIndex = 9;
			this.picPoint1.TabStop = false;
			this.picPoint1.Click += new System.EventHandler(this.picPoint1_Click);
			// 
			// picMap
			// 
			this.picMap.BackColor = System.Drawing.Color.Transparent;
			this.picMap.Image = global::ProjectBlood.Properties.Resources.map;
			this.picMap.Location = new System.Drawing.Point(3, 83);
			this.picMap.Name = "picMap";
			this.picMap.Size = new System.Drawing.Size(530, 438);
			this.picMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picMap.TabIndex = 0;
			this.picMap.TabStop = false;
			// 
			// picBank
			// 
			this.picBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picBank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picBank.Location = new System.Drawing.Point(539, 83);
			this.picBank.Name = "picBank";
			this.picBank.Size = new System.Drawing.Size(271, 197);
			this.picBank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picBank.TabIndex = 2;
			this.picBank.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ProjectBlood.Properties.Resources.ProjectB;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(218, 114);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label7.Location = new System.Drawing.Point(36, 279);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(285, 25);
			this.label7.TabIndex = 1;
			this.label7.Text = "Email:        projectB@gmail.com";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
			this.ClientSize = new System.Drawing.Size(1084, 591);
			this.Controls.Add(this.panelContact);
			this.Controls.Add(this.panelWeb);
			this.Controls.Add(this.pnlList);
			this.Controls.Add(this.pnlMap);
			this.Controls.Add(this.panelSideMenu);
			this.Controls.Add(this.lblBankInfo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1100, 630);
			this.Name = "Form1";
			this.Text = "ProjectB";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panelSideMenu.ResumeLayout(false);
			this.pnlInfo.ResumeLayout(false);
			this.pnlInfo.PerformLayout();
			this.pnlManage.ResumeLayout(false);
			this.pnlBlood.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.pnlMap.ResumeLayout(false);
			this.pnlMap.PerformLayout();
			this.pnlList.ResumeLayout(false);
			this.panelWeb.ResumeLayout(false);
			this.panelWeb.PerformLayout();
			this.panelContact.ResumeLayout(false);
			this.panelContact.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPoint2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPoint1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBank)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picMap;
		private System.Windows.Forms.PictureBox picBank;
		private System.Windows.Forms.Label lblBankInfo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lstDonors;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panelSideMenu;
		private System.Windows.Forms.Panel pnlBlood;
		private System.Windows.Forms.Button btnSMap;
		private System.Windows.Forms.Button btnSBlood;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSList;
		private System.Windows.Forms.Panel pnlInfo;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button btnSInfo;
		private System.Windows.Forms.Panel pnlManage;
		private System.Windows.Forms.Button btnSRemove;
		private System.Windows.Forms.Button btnSAdd;
		private System.Windows.Forms.Button btnSManage;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel pnlMap;
		private System.Windows.Forms.PictureBox picPoint1;
		private System.Windows.Forms.Label lblBI;
		private System.Windows.Forms.Panel pnlList;
		private System.Windows.Forms.ListBox lstAll;
		private System.Windows.Forms.PictureBox picPoint2;
		private System.Windows.Forms.Panel panelWeb;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panelContact;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label7;
	}
}

