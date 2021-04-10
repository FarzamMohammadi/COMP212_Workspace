using _301109706_Mohammadi__Lab05_Ex2.Models.Books.db;
using _301109706_Mohammadi__Lab05_Ex2.ViewModels;
using _301109706_Mohammadi__Lab05_Ex2.Views;
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

namespace _301109706_Mohammadi__Lab05_Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Authors> returnedSearch = new List<Authors>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void listButton_Click(object sender, RoutedEventArgs e)
        {
            ListBooksPage lp = new ListBooksPage();
            MyMainFrame.Navigate(lp);
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            MyMainFrame.Navigate(new System.Uri("Views/AddBookPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
