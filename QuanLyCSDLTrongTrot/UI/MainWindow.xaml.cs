using System.Windows;
using System.Windows.Input;

namespace QuanLyCSDLTrongTrot.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }
        public void Drag_Windows(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        public void BackClick(object sender, RoutedEventArgs e)
        {

        }
        public void MenuClick(object sender, RoutedEventArgs e)
        {

        }
        public void MinimizeWindow(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        public void MaximizeWindow(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }
        public void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
