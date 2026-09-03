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
            IPAddress.Parse("192.168.0.4"), 9060
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
                    lstMensagem.Items.Add(mensagem);
                }));
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string mensagem = txtMensagem.Text;

            byte[] dados = Encoding.UTF8.GetBytes(mensagem);

            socket.SendTo(dados, servidor);

            lstMensagem.Items.Add("Você: " + mensagem);

            txtMensagem.Clear();
        }
    }
}