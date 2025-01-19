using System;

namespace juegoDe3_2 {
    public abstract class Persona {
        public string Nombre { get; set; }

        protected Persona(string nombre) {
            Nombre = nombre;
        }
    }
}
