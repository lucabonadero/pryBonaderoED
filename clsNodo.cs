using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryBonaderoED
{
    public class clsNodo
    {
        #region Campos
        //Declaracion de campos
        private Int32 codigo;
        private String nombre; 
        private String tramite;
        private clsNodo sig;
        private clsNodo ant;
        #endregion
        #region Valores
        public Int32 Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Tramite
        {
            get { return tramite; }
            set { tramite = value; }
        }
        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
        public clsNodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }
        public clsNodo Izquierdo
        {
            get { return ant; }
            set { ant = value; }
        }
        public clsNodo Derecho
        {
            get { return sig; }
            set { sig = value; }
        }

        #endregion

    }
}
