
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TestOveractive.Entities;

namespace TestOveractive.DAL
{
    public partial class TestOveractiveContext : DbContext
    {

        public virtual DbSet<Permiso> Permisos { get; set; }
        public virtual DbSet<TipoPermiso> TiposPermisos { get; set; }

        public TestOveractiveContext(DbContextOptions<TestOveractiveContext> options)
         : base(options)
        {
        }



    }
}
