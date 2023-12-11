using System;
using System.Collections.Generic;
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

namespace Saludo
{
    /// <summary>
    /// Lógica de interacción para Hola.xaml
    /// </summary>
    public partial class Hola : Window
    {
        MainWindow main;
        public Hola(MainWindow main)
        {
            InitializeComponent();
            this.main = main;
        }


        private void Window_Closed_1(object sender, EventArgs e)
        {
            main.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
