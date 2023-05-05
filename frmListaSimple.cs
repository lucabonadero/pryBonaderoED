﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBonaderoED
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple clsListaSimple = new clsListaSimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                clsNodo Nodo = new clsNodo();
                Nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                Nodo.Nombre = txtNombre.Text;
                Nodo.Tramite = txtTramite.Text;

                //Procedimientos para mostrar
                clsListaSimple.Agregar(Nodo);
                clsListaSimple.Recorrer(dgvCola, lstCola);
                clsListaSimple.Recorrer(cmbCodigo);
                txtCodigo.Clear();
                txtNombre.Clear();
                txtTramite.Clear();
                txtCodigo.Focus();

            }
            else
            {
                MessageBox.Show("Llene todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clsListaSimple.Primero != null)
            {
                
                Int32 Codigo = Convert.ToInt32(cmbCodigo.SelectedItem.ToString());
                clsListaSimple.Eliminar(Codigo);
                clsListaSimple.Recorrer(dgvCola, lstCola);
                clsListaSimple.Recorrer(cmbCodigo);
                
                
            }
            else
            {
                MessageBox.Show("Lista vacia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {
         
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
