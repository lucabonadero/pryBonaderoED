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
    public partial class frmArbol : Form
    {
        public frmArbol()
        {
            InitializeComponent();
        }
        clsArbolBinario clsArbolBinario = new clsArbolBinario();

        private void btnAgregar_Click(object sender, EventArgs e)

        {
            
           
                if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
                {
                    clsNodo clsNodo = new clsNodo();
                    clsNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                    clsNodo.Nombre = (txtNombre.Text);
                    clsNodo.Tramite = (txtTramite.Text);

                    clsArbolBinario.Agregar(clsNodo);
                    if (clsArbolBinario.Raiz == null)
                    {
                        btnEliminar.Enabled = true; // Habilitar el botón eliminar
                    }
                    if (rdbAsc.Checked == true)
                    {
                        clsArbolBinario.RecorrerInOrder(dgvArbol);
                        clsArbolBinario.RecorrerInOrder(lstCola);
                        clsArbolBinario.RecorrerInOrder(cmbCodigo);
                        treeView1.Nodes.Clear();
                        clsArbolBinario.RecorrerInOrder(treeView1);

                }
                    else
                    {
                        if (rdbDes.Checked == true)
                        {
                            clsArbolBinario.RecorrerInOrderDes(dgvArbol);
                            clsArbolBinario.RecorrerInOrderDes(lstCola);
                            clsArbolBinario.RecorrerInOrderDes(cmbCodigo);
                            
                    }
                        MessageBox.Show("Marque algun boton de opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                                

                    txtCodigo.Text = "";
                    txtNombre.Text = "";
                    txtTramite.Text = "";
                }
                else
                {
                    MessageBox.Show("Faltan datos por completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            if (lstCola.Items.Count > 0)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex != -1)
            {
                if (clsArbolBinario.Raiz != null)
                {
                    clsArbolBinario.Eliminar(Convert.ToInt32(cmbCodigo.SelectedItem.ToString()));
                    if (rdbAsc.Checked == true)
                    {
                        clsArbolBinario.RecorrerInOrder(dgvArbol);
                        clsArbolBinario.RecorrerInOrder(lstCola);
                        clsArbolBinario.RecorrerInOrder(cmbCodigo);
                        clsArbolBinario.RecorrerInOrder(treeView1);

                    }
                    
                    else
                    {
                        clsArbolBinario.RecorrerInOrderDes(dgvArbol);
                        clsArbolBinario.RecorrerInOrderDes(lstCola);
                        clsArbolBinario.RecorrerInOrderDes(cmbCodigo);
                    }
                    cmbCodigo.Text = "";


                }
                else
                {
                    MessageBox.Show("Lista vacia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 codigo = Convert.ToInt32(cmbCodigo.SelectedItem);
            clsNodo nodo = clsArbolBinario.BuscarNodo(codigo);
            if (nodo != null)
            {
                // Mostrar los datos del nodo encontrado
                txtCodigoBUS.Text = nodo.Codigo.ToString();
                txtNombreBUS.Text = nodo.Nombre;
                txtTramiteBUS.Text = nodo.Tramite;
            }
            else
            {
                MessageBox.Show("No se encontró el nodo con código " + codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmArbol_Load(object sender, EventArgs e)
        {
            rdbAsc.Checked = true;
            btnEliminar.Enabled = false;
            

        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            //Equilibrar arbol binario
            clsArbolBinario.Equilibrar();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}


