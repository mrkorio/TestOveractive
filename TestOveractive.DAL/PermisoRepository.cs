using System;
using System.Collections.Generic;
using System.Text;
using TestOveractive.DAL.Contracts;
using TestOveractive.Entities;

namespace TestOveractive.DAL
{
    public class PermisoRepository : Repository<Permiso>, IPermisoRepository
    {
        public PermisoRepository(TestOveractiveContext context) : base(context)
        {
        }
    }
}
