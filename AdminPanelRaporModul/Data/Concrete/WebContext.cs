using AdminPanelRaporModul.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminPanelRaporModul.Data.Concrete
{
    public class WebContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdminPanelRaporModul;Integrated Security=True
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdminPanelRaporModul;Integrated Security=True");
        }

        public DbSet<ProductOrder> order_product_list { get; set; }
    }
}
