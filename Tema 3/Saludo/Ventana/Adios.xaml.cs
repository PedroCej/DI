﻿using System;
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
    /// Lógica de interacción para Adios.xaml
    /// </summary>
    public partial class Adios : Window
    {
        MainWindow main;
        public Adios(MainWindow main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            main.Show();
        }
    }
}
