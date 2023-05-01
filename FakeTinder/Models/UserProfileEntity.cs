using System.ComponentModel.DataAnnotations;


namespace FakeTinder.Models
{
	public class UserProfileEntity
	{
		public int Id { get; set; }
		public string UserName { get; set; }

		[Required(ErrorMessage ="Date of birth required")]
		public DateTime BirthDate { get; set; }
		public int Height { get; set; }
		public string AboutMe { get; set; }
		public CityEntity City { get; set; } = new CityEntity();
		public GenderEntity Gender { get; set; } = new GenderEntity();
		public UserEntity User { get; set; } = new UserEntity();

	}
}
