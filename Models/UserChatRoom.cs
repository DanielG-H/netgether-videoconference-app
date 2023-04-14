using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoconferenceApp.Models
{
	public class UserChatRoom
	{
		[Key]
		public int UserRoomId { get; set; }

		[ForeignKey("UserId")]
		public int UserId { get; set; }

		[ForeignKey("RoomId")]
		public int RoomId { get; set; }
	}
}
