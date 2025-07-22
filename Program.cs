using System;
using System.Collections.Generic;
using System.Linq;

namespace SISTEMA_GESTION_DE_HOTEL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sistema Hotel";
            SistemaLogin sistema = new SistemaLogin();

            // Mostrar usuarios de demostración para Iniciar Sesion
            sistema.MostrarUsuariosDemo();

            // Hacer inicio de sesión
            if (sistema.IniciarSesion())
            {
                // Si el login es exitoso, mostrar el menú principal
                Usuario usuarioLogueado = sistema.ObtenerUsuarioActual();
                MenuPrincipal menu = new MenuPrincipal(usuarioLogueado);
                menu.MostrarMenuPrincipal();
            }

            Console.WriteLine("\n¡Gracias por usar nuestro sistema!");
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
