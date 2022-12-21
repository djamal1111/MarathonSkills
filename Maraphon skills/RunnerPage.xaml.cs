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

namespace Maraphon_skills
{
    /// <summary>
    /// Логика взаимодействия для RunnerPage.xaml
    /// </summary>
    public partial class RunnerPage : Page
    {
        public RunnerPage()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void button_new_runner_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("RunnerNewPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void button_runner_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("RunnerOldPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
