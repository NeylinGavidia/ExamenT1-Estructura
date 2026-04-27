using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Métodos
    {
        static int incr = 1000;
        Nodo cima = new Nodo();

        public void Push(Caja c)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = c;
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
            try {
            Caja save = null;
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
            catch (NullReferenceException e)
            {
                throw new Exception("Erro de límite: No se puede desapilar más");
            }
            
        }
        public void Contador()
        {
            int code = incr;
            incr++;
        }
        public bool Vacio()
        {
            return cima == null;
        }
        public Caja Peek()
        {
            if (cima == null)
            { Console.WriteLine("Vacío"); }
            return cima.dato;
        }
    }
}
