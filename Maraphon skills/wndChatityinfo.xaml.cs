using System;
using System.Collections.Generic;
using System.IO;
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

namespace Maraphon_skills
{
    /// <summary>
    /// Логика взаимодействия для wndChatityinfo.xaml
    /// </summary>
    public partial class wndChatityinfo : Window
    {
        public wndChatityinfo(Charity charity)
        {
            InitializeComponent();

            label_charityName.Content = charity.CharityName;
            textblok_charityDescreption.Text = charity.CharityDescription;

            image.Source = new BitmapImage(new Uri(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "charities", charity.CharityLogo)));
        }
    }
}
