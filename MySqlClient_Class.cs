using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mysqlclient
{
	class MySqlClient_Class
	{
		/*MySqlConnection connection;
		MySqlConnectionStringBuilder builder;
		MySqlCommand cmd;
		//List<Student> studentList;

		MySqlDataAdapter adapter;
		MySqlCommandBuilder cmdBuilder;
		//DataTable table;

		public MySqlConnectionStringBuilder GenerateConnectionString()
		{
			builder = new MySqlConnectionStringBuilder()
			{
				Server = "localhost",
				Port = 3306,
				UserID = "root",
				Password = "",
				Database = "get_data"
			};

			//connection = new MySqlConnection();

			//connection.ConnectionString = builder.ToString();

			//cmd = new MySqlCommand();

			return builder;
		}

		public static string Connect()
		{
			

			return connection;
		}*/

		public static MySqlConnection Connection;

		static string GenerateConnectionString()
		{
			var builder = new MySqlConnectionStringBuilder()
			{
				Server = "localhost",
				Port = 3306,
				UserID = "root",
				Password = "",
				Database = "vampirebay"
			};

			return builder.ToString();
		}

		public static void Connect()
		{
			if (Connection == null)
			{
				MySqlConnection connection = new MySqlConnection();
				connection.ConnectionString = GenerateConnectionString();
				connection.Open();

				Connection = connection;
			}
		}

		public static void ExecuteCommand(string query)
		{
			var cmd = new MySqlCommand(query, Connection);

			try
			{
				cmd.ExecuteNonQuery();
			}
			catch (MySqlException ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}

		public static MySqlDataReader GetDataReader(string query)
		{
			var cmd = new MySqlCommand(query, Connection);
			try
			{
				return cmd.ExecuteReader();
			}
			catch (MySqlException ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

			return null;
		}

		public static MySqlDataAdapter GetDataAdapter(string query)
		{
			var cmd = new MySqlCommand(query, Connection);

			try
			{
				return new MySqlDataAdapter(cmd);
			}
			catch (MySqlException ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

			return null;
		}

		public static object GetResult(string query)
		{
			var cmd = new MySqlCommand(query, Connection);

			try
			{
				return cmd.ExecuteScalar();
			}
			catch (MySqlException ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			return null;
		}
	}
}
