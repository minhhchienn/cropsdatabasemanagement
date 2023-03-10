using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Collections.Generic;
using QuanLyCSDLTrongTrot.Classes;

namespace QuanLyCSDLTrongTrot.UI
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        SolidColorBrush lightBlue = new(Color.FromArgb(255, 0, 153, 255));
        public Button ActiveButton { get; set; }
        public List<TextBox> InfoFields { get; set; }
        public User? currentUser;

        public AdminWindow()
        {
            InitializeComponent();
            ActiveButton = Profile;
            InfoFields = new List<TextBox> { FirstNameField, LastNameField, UsernameField, DoBField, EmailField, NumberField, GenderField, CountrySideField };
            currentUser = new();
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

        public void SetCurrentUser(User user)
        {
            if (user == null) return;
            currentUser = user;
        }

        public void Sidebar_Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is not Button clickedButton) return;
            if (ActiveButton == clickedButton) return;
            ActiveButton.Foreground = Brushes.Gray;
            ActiveButton.BorderBrush = Brushes.Transparent;
            ActiveButton = clickedButton;
            ActiveButton.BorderBrush = lightBlue;
            ActiveButton.Foreground = lightBlue;
        }
        public void Change_Avatar(object sender, RoutedEventArgs e)
        {

        }
        public void Change_Info(object sender, RoutedEventArgs e)
        {
            foreach (var field in InfoFields)
            {
                field.IsHitTestVisible = true;  
            }
            Update_Info_Panel.Visibility = Visibility.Visible;
        }
        public void Update_Info(object sender, RoutedEventArgs e)
        {

        }
        public void Cancel_Update(object sender, RoutedEventArgs e)
        {
            Update_Info_Panel.Visibility = Visibility.Collapsed;
        }
        public void Update_Password(object sender, RoutedEventArgs e)
        {

        }
    }
}
