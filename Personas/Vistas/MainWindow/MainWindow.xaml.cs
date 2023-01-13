﻿using Personas.Vistas.MainWindow;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Personas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowVM vm = new MainWindowVM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void nuevaPersonaButton_Click(object sender, RoutedEventArgs e)
        {
            vm.CargarUCNuevaPersona();
        }

        private void listadoPersonasButton_Click(object sender, RoutedEventArgs e)
        {
            vm.CargarUCListadoPersonas();
        }
    }
}
