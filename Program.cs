using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Guia5
{
       public class Program
       {
        static  List<Telefono> inventario = new List<Telefono>();

        static void Main(string[] args)
        {
            

            bool continuar = true;
            while (continuar)
            {

                Console.WriteLine("****Menu****");
                Console.WriteLine("1.Registrar Teléfono. ");
                Console.WriteLine("2.Mostrar Teléfono Registrados. ");
                Console.WriteLine("3.Consultar Stock de  un telefono. ");
                Console.WriteLine("4.Salir.");
                Console.Write("Introduzca una opción: ");
                int opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:

                        RegistrarTelefono();

                        break;
                    case 2:
                        MostrarTelefonos();
                        break;
                    case 3:
                       ConsultatStock();
                        break;
                    case 4:
                        Console.WriteLine("Ha salido del programa.");
                        break; 
                }


            }
          }
        static void RegistrarTelefono()
        {
            Console.Write("Cuantos teléfonos desea registrar? ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Qué tipo de teléfono desea registrar?");
            Console.WriteLine("1.Teléfono Básico.");
            Console.WriteLine("2.Teléfono Inteligente.");
            Console.Write("Seleccione una opción: ");
            int tipoTelefono = Convert.ToInt32(Console.ReadLine());

             
            for (int i = 0; i < cantidad; i++) { 
            if (tipoTelefono == 1)
            {
                 TelefonoBasico telefonoBasico = new TelefonoBasico();
                 

                Console.Write("Ingrese la marca del teléfono: ");
                telefonoBasico.Marca = Console.ReadLine();

                Console.Write("Ingrese el modelo del teléfono: ");
                telefonoBasico.Modelo = Console.ReadLine();

                Console.Write("Ingrese el precio del teléfono: ");
                telefonoBasico.Precio = Convert.ToDecimal(Console.ReadLine());
                
                Console.Write("Ingrese el stock del teléfono: ");
                telefonoBasico.Stock = Convert.ToInt32(Console.ReadLine());

                Console.Write("¿El teléfono tiene Radio FM? (true/false): ");
                telefonoBasico.TieneRadioFM = Convert.ToBoolean(Console.ReadLine());

                Console.Write("¿El teléfono tiene Linterna? (true/false): ");
                telefonoBasico.TieneLinterna = Convert.ToBoolean(Console.ReadLine());

                    telefonoBasico.MostrarInformacionBasico();
             
                Console.WriteLine("Teléfono básico registrado con éxito.");
                    inventario.Add(telefonoBasico);

                }
            else if (tipoTelefono == 2)
            {
                TelefonoIntelegente telefonointelegente = new TelefonoIntelegente();
                Console.Write("Ingrese la marca del teléfono: ");
                telefonointelegente.Marca = Console.ReadLine();

                Console.Write("Ingrese el modelo del teléfono: ");
                telefonointelegente.Modelo = Console.ReadLine();

                Console.Write("Ingrese el precio del teléfono: ");
                telefonointelegente.Precio = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Ingrese el sistema operativo del teléfono: ");
                telefonointelegente.SistemaOperativo    = Console.ReadLine();

                Console.Write("Ingrese la memoria RAM del teléfono (en GB): ");
                telefonointelegente.MemoriaRam = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el stock del teléfono: ");
                telefonointelegente.Stock = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Teléfono inteligente registrado con éxito.");
                    inventario.Add(telefonointelegente);
                }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                return;
                
            }
                
                

            }
            foreach(Telefono telefono in inventario)
            {
                if(telefono is TelefonoBasico)
                {
                    ((TelefonoBasico)telefono).MostrarInformacionBasico();

                }else if(telefono is TelefonoIntelegente){
                    ((TelefonoIntelegente)telefono).MostrarInformacionInteligente();
                }

            }
           
        }
        
         static void MostrarTelefonos()
         {
            Console.WriteLine("Mostrar teléfonos registrados: ");
            foreach(var telefono in inventario)
            {
              telefono.MostrarInformacion();
                Console.WriteLine();
                
            }
         }
        static void ConsultatStock()
        {
            Console.Write("Ingrese el Stock del teléfono a consultar: ");
            int stock = Convert.ToInt32(Console.ReadLine());

            int cantidad = 0;
            foreach (var telefono in inventario)
            {
                if (telefono.Stock == stock)
                {
                    cantidad++;
                }
            }

            if (cantidad > 0)
            {
                Console.WriteLine($"Hay {cantidad} teléfonos del modelo {stock} en stock.");
            }
            else
            {
                Console.WriteLine($"No hay teléfonos del modelo {stock} en stock.");
            }

        }
    }
}
