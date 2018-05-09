using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Data.Models
{
    public class RafaelContext : DbContext, IDbContext
    {
        IDbSet<TEntity> IDbContext.Set<TEntity>()
        {


            return base.Set<TEntity>();
        }

        public DbSet<RestModel> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
