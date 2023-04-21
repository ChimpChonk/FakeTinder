using FakeTinder.Models;

namespace FakeTinder.Services
{
	public interface IUserService
	{
		public IEnumerable<UserEntity> GetAllUsers();
		public bool AddUser(UserEntity user);
		public bool UpdateUser(UserEntity user);
		public bool DeleteUser(int? id);
		public UserEntity GetLogin(string login, string password);
	}
}
