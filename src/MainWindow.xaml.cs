using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TypeKid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainText_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            switch (e.Key)
            {
                case Key.Escape:
                case Key.F5:
                    textBox.Text = string.Empty;
                    return;
            }

            string replacement = null;

            switch (e.Key)
            {
                case Key.Up: replacement = "\u2191"; break;
                case Key.Down: replacement = "\u2193"; break;
                case Key.Left: replacement = "\u2190"; break;
                case Key.Right: replacement = "\u2192"; break;
                case Key.Enter: replacement = "\u23CE"; break;
                case Key.Home: replacement = "\u2302"; break;
                case Key.End: replacement = "\u221E"; break;
                case Key.PageUp: replacement = "\u25B2"; break;
                case Key.PageDown: replacement = "\u25BC"; break;
                case Key.Clear: replacement = "\u263A"; break;
                case Key.Insert: replacement = "\u25A0"; break;
                case Key.Delete: replacement = "\u25A1"; break;
                case Key.Apps: replacement = "\u2261"; break;
                case Key.Tab: replacement = "\u25AC"; break;
                case Key.Capital: replacement = "\u2206"; break;
                case Key.LeftShift:
                case Key.RightShift: replacement = "\u2248"; break;
                case Key.LeftCtrl:
                case Key.RightCtrl: replacement = "\u2022"; break;
                case Key.System: replacement = "\u266A"; break;
            }

            if (replacement != null)
            {
                e.Handled = true;
                textBox.AppendTextEx(replacement);
            }

            if (e.Key == Key.System)
                e.Handled = false;
        }

        private void MainText_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.System)
                e.Handled = true;
        }
    }
}
