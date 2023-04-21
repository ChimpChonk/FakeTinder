using FakeTinder.Models;
using FakeTinder.Repository;

namespace FakeTinder.Services
{
	public class UserServices : IUserService

	{
		private UserEntity _user;
		private readonly IUserRepository repository;

		public UserServices(IUserRepository _repository)
		{
			repository = _repository;
		}

		public bool AddUser(UserEntity user)
		{
			try
			{
				repository.AddUser(user);
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public bool DeleteUser(int? Id)
		{
			try
			{
				repository.DeleteUser(Id);
				return true;

			}
			catch (Exception)
			{

				return false;
			}
		}

		public IEnumerable<UserEntity> GetAllUsers()
		{
			List<UserEntity> users = new List<UserEntity>();

			users = repository.GetAllUsers().ToList();

			return users;
		}

		public bool UpdateUser(UserEntity user)
		{
			try
			{
				repository.UpdateUser(user);
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public UserEntity GetLogin(string inputLogin, string inputPassword)
		{
			try
			{
				_user = repository.GetLogin(inputLogin, inputPassword);
				return _user;
			}
			catch (Exception ex)
			{
				return _user;
			}
		}
	}
}
