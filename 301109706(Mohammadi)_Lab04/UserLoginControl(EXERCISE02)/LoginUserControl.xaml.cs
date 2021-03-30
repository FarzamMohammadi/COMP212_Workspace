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

namespace UserLoginControl_EXERCISE02_
{
    /// <summary>
    /// Interaction logic for LoginUserControl.xaml
    /// </summary>
    public partial class LoginUserControl : UserControl
    {
        //Username Dependecy 
        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }

        public static readonly DependencyProperty UsernameProperty =
            DependencyProperty.Register("Username", typeof(string), typeof(LoginUserControl), new PropertyMetadata(UsernamePropertyChanged));

        //Password Dependecy 
        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value);}
        }

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(LoginUserControl), new PropertyMetadata(UsernamePropertyChanged));

        //UsernameAndPassword Dependecy Which is used to show userinput for project requirements 
        public string UsernameAndPassword
        {
            get { return (string)GetValue(UsernameAndPasswordProperty); }
            set { SetValue(UsernameAndPasswordProperty, value); }
        }

     
        public static readonly DependencyProperty UsernameAndPasswordProperty =
            DependencyProperty.Register("UsernameAndPassword", typeof(string), typeof(LoginUserControl), new PropertyMetadata(null));

        public LoginUserControl()
        {
            InitializeComponent();
        }
        private static void UsernamePropertyChanged(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            LoginUserControl myView = source as LoginUserControl;
            myView.OnChangedCredentials();
        }
        
        //Sets the UsernameAndPassword to updated values
        private void OnChangedCredentials()
        {
            UsernameAndPassword = Username + Password;
        }
        //When password is changed due to "PasswordBox" not being able to have direct dependencies I use this to send password for user display
        private void passwordTxt_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = passwordTxt.Password;
        }
    }
}
