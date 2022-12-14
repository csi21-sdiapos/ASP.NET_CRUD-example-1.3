using ASP.NET_CRUD_example_1._3_DAL;

namespace ASP.NET_CRUD_example_1._3.Data
{
    public static class DataSeeder
    {
        public static void Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<PostgreSqlContext>();

            context.Database.EnsureCreated();
            AddAsignaturas(context);
        }

        private static void AddAsignaturas(PostgreSqlContext context)
        {
            var asignatura = context.Asignaturas.FirstOrDefault();

            if (asignatura != null)
                return;

            context.Asignaturas.Add
                (
                    new Asignatura
                    {
                        AsignaturaNombre = "angular",
                        ListaAlumnos = new List<Alumno>
                        {
                            new Alumno { AlumnoNombre = "sergio", AlumnoApellidos = "diaz", AlumnoEmail = "sergio@gmail.com"},
                            new Alumno { AlumnoNombre = "angel", AlumnoApellidos = "mora", AlumnoEmail = "angel@gmail.com"},
                        }
                    }
                );

            context.Asignaturas.Add
                (
                    new Asignatura
                    {
                        AsignaturaNombre = "dws",
                        ListaAlumnos = new List<Alumno>
                        {
                            new Alumno { AlumnoNombre = "alberto", AlumnoApellidos = "talamino", AlumnoEmail = "alberto@gmail.com"},
                            new Alumno { AlumnoNombre = "yerai", AlumnoApellidos = "del toro", AlumnoEmail = "yerai@gmail.com"},
                        }
                    }
                );

            context.Asignaturas.Add
                (
                    new Asignatura
                    {
                        AsignaturaNombre = "diw",
                        ListaAlumnos = new List<Alumno>
                        {
                            new Alumno { AlumnoNombre = "javi", AlumnoApellidos = "cano", AlumnoEmail = "javi@gmail.com"},
                            new Alumno { AlumnoNombre = "angel", AlumnoApellidos = "hidalgo", AlumnoEmail = "moises@gmail.com"},
                        }
                    }
                );

            context.SaveChanges();
        }
    }
}
