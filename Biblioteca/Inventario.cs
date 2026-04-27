using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Inventario
    {
        public Nodo cima;

        public void Guardar(Caja c)
        {

            Nodo nuevo = new Nodo();
            nuevo.dato = c;
            //caja1 -> caja2(cima)=nuevo
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
    }
}
