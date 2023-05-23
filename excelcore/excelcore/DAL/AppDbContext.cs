

using Microsoft.EntityFrameworkCore;

namespace excelcore.DAL;

internal class AppDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(@"Server=RUBIS09\SQLEXPRESS;Database=Report;Trusted_Connection=True;");
    }
}
