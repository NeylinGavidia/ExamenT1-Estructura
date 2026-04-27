using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Inventario
    {
        public Nodo cima = null; //nueva cima es igual a nulo

        public void Guardar(Caja c)
        {

            Nodo nuevo = new Nodo();
            nuevo.dato = c;
            //caja1 -> caja2(cima)=nuevo
            nuevo.sig = null;

            if(cima == null) //para que ingrese como primer dato
            {
                cima = nuevo;
            }
            else //aqui para que siga la cola
            {
                Nodo temp = cima;
                while(temp.sig != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevo;
            }
           
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
        public void Limpiar()
        {
            cima = null;
        }
    }
}
