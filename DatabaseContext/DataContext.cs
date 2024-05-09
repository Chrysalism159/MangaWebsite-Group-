using AnimeWebsite.Data;
using Microsoft.EntityFrameworkCore;

namespace MangaWebsite.DatabaseContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        DbSet<AnimeWebsite.Data.DangKi> DangKi { get; set; } = null!;
        DbSet<AnimeWebsite.Data.DangNhap> DangNhap { get; set; } = null!;
    }
}
