using Mango.Services.RoomTypeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.RoomTypeAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<RoomType> RoomTypes { get; set; }
    }

}
