using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia5
{
    public class TelefonoIntelegente : Telefono
    {
        public string SistemaOperativo { get; set; }

        public int MemoriaRam { get; set; }

        public void MostrarInformacionInteligente()
        {
            MostrarInformacion();
            Console.WriteLine($"Sistema Operativo:{SistemaOperativo}, Memoria Ram: {MemoriaRam} GB");
        }
    }
}
