using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD6_ChatBot_Manu
{
    class Mensaje : INotifyPropertyChanged
    {
        private string _mensaje;

        private string _usuario;

        public string Usuario
        {
            get { return _usuario; }
            set
            {
                _usuario = value;
                NotifyPropertyChanged("Usuario");
            }
        }

        public string Mensaje1
        {
            get { return _mensaje; }
            set
            {
                _mensaje = value;
                NotifyPropertyChanged("Nombre");
            }
        }

        public Mensaje()
        {
            _usuario = "mujer";
        }

        public Mensaje(string mensaje, string usuario)
        {
            _mensaje = mensaje;
            Usuario = usuario;
        }

        public static ObservableCollection<Mensaje> GetSamples()
        {
            ObservableCollection<Mensaje> lista = new ObservableCollection<Mensaje>();
            /*lista.Add(new Mensaje("Nombre1"));
            lista.Add(new Mensaje("Nombre2"));
            lista.Add(new Mensaje("Nombre3"));*/

            return lista;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
