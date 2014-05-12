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
            }

            if (replacement != null)
            {
                e.Handled = true;
                Int32 lastLocation = ((TextBox)sender).SelectionStart;
                ((TextBox)sender).Text = ((TextBox)sender).Text.Insert(lastLocation, replacement);
                ((TextBox)sender).SelectionStart = lastLocation + 1;
            }
        }
    }
}
