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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsPila clsPila = new clsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                clsNodo Nodo = new clsNodo();
                Nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                Nodo.Nombre = txtNombre.Text;
                Nodo.Tramite = txtTramite.Text;

                //Procedimientos para mostrar
                clsPila.Agregar(Nodo);
                clsPila.Recorrer(dgvCola, lstCola);
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
            if (clsPila.Primero != null)
            {
                txtCodigoRO.Text = clsPila.Primero.Codigo.ToString();
                txtNombreRO.Text = clsPila.Primero.Nombre;
                txtTramiteRO.Text = clsPila.Primero.Tramite;
                clsPila.Eliminar();
                clsPila.Recorrer(dgvCola, lstCola);
            }
            else
            {
                MessageBox.Show("No hay datos en la cola", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
