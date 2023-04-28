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
					userProfile.Id = Convert.ToInt32(rdr["Id"]);
					userProfile.UserName = rdr["ProfileId"].ToString();
					userProfile.BirthDate = Convert.ToDateTime(rdr["BirthDate"].ToString());
					userProfile.Height = Convert.ToInt32(rdr["Height"]);
					userProfile.AboutMe = rdr["AboutMe"].ToString();
					userProfile.City.CityName = rdr["CityName"].ToString();
					userProfile.Gender.GenderName = rdr["GenderName"].ToString();


				}
			}
		}

	}
}
