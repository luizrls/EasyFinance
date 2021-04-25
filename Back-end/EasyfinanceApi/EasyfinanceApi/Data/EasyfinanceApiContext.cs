using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EasyfinanceApi.Model;

namespace EasyfinanceApi.Data
{
    public class EasyfinanceApiContext : DbContext
    {
        public EasyfinanceApiContext(DbContextOptions<EasyfinanceApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Transacoes> Transacao { get; set; }
        public virtual DbSet<Usuarios> Usuario { get; set; }


    }
}
