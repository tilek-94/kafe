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

namespace Кафеге_программа
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void A1_MouseEnter(object sender, MouseEventArgs e)
        {
            Grid g = (Grid)sender;
             var converter = new System.Windows.Media.BrushConverter();
             g.Background = (Brush)converter.ConvertFromString("#FF8F8F8F");
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void A1_MouseLeave(object sender, MouseEventArgs e)
        {
            Grid g = (Grid)sender;
            g.Background = null;
        }

        private void A3_MouseEnter(object sender, MouseEventArgs e)
        {
            StackPanel g = (StackPanel)sender;
            var converter = new System.Windows.Media.BrushConverter();
            g.Background = (Brush)converter.ConvertFromString("#FF8F8F8F");
        }

        private void A3_MouseLeave(object sender, MouseEventArgs e)
        {
            StackPanel g = (StackPanel)sender;
            g.Background = null;
        }


        

        private void Skryit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
          

           

        }

       

        private void StolName_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Stol.Visibility = Visibility.Visible;
        }

      

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Stol.Visibility = Visibility.Collapsed;
        }

        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Check.Visibility = Visibility.Visible;
        }

       

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
          Check.Visibility = Visibility.Collapsed;
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#FF727272");
            StackPanel g = (StackPanel)sender;
            g.Background = brush;

        }

        private void StackPanel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            StackPanel g = (StackPanel)sender;
            g.Background = null;
        }

     

        private void Title_MouseDown(object sender, MouseButtonEventArgs e)
        {
            vmenu.Visibility = Visibility.Collapsed;
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
             vmenu.Visibility = Visibility.Visible;
        }

        private void Image1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            image2.Visibility = Visibility.Visible;
            image1.Visibility = Visibility.Collapsed;
        }

       

        private void Image1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            grid.Visibility = Visibility.Visible;
        }

        private void Image2_MouseDown(object sender, MouseButtonEventArgs e)
        {
           grid.Visibility = Visibility.Collapsed;
           
        }

        private void Image2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            image2.Visibility = Visibility.Collapsed;
            image1.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
        }
    }
}
