using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_SM1211926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ID_usuario, PIN, Token_de_seguridad, Modo_Seguro;
            string modo;

            Console.WriteLine("Ingrese ID de usuario");
            ID_usuario = Convert.ToInt32(Console.ReadLine());

            if (Convert.ToInt32(ID_usuario) == 2026)
            { 
                Console.WriteLine("Usuario reconocido");
            }
            else
            {
                Console.WriteLine("Usuario no reconocido");
            }
            Console.WriteLine("Ingrese PIN");
            PIN = Convert.ToInt32(Console.ReadLine());

            if (Convert.ToInt32(ID_usuario) == 2026)

                if (Convert.ToInt32(PIN) ==1234)
            {
                Console.WriteLine("PIN correcto");
            }
            else
            {
                Console.WriteLine("PIN incorrecto");
            }

            Console.WriteLine("Ingrese Token de seguridad");
            Token_de_seguridad = Convert.ToInt32(Console.ReadLine());

            if (Convert.ToInt32(ID_usuario) == 2026)

                if (Convert.ToInt32(Token_de_seguridad) == 777)
            {
                Console.WriteLine("Token válido");
            }
            else
            {
                Console.WriteLine("Token Inválido");
            }

            Console.WriteLine("¿Modo seguro activado?");
            modo = Console.ReadLine();

                if (modo.ToLower() == "si")
            {
                Modo_Seguro = 1;
            }
            else
            {
                Modo_Seguro = 0;
            }
                if (Modo_Seguro == 1)
            {
                Console.WriteLine("Modo seguro activado: se aplican reglas extra.");
            }
            else
            {
                Console.WriteLine("Modo seguro desactivado");
            }
                if (ID_usuario == 2026 && PIN == 1234 && Token_de_seguridad == 777)
            {
                Console.WriteLine("Acceso total concedido");
            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }

            {
                if (Modo_Seguro == 1 && Token_de_seguridad >= 700)
                {
                    Console.WriteLine("Regla extra aprobada");
                }
            else
                {
                    Console.WriteLine("Regla extra fallida");
                }
        }
    }
}
}

