using Simulator.GameWindows;
using System.Windows;

namespace Simulator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Настройки окна
            this.Height = 550;
            this.Width = 1100;
            this.BorderThickness = new Thickness(2, 10, 2, 2);

            this.WindowStyle = WindowStyle.None;
            this.ResizeMode = ResizeMode.NoResize;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        void BtnStartGame_Click(object sender, RoutedEventArgs e)
        {
            WPF_Misc.OpenNewWindow(this, new HomeWindow(this));

            this.Close();
        }

        void BtnExitGame_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
