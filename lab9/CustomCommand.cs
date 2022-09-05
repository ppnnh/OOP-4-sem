using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace lab6_7
{
    public class CustomCommand
    {
        private static RoutedUICommand command;

        static CustomCommand()
        {
            InputGestureCollection input = new InputGestureCollection();
            input.Add(
                new KeyGesture(Key.X,ModifierKeys.Control, "Ctrl+X"));
            command = new RoutedUICommand("Exit from application", "extCommand", typeof(CustomCommand), input);
        }

        public static RoutedUICommand Command
        {
            get { return command; }
        }
    }
}
