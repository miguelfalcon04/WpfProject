using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MyFirstWpfProject
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Grid grid = new Grid();
            //this.Content = grid;
            //Button btn = new Button();
            //btn.FontSize = 26;
            //btn.Height = 50;
            //btn.Width = 300;


            //WrapPanel wrapPanel = new WrapPanel();
            //TextBlock txtBlock = new TextBlock();
            //txtBlock.Text = "Botón";
            //txtBlock.Foreground = Brushes.Blue;
            //wrapPanel.Children.Add(txtBlock);

            //txtBlock = new TextBlock();
            //txtBlock.Text = "multi";
            //txtBlock.Foreground = Brushes.Red;
            //wrapPanel.Children.Add(txtBlock);

            //txtBlock = new TextBlock();
            //txtBlock.Text = "color";
            //txtBlock.Foreground = Brushes.Green;
            //wrapPanel.Children.Add(txtBlock);

            //btn.Content = wrapPanel;
            //grid.Children.Add(btn);
        }



        //private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    MessageBox.Show("El botón izquierdo ha sido presionado");
        //}

        //private void Button_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        //{
        //    MessageBox.Show("El botón derecho ha sido presionado");
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Externo");
        //}

        //private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        //{
        //    MessageBox.Show("Interno");
        //}


        //EJERCICIO 4
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Has hecho click");
        //}

        //EJERCICIO 5
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Has hecho click");
        //}

        //private void Button_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    MessageBox.Show("Evento MouseEnter - Detecta cuando el ratón entra en el botón.");  
        //}

        //private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    MessageBox.Show("Un evento de clic específico con el botón izquierdo");
        //}

        //ADVERTENCIA DE ERROR
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    string s = null;
        //    try
        //    {        
        //    s.Trim();
        //    }
        //    catch (Exception ex) {
        //        MessageBox.Show("A handle exception just ocurred: " +  ex.Message , "Exception Sample",
        //            MessageBoxButton.OK, MessageBoxImage.Warning);
        //    }
        //}

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(e.Uri.AbsoluteUri);
            e.Handled = true;
        }
    }
}
