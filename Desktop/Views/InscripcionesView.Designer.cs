namespace Desktop.Views
{
    partial class InscripcionesView
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
            panel1 = new Panel();
            label = new Label();
            CmbCapacitaciones = new ComboBox();
            Capacitacion = new Label();
            GridInscripciones = new DataGridView();
            PanelInscriciones = new Panel();
            BtnAgregarUsuario = new FontAwesome.Sharp.IconButton();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            TxtBuscarUsuarios = new TextBox();
            GridUsuarios = new DataGridView();
            label1 = new Label();
            CmbTipoIncripcion = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridInscripciones).BeginInit();
            PanelInscriciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 66);
            panel1.TabIndex = 8;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(19, 9);
            label.Name = "label";
            label.Size = new Size(230, 39);
            label.TabIndex = 1;
            label.Text = "Inscripciones";
            // 
            // CmbCapacitaciones
            // 
            CmbCapacitaciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbCapacitaciones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbCapacitaciones.FormattingEnabled = true;
            CmbCapacitaciones.Location = new Point(159, 92);
            CmbCapacitaciones.Name = "CmbCapacitaciones";
            CmbCapacitaciones.Size = new Size(601, 36);
            CmbCapacitaciones.TabIndex = 9;
            CmbCapacitaciones.SelectedIndexChanged += CmbCapacitaciones_SelectedIndexChanged;
            // 
            // Capacitacion
            // 
            Capacitacion.Anchor = AnchorStyles.Left;
            Capacitacion.AutoSize = true;
            Capacitacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Capacitacion.Location = new Point(20, 101);
            Capacitacion.Name = "Capacitacion";
            Capacitacion.Size = new Size(128, 28);
            Capacitacion.TabIndex = 10;
            Capacitacion.Text = "Capacitación:";
            // 
            // GridInscripciones
            // 
            GridInscripciones.AllowUserToAddRows = false;
            GridInscripciones.AllowUserToDeleteRows = false;
            GridInscripciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridInscripciones.Location = new Point(20, 147);
            GridInscripciones.Name = "GridInscripciones";
            GridInscripciones.ReadOnly = true;
            GridInscripciones.RowHeadersVisible = false;
            GridInscripciones.RowHeadersWidth = 51;
            GridInscripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridInscripciones.Size = new Size(740, 453);
            GridInscripciones.TabIndex = 11;
            // 
            // PanelInscriciones
            // 
            PanelInscriciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            PanelInscriciones.BorderStyle = BorderStyle.Fixed3D;
            PanelInscriciones.Controls.Add(label2);
            PanelInscriciones.Controls.Add(CmbTipoIncripcion);
            PanelInscriciones.Controls.Add(BtnAgregarUsuario);
            PanelInscriciones.Controls.Add(BtnBuscar);
            PanelInscriciones.Controls.Add(TxtBuscarUsuarios);
            PanelInscriciones.Controls.Add(GridUsuarios);
            PanelInscriciones.Controls.Add(label1);
            PanelInscriciones.Location = new Point(795, 90);
            PanelInscriciones.Name = "PanelInscriciones";
            PanelInscriciones.Size = new Size(474, 519);
            PanelInscriciones.TabIndex = 12;
            // 
            // BtnAgregarUsuario
            // 
            BtnAgregarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAgregarUsuario.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            BtnAgregarUsuario.IconColor = Color.Black;
            BtnAgregarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregarUsuario.IconSize = 40;
            BtnAgregarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregarUsuario.Location = new Point(356, 32);
            BtnAgregarUsuario.Margin = new Padding(2);
            BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            BtnAgregarUsuario.Size = new Size(112, 45);
            BtnAgregarUsuario.TabIndex = 14;
            BtnAgregarUsuario.Text = "&Agregar";
            BtnAgregarUsuario.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.Black;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.IconSize = 40;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(239, 32);
            BtnBuscar.Margin = new Padding(2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(112, 43);
            BtnBuscar.TabIndex = 13;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtBuscarUsuarios
            // 
            TxtBuscarUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TxtBuscarUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBuscarUsuarios.Location = new Point(3, 41);
            TxtBuscarUsuarios.Name = "TxtBuscarUsuarios";
            TxtBuscarUsuarios.PlaceholderText = "Buscar usuario...";
            TxtBuscarUsuarios.Size = new Size(231, 34);
            TxtBuscarUsuarios.TabIndex = 2;
            TxtBuscarUsuarios.TextChanged += TxtBuscarUsuarios_TextChanged;
            TxtBuscarUsuarios.KeyPress += TxtBuscarUsuarios_KeyPress;
            // 
            // GridUsuarios
            // 
            GridUsuarios.AllowUserToAddRows = false;
            GridUsuarios.AllowUserToDeleteRows = false;
            GridUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            GridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridUsuarios.Location = new Point(3, 84);
            GridUsuarios.Name = "GridUsuarios";
            GridUsuarios.ReadOnly = true;
            GridUsuarios.RowHeadersVisible = false;
            GridUsuarios.RowHeadersWidth = 51;
            GridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridUsuarios.Size = new Size(464, 357);
            GridUsuarios.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 0;
            label1.Text = "Agregar Inscipcion";
            // 
            // CmbTipoIncripcion
            // 
            CmbTipoIncripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbTipoIncripcion.FormattingEnabled = true;
            CmbTipoIncripcion.Location = new Point(3, 472);
            CmbTipoIncripcion.Name = "CmbTipoIncripcion";
            CmbTipoIncripcion.Size = new Size(195, 36);
            CmbTipoIncripcion.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 450);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 16;
            label2.Text = "Tipo de inscripcion:";
            // 
            // InscripcionesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 624);
            Controls.Add(PanelInscriciones);
            Controls.Add(GridInscripciones);
            Controls.Add(Capacitacion);
            Controls.Add(CmbCapacitaciones);
            Controls.Add(panel1);
            Name = "InscripcionesView";
            Text = "Inscripciones";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridInscripciones).EndInit();
            PanelInscriciones.ResumeLayout(false);
            PanelInscriciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label;
        private ComboBox CmbCapacitaciones;
        private Label Capacitacion;
        private DataGridView GridInscripciones;
        private Panel PanelInscriciones;
        private DataGridView GridUsuarios;
        private Label label1;
        private TextBox TxtBuscarUsuarios;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private FontAwesome.Sharp.IconButton BtnAgregarUsuario;
        private Label label2;
        private ComboBox CmbTipoIncripcion;
    }
}