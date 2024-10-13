using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClienteUDP.Class
{
    /// <summary>
    /// Clase que representa un cliente UDP.
    /// </summary>
    public class Cliente
    {
        private UdpClient _clienteUDP;
        private IPEndPoint _puntoDeConexionRemoto;

        /// <summary>
        /// Constructor que inicializa el cliente UDP con la dirección IP y el puerto del servidor.
        /// </summary>
        /// <param name="direccionIP">Dirección IP del servidor.</param>
        /// <param name="puerto">Puerto del servidor.</param>
        public Cliente(string direccionIP, int puerto)
        {
            _clienteUDP = new UdpClient();
            _puntoDeConexionRemoto = new IPEndPoint(IPAddress.Parse(direccionIP), puerto);
        }

        /// <summary>
        /// Envía un mensaje al servidor.
        /// </summary>
        /// <param name="mensaje">Mensaje a enviar.</param>
        public void EnviarMensaje(string mensaje)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(mensaje);
            _clienteUDP.Send(bytes, bytes.Length, _puntoDeConexionRemoto);
        }
    }
}