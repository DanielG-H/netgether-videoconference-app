using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoconferenceApp.Models
{
	public class RoomComment
	{
		[Key]
		public int RoomCommentId { get; set; }

		[ForeignKey("RoomId")]
		public int RoomId { get; set; }

		[ForeignKey("CommentId")]
		public int CommentId { get; set; }
	}
}