using Microsoft.EntityFrameworkCore;
using VideoconferenceApp.Models;

namespace VideoconferenceApp.Database
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

		public DbSet<User> Users { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<RoomComment> RoomComments { get; set; }
		public DbSet<ChatRoom> ChatRooms { get; set; }
		public DbSet<UserChatRoom> UserChatRooms { get; set; }
		public DbSet<FileAttached> Files { get; set; }
	}
}