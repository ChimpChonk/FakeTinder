using FakeTinder.Models;

namespace FakeTinder.Data
{
    public interface IAdoGetProfileData
    {
        public IEnumerable<CityEntity> GetCity();
        public IEnumerable<GenderEntity> GetGender();
    }
}
