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

namespace _301109706_Mohammadi__Lab04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StoreGoods newItem = new StoreGoods();
        List<StoreGoods> newItemList = new List<StoreGoods>();
        private readonly MyViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MyViewModel();
            // The DataContext serves as the starting point of Binding Paths
            DataContext = _viewModel;
        }

        private void appetizerCbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            StoreGoods_Appetizers selectedItem = (StoreGoods_Appetizers)appetizerCbBox.SelectedItem;
            newItem = new StoreGoods();
            newItem.PurchaseName = selectedItem.AppetizerName;
            newItem.PurchaseCategory = selectedItem.AppetizerCategory;
            newItem.PurchasePrice = selectedItem.AppetizerPrice;
            newItemList.Add(newItem);
            BillCalculatorXMAL.Items.Add(newItem);
        }

        private void mainCoursesCbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            StoreGoods_MainCourses selectedItem = (StoreGoods_MainCourses)mainCoursesCbBox.SelectedItem;
            newItem = new StoreGoods();
            newItem.PurchaseName = selectedItem.MainCourseName;
            newItem.PurchaseCategory = selectedItem.MainCourseCategory;
            newItem.PurchasePrice = selectedItem.MainCoursePrice;
            newItemList.Add(newItem);
            BillCalculatorXMAL.Items.Add(newItem);
        }

        private void beverageCbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            StoreGoods_Beverages selectedItem = (StoreGoods_Beverages)beverageCbBox.SelectedItem;
            newItem = new StoreGoods();
            newItem.PurchaseName = selectedItem.BeverageName;
            newItem.PurchaseCategory = selectedItem.BeverageCategory;
            newItem.PurchasePrice = selectedItem.BeveragePrice;
            newItemList.Add(newItem);
            BillCalculatorXMAL.Items.Add(newItem);
        }

        private void dessertCbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            StoreGoods_Desserts selectedItem = (StoreGoods_Desserts)dessertCbBox.SelectedItem;
            newItem = new StoreGoods();
            newItem.PurchaseName = selectedItem.DessertName;
            newItem.PurchaseCategory = selectedItem.DessertCategory;
            newItem.PurchasePrice = selectedItem.DessertPrice;
            newItemList.Add(newItem);
            BillCalculatorXMAL.Items.Add(newItem);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double total = 0;
            foreach(StoreGoods items in newItemList)
            {
                total += items.PurchasePrice;
            }

            StoreGoods finalOrder = new StoreGoods();
            

            subtotalTxt.Text = "$" +total.ToString();
            taxTxt.Text = finalOrder.calculateTax(total).ToString();
            grandTotalTxt.Text = finalOrder.calculateGrandTotal(total).ToString();
        }
    }
}

      