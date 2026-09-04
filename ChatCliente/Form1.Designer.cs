namespace ChatCliente
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
            lstMensagem = new ListBox();
            btnEnviar = new Button();
            txtMensagem = new TextBox();
            btnConectar = new Button();
            txtUsuario = new TextBox();
            lstUsuarios = new ListBox();
            SuspendLayout();
            // 
            // lstMensagem
            // 
            lstMensagem.FormattingEnabled = true;
            lstMensagem.ItemHeight = 20;
            lstMensagem.Location = new Point(191, 76);
            lstMensagem.Margin = new Padding(3, 4, 3, 4);
            lstMensagem.Name = "lstMensagem";
            lstMensagem.Size = new Size(426, 344);
            lstMensagem.TabIndex = 5;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(354, 428);
            btnEnviar.Margin = new Padding(3, 4, 3, 4);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(86, 31);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtMensagem
            // 
            txtMensagem.Location = new Point(14, 428);
            txtMensagem.Margin = new Padding(3, 4, 3, 4);
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(321, 27);
            txtMensagem.TabIndex = 3;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(273, 21);
            btnConectar.Margin = new Padding(3, 4, 3, 4);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(167, 31);
            btnConectar.TabIndex = 7;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(14, 21);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(252, 27);
            txtUsuario.TabIndex = 6;
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 20;
            lstUsuarios.Location = new Point(12, 76);
            lstUsuarios.Margin = new Padding(3, 4, 3, 4);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(165, 344);
            lstUsuarios.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 469);
            Controls.Add(lstUsuarios);
            Controls.Add(btnConectar);
            Controls.Add(txtUsuario);
            Controls.Add(lstMensagem);
            Controls.Add(btnEnviar);
            Controls.Add(txtMensagem);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private ListBox lstMensagem;
        private Button btnEnviar;
        private TextBox txtMensagem;
        private Button btnConectar;
        private TextBox txtUsuario;
        private ListBox lstUsuarios;
    }
}