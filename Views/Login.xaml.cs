using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Walkydoggy.View
{
    /// <summary>
    /// Login.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("/Views/Paging.xaml", UriKind.Relative);
            NavigationService.Navigate(uri);
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("/Views/Register.xaml", UriKind.Relative);
            NavigationService.Navigate(uri);
        }
    }
}
