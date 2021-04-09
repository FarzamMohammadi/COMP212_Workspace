using _301109706_Mohammadi__Lab05_Ex2.Models.Books.db;
using _301109706_Mohammadi__Lab05_Ex2.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

          /*  SqlConnection conn =new SqlConnection();
            conn.ConnectionString = "Server =.; Database = Books; Trusted_Connection = True";

            conn.Open();*/

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            DataAccess db = new DataAccess();

            returnedSearch = db.GetAuthor(lastNameTxt.Text);
            foreach(Authors item in returnedSearch)
            {
                MessageBox.Show(item.FirstName.ToString());
            }
        
           
        }
    }
}
