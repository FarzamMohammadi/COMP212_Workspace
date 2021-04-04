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

namespace LoginUserControl
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {

        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Username.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UsernameProperty =
            DependencyProperty.Register("Username", typeof(string), typeof(UserControl1), new PropertyMetadata("-USERNAME-"));


        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Username.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(UserControl1), new PropertyMetadata("***********"));

        public string UsernameAndPassword
        {
            get { return (string)GetValue(UsernameAndPasswordProperty); }
            set { SetValue(UsernameAndPasswordProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Username.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UsernameAndPasswordProperty =
            DependencyProperty.Register("UsernameAndPassword", typeof(string), typeof(UserControl1), new PropertyMetadata("-ENTERED CREDENTIALS-"));




        public UserControl1()
        {
            InitializeComponent();
        }

        private void usernameTxt_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
