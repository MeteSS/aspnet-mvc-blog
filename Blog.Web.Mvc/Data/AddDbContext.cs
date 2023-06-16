using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Mvc.Data
{
    public class AddDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-CQBBURH\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Database=Deneme;");
      // farklı bende bağlantı
            base.OnConfiguring(optionsBuilder);
        }
    }

}

