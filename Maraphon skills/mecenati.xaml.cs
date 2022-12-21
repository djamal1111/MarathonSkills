using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для mecenati.xaml
    /// </summary>
    public partial class mecenati : Page, INotifyPropertyChanged
    {
        public int donate = 50;

        public event PropertyChangedEventHandler PropertyChanged;

        public int donation
        {
            get
            {
                return donate;
            }
            set
            {
                int temp = 0;

                int.TryParse(value.ToString(), out temp);

                donate = value;

                if (temp >= 10)
                {
                    donate = value;
                    PropertyChange("donation");
                }
            }
        }

        private void PropertyChange(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public mecenati()
        {
            InitializeComponent();
        }



        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<Runnerinfo> runnerInfo = new List<Runnerinfo>();

            Util.db.Registration.ToList().ForEach(r => runnerInfo.Add(new Runnerinfo() { runner = r.Runner, reg = r }));
            comboBox.ItemsSource = runnerInfo;
            comboBox.DisplayMemberPath = "info";
            this.DataContext = this;

            donation = 50;
            comboBox.SelectedIndex = 0;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Runnerinfo runner = comboBox.SelectedItem as Runnerinfo;
            Registration reg = runner.runner.Registration.SingleOrDefault();

            if (reg != null)
            {
                Charity charity = reg.Charity;

                label_charity.Content = charity.CharityName;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_add_Click(object sender, RoutedEventArgs e)
        {
            donation += 10;
        }

        private void Button_sub_Click(object sender, RoutedEventArgs e)
        {
            if (donation >= 20)
            {
                donation -= 10;

            }


        }
        private void charitinfa_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Runnerinfo runner = comboBox.SelectedItem as Runnerinfo;
            Registration reg = runner.runner.Registration.SingleOrDefault();

            if (reg != null) 
            {
                new wndChatityinfo(reg.Charity).ShowDialog();
            }
            

       
        }

        private void button_pay_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_name.Text) || textBox_name.Text.Length <= 0) 
            {
                MessageBox.Show("Введите ваше имя");
                return;
            }
            if(string.IsNullOrEmpty(textBox_card.Text) || textBox_card.Text.Length <= 0) 
            {
                MessageBox.Show("Введите владельца карты");
                return;
            }

            if (string.IsNullOrEmpty(textBox_card_num.Text) || textBox_card_num.Text.Length !=16)
            {
                MessageBox.Show("Введите номер карты ");
                return;
            }
            if (string.IsNullOrEmpty(textBox_card_mon.Text) || textBox_card_mon.Text.Length !=2)
            {
                MessageBox.Show("Введите месяц ");
                return;
            }

            if (int.Parse (textBox_card_mon.Text) < 1 || int.Parse (textBox_card_mon.Text) > 12)
            {
                MessageBox.Show("Введите корректный месяц ");
                return;
            }

            if (string.IsNullOrEmpty(textBox_card_year.Text) || textBox_card_year.Text.Length !=4)
            {
                MessageBox.Show("Введите год ");
                return;
            }
            if (string.IsNullOrEmpty(textBox_card_cvc.Text) || textBox_card_cvc.Text.Length != 3)
            {
                MessageBox.Show("Введите cvc");
                return;
            }

            Sponsorship sponsor = new Sponsorship();

            sponsor.Amount = donation;
            sponsor.Registration = (comboBox.SelectedItem as Runnerinfo).reg;
            sponsor.SponsorName = textBox_name.Text;

            try
            {
                Util.db.Sponsorship.Add(sponsor);
                Util.db.SaveChanges();


            }
            catch
            {
                MessageBox.Show("Произошла ошибка при добавлении");
            }
            finally 
            {
                NavigationService.Navigate(new SponsorshipSicces((comboBox.SelectedItem as Runnerinfo), sponsor.Registration.Charity, donation));
            
            }
        }
        private void textBox_card_num_Keydown (object sender, KeyEventArgs e)
        {
            if (!new Regex("[0-9]").IsMatch(e.Key.ToString()))
            {
                e.Handled = true;
            }
           
        }
    }

   
}
