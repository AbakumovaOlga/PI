using PI_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service
{
    [Table("PiDatabase")]
    public class PiDbContext:DbContext
    {
        public PiDbContext()
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<MaterialOrder> MaterialOrders { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<Typemy> Typemys { get; set; }
        public virtual DbSet<Buy> Buys { get; set; }
        public virtual DbSet<MaterialBuy> MaterialBuys { get; set; }
    }
}
