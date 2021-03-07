using Microsoft.EntityFrameworkCore;
using Core.EntitiesDb;

namespace Infrastructure.Data
{
    public class ShopContext : DbContext
    {
        //allow to accept options 
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }


        //entitiesdb/item.cs - dbset allows to query results from database 
        public DbSet<Item> Items {get; set;}
    }
}