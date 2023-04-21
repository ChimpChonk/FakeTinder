using FakeTinder.Models;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace FakeTinder.Repository
{
	public class UserRepository : IUserRepository
	{
		private UserEntity _userEntity;
		string connectionString = string.Empty;

		private readonly IConfiguration _configuration;

		public UserRepository(IConfiguration configuration)
		{
			_configuration = configuration;
			connectionString = _configuration.GetConnectionString("DefaultConnection");
		}

		public IEnumerable<UserEntity> GetAllUsers()
		{
			List<UserEntity> lstusers = new List<UserEntity>();
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				SqlCommand cmd = new SqlCommand("", con);
				cmd.CommandType = CommandType.StoredProcedure;
				con.Open();
				SqlDataReader rdr = cmd.ExecuteReader();
				while (rdr.Read())
				{
					UserEntity user = new UserEntity();
					user.Id = Convert.ToInt32(rdr["Id"]);
					user.FirstName = rdr["FirstName"].ToString();
					user.LastName = rdr["LastName"].ToString();
					user.Email = rdr["Email"].ToString();
					user.Login = rdr["Login"].ToString();
					user.Password = rdr["Password"].ToString();
					user.Password2 = rdr["Password2"].ToString();
					user.CreateDate = Convert.ToDateTime(rdr["CreateDate"].ToString());
					user.DeleteDate = rdr["DeleteDate"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(rdr["DeleteDate"].ToString());

					lstusers.Add(user);
				}
				con.Close();
			}
			return lstusers;
		}

		public bool AddUser(UserEntity user)
		{
			bool returnValue = true;
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				SqlCommand cmd = new SqlCommand("", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
				cmd.Parameters.AddWithValue("@LastName", user.LastName);
				cmd.Parameters.AddWithValue("@Email", user.Email);
				cmd.Parameters.AddWithValue("@Login", user.Login);
				cmd.Parameters.AddWithValue("@Password", user.Password);
				cmd.Parameters.AddWithValue("@Password2", user.Password2);
				cmd.Parameters.AddWithValue("@CreateDate", user.CreateDate);
				cmd.Parameters.AddWithValue("@DeleteDate", user.DeleteDate);
				con.Open();
				int i = cmd.ExecuteNonQuery();
				con.Close();
				if (i >= 1) { returnValue = false; }
			}
			return returnValue;
		}


	}
}
