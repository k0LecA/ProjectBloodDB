﻿namespace ProjectBlood
{
	partial class FormRemove
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRemove));
			this.lstList = new System.Windows.Forms.ListBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRemove = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstList
			// 
			this.lstList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
			this.lstList.ForeColor = System.Drawing.SystemColors.InactiveCaption;
			this.lstList.FormattingEnabled = true;
			this.lstList.HorizontalScrollbar = true;
			this.lstList.Location = new System.Drawing.Point(36, 48);
			this.lstList.Name = "lstList";
			this.lstList.ScrollAlwaysVisible = true;
			this.lstList.Size = new System.Drawing.Size(477, 290);
			this.lstList.TabIndex = 0;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(589, 228);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(29, 20);
			this.txtId.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(562, 231);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "ID:";
			// 
			// btnRemove
			// 
			this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemove.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnRemove.Location = new System.Drawing.Point(534, 271);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(84, 67);
			this.btnRemove.TabIndex = 3;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// FormRemove
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
			this.ClientSize = new System.Drawing.Size(644, 385);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.lstList);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormRemove";
			this.Text = "Remove donor";
			this.Load += new System.EventHandler(this.FormRemove_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstList;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRemove;
	}
}