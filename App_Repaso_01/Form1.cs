using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Repaso_01
{
    public partial class frmRepaso : Form
    {
        public frmRepaso()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (txtnombre.Text=="")
            {
                MessageBox.Show("Agrege un Nombre");
                txtnombre.Focus();
            }
            else
            {
                string name = txtnombre.Text.ToUpper();
                listMatricula.Items.Add(name);
                txtnombre.Clear();
                txtnombre.Focus();
                btnEliminar.Enabled = true;
            }
            txttotal.Text = listMatricula.Items.Count.ToString("n0");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listMatricula.Items.Count == 0)
            {
                btnEliminar.Enabled = false;
                return;
            }
            else if (listMatricula.Items.Count == -1)
            {
                MessageBox.Show("Seleccione un Elemento");
                listMatricula.Focus();
            }
            else
            {
                listMatricula.Items.RemoveAt(listMatricula.SelectedIndex);
                txttotal.Text = listMatricula.Items.Count.ToString("n0");
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listMatricula.Items.Clear();
            txtnombre.Focus();
            txttotal.Text = listMatricula.Items.Count.ToString("n0");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }      
        }
    }
}
