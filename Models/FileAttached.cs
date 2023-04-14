using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoconferenceApp.Models
{
	public class FileAttached
	{
		[Key]
		public int FileId { get; set; }

		[Required]
		public string Name { get; set; } = string.Empty;

		[Required]
		public string FileType { get; set; } = string.Empty;

		[Required] 
		public byte Attachment { get; set; } 

		[ForeignKey("UserId")]
		public int UploadedBy { get; set; } 

		[Required]
		public DateTime UploadedAt { get; set; } = DateTime.Now;

		[ForeignKey("CommentId")]
		public int CommentId { get; set;}
	}
}
