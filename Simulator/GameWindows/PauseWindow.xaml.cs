using System.Windows;

namespace Simulator.GameWindows
{
    /// <summary>
    /// Логика взаимодействия для PauseWindow.xaml
    /// </summary>
    public partial class PauseWindow : Window
    {
        HomeWindow homeWindow;

        public PauseWindow(HomeWindow homeWindow)
        {
            InitializeComponent();

            this.homeWindow = homeWindow;
        }

        private void BtnReturnToGame_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnEndGame_Click(object sender, RoutedEventArgs e)
        {
            WPF_Misc.OpenNewWindow(this, new MainWindow(), false, false);

            // Вместе с этим окном закроется и окно паузы, т.к. это окно-родитель
            homeWindow.MainWindow.Close();
            homeWindow.Close();
        }

        private void BtnRestartGame_Click(object sender, RoutedEventArgs e)
        {
            homeWindow.Game.BreakCurrentTime();
            homeWindow.InitGame();
            homeWindow.InitPerson();
            this.Close();
        }
    }
}
