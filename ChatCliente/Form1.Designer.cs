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
            SuspendLayout();
            // 
            // lstMensagem
            // 
            lstMensagem.FormattingEnabled = true;
            lstMensagem.ItemHeight = 15;
            lstMensagem.Location = new Point(12, 51);
            lstMensagem.Name = "lstMensagem";
            lstMensagem.Size = new Size(373, 259);
            lstMensagem.TabIndex = 5;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(310, 321);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtMensagem
            // 
            txtMensagem.Location = new Point(12, 321);
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(281, 23);
            txtMensagem.TabIndex = 3;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(239, 16);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(146, 23);
            btnConectar.TabIndex = 7;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 16);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(221, 23);
            txtUsuario.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 352);
            Controls.Add(btnConectar);
            Controls.Add(txtUsuario);
            Controls.Add(lstMensagem);
            Controls.Add(btnEnviar);
            Controls.Add(txtMensagem);
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
    }
}