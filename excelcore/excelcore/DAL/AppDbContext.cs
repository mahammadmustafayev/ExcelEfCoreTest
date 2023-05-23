

using excelcore.Models;
using Microsoft.EntityFrameworkCore;

namespace excelcore.DAL;

internal class AppDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(@"Server=DESKTOP-IE3NLPF;Database=ExcelReport;Trusted_Connection=True;TrustServerCertificate=yes;");
    }
    public DbSet<Student> Students { get; set; }
}
