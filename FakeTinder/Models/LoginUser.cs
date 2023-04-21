using System.ComponentModel.DataAnnotations;

namespace FakeTinder.Models
{
	public class LoginUser
	{
		[Required(ErrorMessage ="Login required")]
		public string InLogin { get; set; }

		[Required(ErrorMessage = "Password required")]
		public string InPassword { get; set; }

	}
}
