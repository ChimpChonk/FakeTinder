using FakeTinder.Models;
using FakeTinder.Data;

namespace FakeTinder.Repository
{
	public interface IAdoGetProfileData
	{
		public IEnumerable<CityEntity> GetCity();
		public IEnumerable<GenderEntity> GetGender();
	}
}
