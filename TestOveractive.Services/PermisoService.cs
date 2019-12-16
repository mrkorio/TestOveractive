using System;
using System.Collections.Generic;
using System.Text;
using TestOveractive.DAL.Contracts;
using TestOveractive.Entities;
using TestOveractive.Services.Contracts;

namespace TestOveractive.Services
{
    public class PermisoService : Service<Permiso>, IPermisoService
    {
        private readonly IPermisoRepository Repository;

        public PermisoService(IPermisoRepository repository) : base(repository)
        {
        }
    }
}
