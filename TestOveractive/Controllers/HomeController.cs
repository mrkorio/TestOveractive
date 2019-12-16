using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestOveractive.Controllers.Base;
using TestOveractive.Entities;
using TestOveractive.Models;
using TestOveractive.Services.Contracts;

namespace TestOveractive.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IPermisoService permisoService, ITipoPermisoService tipoPermisoService) : base(permisoService, tipoPermisoService)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            IEnumerable<Permiso> permisos = new List<Permiso>();
            try
            {
                permisos = this._permisoService.GetAll();
                ViewBag.tipoPermisos = this._tipoPermisoService.GetAll();
            }
            catch (Exception ex )
            {

                ViewBag.hasError = true;
                ViewBag.errorMessage = "No se pudo obtener los registros";
                ViewBag.innerErrorMessage = ex.Message;
            }

            return View(permisos);
        }


        [HttpGet]
        public IActionResult CreatePermiso()
        {
            IEnumerable<TipoPermiso> tipoPermisos = this._tipoPermisoService.GetAll();
            ViewBag.tipoPermisos = tipoPermisos;
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePermiso(PermisoViewModel newPermisoViewModel)
        {
            if (ModelState.IsValid)
            {
                var newPermiso = new Permiso()
                {
                    ApellidosEmpleado = newPermisoViewModel.ApellidosEmpleado,
                    NombreEmpleado = newPermisoViewModel.NombreEmpleado,
                    Fecha = newPermisoViewModel.Fecha,
                    TipoPermisoId = newPermisoViewModel.TipoPermisoId.Value
                };

                this._permisoService.Add(newPermiso);

            }
            else
            {
                IEnumerable<TipoPermiso> tipoPermisos = this._tipoPermisoService.GetAll();
                ViewBag.tipoPermisos = tipoPermisos;
                return View(newPermisoViewModel);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            try
            {
                this._permisoService.Delete(id);
            }
            catch (Exception ex)
            {

                ViewBag.hasError = true;
                ViewBag.errorMessage = "No se pudo eliminar el registro";
                ViewBag.innerErrorMessage = ex.Message;
            }
            
            return RedirectToAction("Index");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
