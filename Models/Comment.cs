using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoconferenceApp.Models
{
	public class Comment
	{
		[Key]
		public int CommentId { get; set; }

		[ForeignKey("UserId")]
		public int CreatedBy { get; set; }

		[Required]
		public DateTime CreatedAt { get; set; } = DateTime.Now;

		[Required]
		public string Text { get; set; } = string.Empty;

		[ForeignKey("FileId")]
		public int FileId { get; set; } 

	}
}
