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
	public partial class FormAdd : Form
	{
		MySqlConnection connection;
		MySqlConnectionStringBuilder builder;
		MySqlCommand cmd;

		public FormAdd()
		{
			InitializeComponent();
		}

		private void FormAdd_Load(object sender, EventArgs e)
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

			GetBanks();
		}

		private void GetBanks()
		{
			if (connection.State == ConnectionState.Closed)
				connection.Open();

			var query = $"SELECT * FROM banks;";

			cmd.Connection = connection;
			cmd.CommandText = query;

			MySqlDataReader reader = cmd.ExecuteReader();

			if (reader == null)
			{
				reader.Close();
				return;
			}

			while (reader.Read())
			{
				cmbBanks.Items.Add(reader.GetString("name"));
			}
			reader.Close();
			return;
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

		private void btnAdd_Click(object sender, EventArgs e)
		{
			int bank_id = GetBankId(cmbBanks.Text);

			if (connection.State == ConnectionState.Closed)
				connection.Open();

			var query = $"INSERT donors VALUES(NULL,'{txtName.Text}','{txtLastname.Text}','{cmbBloodtype.Text}',{nudAge.Value},'{txtEmail.Text}','{txtAddress.Text}','{bank_id}');";

			cmd.Connection = connection;
			cmd.CommandText = query;

			MySqlDataReader reader = cmd.ExecuteReader();
			reader.Close();

			MessageBox.Show("Donor succesfuly added!", "Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}
	}
}
