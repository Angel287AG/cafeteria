using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class frmCafeteria : Form
    {
        private List<Bebida> bebidas;

        public frmCafeteria()
        {
            InitializeComponent();
            bebidas = new List<Bebida>();
        }

        private void rdbCaliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCaliente.Checked)
            {
                lblExtra.Text = "Temperatura";
            }
            else
            {
                lblExtra.Text = "Hielos";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre");
                return;
            }

            if (!float.TryParse(txtPrecio.Text, out float precio))
            {
                MessageBox.Show("Precio inválido");
                return;
            }

            if (!int.TryParse(txtExtra.Text, out int extra))
            {
                MessageBox.Show("Dato extra inválido");
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string tamano = cmbTamano.Text;

            if (rdbCaliente.Checked)
            {
                bebidas.Add(
                    new calient(nombre, tamano, precio, extra)
                );
            }
            else
            {
                bebidas.Add(
                    new fri(nombre, tamano, precio, extra)
                );
            }

            Bebida ultima = bebidas[bebidas.Count - 1];

            if (ultima is calient caliente)
            {
                lsbBebidas.Items.Add(caliente.Mensaje());
            }
            else if (ultima is fri fria)
            {
                lsbBebidas.Items.Add(fria.Mensaje());
            }

            lblCantidad.Text =
                bebidas.Count + " Bebidas Registradas";

            LimpiarComponentes();
        }

        private void LimpiarComponentes()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtExtra.Clear();
            cmbTamano.SelectedIndex = -1;
        }

        private void lsbBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbBebidas.SelectedIndex >= 0)
            {
                lblDescripcion.Text =
                    bebidas[lsbBebidas.SelectedIndex].Preparar();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmCafeteria_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}