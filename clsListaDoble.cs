using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBonaderoED
{
    public class clsListaDoble
    {
        #region Nodos
        public clsNodo Primero;
        public clsNodo Ultimo;
        #endregion
        #region Procedimientos
        #region Agregar y Eliminar
        public void Agregar(clsNodo Nuevo)
        {
            //Preguntas si la lista esta vacia
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo) //Si es menor a Primero
                {
                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo > Ultimo.Codigo) //Si es mayor a Ultimo
                    {
                        Nuevo.Anterior = Ultimo;
                        Ultimo.Siguiente = Nuevo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo ant = Primero;
                        clsNodo aux = Primero;
                        while (Nuevo.Codigo > aux.Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }
                        ant.Siguiente = Nuevo;
                        aux.Anterior = Nuevo;
                        Nuevo.Anterior = ant;
                        Nuevo.Siguiente = aux;

                    }
                }
            }



        }
        public void Eliminar(Int32 Codigo)
        {
            //1- Cuando tengo solo un nodo
            //2- Cuando queremos sacar el primero
            //3- Cuando queremos sacar el Ultimo
            //4- Cuando queremos sacar uno Al medio

            if (Primero.Codigo == Codigo && Primero == Ultimo) //Si hay un unico dato
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == Codigo) //Si queres borrar el primero
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;

                }
                else
                {
                    if (Ultimo.Codigo == Codigo) //Si queres borrar el ultimo
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        //Si queres borrar alguno en el medio
                        clsNodo ant = Primero;
                        clsNodo aux = Primero;
                        while (aux.Codigo != Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }
                        ant.Siguiente = aux.Siguiente;
                        aux = aux.Siguiente;
                        aux.Anterior = ant;

                    }
                }
            }
        }

        #endregion
        #region Recorrer
        public void Recorrer(DataGridView dgvGrilla, ListBox lstLista)
        {
            clsNodo aux = Primero;
            dgvGrilla.Rows.Clear();
            lstLista.Items.Clear();
            while (aux != null)
            {
                dgvGrilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                lstLista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }

        }
        public void Recorrer(ComboBox combo)
        {
            clsNodo Aux = Primero;
            combo.Items.Clear();
            while (Aux != null)
            {
                combo.Items.Add(Aux.Codigo);
                Aux = Aux.Siguiente;
            }
        }
        #region RecorrerDes
        public void RecorrerDes(DataGridView Grilla)
        {
            clsNodo Aux = Ultimo;
            Grilla.Rows.Clear();
            while (Aux != null)
            {
                Grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Anterior;
            }
        }

        public void RecorrerDes(ListBox Lista)
        {
            clsNodo Aux = Ultimo;
            Lista.Items.Clear();
            while (Aux != null)
            {
                Lista.Items.Add(Aux.Codigo + " " + Aux.Nombre + " " + Aux.Tramite);
                Aux = Aux.Anterior;
            }
        }

        public void RecorrerDes(ComboBox combo)
        {
            clsNodo Aux = Ultimo;
            combo.Items.Clear();
            while (Aux != null)
            {
                combo.Items.Add(Aux.Codigo);
                Aux = Aux.Anterior;
            }

           
        }
        #endregion
        #endregion
        #endregion

    }
}
