using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using mysqlclient;
using projectB;

namespace ProjectBlood
{
	public partial class Form1 : Form
	{
		MySqlConnection connection;
		MySqlConnectionStringBuilder builder;
		MySqlCommand cmd;
		List<Donor> donorList;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			donorList = new List<Donor>();

			builder = new MySqlConnectionStringBuilder()
			{
				Server = "localhost",
				Port = 3306,
				UserID = "root",
				Password = "",
				Database = "projectB"
			};

			connection = new MySqlConnection();

			connection.ConnectionString = builder.ToString();

			cmd = new MySqlCommand();

			hideSubMenu();

		}

		#region Menu
		private void hideSubMenu()
		{
			if (pnlBlood.Visible == true)
			{
				pnlBlood.Visible = false;
			}
			if (pnlManage.Visible == true)
			{
				pnlManage.Visible = false;
			}
			if (pnlInfo.Visible == true)
			{
				pnlInfo.Visible = false;
			}
		}

		private void hidePanel()
		{
			if (pnlMap.Visible == true)
			{
				pnlMap.Visible = false;
			}
			if (pnlList.Visible == true)
			{
				pnlList.Visible = false;
			}
			if (panelWeb.Visible == true)
			{
				panelWeb.Visible = false;
			}
			if (panelContact.Visible = true)
			{
				panelContact.Visible = false;
			}
		}

		private void showSubMenu(Panel subMenu)
		{
			if (subMenu.Visible == false)
			{
				hideSubMenu();
				subMenu.Visible = true;
			}
			else
				subMenu.Visible = false;
		}
		private void btnBlood_Click(object sender, EventArgs e)
		{
			showSubMenu(pnlBlood);
		}
		private void btnInfo_Click(object sender, EventArgs e)
		{
			showSubMenu(pnlInfo); ;
		}
		private void btnManage_Click(object sender, EventArgs e)
		{
			showSubMenu(pnlManage);
		}
		#endregion

		private void picPoint1_Click(object sender, EventArgs e)
		{
			picBank.Image = Properties.Resources.kaunoK;
			lblBI.Text = "Nacionalinis Kraujo Centras";

			int bank_id = GetBankId(lblBI.Text);
			if (bank_id == 0)
			{
				MessageBox.Show("Bank is unavailable :(");
			}
			else
			{
				if (comboBox1.Text == "")
				{
					MessageBox.Show("Select your blood type!");
				}
				else
				{
					GetDonors(bank_id, comboBox1.Text);
				}
			}
		}

		private void picPoint2_Click(object sender, EventArgs e)
		{
			picBank.Image = Properties.Resources.delmarva;
			lblBI.Text = "Blood Bank Of Delmarva";

			int bank_id = GetBankId(lblBI.Text);
			if (bank_id == 0)
			{
				MessageBox.Show("Bank is unavailable :(");
			}
			else
			{
				if (comboBox1.Text == "")
				{
					MessageBox.Show("Select your blood type!");
				}
				else
				{
					GetDonors(bank_id, comboBox1.Text);
				}
			}
		}

		private int GetBankId(string bankName)
		{

			int bank_id = 0;

			if (connection.State == ConnectionState.Closed)
				connection.Open();

			var query = $"SELECT * FROM banks WHERE name LIKE '{bankName}';";

			cmd.Connection = connection;
			cmd.CommandText = query;

			MySqlDataReader reader = cmd.ExecuteReader();

			if (reader == null) return 0;

			while (reader.Read())
			{
				bank_id = (int)reader.GetUInt64("id");
			}
			reader.Close();
			return bank_id;

		}

		private void GetDonors(int bank_id, string bloodType)
		{
			lstDonors.Items.Clear();
			if (connection.State == ConnectionState.Closed)
				connection.Open();

			string query;

			/*if (bloodType == "N")
			{
				query = $"SELECT * FROM donors ;";
			}
			else
			{
				query = $"SELECT * FROM donors WHERE bloodtype LIKE '{bloodType}';";
			}*/

			if (bloodType == "O+")
			{
				query = $"SELECT * FROM donors WHERE (bloodtype LIKE 'O+' OR bloodtype LIKE 'O-') AND bank_id={bank_id};";
			}
			else if (bloodType == "O-")
			{
				query = $"SELECT * FROM donors WHERE bloodtype LIKE 'O-' AND bank_id={bank_id};";
			}
			else if (bloodType == "A+")
			{
				query = $"SELECT * FROM donors WHERE (bloodtype LIKE 'O+' OR bloodtype LIKE 'O-' OR bloodtype LIKE 'A+' OR bloodtype LIKE 'A-') AND bank_id={bank_id};";
			}
			else if (bloodType=="A-")
			{
				query = $"SELECT * FROM donors WHERE (bloodtype LIKE 'O-' OR bloodtype LIKE 'A-') AND bank_id={bank_id};";
			}
			else if (bloodType=="B+")
			{
				query = $"SELECT * FROM donors WHERE (bloodtype LIKE 'O+' OR bloodtype LIKE 'O-' OR bloodtype LIKE 'B-' OR bloodtype LIKE 'B+') AND bank_id={bank_id};";
			}
			else if(bloodType=="B-")
			{
				query = $"SELECT * FROM donors WHERE (bloodtype LIKE 'B-' OR bloodtype LIKE 'O-') AND bank_id={bank_id};";
			}
			else if (bloodType=="AB+")
			{
				query = $"SELECT * FROM donors WHERE bank_id={bank_id};";
			}
			else if (bloodType=="AB-")
			{
				query = $"SELECT * FROM donors WHERE bloodtype LIKE '%-%' AND bank_id={bank_id};";
			}
			else
			{
				query = $"SELECT * FROM donors WHERE bank_id={bank_id};";
			}





			cmd.Connection = connection;
			cmd.CommandText = query;

			MySqlDataReader reader = cmd.ExecuteReader();

			if (!reader.HasRows)
			{
				reader.Close();
				MessageBox.Show("No data found");
				return;
			}

			while (reader.Read())
			{
				Donor don = new Donor()
				{
					Id = reader.GetUInt64("ID"),
					Name = reader.GetString("name"),
					Lastname = reader.GetString("lastname"),
					Bloodtype = reader.GetString("bloodtype"),
					Age = reader.GetInt32("age"),
					Email = reader.GetString("email"),
					Address = reader.GetString("address")

				};

				donorList.Add(don);

				//lstDonors.Items.Add($"{don.Id} | {don.Name} | {don.Lastname} | Blood type: {don.Bloodtype} | Age: {don.Age} | Address: {don.Address} | Contact info: {don.Email}");
				lstDonors.Items.Add($"ID: {don.Id}    Blood type: {don.Bloodtype} | Donors age: {don.Age}");
			}
			reader.Close();
		}

		private void picPoint1_MouseEnter(object sender, EventArgs e)
		{
			picPoint1.BackColor = Color.DarkBlue;
		}

		private void picPoint1_MouseLeave(object sender, EventArgs e)
		{
			picPoint1.BackColor = Color.RoyalBlue;
		}

		private void btnSMap_Click(object sender, EventArgs e)
		{
			hidePanel();
			pnlMap.Visible = true;
			pnlMap.Dock = DockStyle.Fill;
		}

		private void btnSList_Click(object sender, EventArgs e)
		{
			hidePanel();
			pnlList.Visible = true;
			pnlList.Dock = DockStyle.Fill;

			lstAll.Items.Clear();
			if (connection.State == ConnectionState.Closed)
				connection.Open();

			string query;

			query = $"SELECT * FROM donors ;";

			cmd.Connection = connection;
			cmd.CommandText = query;

			MySqlDataReader reader = cmd.ExecuteReader();

			if (!reader.HasRows)
			{
				MessageBox.Show("No data found");
				return;
			}

			while (reader.Read())
			{
				Donor don = new Donor()
				{
					Id = reader.GetUInt64("ID"),
					Name = reader.GetString("name"),
					Lastname = reader.GetString("lastname"),
					Bloodtype = reader.GetString("bloodtype"),
					Age = reader.GetInt32("age"),
					Email = reader.GetString("email"),
					Address = reader.GetString("address")

				};

				donorList.Add(don);

				lstAll.Items.Add($"ID: {don.Id}  | {don.Name} | {don.Lastname} | Blood type: {don.Bloodtype} | Age: {don.Age} | Address: {don.Address} | Contact info: {don.Email}");
				//lstDonors.Items.Add($"{don.Id}  Blood type: {don.Bloodtype} | Donors age: {don.Age}");
			}
			reader.Close();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			hidePanel();
			panelWeb.Visible = true;
			panelWeb.Dock = DockStyle.Fill;
		}

		private void label3_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"C:\Users\User\source\repos\ProjectBlood\web\index.html");
		}

		private void btnSAdd_Click(object sender, EventArgs e)
		{
			FormAdd formAdd = new FormAdd();
			formAdd.Show();
		}

		private void btnSRemove_Click(object sender, EventArgs e)
		{
			FormRemove formRem = new FormRemove();
			formRem.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			hidePanel();
			panelContact.Visible = true;
			panelContact.Dock = DockStyle.Fill;
		}
	}
}
