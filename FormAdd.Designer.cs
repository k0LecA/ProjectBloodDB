namespace ProjectBlood
{
	partial class FormAdd
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtLastname = new System.Windows.Forms.TextBox();
			this.nudAge = new System.Windows.Forms.NumericUpDown();
			this.cmbBloodtype = new System.Windows.Forms.ComboBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.cmbBanks = new System.Windows.Forms.ComboBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(40, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Location = new System.Drawing.Point(158, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Lastname";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Location = new System.Drawing.Point(276, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Age";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label4.Location = new System.Drawing.Point(331, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Blood type";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(43, 100);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Email";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label6.Location = new System.Drawing.Point(43, 162);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Address";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label7.Location = new System.Drawing.Point(287, 100);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Bank";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(43, 58);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 20);
			this.txtName.TabIndex = 1;
			// 
			// txtLastname
			// 
			this.txtLastname.Location = new System.Drawing.Point(161, 58);
			this.txtLastname.Name = "txtLastname";
			this.txtLastname.Size = new System.Drawing.Size(100, 20);
			this.txtLastname.TabIndex = 1;
			// 
			// nudAge
			// 
			this.nudAge.Location = new System.Drawing.Point(279, 59);
			this.nudAge.Name = "nudAge";
			this.nudAge.Size = new System.Drawing.Size(40, 20);
			this.nudAge.TabIndex = 2;
			// 
			// cmbBloodtype
			// 
			this.cmbBloodtype.FormattingEnabled = true;
			this.cmbBloodtype.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
			this.cmbBloodtype.Location = new System.Drawing.Point(334, 59);
			this.cmbBloodtype.Name = "cmbBloodtype";
			this.cmbBloodtype.Size = new System.Drawing.Size(54, 21);
			this.cmbBloodtype.TabIndex = 3;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(43, 126);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(218, 20);
			this.txtEmail.TabIndex = 1;
			// 
			// cmbBanks
			// 
			this.cmbBanks.FormattingEnabled = true;
			this.cmbBanks.Location = new System.Drawing.Point(290, 126);
			this.cmbBanks.Name = "cmbBanks";
			this.cmbBanks.Size = new System.Drawing.Size(148, 21);
			this.cmbBanks.TabIndex = 3;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(43, 192);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(218, 20);
			this.txtAddress.TabIndex = 1;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnAdd.Location = new System.Drawing.Point(290, 192);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(148, 60);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// FormAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
			this.ClientSize = new System.Drawing.Size(454, 261);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.cmbBanks);
			this.Controls.Add(this.cmbBloodtype);
			this.Controls.Add(this.nudAge);
			this.Controls.Add(this.txtLastname);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(470, 300);
			this.MinimumSize = new System.Drawing.Size(470, 300);
			this.Name = "FormAdd";
			this.Text = "Add donor";
			this.Load += new System.EventHandler(this.FormAdd_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtLastname;
		private System.Windows.Forms.NumericUpDown nudAge;
		private System.Windows.Forms.ComboBox cmbBloodtype;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.ComboBox cmbBanks;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Button btnAdd;
	}
}