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
            lstUsuarios = new ListBox();
            SuspendLayout();
            // 
            // lstMensagem
            // 
            lstMensagem.FormattingEnabled = true;
            lstMensagem.ItemHeight = 15;
            lstMensagem.Location = new Point(167, 57);
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
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 15;
            lstUsuarios.Location = new Point(10, 57);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(145, 259);
            lstUsuarios.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 352);
            Controls.Add(lstUsuarios);
            Controls.Add(lstMensagem);
            Controls.Add(btnEnviar);
            Controls.Add(txtMensagem);
            Name = "Form1";
            Text = "Orkut | Inicio";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private ListBox lstMensagem;
        private Button btnEnviar;
        private TextBox txtMensagem;
        private ListBox lstUsuarios;
    }
}