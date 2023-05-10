using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryBonaderoED
{
    public class clsArbolBinario
    {
        #region Nodos
        private clsNodo Inicio;
        public clsNodo Primero;
        public clsNodo Ultimo;
        public clsNodo Raiz
        {
            get { return Inicio;}
            set { Inicio = value; }
        }


        #endregion
        #region Procedimientos
        #region Agregar y Eliminar
        public void Agregar(clsNodo Nuevo)
        {
            Nuevo.Izquierdo = null;
            Nuevo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo Padre = Raiz;
                clsNodo aux = Raiz;
                while (aux != null)
                {
                    Padre = aux;
                    if (Nuevo.Codigo < aux.Codigo)
                    {
                        aux = aux.Izquierdo;
                    }
                    else
                    {
                        aux = aux.Derecho;     
                    }
                    


                }
                if (Nuevo.Codigo < Padre.Codigo)
                {
                    Padre.Izquierdo = Nuevo;
                }
                else
                {
                    Padre.Derecho = Nuevo;
                }

            }
           
        }

        public void Eliminar(Int32 Codigo)
        {
            clsNodo aux = Raiz;
            clsNodo ant = Raiz;
            while (aux != null && aux.Codigo != Codigo)
            {
                ant = aux;
                if (Codigo < aux.Codigo)
                {
                    aux = aux.Izquierdo;
                }
                else
                {
                    aux = aux.Derecho;
                }
            }
            if (aux != null && aux.Izquierdo == null && aux.Derecho == null)
            {
                if (Codigo < ant.Codigo)
                {
                    ant.Izquierdo = null;
                }
                else
                {
                    ant.Derecho = null;
                }
            }
            else
            {
                if (aux != null)
                {
                    if (aux.Izquierdo == null)
                    {
                        if (Codigo < ant.Codigo)
                        {
                            ant.Izquierdo = aux.Derecho;
                        }
                        else
                        {
                            ant.Derecho = aux.Derecho;
                        }
                    }
                    
                }
                else
                {
                    if (aux != null)
                    {
                        if (aux.Derecho == null)
                        {
                            if (Codigo < ant.Codigo)
                            {
                                ant.Izquierdo = aux.Izquierdo;
                            }
                            else
                            {
                                ant.Derecho = aux.Izquierdo;
                            }

                        }
                        
                    }
                    else
                    {
                        clsNodo aux2 = aux.Derecho;
                        clsNodo ant2 = aux.Derecho;
                        while (aux2.Izquierdo != null)
                        {
                            ant2 = aux2;
                            aux2 = aux2.Izquierdo;
                        }
                        aux.Codigo = aux2.Codigo;
                        aux.Nombre = aux2.Nombre;
                        aux.Tramite = aux2.Tramite;
                        if (aux2.Derecho == null)
                        {
                            ant2.Izquierdo = null;
                        }
                        else
                        {
                            ant2.Izquierdo = aux2.Derecho;
                        }
                    }
                }
            }
        }



        #endregion
        
        #region Recorrer y order para cbo, lst, dgv y archivo(ASCENDENTE)
        #region lst
        //Recorrer in order, pre order, post order en Lista
        #region Recorrer
        public void RecorrerInOrder(ListBox lstLista)
        {
            lstLista.Items.Clear();
            InOrderAsc(lstLista, Raiz);
            

        }
        public void RecorrerPreOrder(ListBox lstLista)
        {
            lstLista.Items.Clear();
            PreOrderAsc(lstLista, Raiz);

        }
        public void RecorrerPostOrder(ListBox lstLista)
        {
            lstLista.Items.Clear();
            PostOrderAsc(lstLista, Raiz);
        }
        #endregion
        private void InOrderAsc(ListBox lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrderAsc(lst, R.Izquierdo);
            lst.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrderAsc(lst, R.Derecho);

        }
        
        private void PreOrderAsc(ListBox lst, clsNodo R)
        {
            lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null) PreOrderAsc(lst, R.Izquierdo);
            if (R.Derecho != null) PreOrderAsc(lst, R.Derecho);
        }
        
        private void PostOrderAsc(ListBox lst, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderAsc(lst, R.Izquierdo);
            if (R.Derecho != null) PostOrderAsc(lst, R.Derecho);
            lst.Items.Add(R.Codigo);

        }
        #endregion
        #region cbo
        //Recorrer in order, pre order, post order en ComboBox
        #region Recorrer
        public void RecorrerInOrder(ComboBox cbo)
        {
            cbo.Items.Clear();
            InOrderAsc(cbo, Raiz);


        }
        public void RecorrerPreOrder(ComboBox cbo)
        {
            cbo.Items.Clear();
            PreOrderAsc(cbo, Raiz);

        }
        public void RecorrerPostOrder(ComboBox cbo)
        {
            cbo.Items.Clear();
            PostOrderAsc(cbo, Raiz);
        }
        #endregion
       
        private void InOrderAsc(ComboBox cbo, clsNodo R)
        {
            if (R.Izquierdo != null) InOrderAsc(cbo, R.Izquierdo);
            cbo.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrderAsc(cbo, R.Derecho);

        }
        private void PreOrderAsc(ComboBox cbo, clsNodo R)
        {
            cbo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) PreOrderAsc(cbo, R.Izquierdo);
            if (R.Derecho != null) PreOrderAsc(cbo, R.Derecho);
        }

        private void PostOrderAsc(ComboBox cbo, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderAsc(cbo, R.Izquierdo);
            if (R.Derecho != null) PostOrderAsc(cbo, R.Derecho);
            cbo.Items.Add(R.Codigo);

        }
        #endregion
        #region dgv
        //Recorrer in order, pre order, post order en DataGridView
        #region Recorrer
        public void RecorrerInOrder(DataGridView dgv)
        {
            dgv.Rows.Clear();
            InOrderAsc(dgv, Raiz);


        }
        public void RecorrerPreOrder(DataGridView dgv)
        {
            dgv.Rows.Clear();
            PreOrderAsc(dgv, Raiz);

        }
        public void RecorrerPostOrder(DataGridView dgv)
        {
            dgv.Rows.Clear();
            PostOrderAsc(dgv, Raiz);
        }
        #endregion
        
        private void InOrderAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrderAsc(dgv, R.Izquierdo);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrderAsc(dgv, R.Derecho);

        }
        private void PreOrderAsc(DataGridView dgv, clsNodo R)
        {
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) PreOrderAsc(dgv, R.Izquierdo);
            if (R.Derecho != null) PreOrderAsc(dgv, R.Derecho);
        }

        private void PostOrderAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderAsc(dgv, R.Izquierdo);
            if (R.Derecho != null) PostOrderAsc(dgv, R.Derecho);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

        }
        #endregion
        #region sw
        #region Recorrer
        public void RecorrerInOrder(StreamWriter archivo)
        {
            archivo.WriteLine();
            InOrderAsc(archivo, Raiz);


        }
        public void RecorrerPreOrder(StreamWriter archivo)
        {
            archivo.WriteLine();
            PreOrderAsc(archivo, Raiz);

        }
        public void RecorrerPostOrder(StreamWriter archivo)
        {
            archivo.WriteLine();
            PostOrderAsc(archivo, Raiz);
        }
        #endregion
        private void InOrderAsc(StreamWriter archivo, clsNodo R)
        {
            if (R.Izquierdo != null) InOrderAsc(archivo, R.Izquierdo);
            archivo.Write(R.Codigo + "\n");
            if (R.Derecho != null) InOrderAsc(archivo, R.Derecho);

        }

        private void PreOrderAsc(StreamWriter archivo, clsNodo R)
        {
            archivo.Write(R.Codigo + "\n");
            if (R.Izquierdo != null) PreOrderAsc(archivo, R.Izquierdo);
            if (R.Derecho != null) PreOrderAsc(archivo, R.Derecho);
        }

        private void PostOrderAsc(StreamWriter archivo, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderAsc(archivo, R.Izquierdo);
            if (R.Derecho != null) PostOrderAsc(archivo, R.Derecho);
            archivo.Write(R.Codigo + "\n");

        }
        #endregion
        #region treeview
        #region Recorrer
        public void RecorrerInOrder(TreeView Arbol)
        {
            Arbol.Nodes.Clear();
            InOrderAsc(Arbol.Nodes, Raiz);


        }
        public void RecorrerPreOrder(TreeView Arbol)
        {
            Arbol.Nodes.Clear();
            PreOrderAsc(Arbol.Nodes, Raiz);

        }
        public void RecorrerPostOrder(TreeView Arbol)
        {
            Arbol.Nodes.Clear();
            PostOrderAsc(Arbol.Nodes, Raiz);
        }
        #endregion
        private void InOrderAsc(TreeNodeCollection Arbol, clsNodo R)
        {
            if (R.Izquierdo != null) InOrderAsc(Arbol, R.Izquierdo);
            TreeNode NuevoNodo = Arbol.Add(R.Codigo.ToString());
            if (R.Izquierdo != null || R.Derecho != null)
            {
                NuevoNodo.Nodes.Add(new TreeNode()); // Agregar un nodo vacío para que se muestre el símbolo "+"
            }
            if (R.Derecho != null) InOrderAsc(Arbol, R.Derecho);
            if (NuevoNodo.Nodes.Count > 0)
            {
                NuevoNodo.Expand(); // Expandir el nodo para que se muestre el símbolo "+"
            }
            else
            {
                NuevoNodo.Collapse(); // Colapsar el nodo si no tiene hijos
            }

        }
        private void PreOrderAsc(TreeNodeCollection Arbol, clsNodo R)
        {
            TreeNode NuevoNodo = Arbol.Add(R.Codigo.ToString());
            if (R.Izquierdo != null || R.Derecho != null)
            {
                NuevoNodo.Nodes.Add(new TreeNode()); // Agregar un nodo vacío para que se muestre el símbolo "+"
            }
            if (R.Izquierdo != null) PreOrderAsc(Arbol, R.Izquierdo);
            if (R.Derecho != null) PreOrderAsc(Arbol, R.Derecho);
            if (NuevoNodo.Nodes.Count > 0)
            {
                NuevoNodo.Expand(); // Expandir el nodo para que se muestre el símbolo "+"
            }
            else
            {
                NuevoNodo.Collapse(); // Colapsar el nodo si no tiene hijos
            }
        }
        private void PostOrderAsc(TreeNodeCollection Arbol, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderAsc(Arbol, R.Izquierdo);
            if (R.Derecho != null) PostOrderAsc(Arbol, R.Derecho);
            TreeNode NuevoNodo = Arbol.Add(R.Codigo.ToString());

        }
        #endregion
        #endregion
        
        #region Recorrer y order para cbo, lst, dgv y archivo(DESCENDENTE)
        #region lst
        //Recorrer in order, pre order, post order en Lista
        #region Recorrer
        public void RecorrerInOrderDes(ListBox lstLista)
        {
            lstLista.Items.Clear();
            InOrderDes(lstLista, Raiz);

        }
        public void RecorrerPreOrderDes(ListBox lstLista)
        {
            lstLista.Items.Clear();
            PreOrderDes(lstLista, Raiz);

        }
        public void RecorrerPostOrderDes(ListBox lstLista)
        {
            lstLista.Items.Clear();
            PostOrderDes(lstLista, Raiz);

        }
        #endregion
        private void InOrderDes(ListBox lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrderDes(lst, R.Izquierdo);
            lst.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrderDes(lst, R.Derecho);

        }
        private void PreOrderDes(ListBox lst, clsNodo R)
        {
            lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null) PreOrderDes(lst, R.Izquierdo);
            if (R.Derecho != null) PreOrderDes(lst, R.Derecho);

        }
        private void PostOrderDes(ListBox lst, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderDes(lst, R.Izquierdo);
            if (R.Derecho != null) PostOrderDes(lst, R.Derecho);
            lst.Items.Add(R.Codigo);
        }

        #endregion
        #region cbo
        //Recorrer in order, pre order, post order en ComboBox
        #region Recorrer
        public void RecorrerInOrderDes(ComboBox cbo)
        {
            cbo.Items.Clear();
            InOrderDes(cbo, Raiz);
        }
        public void RecorrerPreOrderDes(ComboBox cbo)
        {
            cbo.Items.Clear();
            PreOrderDes(cbo, Raiz);
        }
        public void RecorrerPostOrderDes(ComboBox cbo)
        {
            cbo.Items.Clear();
            PostOrderDes(cbo, Raiz);
        }
        #endregion

        private void InOrderDes(ComboBox cbo, clsNodo R)
        {
            if (R.Izquierdo != null) InOrderDes(cbo, R.Izquierdo);
            cbo.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrderDes(cbo, R.Derecho);

        }
        private void PreOrderDes(ComboBox cbo, clsNodo R)
        {
            cbo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) PreOrderDes(cbo, R.Izquierdo);
            if (R.Derecho != null) PreOrderDes(cbo, R.Derecho);

        }
        private void PostOrderDes(ComboBox cbo, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderDes(cbo, R.Izquierdo);
            if (R.Derecho != null) PostOrderDes(cbo, R.Derecho);
            cbo.Items.Add(R.Codigo);

        }
        #endregion
        #region dgv
        //Recorrer in order, pre order, post order en DataGridView
        #region Recorrer
        public void RecorrerInOrderDes(DataGridView dgv)
        {
            dgv.Rows.Clear();
            InOrderDes(dgv, Raiz);
        }
        public void RecorrerPreOrderDes(DataGridView dgv)
        {
            dgv.Rows.Clear();
            PreOrderDes(dgv, Raiz);
        }
        public void RecorrerPostOrderDes(DataGridView dgv)
        {
            dgv.Rows.Clear();
            PostOrderDes(dgv, Raiz);
        }
        #endregion

        private void InOrderDes(DataGridView dgv, clsNodo R)
        {
            if (R.Derecho != null) InOrderDes(dgv, R.Derecho);
            dgv.Rows.Add(R.Codigo);
            if (R.Izquierdo != null) InOrderDes(dgv, R.Izquierdo);

        }
        private void PreOrderDes(DataGridView dgv, clsNodo R)
        {
            dgv.Rows.Add(R.Codigo);
            if (R.Izquierdo != null) PreOrderDes(dgv, R.Izquierdo);
            if (R.Derecho != null) PreOrderDes(dgv, R.Derecho);

        }
        private void PostOrderDes(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderDes(dgv, R.Izquierdo);
            if (R.Derecho != null) PostOrderDes(dgv, R.Derecho);
            dgv.Rows.Add(R.Codigo);

        }
        #endregion
        #region sw
        #region Recorrer
        public void RecorrerInOrderDes(StreamWriter archivo)
        {
            archivo.WriteLine();
            InOrderDes(archivo, Raiz);


        }
        public void RecorrerPreOrderDes(StreamWriter archivo)
        {
            archivo.WriteLine();
            PreOrderDes(archivo, Raiz);

        }
        public void RecorrerPostOrderDes(StreamWriter archivo)
        {
            archivo.WriteLine();
            PostOrderDes(archivo, Raiz);
        }
        #endregion
        private void InOrderDes(StreamWriter archivo, clsNodo R)
        {
            if (R.Derecho != null) InOrderDes(archivo, R.Derecho);
            archivo.Write(R.Codigo);
            if (R.Izquierdo != null) InOrderDes(archivo, R.Izquierdo);

        }

        private void PreOrderDes(StreamWriter archivo, clsNodo R)
        {
            archivo.Write(R.Codigo);
            if (R.Derecho != null) PreOrderDes(archivo, R.Derecho);
            if (R.Izquierdo != null) PreOrderDes(archivo, R.Izquierdo);
        }

        private void PostOrderDes(StreamWriter archivo, clsNodo R)
        {
            if (R.Derecho != null) PostOrderDes(archivo, R.Derecho);
            if (R.Izquierdo != null) PostOrderDes(archivo, R.Izquierdo);
            archivo.Write(R.Codigo);

        }
        #endregion
        #region treeview
        #region Recorrer
        public void RecorrerInOrderDes(TreeView Arbol)
        {
            Arbol.Nodes.Clear();
            InOrderDes(Arbol.Nodes, Raiz);


        }
        public void RecorrerPreOrderDes(TreeView Arbol)
        {
            Arbol.Nodes.Clear();
            PreOrderDes(Arbol.Nodes, Raiz);

        }
        public void RecorrerPostOrderDes(TreeView Arbol)
        {
            Arbol.Nodes.Clear();
            PostOrderDes(Arbol.Nodes, Raiz);
        }
        #endregion
        private void InOrderDes(TreeNodeCollection Arbol, clsNodo R)
        {
            if (R.Derecho != null) InOrderDes(Arbol, R.Derecho);
            TreeNode NuevoNodo = Arbol.Add(R.Codigo.ToString());
            if (R.Derecho != null || R.Izquierdo != null)
            {
                NuevoNodo.Nodes.Add(new TreeNode()); // Agregar un nodo vacío para que se muestre el símbolo "+"
            }
            if (R.Izquierdo != null) InOrderDes(Arbol, R.Izquierdo);
            if (NuevoNodo.Nodes.Count > 0)
            {
                NuevoNodo.Expand(); // Expandir el nodo para que se muestre el símbolo "+"
            }
            else
            {
                NuevoNodo.Collapse(); // Colapsar el nodo si no tiene hijos
            }



        }
        private void PreOrderDes(TreeNodeCollection Arbol, clsNodo R)
        {
            TreeNode NuevoNodo = Arbol.Add(R.Codigo.ToString());
            if (R.Derecho != null || R.Izquierdo != null)
            {
                NuevoNodo.Nodes.Add(new TreeNode()); // Agregar un nodo vacío para que se muestre el símbolo "+"
            }
            if (R.Derecho != null) PreOrderDes(Arbol, R.Derecho);
            if (R.Izquierdo != null) PreOrderDes(Arbol, R.Izquierdo);
            if (NuevoNodo.Nodes.Count > 0)
            {
                NuevoNodo.Expand(); // Expandir el nodo para que se muestre el símbolo "+"
            }
            else
            {
                NuevoNodo.Collapse(); // Colapsar el nodo si no tiene hijos
            }
        }
        private void PostOrderDes(TreeNodeCollection Arbol, clsNodo R)
        {
            if (R.Derecho != null) PostOrderDes(Arbol, R.Derecho);
            if (R.Izquierdo != null) PostOrderDes(Arbol, R.Izquierdo);
            TreeNode NuevoNodo = Arbol.Add(R.Codigo.ToString());

        }
        #endregion



        #endregion

        #region Equilibrar
        private clsNodo[] vecEquilibrar = new clsNodo[100];
        private Int32 ind = 0;
        private void CargarVectorInOrder(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                CargarVectorInOrder(NodoPadre.Izquierdo);
            }
            vecEquilibrar[ind] = NodoPadre;
            ind++;
            if (NodoPadre.Derecho != null)
            {
                CargarVectorInOrder(NodoPadre.Derecho);
            }
        }
        private void EquilibrarArbol(Int32 ini , Int32 fin)
        {
            
            if (ini <= fin)
            {
                Int32 m = (ini + fin) / 2;
                Agregar(vecEquilibrar[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }
        public void Equilibrar()
        {
            ind = 0;
            CargarVectorInOrder(Raiz);
            Raiz = null;
            EquilibrarArbol(0, ind - 1);
            
        }
        #endregion
        
        #region Buscar Nodo
        public clsNodo BuscarNodo(Int32 Codigo)
        {
            clsNodo NodoPadre = Raiz;
            while (NodoPadre != null)
            {
                if (NodoPadre.Codigo == Codigo)
                {
                    return NodoPadre;
                }
                else
                {
                    if (Codigo < NodoPadre.Codigo)
                    {
                        NodoPadre = NodoPadre.Izquierdo;
                    }
                    else
                    {
                        NodoPadre = NodoPadre.Derecho;
                    }
                }
            }
            return null;
        }
        #endregion
        #endregion
    }
}