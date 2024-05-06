using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE1
{
    internal class NodoArchivo
    {
        public string nombreArchivo;
        public NodoArchivo siguiente;
        public NodoArchivo(string nombreArchivo)
        {
            this.nombreArchivo = nombreArchivo;
            this.siguiente = null;

        }
    }
    
    
}
