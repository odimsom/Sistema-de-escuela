using System;
using System.Collections.Generic;

namespace juegoDe3_2 {
    public class Escuela {
        public List<Clases> Clases { get; set; }

        public Escuela() {
            Clases = new List<Clases>();
        }

        public void AgregarClase(Clases clase) {
            Clases.Add(clase);
        }

        public void EliminarClase(Clases clase) {
            Clases.Remove(clase);
        }

        public void ListarClases() {
            Console.WriteLine("Clases en la Escuela:");
            foreach (var clase in Clases) {
                Console.WriteLine($"- {clase.Id}");
            }
        }

        public static void Main(string[] args) {
            // Ejemplo de uso
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
