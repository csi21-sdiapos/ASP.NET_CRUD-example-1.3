using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_CRUD_example_1._3_DAL
{
    public class Alumno
    {
        public int Id { get; set; }
        public string AlumnoNombre { get; set; }
        public string AlumnoApellidos { get; set; }
        public string AlumnoEmail { get; set; }

        public List<Asignatura>? ListaAsignaturas { get; set; }
    }

    public class Asignatura
    {
        public int Id { get; set; }
        public string AsignaturaNombre { get; set; }

        public List<Alumno>? ListaAlumnos { get; set; }
    }
}
