using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace ExamenT1
{
    public class Program
    {
        static void Main(string[] args)
        {

            //MENU

            Métodos mt = new Métodos();

            Console.WriteLine("********MENU*********");

            int op = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Apilar");
                Console.WriteLine("2. Mostrar lista");
                Console.WriteLine("3. Desapilar");
                Console.WriteLine("4. Cajas livianas");
                Console.WriteLine("5. Cajas pesadas");
                Console.WriteLine("0. Salir");
                Console.Write("Ingrese una opcion: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Goodbye ¬^^¬");
                        break;
                    case 1:

                        Caja p = new Caja();
                        Console.Write("Ingrese una descripción de la caja: ");
                        p.descr = Console.ReadLine();
                        Console.Write("Ingrese el peso de la caja: ");
                        p.peso = double.Parse(Console.ReadLine());
                        mt.Contador();
                        mt.Push(p);
                        Console.WriteLine();
                        Console.Write("Registrado correctamente ^^");
                        break;
                    case 2:

                        mt.Mostrar();
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Desapilado con éxito:");
                            Console.WriteLine();
                            Console.WriteLine(mt.Pop());

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                Console.ReadKey();
            } while (op != 0);
        }
    }
}
