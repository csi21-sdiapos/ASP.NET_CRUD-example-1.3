using ASP.NET_CRUD_example_1._3_DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP.NET_CRUD_example_1._3.Models;

namespace ASP.NET_CRUD_example_1._3.Controllers
{
    public class AsignaturaController : Controller
    {
        private readonly PostgreSqlContext context;

        public AsignaturaController(PostgreSqlContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var asignaturas = this.context.Asignaturas.Include(asig => asig.ListaAlumnos).Select(asig => new AsignaturaViewModel
            {
                AsignaturaNombre = asig.AsignaturaNombre,
                ListaAlumnos = String.Join(',', asig.ListaAlumnos.Select(alum =>"\n" + alum.Id + ".\t" + alum.AlumnoNombre + " " + alum.AlumnoApellidos + " --> " + alum.AlumnoEmail + "\n")),
            });

            return View(asignaturas);
        }
    }
}
