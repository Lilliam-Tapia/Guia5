using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia5
{
    public class Telefono
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: { Marca}, Modelo: {Modelo},Precio: ${Precio}, Stock: ${Stock}");
        }

        
    }
}
