using System;

namespace juegoDe3_2 {
    public class Cursos {
        public string Nombre { get; set; }
        public int NumClases { get; set; }
        public int NumEjercicios { get; set; }

        public Cursos(string nombre, int numClases, int numEjercicios) {
            Nombre = nombre;
            NumClases = numClases;
            NumEjercicios = numEjercicios;
        }

        public void MostrarDetalles() {
            Console.WriteLine($"Curso: {Nombre}");
            Console.WriteLine($"Número de Clases: {NumClases}");
            Console.WriteLine($"Número de Ejercicios: {NumEjercicios}");
        }
    }
}
