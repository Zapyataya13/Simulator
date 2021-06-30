using System.Windows;

namespace Simulator.GameWindows
{
    /// <summary>
    /// Логика взаимодействия для WinWindow.xaml
    /// </summary>
    public partial class WinWindow : Window
    {
        HomeWindow homeWindow;

        public WinWindow(HomeWindow homeWindow)
        {
            InitializeComponent();

            this.homeWindow = homeWindow;
        }

        void BtnRestartGame_Click(object sender, RoutedEventArgs e)
        {
            homeWindow.Game.BreakCurrentTime();
            homeWindow.InitGame();
            homeWindow.InitPerson();
            this.Close();
        }

        void BtnLoadGame_Click(object sender, RoutedEventArgs e)
        {
            LoadWindow loadWindow = new LoadWindow(homeWindow);

            WPF_Misc.FocusWindow(loadWindow);
            WPF_Misc.OpenNewWindow(this, loadWindow, false);
        }

        void BtnEndGame_Click(object sender, RoutedEventArgs e)
        {
            WPF_Misc.OpenNewWindow(this, new MainWindow(), false, false);

            // Вместе с этим окном закроется и окно паузы, т.к. это окно-родитель
            homeWindow.MainWindow.Close();
            homeWindow.Close();
        }
    }
}
