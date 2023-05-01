using FakeTinder.Models;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace FakeTinder.Repository
{
	public class UserProfileRepository : IUserProfileRepository
	{
		private UserProfileEntity _userProfileEntity;
		string connectionString = string.Empty;

		private readonly IConfiguration _configuration;

		public UserProfileRepository(IConfiguration configuration)
		{
			connectionString = configuration.GetConnectionString("DefaultConnection");
		}

		public IEnumerable<UserProfileEntity> GetAllUserProfiles()
		{
			List<UserProfileEntity> lstUsers = new List<UserProfileEntity>();
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				SqlCommand cmd = new SqlCommand("usp_GetUserProfileDetail", con);
				cmd.CommandType = CommandType.StoredProcedure;
				con.Open();
				SqlDataReader rdr = cmd.ExecuteReader();
				while (rdr.Read())
				{
					UserProfileEntity userProfile = new UserProfileEntity();
					userProfile.Id = Convert.ToInt32(rdr["ProfileId"]);
					userProfile.UserName = rdr["UserName"].ToString();
					userProfile.BirthDate = Convert.ToDateTime(rdr["BirthDate"].ToString());
					userProfile.Height = Convert.ToInt32(rdr["Height"]);
					userProfile.AboutMe = rdr["AboutMe"] == DBNull.Value? null : rdr.GetString("AboutMe").ToString();

					userProfile.City = new CityEntity();
					userProfile.City.CityName = rdr["CityName"] == DBNull.Value ? null : rdr.GetString("CityName").ToString();
					
					userProfile.Gender = new GenderEntity();
					userProfile.Gender.GenderName = rdr["GenderName"] == DBNull.Value ? null : rdr.GetString("GenderName").ToString();

					userProfile.User = new UserEntity();
					userProfile.User.FirstName = rdr["FirstName"].ToString();
					userProfile.User.LastName = rdr["LastName"].ToString();
					userProfile.User.Email = rdr["Email"].ToString();

					lstUsers.Add(userProfile);
				}
				con.Close();
			}

			return lstUsers;
		}

		public bool UpdateUserProfile(UserProfileEntity userProfile)
		{
			bool returnValue = true;
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				SqlCommand cmd = new SqlCommand("usp_UpdateUserProfile", con);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@UserName", userProfile.UserName);
				//cmd.Parameters.AddWithValue("@FirstName", userProfile.User.FirstName);
				//cmd.Parameters.AddWithValue("@LastName", userProfile.User.LastName);
				cmd.Parameters.AddWithValue("@BirthDate", userProfile.BirthDate);
				cmd.Parameters.AddWithValue("@AboutMe", userProfile.AboutMe);
				cmd.Parameters.AddWithValue("@Height", userProfile.Height);
				cmd.Parameters.AddWithValue("@GenderName", userProfile.Gender.Id);
				cmd.Parameters.AddWithValue("@CityName", userProfile.City.Id);
				//cmd.Parameters.AddWithValue("@Email", userProfile.User.Email);
				con.Open();
				int res = cmd.ExecuteNonQuery();
				con.Close();
				if (res != 1) { returnValue = false; }
			}
			return returnValue;
		}

		public bool DeleteUserProfile(int? Id)
		{
			bool returnValue = true;
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				SqlCommand cmd = new SqlCommand("usp_DeleteUserProfile", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Id", Id);
				con.Open();
				int res = cmd.ExecuteNonQuery();
				con.Close();
				if (res != 1) { return returnValue = false; }
			}
			return returnValue;
		}
	}
}
