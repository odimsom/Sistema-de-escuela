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

    }
}

