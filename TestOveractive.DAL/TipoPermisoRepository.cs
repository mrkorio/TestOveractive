using System;
using System.Collections.Generic;
using System.Text;
using TestOveractive.DAL.Contracts;
using TestOveractive.Entities;

namespace TestOveractive.DAL
{
    public class TipoPermisoRepository : Repository<TipoPermiso>, ITipoPermisoRepository
    {
        public TipoPermisoRepository(TestOveractiveContext context) : base(context)
        {
        }
    }
}
