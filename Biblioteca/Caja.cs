using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Caja
    {
        
        public int code;
        public string descr;
        public double peso;
       

        public Caja()
        {
        }


        public override string ToString()
        {
            return $"\n----------------------------\n" +
                   $"Codigo:          {code}\n" +
                   $"Descripcion:     {descr}\n" +
                   $"Peso:            {peso}kg\n" +
                   $"----------------------------\n";
        }
    }
}
