using System;
using System.Collections.Generic;
using System.Text;
using TestOveractive.DAL.Contracts;
using TestOveractive.Entities;
using TestOveractive.Services.Contracts;

namespace TestOveractive.Services
{
    public class TipoPermisoService : Service<TipoPermiso>, ITipoPermisoService
    {
        public TipoPermisoService(ITipoPermisoRepository repository) : base(repository)
        {
        }
    }
}

