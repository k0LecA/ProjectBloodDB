using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectBlood
{
	public partial class FormRemove : Form
	{
		MySqlConnection connection;
		MySqlConnectionStringBuilder builder;
		MySqlCommand cmd;

		public FormRemove()
		{
			InitializeComponent();
		}

		private void FormRemove_Load(object sender, EventArgs e)
		{
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

			GetDonors();
		}

		private void GetDonors()
		{
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
				lstList.Items.Add($"ID: {reader.GetUInt64("id")}  | {reader.GetString("name")} | {reader.GetString("lastname")} | Blood type: {reader.GetString("bloodtype")} | Age: {reader.GetInt32("age")} | Address: {reader.GetString("address")} | Contact info: {reader.GetString("email")}");
				//lstDonors.Items.Add($"{don.Id}  Blood type: {don.Bloodtype} | Donors age: {don.Age}");
			}
			reader.Close();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (connection.State == ConnectionState.Closed)
				connection.Open();

			var query = $"DELETE FROM donors WHERE id = '{txtId.Text}';";

			cmd.Connection = connection;
			cmd.CommandText = query;

			MySqlDataReader reader = cmd.ExecuteReader();
			reader.Close();

			MessageBox.Show("Donor succesfuly removed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}
	}
}
