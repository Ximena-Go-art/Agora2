namespace Desktop.Views
{
    partial class LogInView
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
            label1 = new Label();
            label2 = new Label();
            CheckContraseña = new CheckBox();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnInicio = new FontAwesome.Sharp.IconButton();
            TextBoxEmail = new TextBox();
            TextBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 93);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 144);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // CheckContraseña
            // 
            CheckContraseña.AutoSize = true;
            CheckContraseña.Location = new Point(494, 174);
            CheckContraseña.Name = "CheckContraseña";
            CheckContraseña.Size = new Size(130, 24);
            CheckContraseña.TabIndex = 2;
            CheckContraseña.Text = "Ver Contraseña";
            CheckContraseña.UseVisualStyleBackColor = true;
            CheckContraseña.CheckedChanged += CheckContraseña_CheckedChanged;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Close;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 30;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(612, 256);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(103, 33);
            BtnCancelar.TabIndex = 3;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnInicio
            // 
            BtnInicio.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnInicio.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            BtnInicio.IconColor = Color.Black;
            BtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnInicio.IconSize = 30;
            BtnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            BtnInicio.Location = new Point(425, 256);
            BtnInicio.Name = "BtnInicio";
            BtnInicio.Size = new Size(90, 33);
            BtnInicio.TabIndex = 4;
            BtnInicio.Text = "Iniciar";
            BtnInicio.TextAlign = ContentAlignment.MiddleRight;
            BtnInicio.UseVisualStyleBackColor = true;
            BtnInicio.Click += BtnInicio_Click;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(391, 90);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(324, 27);
            TextBoxEmail.TabIndex = 5;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(391, 141);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(324, 27);
            TextBoxPassword.TabIndex = 6;
            // 
            // LogInView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxEmail);
            Controls.Add(BtnInicio);
            Controls.Add(BtnCancelar);
            Controls.Add(CheckContraseña);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogInView";
            Text = "LogInView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox CheckContraseña;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnInicio;
        private TextBox TextBoxEmail;
        private TextBox TextBoxPassword;
    }
}