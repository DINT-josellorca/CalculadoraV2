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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int contador = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Button boton = new Button();
                    Viewbox viewbox = new Viewbox();
                    TextBlock text = new TextBlock();
                    text.Text = (++contador).ToString();
                    boton.Margin = new Thickness(10);
                    viewbox.Child = text;
                    boton.Content = viewbox;
                    boton.Tag = contador;
                    boton.Click += new RoutedEventHandler(Button_Click);
                    tabla_Grid.Children.Add(boton);
                    Grid.SetRow(boton, i);
                    Grid.SetColumn(boton, j-1);
                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Calculadora_TextBlock.Text += (sender as Button).Tag;
        }
    }
}
