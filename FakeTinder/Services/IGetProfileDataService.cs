using FakeTinder.Data;
using FakeTinder.Models;

namespace FakeTinder.Services
{
	public interface IGetProfileDataService
	{
		public IEnumerable<CityEntity> GetCity();
		public IEnumerable<GenderEntity> GetGender();
	}
}
