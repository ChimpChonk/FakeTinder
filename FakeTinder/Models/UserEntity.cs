﻿using System.ComponentModel.DataAnnotations;

namespace FakeTinder.Models
{
	public class UserEntity
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "First Name is required")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Last Name is required")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "Email is required")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Login is required")]
		public string Login { get; set; }

		[Required(ErrorMessage = "Password is required")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Co-Password is required")]
		[Compare("Password", ErrorMessage = "Passwords do not match")]
		public string Password2 { get; set; }

		public DateTime CreateDate { get; set; } = DateTime.Now;

		public DateTime? DeleteDate { get; set; }
	}
}
