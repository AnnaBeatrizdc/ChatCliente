using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChatCliente
{
    public partial class Form1 : Form
    {
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        IPEndPoint servidor = new IPEndPoint(
            IPAddress.Parse("192.168.0.2"), 9060
        );

        Thread threadReceber;

        public Form1()
        {
            InitializeComponent();

            socket.Bind(new IPEndPoint(IPAddress.Any, 0));

            threadReceber = new Thread(ReceberMensagens);
            threadReceber.IsBackground = true;
            threadReceber.Start();
        }

        private void ReceberMensagens()
        {
            while (true)
            {
                try
                {
                    byte[] dados = new byte[1024];

                    EndPoint remetente = new IPEndPoint(
                        IPAddress.Any,
                        0
                    );

                    int quantidade = socket.ReceiveFrom(
                        dados,
                        ref remetente
                    );

                    string mensagem = Encoding.UTF8.GetString(
                        dados,
                        0,
                        quantidade
                    );

                    Invoke(new Action(() =>
                    {
                        if (mensagem.StartsWith("USUARIOS|"))
                        {
                            string[] partes = mensagem.Split('|');

                            lstUsuarios.Items.Clear();

                            for (int i = 1; i < partes.Length; i++)
                            {
                                lstUsuarios.Items.Add(partes[i]);
                            }
                        }
                        else if (mensagem.StartsWith("MENSAGEM|"))
                        {
                            string[] partes = mensagem.Split('|', 3);

                            if (partes.Length == 3)
                            {
                                string remetente = partes[1];
                                string texto = partes[2];

                                lstMensagem.Items.Add(
                                    remetente + ": " + texto
                                );
                            }
                        }
                    }));
                }
                catch (SocketException)
                {
                    // Evita que o programa seja encerrado caso ocorra
                    // alguma interrupção temporária na comunicação.
                }
                catch (ObjectDisposedException)
                {
                    // O socket foi fechado ao encerrar o programa.
                    break;
                }
            }
        }



        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Verifica se um usuário foi selecionado
            if (lstUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Selecione um usuário para enviar a mensagem.");
                return;
            }

            string mensagem = txtMensagem.Text.Trim();

            if (mensagem == "")
            {
                MessageBox.Show("Digite uma mensagem.");
                return;
            }

            string destinatario = lstUsuarios.SelectedItem.ToString();

            // Monta a mensagem que será enviada ao servidor
            string mensagemEnviar =
                "MENSAGEM|" + destinatario + "|" + mensagem;

            byte[] dados = Encoding.UTF8.GetBytes(mensagemEnviar);

            socket.SendTo(dados, servidor);

            lstMensagem.Items.Add(
                "Você para " + destinatario + ": " + mensagem
            );

            txtMensagem.Clear();
        }
        

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text.Trim();

            if (nome == "")
            {
                MessageBox.Show("Digite seu nome.");
                return;
            }

            string mensagem = "CONECTAR|" + nome;

            byte[] dados = Encoding.UTF8.GetBytes(mensagem);

            socket.SendTo(dados, servidor);

            MessageBox.Show("Conectado como " + nome);

            txtUsuario.Enabled = false;
            btnConectar.Enabled = false;
        }
    }
}