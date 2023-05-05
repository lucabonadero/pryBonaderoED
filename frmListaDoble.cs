using System;
using System.Collections;
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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble clsListaDoble = new clsListaDoble();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            {
                if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
                {
                    clsNodo clsNodo = new clsNodo();
                    clsNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                    clsNodo.Nombre = (txtNombre.Text);
                    clsNodo.Tramite = (txtTramite.Text);

                    clsListaDoble.Agregar(clsNodo);

                    if (rdbAsc.Checked == true)
                    {
                        clsListaDoble.Recorrer(dgvCola, lstCola);
                        clsListaDoble.Recorrer(cmbCodigo);

                    }
                    else
                    {
                        clsListaDoble.RecorrerDes(dgvCola);
                        clsListaDoble.RecorrerDes(lstCola);
                        clsListaDoble.RecorrerDes(cmbCodigo);
                    }


                    txtCodigo.Text = "";
                    txtNombre.Text = "";
                    txtTramite.Text = "";
                }
                else
                {
                    MessageBox.Show("Faltan datos por completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clsListaDoble.Primero != null)
            {
                clsListaDoble.Eliminar(Convert.ToInt32(cmbCodigo.SelectedItem));
                if (rdbAsc.Checked == true)
                {
                    clsListaDoble.Recorrer(dgvCola, lstCola);
                    clsListaDoble.Recorrer(cmbCodigo);

                }
                else
                {
                    clsListaDoble.RecorrerDes(dgvCola);
                    clsListaDoble.RecorrerDes(lstCola);
                    clsListaDoble.RecorrerDes(cmbCodigo);
                }

            }
            else
            {
                MessageBox.Show("Lista vacia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            rdbAsc.Enabled = true;
        }

        private void rdbAsc_CheckedChanged(object sender, EventArgs e)
        {
            clsListaDoble.Recorrer(dgvCola, lstCola);
            clsListaDoble.Recorrer(cmbCodigo);
        }

        private void rdbDes_CheckedChanged(object sender, EventArgs e)
        {
            clsListaDoble.RecorrerDes(dgvCola);
            clsListaDoble.RecorrerDes(lstCola);
        }

        private void grbListado_Enter(object sender, EventArgs e)
        {

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

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
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
