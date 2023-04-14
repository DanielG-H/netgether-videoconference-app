using System.ComponentModel.DataAnnotations;

namespace VideoconferenceApp.Models
{
	public class User
	{
		[Key]
		public int UserId { get; set; }

		[Required]
		public string Username { get; set; } = string.Empty;

		[Required]
        public string Password { get; set; } = string.Empty;
	}
}
