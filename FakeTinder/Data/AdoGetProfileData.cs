using FakeTinder.Repository;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using FakeTinder.Models;

namespace FakeTinder.Data
{
	public class AdoGetProfileData : IAdoGetProfileData
	{
		private CityEntity _city;
		private GenderEntity _gender;

		string connectionString = string.Empty;

		private readonly IConfiguration _configuration;

		public AdoGetProfileData(IConfiguration configuration)
		{
			connectionString = configuration.GetConnectionString("DefaultConnection");
		}


		public IEnumerable<CityEntity> GetCity()
		{
			List<CityEntity> listcity = new List<CityEntity>();
			using(SqlConnection con = new SqlConnection(connectionString))
			{
				SqlCommand cmd = new SqlCommand("usp_GetCityData", con);
				cmd.CommandType = CommandType.StoredProcedure;
				con.Open();
				SqlDataReader rdr = cmd.ExecuteReader();
				while (rdr.Read())
				{
					CityEntity city = new CityEntity();
					city.Id = Convert.ToInt32(rdr["Id"]);
					city.CityName = rdr["CityName"].ToString();

					listcity.Add(city);
				}
				con.Close();
			}
			return listcity;
		}

		public IEnumerable<GenderEntity> GetGender()
		{
			List<GenderEntity> listgender = new List<GenderEntity>();
			using(SqlConnection con = new SqlConnection(connectionString)) 
			{
				SqlCommand cmd = new SqlCommand("usp_GetGender", con);
				cmd.CommandType = CommandType.StoredProcedure;
				con.Open();
				SqlDataReader rdr = cmd.ExecuteReader();
				while(rdr.Read())
				{
					GenderEntity gender = new GenderEntity();
					gender.Id = Convert.ToInt32(rdr["Id"]);
					gender.GenderName = rdr["GenderName"].ToString();
					gender.GenderDescription = rdr["Elaborate"].ToString();
					listgender.Add(gender);
				}
				con.Close();
			}
			return listgender;
		}
	}

}
