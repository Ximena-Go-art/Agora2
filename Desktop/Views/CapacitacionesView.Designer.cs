namespace Desktop.Views
{
    partial class CapacitacionesView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TabControl = new TabControl();
            TabPageLista = new TabPage();
            BtnRestaurar = new FontAwesome.Sharp.IconButton();
            checkVerEliminados = new CheckBox();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            TxtBuscar = new TextBox();
            label2 = new Label();
            BtnSalir = new FontAwesome.Sharp.IconButton();
            GridCapacitaciones = new DataGridView();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnAgregar = new FontAwesome.Sharp.IconButton();
            BtnModificar = new FontAwesome.Sharp.IconButton();
            TabPageAgregarEditar = new TabPage();
            CheckInscripcionAbierta = new CheckBox();
            label8 = new Label();
            DateTimeFechaHora = new DateTimePicker();
            TxtPonente = new TextBox();
            label1 = new Label();
            label5 = new Label();
            NumericCupo = new NumericUpDown();
            TxtDetalle = new TextBox();
            label4 = new Label();
            TxtNombre = new TextBox();
            label3 = new Label();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label = new Label();
            statusStrip1 = new StatusStrip();
            LabelStatusMessage = new ToolStripStatusLabel();
            TimerStatusBar = new System.Windows.Forms.Timer(components);
            TabControl.SuspendLayout();
            TabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridCapacitaciones).BeginInit();
            TabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCupo).BeginInit();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(TabPageLista);
            TabControl.Controls.Add(TabPageAgregarEditar);
            TabControl.Location = new Point(17, 66);
            TabControl.Margin = new Padding(2);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(966, 391);
            TabControl.TabIndex = 6;
            // 
            // TabPageLista
            // 
            TabPageLista.Controls.Add(BtnRestaurar);
            TabPageLista.Controls.Add(checkVerEliminados);
            TabPageLista.Controls.Add(BtnBuscar);
            TabPageLista.Controls.Add(TxtBuscar);
            TabPageLista.Controls.Add(label2);
            TabPageLista.Controls.Add(BtnSalir);
            TabPageLista.Controls.Add(GridCapacitaciones);
            TabPageLista.Controls.Add(BtnEliminar);
            TabPageLista.Controls.Add(BtnAgregar);
            TabPageLista.Controls.Add(BtnModificar);
            TabPageLista.Location = new Point(4, 29);
            TabPageLista.Margin = new Padding(2);
            TabPageLista.Name = "TabPageLista";
            TabPageLista.Padding = new Padding(2);
            TabPageLista.Size = new Size(958, 358);
            TabPageLista.TabIndex = 1;
            TabPageLista.Text = "Lista";
            TabPageLista.UseVisualStyleBackColor = true;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Bottom;
            BtnRestaurar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            BtnRestaurar.IconColor = Color.Black;
            BtnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnRestaurar.IconSize = 40;
            BtnRestaurar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRestaurar.Location = new Point(840, 245);
            BtnRestaurar.Margin = new Padding(2);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(109, 42);
            BtnRestaurar.TabIndex = 6;
            BtnRestaurar.Text = "&Restaurar";
            BtnRestaurar.TextAlign = ContentAlignment.MiddleRight;
            BtnRestaurar.UseVisualStyleBackColor = true;
            BtnRestaurar.Visible = false;
            BtnRestaurar.Click += BtnRestaurar_Click;
            // 
            // checkVerEliminados
            // 
            checkVerEliminados.AutoSize = true;
            checkVerEliminados.Location = new Point(640, 14);
            checkVerEliminados.Name = "checkVerEliminados";
            checkVerEliminados.Size = new Size(129, 24);
            checkVerEliminados.TabIndex = 1;
            checkVerEliminados.Text = "Ver Eliminados";
            checkVerEliminados.UseVisualStyleBackColor = true;
            checkVerEliminados.CheckedChanged += checkVerEliminados_CheckedChanged;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Bottom;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.Black;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.IconSize = 40;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(840, 6);
            BtnBuscar.Margin = new Padding(2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(109, 43);
            BtnBuscar.TabIndex = 2;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(64, 15);
            TxtBuscar.Margin = new Padding(2);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(515, 27);
            TxtBuscar.TabIndex = 0;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 18);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 13;
            label2.Text = "Buscar:";
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            BtnSalir.IconColor = Color.Black;
            BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSalir.IconSize = 40;
            BtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalir.Location = new Point(840, 306);
            BtnSalir.Margin = new Padding(2);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(109, 41);
            BtnSalir.TabIndex = 7;
            BtnSalir.Text = "Salir";
            BtnSalir.TextAlign = ContentAlignment.MiddleRight;
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // GridCapacitaciones
            // 
            GridCapacitaciones.AllowUserToAddRows = false;
            GridCapacitaciones.AllowUserToDeleteRows = false;
            GridCapacitaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridCapacitaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridCapacitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridCapacitaciones.Location = new Point(5, 50);
            GridCapacitaciones.Margin = new Padding(2);
            GridCapacitaciones.MultiSelect = false;
            GridCapacitaciones.Name = "GridCapacitaciones";
            GridCapacitaciones.ReadOnly = true;
            GridCapacitaciones.RowHeadersWidth = 62;
            GridCapacitaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridCapacitaciones.Size = new Size(825, 306);
            GridCapacitaciones.TabIndex = 7;
            GridCapacitaciones.SelectionChanged += GridPeliculas_SelectionChanged_1;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Bottom;
            BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BtnEliminar.IconColor = Color.Black;
            BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEliminar.IconSize = 40;
            BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminar.Location = new Point(840, 184);
            BtnEliminar.Margin = new Padding(2);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(109, 42);
            BtnEliminar.TabIndex = 5;
            BtnEliminar.Text = "&Eliminar";
            BtnEliminar.TextAlign = ContentAlignment.MiddleRight;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click_1;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Bottom;
            BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            BtnAgregar.IconColor = Color.Black;
            BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregar.IconSize = 40;
            BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregar.Location = new Point(840, 70);
            BtnAgregar.Margin = new Padding(2);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(109, 43);
            BtnAgregar.TabIndex = 3;
            BtnAgregar.Text = "&Agregar";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Anchor = AnchorStyles.Bottom;
            BtnModificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            BtnModificar.IconColor = Color.Black;
            BtnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnModificar.IconSize = 40;
            BtnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnModificar.Location = new Point(840, 130);
            BtnModificar.Margin = new Padding(2);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(109, 40);
            BtnModificar.TabIndex = 4;
            BtnModificar.Text = "&Modificar";
            BtnModificar.TextAlign = ContentAlignment.MiddleRight;
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // TabPageAgregarEditar
            // 
            TabPageAgregarEditar.Controls.Add(CheckInscripcionAbierta);
            TabPageAgregarEditar.Controls.Add(label8);
            TabPageAgregarEditar.Controls.Add(DateTimeFechaHora);
            TabPageAgregarEditar.Controls.Add(TxtPonente);
            TabPageAgregarEditar.Controls.Add(label1);
            TabPageAgregarEditar.Controls.Add(label5);
            TabPageAgregarEditar.Controls.Add(NumericCupo);
            TabPageAgregarEditar.Controls.Add(TxtDetalle);
            TabPageAgregarEditar.Controls.Add(label4);
            TabPageAgregarEditar.Controls.Add(TxtNombre);
            TabPageAgregarEditar.Controls.Add(label3);
            TabPageAgregarEditar.Controls.Add(BtnCancelar);
            TabPageAgregarEditar.Controls.Add(BtnGuardar);
            TabPageAgregarEditar.Location = new Point(4, 29);
            TabPageAgregarEditar.Margin = new Padding(2);
            TabPageAgregarEditar.Name = "TabPageAgregarEditar";
            TabPageAgregarEditar.Padding = new Padding(2);
            TabPageAgregarEditar.Size = new Size(958, 358);
            TabPageAgregarEditar.TabIndex = 0;
            TabPageAgregarEditar.Text = "Agregar/Editar";
            TabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // CheckInscripcionAbierta
            // 
            CheckInscripcionAbierta.AutoSize = true;
            CheckInscripcionAbierta.Location = new Point(481, 207);
            CheckInscripcionAbierta.Name = "CheckInscripcionAbierta";
            CheckInscripcionAbierta.Size = new Size(153, 24);
            CheckInscripcionAbierta.TabIndex = 5;
            CheckInscripcionAbierta.Text = "Inscripcion abierta";
            CheckInscripcionAbierta.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 186);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 27;
            label8.Text = "Fecha y Hora:";
            // 
            // DateTimeFechaHora
            // 
            DateTimeFechaHora.CustomFormat = "dd/MM/yyyy  HH:mm";
            DateTimeFechaHora.Format = DateTimePickerFormat.Custom;
            DateTimeFechaHora.Location = new Point(145, 179);
            DateTimeFechaHora.MinDate = new DateTime(2025, 1, 1, 7, 0, 0, 0);
            DateTimeFechaHora.Name = "DateTimeFechaHora";
            DateTimeFechaHora.Size = new Size(250, 27);
            DateTimeFechaHora.TabIndex = 3;
            DateTimeFechaHora.Value = new DateTime(2025, 9, 17, 19, 5, 25, 0);
            // 
            // TxtPonente
            // 
            TxtPonente.Location = new Point(145, 77);
            TxtPonente.Margin = new Padding(2);
            TxtPonente.Name = "TxtPonente";
            TxtPonente.Size = new Size(718, 27);
            TxtPonente.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 68);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 24;
            label1.Text = "Orador/a:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 232);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 19;
            label5.Text = "Cupo:";
            // 
            // NumericCupo
            // 
            NumericCupo.Location = new Point(145, 230);
            NumericCupo.Margin = new Padding(2);
            NumericCupo.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            NumericCupo.Name = "NumericCupo";
            NumericCupo.Size = new Size(144, 27);
            NumericCupo.TabIndex = 4;
            // 
            // TxtDetalle
            // 
            TxtDetalle.Location = new Point(145, 128);
            TxtDetalle.Margin = new Padding(2);
            TxtDetalle.Name = "TxtDetalle";
            TxtDetalle.Size = new Size(718, 27);
            TxtDetalle.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 119);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 16;
            label4.Text = "Detalle:";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(145, 26);
            TxtNombre.Margin = new Padding(2);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(718, 27);
            TxtNombre.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 29);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 11;
            label3.Text = "Nombre:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Bottom;
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 40;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(499, 302);
            BtnCancelar.Margin = new Padding(2);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(109, 43);
            BtnCancelar.TabIndex = 7;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Anchor = AnchorStyles.Bottom;
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.Black;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardar.IconSize = 40;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(339, 302);
            BtnGuardar.Margin = new Padding(2);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(109, 43);
            BtnGuardar.TabIndex = 6;
            BtnGuardar.Text = "&Guardar";
            BtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label);
            panel1.Location = new Point(-2, -2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(996, 63);
            panel1.TabIndex = 7;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(19, 9);
            label.Name = "label";
            label.Size = new Size(265, 39);
            label.TabIndex = 1;
            label.Text = "Capacitaciones";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { LabelStatusMessage });
            statusStrip1.Location = new Point(0, 479);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 11, 0);
            statusStrip1.Size = new Size(992, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // LabelStatusMessage
            // 
            LabelStatusMessage.Name = "LabelStatusMessage";
            LabelStatusMessage.Size = new Size(0, 16);
            // 
            // TimerStatusBar
            // 
            TimerStatusBar.Interval = 5000;
            TimerStatusBar.Tick += TimerStatusBar_Tick;
            // 
            // CapacitacionesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 501);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(TabControl);
            Margin = new Padding(2);
            Name = "CapacitacionesView";
            TabControl.ResumeLayout(false);
            TabPageLista.ResumeLayout(false);
            TabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridCapacitaciones).EndInit();
            TabPageAgregarEditar.ResumeLayout(false);
            TabPageAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCupo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl TabControl;
        private TabPage TabPageLista;
        private TabPage TabPageAgregarEditar;
        private Panel panel1;
        private Label label;
        private PictureBox FilmPicture;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private DataGridView GridCapacitaciones;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private FontAwesome.Sharp.IconButton BtnModificar;
        private Label label2;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private TextBox TxtBuscar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private TextBox TxtDetalle;
        private Label label4;
        private TextBox TxtNombre;
        private Label label3;
        private Label label5;
        private NumericUpDown NumericCupo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LabelStatusMessage;
        private System.Windows.Forms.Timer TimerStatusBar;
        private FontAwesome.Sharp.IconButton BtnRestaurar;
        private CheckBox checkVerEliminados;
        private Label label8;
        private DateTimePicker DateTimeFechaHora;
        private TextBox TxtPonente;
        private Label label1;
        private CheckBox CheckInscripcionAbierta;
    }
}