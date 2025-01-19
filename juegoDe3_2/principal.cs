using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoDe3_2 {
    internal class principal {
        public static void Main(string[] args) {

            Escuela escuela = new Escuela();
            Clases clase10A = new Clases("10-A");
            Estudiantes estudiante1 = new Estudiantes("Carlos López", 1);
            Profesores profesor1 = new Profesores("Laura Pérez");
            Cursos cursoMatematicas = new Cursos("Matemáticas", 20, 15);

            clase10A.AgregarEstudiante(estudiante1);
            clase10A.AsignarProfesor(profesor1);
            profesor1.AsignarCurso(cursoMatematicas);

            escuela.AgregarClase(clase10A);
            escuela.ListarClases();
            clase10A.MostrarDetalles();
            profesor1.MostrarCursos();
            cursoMatematicas.MostrarDetalles();
        }
    }
}
