using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Nodo
    {
        public Caja dato; //esto cambia conforme al tipo de elemento
        public Nodo sig;

        //esto es para listas dobles y circulares
        public Nodo ant;
    }
}
