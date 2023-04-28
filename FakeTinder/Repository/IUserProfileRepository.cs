using FakeTinder.Models;

namespace FakeTinder.Repository
{
	public interface IUserProfileRepository
	{
		public IEnumerable<UserProfileEntity> GetAllUserProfiles();
		public bool UpdateUserProfile(UserProfileEntity userProfile);
		public bool DeleteUserProfile(int? id);
	}
}
