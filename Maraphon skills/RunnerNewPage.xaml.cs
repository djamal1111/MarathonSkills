using Microsoft.Win32;
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
    /// Логика взаимодействия для RunnerNewPage.xaml
    /// </summary>
    public partial class RunnerNewPage : Page
    {
        marafonEntities db = new marafonEntities();
        public RunnerNewPage()
        {
            InitializeComponent();
            List<string> gender = new List<string> { "Male", "Female" };
            var country = new List<string>
            {
                "Andora", "Argentina", "Australia","Austria","Belgium","Botswana","Brazil","Bulgaria","Cameroon","Canada","Central Africa","Chile","China","Chinese Taipei","Colombia","Croatia","Czech Republic","Denmark","Dominican Republic","Ecuador","Egypt","El Salvador","Equatorial Guinea","Esonia","Finland","France","Germany","Greece","Guatemala","Guinea","Guinea-Bissau","Honduras","Hong Kong","Hungary","India","Indonesia","Ireland","Israel","Italy","Ivory Coast","Jamaica","Japan","Jordan","Kenya","Latvia", "Liechtenstein","Lithuania","Luxemburg", "Macau", "Macedonia", "Madagascar", "Malaysia", "Mali", "Malta", "Mauritius", "Mexico", "Moldova", "Monaco", "Montenegro", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Norway", "Panama", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Puerto Rico", "Qatar", "Romania", "Russia", "Saudi Arabia", "Senegal", "Singapore","Slovakia", "South Africa", "South Korea", "Spain", "Sweden", "Switzerland", "Thailand", "Turkey", "Unitied Arab Emirates", "Inited Kingdom", "Uruguay", "USA", "Vatican", "Venezuela", "Vietnam"
            };
            cmb_gender.ItemsSource = gender;
            cmbCountry.ItemsSource = country;



        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Email.Text) || txt_Email.Text.Length <= 0)
            {
                MessageBox.Show("Введите ваш Email");
                return;
            }

            if (int.Parse(txb_name.Text) < 1 || int.Parse(txb_name.Text) > 12)
            {
                MessageBox.Show("Введите ваше имя");
                return;
            }

            if (string.IsNullOrWhiteSpace(txb_surname.Text) || txb_surname.Text.Length < 1)
            {
                MessageBox.Show("Введите ваше фамилие");
                return;
            }
            try
            {

            }
            catch
            {
                MessageBox.Show("Произошла ошибка при добавлении");
            }
            finally
            {
                NavigationService.Navigate(new Uri("RunnerNewLoginPage.xaml", UriKind.RelativeOrAbsolute));
            }


        }

        private void btn_source_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.FilterIndex = 2;
            open.Filter = "jpg|*.jpg| png|*.png";

            if (open.ShowDialog() == true)
            {
                BitmapImage source = new BitmapImage();
                source.BeginInit(); // начало считывания фото
                source.UriSource = new Uri(@"" + open.FileName, UriKind.Relative);
                source.CacheOption = BitmapCacheOption.OnLoad; //Задержка
                source.EndInit();

                imgAvatar.Source = source;
                imgAvatar.Stretch = Stretch.Uniform;
            }
        }

        private void txb_surname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txb_pathphoto_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txb_name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
