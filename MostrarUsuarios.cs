using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SISTEMA_GESTION_DE_HOTEL.Usuario;

namespace SISTEMA_GESTION_DE_HOTEL
{
    internal class MostrarUsuarios
    {
        public static void MostrarUsuariosDemo()
        {
            Console.WriteLine("\n=== USUARIOS DE DEMOSTRACIÓN ===");
            Console.WriteLine("Para probar el sistema, puedes usar:");
            Console.WriteLine();
            Console.WriteLine("ADMINISTRADOR:");
            //Console.WriteLine("   Usuario: admin | Contraseña: admin123");
            //Console.WriteLine("   Usuario: manager | Contraseña: hotel2024");
            Console.WriteLine();
            Console.WriteLine("RECEPCIONISTA:");
            //Console.WriteLine("   Usuario: recepcion | Contraseña: recep123");
            //Console.WriteLine("   Usuario: front | Contraseña: front456");
            Console.WriteLine();
            Console.WriteLine("HUÉSPED:");
            //Console.WriteLine("   Usuario: huesped | Contraseña: guest123");
            //Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }

    }
}
