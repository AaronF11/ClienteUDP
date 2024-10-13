using ClienteUDP.Class;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClienteUDP
{
    /// <summary>
    /// Ventana principal de la aplicación.
    /// </summary>
    public partial class MainWindow : Window
    {
        private Cliente _clienteUDP;

        /// <summary>
        /// Constructor que inicializa la ventana principal.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            string direccionIP = "127.0.0.1"; // Dirección IP del localhost
            int puerto = 6789; // Puerto del servidor
            _clienteUDP = new Cliente(direccionIP, puerto);
        }

        /// <summary>
        /// Manejador del evento Click del botón Enviar Mensaje.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void EnviarMensajeButton_Click(object sender, RoutedEventArgs e)
        {
            string mensaje = MessageTextBox.Text;
            _clienteUDP.EnviarMensaje(mensaje);
        }
    }
}