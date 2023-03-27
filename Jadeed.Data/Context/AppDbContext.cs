using Jadeed.Data.Entities;
using Jadeed.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Jadeed.Data.Context;

public class AppDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string path = "Server=localhost; Database=HealthCare; User Id=postgres; password=Bekmurod21";
        optionsBuilder.UseNpgsql(path);
    }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Dashboard> Dashboards { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<Library> Libraries { get; set; }
    public DbSet<Organization> Organizations { get; set; }
    public DbSet<StudentDetail> StudentDetails { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<SubjectMark> SubjectMarks { get; set; }
    public DbSet<TeacherDetail> TeacherDetails { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserBook> UserBooks { get; set; }
    public DbSet<Vote> Votes { get; set; }
}
