using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoconferenceApp.Models
{
	public class ChatRoom
	{
		[Key]
		public int RoomId { get; set; }

		[Required]
		public string Name { get; set; } = string.Empty;

		[ForeignKey("UserId")]
		public int CreatedBy { get; set; }

		[Required]
		public DateTime CreatedAt { get; set; } = DateTime.Now;
	}
}
