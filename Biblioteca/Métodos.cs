using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Métodos
    {

        Nodo cima = null;
        static int incr = 1000; //va ayudar a poner codigo automaticamente empezando desde 1000

        public void Push(Caja c) //apilar
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = c;
            // nuevo(2) - > 1 (cima)
            nuevo.sig = cima;
            cima = nuevo;
        }
        public void Mostrar()
        {
            Nodo actual = cima;
            while (actual != null)
            {
                Console.WriteLine(actual.dato);
                actual = actual.sig;
            }
        }
        public Caja Pop()
        {
     
            Caja save = null; //la caja guardada es la que se desapila
            if (cima != null)
            {
                save = cima.dato;
                cima = cima.sig;
                if (save.peso > 50)
                {
                    Console.WriteLine("Caja pesada");
                }
                else
                {
                    Console.WriteLine("Caja liviana");
                }

            }
            return save;
            
        }
        public void Contador(Caja d)
        {
            d.code = incr;
            incr++;
        }
        
    }
}
