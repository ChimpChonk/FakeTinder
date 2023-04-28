namespace FakeTinder.Models
{
	public class ProfilePictureEntity
	{
		public int Id { get; set; }
		public string PicURL { get; set; }
		public UserProfileEntity UserProfile { get; set; }
	}
}

