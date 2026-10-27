
using System;
using System.Drawing;
using System.Windows.Forms;

namespace VetControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void lblEtapa_Click(object sender, EventArgs e) { }
        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lstServicios_SelectedIndexChanged(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "VetControl - Registro de mascotas";
            lblTotal.Text = "Mascotas: 0";
            lblEtapa.Text = "-";
            lblEtapa.BackColor = Color.White;
        }

        private void MostrarMensaje(string texto, Color color)
        {
            lblMensaje.Text = texto;
            lblMensaje.ForeColor = color;
        }

        private void ActualizarTotal()
        {
            lblTotal.Text = "Mascotas: " + lstMascotas.Items.Count;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtEspecie.Clear();
            txtEdad.Clear();
            txtPeso.Clear();
            txtSexo.Clear();

            lblEtapa.Text = "-";
            lblEtapa.BackColor = Color.White;
            lblMeses.Text = "";
            lblCosto.Text = "";
            lblMensaje.Text = "";
            errorProvider1.Clear();

            txtNombre.Focus();
        }

        private void cmsLista_Opening(object sender,
            System.ComponentModel.CancelEventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            Mascota mascota = new Mascota();

            mascota.Nombre = txtNombre.Text.Trim();
            mascota.Especie = txtEspecie.Text.Trim();
            mascota.Edad = int.Parse(txtEdad.Text);
            mascota.Peso = double.Parse(txtPeso.Text);
            mascota.Sexo = char.ToUpper(txtSexo.Text.Trim()[0]);
            mascota.Servicio = lstServicios.Text;

            string etapa = mascota.ObtenerEtapa();

            lblEtapa.Text = etapa;

            switch (etapa)
            {
                case "Cachorro":
                    lblEtapa.BackColor = Color.LightSkyBlue;
                    break;

                case "Adulto":
                    lblEtapa.BackColor = Color.LightGreen;
                    break;

                case "Senior":
                    lblEtapa.BackColor = Color.Khaki;
                    break;
            }

            lblMeses.Text = "Edad en meses: " +
                            mascota.CalcularEdadEnMeses();

            decimal costoBase = mascota.ObtenerCostoBase();
            decimal descuento = mascota.CalcularDescuento();
            decimal impuesto = mascota.CalcularImpuesto();
            decimal total = mascota.CalcularTotal();

            lblCosto.Text =
                "Costo base: ₡" + costoBase.ToString("N2") +
                "\nDescuento: ₡" + descuento.ToString("N2") +
                "\nImpuesto (13%): ₡" + impuesto.ToString("N2") +
                "\nTotal: ₡" + total.ToString("N2");

            lstMascotas.Items.Add(mascota.ObtenerResumen());

            ActualizarTotal();

            string resumen = "Mascota registrada\n\n" +
                             "Nombre: " + mascota.Nombre + "\n" +
                             "Especie: " + mascota.Especie + "\n" +
                             "Sexo: " + mascota.ObtenerSexoCompleto() + "\n" +
                             "Edad: " + mascota.Edad + " años\n" +
                             "Etapa: " + etapa + "\n" +
                             "Edad en meses: " +
                             mascota.CalcularEdadEnMeses() + "\n" +
                             "Servicio: " + mascota.Servicio + "\n" +
                             "Costo base: ₡" + costoBase.ToString("N2") + "\n" +
                             "Descuento: ₡" + descuento.ToString("N2") + "\n" +
                             "Impuesto: ₡" + impuesto.ToString("N2") + "\n" +
                             "Total: ₡" + total.ToString("N2");

            MessageBox.Show(
                resumen,
                "Mascota registrada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            LimpiarCampos();
            lstServicios.ClearSelected();
            MostrarMensaje("Mascota agregada: " + mascota.Nombre, Color.Green);
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            lstServicios.ClearSelected();
        }
        private bool ValidarCampos()
        {
            errorProvider1.Clear();
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre de la mascota.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtEspecie.Text))
            {
                errorProvider1.SetError(txtEspecie, "Ingrese la especie.");
                valido = false;
            }

            int edad;
            if (!int.TryParse(txtEdad.Text, out edad) || edad < 0 || edad > 30)
            {
                errorProvider1.SetError(txtEdad, "La edad debe ser un número entre 0 y 30.");
                valido = false;
            }

            double peso;
            if (!double.TryParse(txtPeso.Text, out peso) || peso <= 0)
            {
                errorProvider1.SetError(txtPeso, "El peso debe ser mayor que cero.");
                valido = false;
            }

            string sexo = txtSexo.Text.Trim().ToUpper();

            if (sexo != "M" && sexo != "H")
            {
                errorProvider1.SetError(txtSexo, "Ingrese M para macho o H para hembra.");
                valido = false;
            }

            if (lstServicios.SelectedIndex == -1)
            {
                errorProvider1.SetError(lstServicios, "Seleccione un servicio.");
                valido = false;
            }

            return valido;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir de VetControl?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void eliminarToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            if (lstMascotas.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Primero seleccione una mascota de la lista.",
                    "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string mascota = lstMascotas.Text;

            DialogResult respuesta = MessageBox.Show(
                "¿Desea eliminar a " + mascota + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                lstMascotas.Items.RemoveAt(lstMascotas.SelectedIndex);
                ActualizarTotal();
            }
        }

        private void limpiarListaToolStripMenuItem_Click(
     object sender, EventArgs e)
        {
            // Preguntar si también se deben limpiar los campos.
            DialogResult respuesta = MessageBox.Show(
                "¿Desea limpiar también los campos de texto?",
                "Limpiar lista",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            // Ejecutar la acción según la respuesta.
            switch (respuesta)
            {
                case DialogResult.Yes:
                    lstMascotas.Items.Clear();
                    LimpiarCampos();
                    lstServicios.ClearSelected();
                    ActualizarTotal();
                    break;

                case DialogResult.No:
                    lstMascotas.Items.Clear();
                    ActualizarTotal();
                    break;

                case DialogResult.Cancel:
                    // No hacer ningún cambio.
                    break;
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblMeses_Click(object sender, EventArgs e)
        {

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
