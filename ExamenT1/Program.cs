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
            Inventario total = new Inventario();
            Inventario pesado = new Inventario();
            Inventario liviano = new Inventario();

            Console.WriteLine("********MENU*********");

            int op = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Apilar");
                Console.WriteLine("2. Mostrar lista");
                Console.WriteLine("3. Desapilar");
                Console.WriteLine("4. Inventario");
                Console.WriteLine("5. Cajas pesadas");
                Console.WriteLine("6. Cajas livianas");
                Console.WriteLine("0. Salir");
                Console.Write("Ingrese una opcion: ");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine();

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
                        mt.Contador(p);
                        mt.Push(p);
                        Console.WriteLine();
                        Console.Write("Registrado correctamente ^^");
                        break;
                    case 2:

                        mt.Mostrar();
                        break;
                    case 3:
                        Caja desapilada = mt.Pop();
                        if (desapilada != null)
                        {
                            Console.WriteLine(desapilada);

                            total.Guardar(desapilada);

                            if (desapilada.peso > 50)
                                pesado.Guardar(desapilada);
                            else
                                liviano.Guardar(desapilada);
                        }
                        else
                        {
                            Console.WriteLine("Pila vacía");
                        }

                        break;
                    case 4:

                        Console.WriteLine("Inventario general");
                        Console.WriteLine();
                        total.Mostrar();
                        break;
                    case 5:

                        Console.WriteLine("Inventario pesado");
                        Console.WriteLine();
                        pesado.Mostrar();
                        break;
                    case 6:

                        Console.WriteLine("Inventario liviano");
                        Console.WriteLine();
                        liviano.Mostrar();
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
