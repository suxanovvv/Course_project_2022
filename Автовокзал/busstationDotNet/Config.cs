using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace busstationDotNet
{
	class Config
	{
		public static SqlConnection Connection()
		{
			SqlConnection con = new SqlConnection();
			con.ConnectionString = "Data Source=LAPTOP-54EHI21F;Initial Catalog=busStationBase;Integrated Security=True";
			return con;
		}
		public static int authenticate(String login, String password)
		{
			SqlConnection connect = Connection();
			connect.Open();
			int role = -1;
			SqlCommand cmd = new SqlCommand("select role from dbo.users where login='" + login + "'and password='" + password + "'", connect);
			SqlDataAdapter userAdapter = new SqlDataAdapter(cmd);
			DataTable user = new DataTable();
			userAdapter.Fill(user);
			if (user.Rows.Count > 0)
			{
				//получаем роль пользователя
				role = (int)cmd.ExecuteScalar();

			}
			connect.Close();
			return role;
		}
	public static int getId(String login,String password)
		{
			SqlConnection connect = Connection();
			connect.Open();
			int id = -1;
			SqlCommand cmd = new SqlCommand("select id from dbo.users where login='" + login + "'and password='" + password + "'", connect);
			SqlDataAdapter userAdapter = new SqlDataAdapter(cmd);
			DataTable user = new DataTable();
			userAdapter.Fill(user);
			if (user.Rows.Count > 0)
			{
				//получаем роль пользователя
				id = (int)cmd.ExecuteScalar();

			}
			connect.Close();
			return id;
		}
	}
}
