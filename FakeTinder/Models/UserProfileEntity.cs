using System.ComponentModel.DataAnnotations;

namespace FakeTinder.Models
{
	public class UserProfileEntity
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public DateTime BirthDate { get; set; }
		public int Height { get; set; }
		public string AboutMe { get; set; }
		public int CityId { get; set; }
		public int GenderId { get; set; }

	}
}
