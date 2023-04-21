using System.ComponentModel.DataAnnotations;

namespace FakeTinder.Models
{
	public class UserProfileEntity
	{
		public DateTime BirthDate { get; set; }
		public int Height { get; set; }
		public string AboutMe { get; set; }

	}
}
