
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

            txtNombre.Focus();
        }

        private void cmsLista_Opening(object sender,
            System.ComponentModel.CancelEventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEspecie.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtPeso.Text) ||
                string.IsNullOrWhiteSpace(txtSexo.Text))
            {
                MessageBox.Show("Complete todos los campos.",
                    "Datos no válidos", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtEdad.Text, out int edad) ||
                edad < 0 || edad > 30)
            {
                MessageBox.Show(
                    "La edad debe ser un número entero entre 0 y 30.",
                    "Datos no válidos", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPeso.Text, out decimal peso) ||
                peso <= 0)
            {
                MessageBox.Show(
                    "El peso debe ser un número mayor que cero.",
                    "Datos no válidos", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string sexo = txtSexo.Text.Trim().ToUpper();

            if (sexo != "M" && sexo != "H")
            {
                MessageBox.Show(
                    "En sexo escriba M para macho o H para hembra.",
                    "Datos no válidos", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (lstServicios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un servicio.",
                    "Datos no válidos", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string especie = txtEspecie.Text.Trim();
            // Convertir el sexo usando switch.
            char letraSexo = sexo[0];
            string sexoCompleto;

            switch (letraSexo)
            {
                case 'M':
                    sexoCompleto = "Macho";
                    break;

                case 'H':
                    sexoCompleto = "Hembra";
                    break;

                default:
                    sexoCompleto = "";
                    break;
            }
            string servicio = lstServicios.Text;

            string etapa;

            if (edad < 1)
            {
                etapa = "Cachorro";
                lblEtapa.BackColor = Color.LightSkyBlue;
            }
            else if (edad <= 7)
            {
                etapa = "Adulto";
                lblEtapa.BackColor = Color.LightGreen;
            }
            else
            {
                etapa = "Senior";
                lblEtapa.BackColor = Color.Khaki;
            }

            lblEtapa.Text = etapa;
            lblMeses.Text = "Edad en meses: " + (edad * 12);

            decimal costoBase;

            switch (servicio)
            {
                case "Consulta general":
                    costoBase = 15000m;
                    break;

                case "Vacunación":
                    costoBase = 20000m;
                    break;

                case "Desparasitación":
                    costoBase = 10000m;
                    break;

                case "Baño":
                    costoBase = 12000m;
                    break;

                default:
                    MessageBox.Show("Seleccione un servicio válido.",
                        "Datos no válidos", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
            }

            decimal descuento =
                (etapa == "Cachorro" || etapa == "Senior")
                ? costoBase * 0.10m : 0m;

            decimal subtotal = costoBase - descuento;
            decimal impuesto = subtotal * 0.13m;
            decimal total = subtotal + impuesto;

            lblCosto.Text =
                "Descuento: ₡" + descuento.ToString("N2") +
                "\nImpuesto (13%): ₡" + impuesto.ToString("N2") +
                "\nTotal: ₡" + total.ToString("N2");

            lstMascotas.Items.Add(
                nombre + " (" + sexoCompleto + ") - " +
                especie + " - " + etapa + " - " + servicio +
                " - ₡" + total.ToString("N2"));

            ActualizarTotal();

            MessageBox.Show(
                "Nombre: " + nombre +
                "\nEspecie: " + especie +
                "\nSexo: " + sexoCompleto +
                "\nEtapa: " + etapa +
                "\nServicio: " + servicio +
                "\nTotal: ₡" + total.ToString("N2"),
                "Mascota registrada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            MostrarMensaje("Mascota agregada: " + nombre, Color.Green);

            txtNombre.Clear();
            txtEspecie.Clear();
            txtEdad.Clear();
            txtPeso.Clear();
            txtSexo.Clear();

            txtNombre.Focus();
            lstServicios.ClearSelected();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            lstServicios.ClearSelected();
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
    }
}
