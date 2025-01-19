using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace juegoDe3_2 {
    public class Profesores : Persona {
        public List<Cursos> Cursos { get; set; }

        public Profesores(string nombre) : base(nombre) {
            Cursos = new List<Cursos>();
        }

        public void AsignarCurso(Cursos curso) {
            Cursos.Add(curso);
        }

        public void EliminarCurso(Cursos curso) {
            Cursos.Remove(curso);
        }

        public void MostrarCursos() {
            Console.WriteLine($"Profesor: {Nombre}");
            Console.WriteLine("Cursos:");
            foreach (var curso in Cursos) {
                Console.WriteLine($"- {curso.Nombre}");
            }
        }
    }
}
