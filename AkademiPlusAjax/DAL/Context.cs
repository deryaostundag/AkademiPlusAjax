using Microsoft.EntityFrameworkCore;

namespace AkademiPlusAjax.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DERYA;initial Catalog=AkademiPlusAjaxDb;integrated Security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
