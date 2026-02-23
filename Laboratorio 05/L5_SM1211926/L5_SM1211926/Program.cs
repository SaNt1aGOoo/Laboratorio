using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace L5_SM1211926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1  Panel de Acceso Numérico (Usuario + PIN + Modo seguro)
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

                if (Convert.ToInt32(PIN) == 1234)
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
            //Ejercicio 2 Validador de PIN Inteligente (Módulo y rangos)
            int PIN_Inteligente;

            Console.WriteLine("Ingrese el PIN: ");
            PIN_Inteligente = Convert.ToInt32(Console.ReadLine());

            // a) Validación de 4 dígitos entre 1000 y 9999
            if (PIN_Inteligente >= 1000 && PIN_Inteligente <= 9999)
               {
                Console.WriteLine("PIN de 4 dígitos: OK");
            }
            else
            {
                Console.WriteLine("PIN inválido: debe tener 4 dígitos");
            }
            // b) Validación de par o impar
            if (PIN_Inteligente %2 == 0 )
            {
                Console.WriteLine("PIN par.");
            }
            else 
            {
                Console.WriteLine("PIN impar.");
            }
            // c) Validación múltiplo de 5 
            if (PIN_Inteligente %5 == 0)
            {
                Console.WriteLine("Múltiplo de 5. ");
            }
            else
            {
                Console.WriteLine("No es múltiplo de 5. ");
            }
            // d) Validación regla de seguridad
            if ((PIN_Inteligente >= 1000 && PIN_Inteligente <= 9999) && (PIN_Inteligente %2 == 0) && (PIN_Inteligente %5 != 0))
            {
                Console.WriteLine("PIN aceptado por política. ");
            }
            else
            {
                Console.WriteLine("PIN rechazado por política. ");
            }

            // Ejericicio 3 Activación de Cuenta (Booleans)

            int Codigo_Activacion, Edad, Terminos, DosFA, Puntaje;

            Console.WriteLine("Ingrese código de activación:");
            Codigo_Activacion = Convert.ToInt32(Console.ReadLine());

            // a) Validación de código
            if (Codigo_Activacion == 2026)
            {
                Console.WriteLine("Código correcto.");
            }
            else
            {
                Console.WriteLine("Código incorrecto.");
            }

            Console.WriteLine("Ingrese su edad:");
            Edad = Convert.ToInt32(Console.ReadLine());

            // b) Validación de edad
            if (Edad >= 18)
            {
                Console.WriteLine("Edad válida.");
            }
            else
            {
                Console.WriteLine("Edad no válida.");
            }

            Console.WriteLine("¿Aceptó términos y condiciones?");
            Terminos = Convert.ToInt32(Console.ReadLine());

            // c) Validación de términos
            if (Terminos == 1)
            {
                Console.WriteLine("Términos aceptados.");
            }
            else
            {
                Console.WriteLine("Debe aceptar términos. 1(Si), 0(No)");
            }

            Console.WriteLine("¿Activó verificación en dos pasos (2FA)? 1(Si), 0(No)");
            DosFA = Convert.ToInt32(Console.ReadLine());

            // d) Validación DosFA
            if (DosFA == 1)
            {
                Console.WriteLine("2FA activado.");
            }
            else
            {
                Console.WriteLine("2FA no activado.");
            }

            Console.WriteLine("Ingrese puntaje de verificación (0 a 100):");
            Puntaje = Convert.ToInt32(Console.ReadLine());

            // e) Validación de puntaje
            if (Puntaje >= 70)
            {
                Console.WriteLine("Puntaje suficiente.");
            }
            else
            {
                Console.WriteLine("Puntaje insuficiente.");
            }

            // f) Decisión final: Cuenta activada
            if (Codigo_Activacion == 2026 && Edad >= 18 && Terminos == 1 && DosFA == 1 && Puntaje >= 70)
            {
                Console.WriteLine("Cuenta activada exitosamente.");
            }
            else
            {
                Console.WriteLine("Cuenta NO activada.");
            }

            // Ejercicio 4 Acceso a Sala de Examen (Validación múltiple)
            int NotaPrevia, MinutosTarde, SolvenciaPago, Identificación, Calculadora;

            Console.WriteLine("Ingrese su nota: ");
            NotaPrevia = Convert.ToInt32(Console.ReadLine());

            if (NotaPrevia >=61)
            {
                Console.WriteLine("Requisito académico aprobado. ");
            }
            else
            {
                Console.WriteLine("Requisito académico NO aprobado");
            }

            Console.WriteLine("Ingrese minutos de llegada tarde, si no llego tarde coloque 0: ");
            MinutosTarde = Convert.ToInt32(Console.ReadLine());

            if (MinutosTarde <=10)
                {
                Console.WriteLine("Hora válida");            
            }
            else
            {
                Console.WriteLine("Llegada fuera de tiempo.");
            }

            Console.WriteLine("¿Tiene solencia de pagos? 1(si)/0(No)");
            SolvenciaPago = Convert.ToInt32(Console.ReadLine());

            if (SolvenciaPago == 1)
            {
                Console.WriteLine("Solvencia validada.");
            }
            else
            {
                Console.WriteLine("Sin solvencia");
            }

            Console.WriteLine("¿Trae identificación física? 1(si)/0(no)");
            Identificación = Convert.ToInt32(Console.ReadLine());
            
            if (Identificación == 1)
            {
                Console.WriteLine("Identificación validada");
            }
            else
            {
                Console.WriteLine("Sin identificación");
            }

            Console.WriteLine("¿Trae Calculadora permitida? 1(si)/0(no)");
            Calculadora = Convert.ToInt32(Console.ReadLine());

            if (Calculadora == 1)
            {
                Console.WriteLine("Calculadora permitida");
            }
            else
            {
                Console.WriteLine("Sin calculadora permitida");
            }

            if ((NotaPrevia >=61) && (MinutosTarde <=10) && (SolvenciaPago == 1) && (Identificación == 1))
            {
                Console.WriteLine("Acceso a sala de examen concedido");
            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }

            if (MinutosTarde > 0 && MinutosTarde <= 10)
            {
                Console.WriteLine("Advertencia llegó tarde, pero aún puede ingresar");
            }
            else if (MinutosTarde > 10)
            {
                Console.WriteLine("El estudiante excedió el limite de entrada, no puede ingresar a la sala");
            }

            // Ejercicio Extra San Valentin Hacker Edition

            // Bonus: San Valentín Hacker Edition
string Nombre;
int Valentia, Programacion, Memes, Interes, Soltera;

Console.WriteLine("Ingrese el nombre de la persona:");
Nombre = Console.ReadLine();

Console.WriteLine("Ingrese nivel de valentía (0 a 100):");
Valentia = Convert.ToInt32(Console.ReadLine());

if (Valentia >= 70)
{
    Console.WriteLine("Valentía favorable. Confía en sí mismo(a).");
}
else
{
    Console.WriteLine("Nivel de valentía bajo. Actualización de hardware requerida (vaya al gym).");
}

Console.WriteLine("¿Le gusta la programación? (1 para Sí / 0 para No):");
Programacion = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("¿Le gustan los memes técnicos? (1 para Sí / 0 para No):");
Memes = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese nivel de interés (0 a 100):");
Interes = Convert.ToInt32(Console.ReadLine());

// 1) Validación de Interés
if (Interes >= 70)
{
    Console.WriteLine("Interés alto detectado.");
}
else
{
    Console.WriteLine("Interés insuficiente. Riesgo de friend zone elevado.");
}

Console.WriteLine("¿Está soltera/o? (1 para Sí / 0 para No):");
Soltera = Convert.ToInt32(Console.ReadLine());

// 3) Validación de Estado sentimental
if (Soltera == 1)
{
    Console.WriteLine("Estado sentimental favorable… aunque lo esté, no le crea: todos/todas mienten.");
}
else
{
    Console.WriteLine("Estado sentimental comprometido, no es recomendable hackear esa relación.");
}

Console.WriteLine("--- INICIANDO DIAGNÓSTICO SENTIMENTAL ---");


// 4) Validación de Compatibilidad técnica
if (Programacion == 1 && Memes == 1)
{
    Console.WriteLine("Compatibilidad geek detectada.");
}
else
{
    Console.WriteLine("Compatibilidad parcial o inexistente.");
}

Console.WriteLine("\n--- DECISIÓN FINAL ---");

// Decisión Final
if (Interes >= 70 && Soltera == 1 && Programacion == 1 && Memes == 1 && Valentia >= 70)
{
    Console.WriteLine("DECLARACIÓN APROBADA. Proceder con chocolates y flores.");
}
else if (Interes >= 70 && Soltera == 1 && Programacion == 1 && Memes == 1 && Valentia < 70)
{
    Console.WriteLine("No le tenga miedo al éxito que vida solo hay 1.");
}
else
{
    Console.WriteLine(Nombre + ", no te ama..por ahora.");
}
        } 
    }
}

