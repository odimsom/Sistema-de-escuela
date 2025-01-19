using System;

namespace juegoDe3_2 {
    public class Estudiantes : Persona {
        public int NumUnicoClas { get; set; }

        public Estudiantes(string nombre, int numUnicoClas) : base(nombre) {
            NumUnicoClas = numUnicoClas;
        }
    }
}
