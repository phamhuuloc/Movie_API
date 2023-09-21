using Microsoft.EntityFrameworkCore;
using MOVIE_API.Model;


public class MysqlDBContext: DbContext
{
    public MysqlDBContext(DbContextOptions<MysqlDBContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; } = null!;
}