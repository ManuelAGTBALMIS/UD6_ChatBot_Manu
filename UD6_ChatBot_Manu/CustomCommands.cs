using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UD6_ChatBot_Manu
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand NewConversation = new RoutedUICommand
            (
                "NewConversation",
                "NewConversation",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.N, ModifierKeys.Control)
                }
            );

        public static readonly RoutedUICommand GuardarConversation = new RoutedUICommand
            (
                "GuardarConversation",
                "GuardarConversation",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.G, ModifierKeys.Control)
                }
            );
        public static readonly RoutedUICommand ComprobarConexion = new RoutedUICommand
            (
                "ComprobarConexion",
                "ComprobarConexion",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.O, ModifierKeys.Control)
                }
            );

        public static readonly RoutedUICommand Salir = new RoutedUICommand
            (
                "Salir",
                "Salir",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.S, ModifierKeys.Control)
                }
            );

        public static readonly RoutedUICommand Enviar = new RoutedUICommand
            (
                "Enviar",
                "Enviar",
                typeof(CustomCommands)
                /*new InputGestureCollection()
                {
                    new KeyGesture(Key.Enter)
                }*/
            );

        public static readonly RoutedUICommand Config = new RoutedUICommand
            (
                "Config",
                "Config",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.C, ModifierKeys.Control)
                }
            );
    }
}
