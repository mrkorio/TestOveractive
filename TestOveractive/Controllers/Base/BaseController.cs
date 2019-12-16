using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestOveractive.Services.Contracts;

namespace TestOveractive.Controllers.Base
{
    public class BaseController : Controller
    {
        protected readonly IPermisoService _permisoService;
        protected readonly ITipoPermisoService _tipoPermisoService;


        public BaseController(IPermisoService permisoService, ITipoPermisoService tipoPermisoService)
        {
            this._permisoService = permisoService;
            this._tipoPermisoService = tipoPermisoService;  
        }
    }
}