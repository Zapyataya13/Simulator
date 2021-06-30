using Simulator.BusinessLogic;
using System.Windows;
using System.Windows.Controls;

namespace Simulator.GameWindows
{
    /// <summary>
    /// Логика взаимодействия для LITER.xaml
    /// </summary>
    public partial class LITER : Window
    {
        private Person person;
        public LITER(Person person)
        {
            InitializeComponent();

            this.person = person;
        }

        private void Book_Click(object sender, RoutedEventArgs e)
        {
            person.Books((sender as Button).Name);
        }

        private void Closewindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
