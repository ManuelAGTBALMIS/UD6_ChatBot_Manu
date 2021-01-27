using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UD6_ChatBot_Manu
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Mensaje> mensajes = Mensaje.GetSamples();


        public MainWindow()
        {
            InitializeComponent();
            MensajesItemsControl.DataContext = mensajes;
        }


        //Nueva Conversación Metodos
        private void NewConversation_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            for (int i = mensajes.Count - 1; i >= 0; i--)
            {
                mensajes.RemoveAt(i);
            }
        }

        private void NewConversation_CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (mensajes.Count > 0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }


        //Guardar Conversación Metodos
        private void GuardarConversation_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string conversacion = "";

            if (saveFileDialog.ShowDialog() == true)
            {
                for (int i = 0; i < mensajes.Count; i++)
                {
                    conversacion += mensajes[i].Mensaje1.ToString();
                    conversacion += "\n";
                }
                File.WriteAllText(saveFileDialog.FileName, conversacion);
            }
        }

        private void GuardarConversation_CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (mensajes.Count > 0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }


        //ComprobarConexion Metodos
        private void ComprobarConexion_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Conexión correcta con el servidor del bot", "Comprobar Conexion", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ComprobarConexion_CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }


        //Salir Metodos
        private void Salir_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Salir_CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        //Enviar Metodos
        private void Enviar_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Mensaje usuario = new Mensaje(textoMensajeTextBox.Text, "usuario");
            Mensaje robot = new Mensaje("Lo siento, estoy un poco cansado para hablar", "robot");

            scrollViewer1.ScrollToEnd();

            mensajes.Add(usuario);
            mensajes.Add(robot);
        }

        private void Enviar_CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (textoMensajeTextBox != null && textoMensajeTextBox.Text != ""  )
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        //Configuración
        private void Config_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Editor editor = new Editor();
            editor.Title = "Configuración de la Aplicación";
            editor.Owner = this;

            if (editor.ShowDialog() == true)
            {
                Properties.Settings.Default.ColorFondo = editor.Fondo;
                Properties.Settings.Default.ColorRobot = editor.ColBot;
                Properties.Settings.Default.ColorUsuario = editor.ColUser;
                Properties.Settings.Default.Sexo = editor.Genero;
                


                Properties.Settings.Default.Save();
            }

        }

        private void Config_CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
