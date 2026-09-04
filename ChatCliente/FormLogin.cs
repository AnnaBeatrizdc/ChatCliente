using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatCliente
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            //Fundo
            this.BackColor = Color.FromArgb(247, 247, 251);
        }

        private void btnEntra_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();

            if (nome == "")
            {
                MessageBox.Show("Digite seu nome.");
                return;
            }

            Form1 chat = new Form1(nome);

            chat.Show();

            this.Hide();
        }
    }
}
