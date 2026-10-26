namespace VetControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            txtNombre = new TextBox();
            Nombre = new Label();
            label1 = new Label();
            txtEspecie = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEdad = new TextBox();
            txtPeso = new TextBox();
            txtSexo = new TextBox();
            lblEtapa = new Label();
            lblMeses = new Label();
            lblCosto = new Label();
            lblMensaje = new Label();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            btnColor = new Button();
            btnSalir = new Button();
            lstMascotas = new ListBox();
            cmsLista = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            limpiarListaToolStripMenuItem = new ToolStripMenuItem();
            lblTotal = new Label();
            colorDialog1 = new ColorDialog();
            lstServicios = new ListBox();
            lblServicios = new Label();
            cmsLista.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(15, 9);
            lblTitulo.Margin = new Padding(6, 0, 6, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(220, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de mascotas";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(125, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 35);
            txtNombre.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nombre.Location = new Point(25, 57);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(94, 30);
            Nombre.TabIndex = 2;
            Nombre.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 101);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 3;
            label1.Text = "Especie:";
            // 
            // txtEspecie
            // 
            txtEspecie.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEspecie.Location = new Point(125, 96);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(100, 35);
            txtEspecie.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 147);
            label2.Name = "label2";
            label2.Size = new Size(64, 30);
            label2.TabIndex = 5;
            label2.Text = "Edad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 201);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 6;
            label3.Text = "Peso:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 251);
            label4.Name = "label4";
            label4.Size = new Size(62, 30);
            label4.TabIndex = 7;
            label4.Text = "Sexo:";
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdad.Location = new Point(125, 147);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 35);
            txtEdad.TabIndex = 8;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPeso.Location = new Point(125, 201);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 35);
            txtPeso.TabIndex = 9;
            // 
            // txtSexo
            // 
            txtSexo.CharacterCasing = CharacterCasing.Upper;
            txtSexo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSexo.Location = new Point(125, 248);
            txtSexo.MaxLength = 1;
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(100, 35);
            txtSexo.TabIndex = 10;
            // 
            // lblEtapa
            // 
            lblEtapa.BorderStyle = BorderStyle.FixedSingle;
            lblEtapa.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEtapa.Location = new Point(28, 309);
            lblEtapa.Name = "lblEtapa";
            lblEtapa.Size = new Size(197, 57);
            lblEtapa.TabIndex = 15;
            lblEtapa.Text = "-";
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMeses.Location = new Point(28, 432);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(0, 30);
            lblMeses.TabIndex = 16;
            lblMeses.Click += lblMeses_Click;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCosto.Location = new Point(28, 477);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(0, 30);
            lblCosto.TabIndex = 17;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(28, 387);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 30);
            lblMensaje.TabIndex = 18;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(322, 387);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 45);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(479, 387);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(99, 38);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnColor
            // 
            btnColor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnColor.Location = new Point(634, 385);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(76, 39);
            btnColor.TabIndex = 21;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(774, 385);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(79, 39);
            btnSalir.TabIndex = 22;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lstMascotas
            // 
            lstMascotas.ContextMenuStrip = cmsLista;
            lstMascotas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(537, 87);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(120, 184);
            lstMascotas.TabIndex = 23;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // cmsLista
            // 
            cmsLista.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem, limpiarListaToolStripMenuItem });
            cmsLista.Name = "cmsLista";
            cmsLista.Size = new Size(139, 48);
            cmsLista.Opening += cmsLista_Opening;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(138, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // limpiarListaToolStripMenuItem
            // 
            limpiarListaToolStripMenuItem.Name = "limpiarListaToolStripMenuItem";
            limpiarListaToolStripMenuItem.Size = new Size(138, 22);
            limpiarListaToolStripMenuItem.Text = "Limpiar lista";
            limpiarListaToolStripMenuItem.Click += limpiarListaToolStripMenuItem_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(537, 287);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(123, 30);
            lblTotal.TabIndex = 24;
            lblTotal.Text = "Mascotas: 0";
            lblTotal.Click += lblTotal_Click;
            // 
            // lstServicios
            // 
            lstServicios.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstServicios.FormattingEnabled = true;
            lstServicios.Items.AddRange(new object[] { "Consulta general", "Vacunación", "Desparasitación", "Baño" });
            lstServicios.Location = new Point(288, 117);
            lstServicios.Name = "lstServicios";
            lstServicios.Size = new Size(164, 154);
            lstServicios.TabIndex = 25;
            // 
            // lblServicios
            // 
            lblServicios.AutoSize = true;
            lblServicios.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblServicios.Location = new Point(269, 74);
            lblServicios.Name = "lblServicios";
            lblServicios.Size = new Size(221, 30);
            lblServicios.TabIndex = 26;
            lblServicios.Text = "Seleccione un servicio:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 749);
            Controls.Add(lblServicios);
            Controls.Add(lstServicios);
            Controls.Add(lblTotal);
            Controls.Add(lstMascotas);
            Controls.Add(btnSalir);
            Controls.Add(btnColor);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(lblMensaje);
            Controls.Add(lblCosto);
            Controls.Add(lblMeses);
            Controls.Add(lblEtapa);
            Controls.Add(txtSexo);
            Controls.Add(txtPeso);
            Controls.Add(txtEdad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEspecie);
            Controls.Add(label1);
            Controls.Add(Nombre);
            Controls.Add(txtNombre);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            cmsLista.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtNombre;
        private Label Nombre;
        private Label label1;
        private TextBox txtEspecie;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEdad;
        private TextBox txtPeso;
        private TextBox txtSexo;
        private Label lblEtapa;
        private Label lblMeses;
        private Label lblCosto;
        private Label lblMensaje;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Button btnColor;
        private Button btnSalir;
        private ListBox lstMascotas;
        private Label lblTotal;
        private ContextMenuStrip cmsLista;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem limpiarListaToolStripMenuItem;
        private ColorDialog colorDialog1;
        private ListBox lstServicios;
        private Label lblServicios;
    }
}
