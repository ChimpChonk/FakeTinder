using FakeTinder.Models;

namespace FakeTinder.Services
{
	public interface IUserProfileService
	{
		public IEnumerable<UserProfileEntity> GetAllUserProfiles();
		public bool UpdateUserProfile (UserProfileEntity userProfile);
		public bool DeleteUserProfile (int? id);
	}
}
