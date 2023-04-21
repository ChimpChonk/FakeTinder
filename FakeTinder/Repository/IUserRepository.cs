using FakeTinder.Models;

namespace FakeTinder.Repository
{
	public interface IUserRepository
	{
		public IEnumerable<UserEntity> GetAllUsers();
		public bool AddUser(UserEntity user);
		public bool UpdateUser(UserEntity user);
		public bool DeleteUser(int id);
		public UserEntity GetLogin(string login, string password);

	}
}
