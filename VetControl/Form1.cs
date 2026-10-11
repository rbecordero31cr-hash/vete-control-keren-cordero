namespace VetControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "VetControl - Registro de mascotas";
            lblTotal.Text = "Mascotas: 0";
            lblEtapa.Text = "-";
            lblEtapa.BackColor = Color.White;
        }
        // Método para mostrar mensajes de éxito o error
        private void MostrarMensaje(string texto, Color color)
        {
            lblMensaje.Text = texto;
            lblMensaje.ForeColor = color;
        }
        // Método para actualizar el total de mascotas
        private void ActualizarTotal()
        {
            lblTotal.Text = "Mascotas: " + lstMascotas.Items.Count;
        }

        // Método para limpiar los campos de entrada
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtEspecie.Clear();
            txtEdad.Clear();
            txtPeso.Clear();
            txtSexo.Clear();
            txtCosto.Clear();

            txtNombre.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmsLista_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (lstMascotas.SelectedIndex == -1)
            {
                MostrarMensaje("Primero seleccione una mascota de la lista.", Color.Red);
                return;
            }

            lstMascotas.Items.RemoveAt(lstMascotas.SelectedIndex);
            ActualizarTotal();
            MostrarMensaje("Mascota eliminada correctamente.", Color.Green);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            // Verificar que todos los campos estén completos
            if (txtNombre.Text == "" ||
                txtEspecie.Text == "" ||
                txtEdad.Text == "" ||
                txtPeso.Text == "" ||
                txtSexo.Text == "" ||
                txtCosto.Text == "")
            {
                MostrarMensaje("Complete todos los campos.", Color.Red);
                return;
            }
            // Validar que la edad sea un número entero
            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MostrarMensaje("La edad debe ser un número entero.", Color.Red);
                return;
            }

            // Validar que la edad esté entre 0 y 30 años
            if (edad < 0 || edad > 30)
            {
                MostrarMensaje("La edad debe estar entre 0 y 30 años.", Color.Red);
                return;
            }
            // Validar que el peso sea un número
            if (!decimal.TryParse(txtPeso.Text, out decimal peso))
            {
                MostrarMensaje("El peso debe ser un número.", Color.Red);
                return;
            }

            // Validar que el peso sea mayor que cero
            if (peso <= 0)
            {
                MostrarMensaje("El peso debe ser mayor que 0.", Color.Red);
                return;
            }
            // Validar que el sexo sea M o H
            if (txtSexo.Text != "M" && txtSexo.Text != "H")
            {
                MostrarMensaje("El sexo debe ser M o H.", Color.Red);
                return;
            }
            // Validar que el costo sea un número
            if (!decimal.TryParse(txtCosto.Text, out decimal costo))
            {
                MostrarMensaje("El costo debe ser un número.", Color.Red);
                return;
            }

            // Validar que el costo sea mayor que cero
            if (costo <= 0)
            {
                MostrarMensaje("El costo debe ser mayor que 0.", Color.Red);
                return;
            }

            // Calcular la edad en meses
            int meses = edad * 12;
            lblMeses.Text = "Edad en meses: " + meses;


            // Determinar la etapa de vida de la mascota
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

            // Calcular el descuento
            decimal descuento = 0;

            if (etapa == "Cachorro" || etapa == "Senior")
            {
                descuento = costo * 0.10m;
            }

            // Calcular el subtotal y el impuesto
            decimal subtotal = costo - descuento;
            decimal impuesto = subtotal * 0.13m;

            // Calcular el total
            decimal total = subtotal + impuesto;

            // Mostrar los resultados
            lblCosto.Text = "Descuento: ₡" + descuento.ToString("N2") +
                            "\nImpuesto (13%): ₡" + impuesto.ToString("N2") +
                            "\nTotal: ₡" + total.ToString("N2");


            // Agregar la mascota a la lista
            string nombre = txtNombre.Text;
            string especie = txtEspecie.Text;
            string sexo = txtSexo.Text;

            lstMascotas.Items.Add(
                nombre + " (" + sexo + ") - " +
                especie + " - " + etapa + " - ₡" + total.ToString("N2")
            );

            // Actualizar el total de mascotas
            ActualizarTotal();

            // Mostrar mensaje de éxito
            MostrarMensaje("Mascota agregada: " + nombre, Color.Green);

            // Limpiar los campos
            LimpiarCampos();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            // Limpiar los campos y los resultados
            LimpiarCampos();

            lblEtapa.Text = "-";
            lblEtapa.BackColor = Color.White;
            lblMeses.Text = "";
            lblCosto.Text = "";
            lblMensaje.Text = "";

            txtNombre.Focus();

        }

        private void btnColor_Click(object sender, EventArgs e)
        {

            // Cambiar el color del formulario
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            // Cerrar el programa
            this.Close();


        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
            



