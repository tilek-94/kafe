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

namespace Кафеге_программа
{
    /// <summary>
    /// Логика взаимодействия для StolWindow.xaml
    /// </summary>
    public partial class StolWindow : Window
    {
        public StolWindow()
        {
            InitializeComponent();
        }

        private void Skryit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Tandaldy");
        }
    }
}
