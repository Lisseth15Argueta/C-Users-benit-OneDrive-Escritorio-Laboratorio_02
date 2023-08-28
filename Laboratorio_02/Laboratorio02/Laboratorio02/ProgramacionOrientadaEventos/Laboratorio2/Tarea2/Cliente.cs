using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02.ProgramacionOrientadaEventos.Laboratorio2.Tarea2
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public Cliente(string nombre)
        {
            Nombre = nombre;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
