using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace UD6_ChatBot_Manu
{
    /// <summary>
    /// Lógica de interacción para Editor.xaml
    /// </summary>
    public partial class Editor : Window
    {
        public string Fondo { get; set; }
        public string ColUser { get; set; }
        public string ColBot { get; set; }
        public string Genero { get; set; }

        public Editor()
        {
            Fondo = Properties.Settings.Default.ColorFondo;
            ColUser = Properties.Settings.Default.ColorUsuario;
            ColBot = Properties.Settings.Default.ColorRobot;
            Genero = Properties.Settings.Default.Sexo;


            InitializeComponent();

            //El dataContext de la ventana es la propia ventana, por lo que en XAML podemos hacer binding
            //a las propiedades.
            DataContext = this;

            FondoColorComboBox.ItemsSource = typeof(Colors).GetProperties();
            ColorUsuarioComboBox.ItemsSource = typeof(Colors).GetProperties();
            ColorRobotComboBox.ItemsSource = typeof(Colors).GetProperties();

        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
