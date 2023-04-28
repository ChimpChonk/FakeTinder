using FakeTinder.Models;
using FakeTinder.Repository;

namespace FakeTinder.Services
{
	public class UserProfileService : IUserProfileService
	{
		private UserProfileEntity _userProfileEntity;
		private readonly IUserProfileRepository repository;

		public UserProfileService(IUserProfileRepository _repository)
		{
			repository = _repository;
		}

		public IEnumerable<UserProfileEntity> GetAllUserProfiles()
		{
			List<UserProfileEntity> users = new List<UserProfileEntity>();
			users = repository.GetAllUserProfiles().ToList();
			return users;
		}

		public bool UpdateUserProfile(UserProfileEntity userProfile)
		{
			try
			{
				repository.UpdateUserProfile(userProfile);
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public bool DeleteUserProfile(int? Id)
		{
			try
			{
				repository.DeleteUserProfile(Id);
					return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
