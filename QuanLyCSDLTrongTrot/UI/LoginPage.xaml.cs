using QuanLyCSDLTrongTrot.Classes;
using QuanLyCSDLTrongTrot.Modules;
using System;
using System.Data;
using System.Windows;
using System.Windows.Input;

namespace QuanLyCSDLTrongTrot.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        UserList? users;
        public LoginPage()
        {
            InitializeComponent();
        }
        public void Drag_Windows(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton== MouseButton.Left)
            {
                this.DragMove();
            }
        }
        //Close Button Events
        public void Close_Button_Mouse_Enter(object sender, MouseEventArgs e)
        {
            Close_Button.Opacity = 1;
        }
        public void Close_Button_Mouse_Leave(object sender, MouseEventArgs e)
        {
            Close_Button.Opacity = 0.7;
        }

        private void Close_Button_Mouse_Down(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        //Recover Password
        private void Recover_Password(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Recover password...");
        }
        //Login
        private void Login(object sender, RoutedEventArgs e)
        {
            SQLConnectionModule connectionModule = new();
            try
            {
                connectionModule.CreateConnect();
                var username = Username_Box.Text;
                var password = Password_Box.Text;
                if (connectionModule.CheckPassword(username, password))
                {
                    AdminWindow mainwindow = new();
                    this.Close();
                    //DataTable UserListTable = connectionModule.LoadData("Select * from [dbo.USER]");
                    //users = new(UserListTable);
                    //var currentUser = users.GetUser(Username_Box.Text);
                    //mainwindow.SetCurrentUser(currentUser);
                    mainwindow.Show();
                }
                else
                {
                    MessageBox.Show("Unsuccess");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
