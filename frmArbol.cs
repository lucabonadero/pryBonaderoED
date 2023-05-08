using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "" && (rdbAsc.Checked || rdbDes.Checked == true) && (rdbInOrder.Checked || rdbPreOrder.Checked || rdbPostOrder.Checked == true))
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
                    if (rdbInOrder.Checked == true)
                    {
                        clsArbolBinario.RecorrerInOrder(dgvArbol);
                        clsArbolBinario.RecorrerInOrder(lstCola);
                        clsArbolBinario.RecorrerInOrder(cmbCodigo);
                        treeView1.Nodes.Clear();
                        clsArbolBinario.RecorrerInOrder(treeView1);
                    }
                    else if (rdbPreOrder.Checked == true)
                    {
                        clsArbolBinario.RecorrerPreOrder(dgvArbol);
                        clsArbolBinario.RecorrerPreOrder(lstCola);
                        clsArbolBinario.RecorrerPreOrder(cmbCodigo);
                        treeView1.Nodes.Clear();
                        clsArbolBinario.RecorrerPreOrder(treeView1);
                    }
                    else if (rdbPostOrder.Checked == true)
                    {
                        clsArbolBinario.RecorrerPostOrder(dgvArbol);
                        clsArbolBinario.RecorrerPostOrder(lstCola);
                        clsArbolBinario.RecorrerPostOrder(cmbCodigo);
                        treeView1.Nodes.Clear();
                        clsArbolBinario.RecorrerPostOrder(treeView1);
                    }
                }
                else if (rdbDes.Checked == true)
                {
                    if (rdbInOrder.Checked == true)
                    {
                        clsArbolBinario.RecorrerInOrderDes(dgvArbol);
                        clsArbolBinario.RecorrerInOrderDes(lstCola);
                        clsArbolBinario.RecorrerInOrderDes(cmbCodigo);
                        treeView1.Nodes.Clear();
                        clsArbolBinario.RecorrerInOrderDes(treeView1);
                    }
                    else if (rdbPreOrder.Checked == true)
                    {
                        clsArbolBinario.RecorrerPreOrderDes(dgvArbol);
                        clsArbolBinario.RecorrerPreOrderDes(lstCola);
                        clsArbolBinario.RecorrerPreOrderDes(cmbCodigo);
                        treeView1.Nodes.Clear();
                        clsArbolBinario.RecorrerPreOrderDes(treeView1);
                    }
                    else if (rdbPostOrder.Checked == true)
                    {
                        clsArbolBinario.RecorrerPostOrderDes(dgvArbol);
                        clsArbolBinario.RecorrerPostOrderDes(lstCola);
                        clsArbolBinario.RecorrerPostOrderDes(cmbCodigo);
                        treeView1.Nodes.Clear();
                        clsArbolBinario.RecorrerPostOrderDes(treeView1);
                    }
                }
                else
                {
                    MessageBox.Show("Marque algun boton de opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por completar o botones por marcar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            if (lstCola.Items.Count > 0)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
            #region Codigo antiguo (por las dudas)
            //if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            //{
            //    clsNodo clsNodo = new clsNodo();
            //    clsNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            //    clsNodo.Nombre = (txtNombre.Text);
            //    clsNodo.Tramite = (txtTramite.Text);

            //    clsArbolBinario.Agregar(clsNodo);
            //    if (clsArbolBinario.Raiz == null)
            //    {
            //        btnEliminar.Enabled = true; // Habilitar el botón eliminar
            //    }
            //    if (rdbAsc.Checked == true)
            //    {
            //        clsArbolBinario.RecorrerInOrder(dgvArbol);
            //        clsArbolBinario.RecorrerInOrder(lstCola);
            //        clsArbolBinario.RecorrerInOrder(cmbCodigo);
            //        treeView1.Nodes.Clear();
            //        clsArbolBinario.RecorrerInOrder(treeView1);

            //}
            //    else
            //    {
            //        if (rdbDes.Checked == true)
            //        {
            //            clsArbolBinario.RecorrerInOrderDes(dgvArbol);
            //            clsArbolBinario.RecorrerInOrderDes(lstCola);
            //            clsArbolBinario.RecorrerInOrderDes(cmbCodigo);

            //    }
            //        MessageBox.Show("Marque algun boton de opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }


            //    txtCodigo.Text = "";
            //    txtNombre.Text = "";
            //    txtTramite.Text = "";
            //}
            //else
            //{
            //    MessageBox.Show("Faltan datos por completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            #endregion //
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
            btnAgregar.Enabled = false;
            rdbAsc.Checked = true;
            btnEliminar.Enabled = false;
            

        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            //Llamar al metodo equilibrar para que se equilibre el arbol
            clsArbolBinario.Equilibrar();
            //Mostrar el arbol equilibrado en el datagridview y en el listbox y en el combobox y en el treeview
            clsArbolBinario.RecorrerInOrder(dgvArbol);
            clsArbolBinario.RecorrerInOrder(lstCola);
            clsArbolBinario.RecorrerInOrder(cmbCodigo);
            clsArbolBinario.RecorrerInOrder(treeView1);


        }

        private void groupBox2_Enter(object sender, EventArgs e)
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            // Crear una tabla temporal para contener los datos del DataGridView
            DataTable tabla = new DataTable();
            foreach (DataGridViewColumn columna in dgvArbol.Columns)
            {
                tabla.Columns.Add(columna.HeaderText, typeof(string));
            }
            foreach (DataGridViewRow fila in dgvArbol.Rows)
            {
                DataRow nuevaFila = tabla.NewRow();
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    nuevaFila[celda.ColumnIndex] = celda.Value;
                }
                tabla.Rows.Add(nuevaFila);
            }

            // Mostrar diálogo para seleccionar la ubicación y el nombre del archivo CSV
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Guardar archivo CSV";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Exportar la tabla a un archivo CSV
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                foreach (DataColumn columna in tabla.Columns)
                {
                    streamWriter.Write(columna.ColumnName + ",");
                }
                streamWriter.WriteLine();
                foreach (DataRow fila in tabla.Rows)
                {
                    for (int i = 0; i < tabla.Columns.Count; i++)
                    {
                        streamWriter.Write(fila[i].ToString() + ", ");
                    }
                    streamWriter.WriteLine();
                }
                streamWriter.Close();
            }
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            //Limpiar todo el formulario
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            txtCodigoBUS.Text = "";
            txtNombreBUS.Text = "";
            txtTramiteBUS.Text = "";
            cmbCodigo.Text = "";
            dgvArbol.Rows.Clear();
            lstCola.Items.Clear();
            cmbCodigo.Items.Clear();
            treeView1.Nodes.Clear();
            clsArbolBinario.Raiz = null;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            rdbAsc.Checked = true;
            rdbInOrder.Checked = true;
            txtCodigo.Focus();
        }
    }
}


