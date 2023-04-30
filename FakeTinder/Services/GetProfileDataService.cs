using FakeTinder.Models;
using FakeTinder.Data;
using FakeTinder.Repository;

namespace FakeTinder.Services
{
	public class GetProfileDataService : IGetProfileDataService
	{

		private readonly IAdoGetProfileData adoGetProfileData;

		public GetProfileDataService(IAdoGetProfileData _adoGetProfileData)
		{
			adoGetProfileData = _adoGetProfileData; 
		}

		public IEnumerable<CityEntity> GetCity()
		{
			List<CityEntity> city = new();
			city = adoGetProfileData.GetCity().ToList();
			return city;
		}

		public IEnumerable<GenderEntity> GetGender()
		{
			List<GenderEntity> gender = new();
			gender = adoGetProfileData.GetGender().ToList();
			return gender;
		}
	}
}
