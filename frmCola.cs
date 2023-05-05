using System;
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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        clsCola clsCola = new clsCola();

        private void txtCodigoRO_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTramiteRO_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreRO_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //Si estan lleno todos los campos habilitar boton agregar si no lanzar un messagebox
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                clsNodo Nodo = new clsNodo();
                Nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                Nodo.Nombre = txtNombre.Text;
                Nodo.Tramite = txtTramite.Text;

                //Procedimientos para mostrar
                clsCola.Agregar(Nodo);
                clsCola.Recorrer(dgvCola, lstCola);
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
            if (clsCola.Primero != null)
            {
                txtCodigoRO.Text = clsCola.Primero.Codigo.ToString();
                txtNombreRO.Text = clsCola.Primero.Nombre;
                txtTramiteRO.Text = clsCola.Primero.Tramite;
                clsCola.Eliminar();
                clsCola.Recorrer(dgvCola, lstCola);
            }
            else
            {
                MessageBox.Show("No hay datos en la cola", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmCola_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
        }
        private void ValidarCampos()
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtTramite.Text))
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }
        

        private void txtCodigo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

            {
                e.Handled = true;
            }
        }
    }
}
