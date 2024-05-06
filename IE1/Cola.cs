using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE1
{
    internal class Cola
    {
        public NodoArchivo inicio;
        public NodoArchivo fin;

        public void Insertar(NodoArchivo paciente)
        {
            if (inicio == null)
            {
                inicio = paciente;
                fin = paciente;
            }
            else
            {
                fin.siguiente = paciente;
                fin = paciente;
            }
        }
        public void Listar(ListBox lstEspera)
        {
            lstEspera.Items.Clear();
            if (inicio == null) lstEspera.Items.Add("No hay pacientes");
            else
            {
                NodoArchivo aux = inicio;
                while (aux != null)
                {
                    //lstEspera.Items.Add();
                    aux = aux.siguiente;
                }
            }
        }
        public void Eliminar()
        {
            if (inicio != null)
            {
                NodoArchivo aux = inicio;
                inicio = aux.siguiente;
                aux = null;

                if (inicio == null) fin = null;
            }
        }
    }
}
