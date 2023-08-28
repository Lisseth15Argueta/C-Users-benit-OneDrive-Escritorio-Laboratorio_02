using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02.ProgramacionOrientadaEventos.Laboratorio2.Tarea2
{
    internal class Electrodomestico
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public Electrodomestico(string nombre, int precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
        public override string ToString()
        {
            return Nombre + "Precio: $" + Precio;
        }
    }
}
