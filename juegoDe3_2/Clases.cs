using System;
using System.Collections.Generic;

namespace juegoDe3_2 {
    public class Clases {
        public string Id { get; set; }
        public List<Estudiantes> Estudiantes { get; set; }
        public List<Profesores> Profesores { get; set; }

        public Clases(string id) {
            Id = id;
            Estudiantes = new List<Estudiantes>();
            Profesores = new List<Profesores>();
        }

        public void AgregarEstudiante(Estudiantes estudiante) {
            Estudiantes.Add(estudiante);
        }

        public void EliminarEstudiante(Estudiantes estudiante) {
            Estudiantes.Remove(estudiante);
        }

        public void AsignarProfesor(Profesores profesor) {
            Profesores.Add(profesor);
        }

        public void MostrarDetalles() {
            Console.WriteLine($"Clase ID: {Id}");
            Console.WriteLine("Estudiantes:");
            foreach (var estudiante in Estudiantes) {
                Console.WriteLine($"- {estudiante.Nombre} ({estudiante.NumUnicoClas})");
            }
            Console.WriteLine("Profesores:");
            foreach (var profesor in Profesores) {
                Console.WriteLine($"- {profesor.Nombre}");
            }
        }
    }
}
