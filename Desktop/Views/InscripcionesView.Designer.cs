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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridInscripciones).BeginInit();
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
            panel1.Size = new Size(1000, 66);
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
            CmbCapacitaciones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbCapacitaciones.FormattingEnabled = true;
            CmbCapacitaciones.Location = new Point(146, 78);
            CmbCapacitaciones.Name = "CmbCapacitaciones";
            CmbCapacitaciones.Size = new Size(488, 36);
            CmbCapacitaciones.TabIndex = 9;
            // 
            // Capacitacion
            // 
            Capacitacion.AutoSize = true;
            Capacitacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Capacitacion.Location = new Point(12, 83);
            Capacitacion.Name = "Capacitacion";
            Capacitacion.Size = new Size(128, 28);
            Capacitacion.TabIndex = 10;
            Capacitacion.Text = "Capacitación:";
            // 
            // GridInscripciones
            // 
            GridInscripciones.AllowUserToAddRows = false;
            GridInscripciones.AllowUserToDeleteRows = false;
            GridInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridInscripciones.Location = new Point(23, 130);
            GridInscripciones.Name = "GridInscripciones";
            GridInscripciones.ReadOnly = true;
            GridInscripciones.RowHeadersWidth = 51;
            GridInscripciones.Size = new Size(762, 371);
            GridInscripciones.TabIndex = 11;
            // 
            // InscripcionesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 513);
            Controls.Add(GridInscripciones);
            Controls.Add(Capacitacion);
            Controls.Add(CmbCapacitaciones);
            Controls.Add(panel1);
            Name = "InscripcionesView";
            Text = "Inscripciones";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridInscripciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label;
        private ComboBox CmbCapacitaciones;
        private Label Capacitacion;
        private DataGridView GridInscripciones;
    }
}