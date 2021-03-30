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
        class Quantity
        {
        }

        StoreGoods newItem = new StoreGoods();
        List<StoreGoods> newItemList = new List<StoreGoods>();
        private readonly MyViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            clear();

            _viewModel = new MyViewModel();
            // The DataContext serves as the starting point of Binding Paths
            DataContext = _viewModel;
        }
        //Retrieves seleceted Appetizer to be added to the total order list
        private void appetizerCbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            StoreGoods_Appetizers selectedItem = null;
            selectedItem = (StoreGoods_Appetizers)appetizerCbBox.SelectedItem;
            newItem = new StoreGoods();
            if (selectedItem != null)
            {
                newItem.PurchaseName = selectedItem.AppetizerName;
                newItem.PurchaseCategory = selectedItem.AppetizerCategory;
                newItem.PurchasePrice = selectedItem.AppetizerPrice;
                newItemList.Add(newItem);
                BillCalculatorXMAL.Items.Add(newItem);
            }
            
        }
        //Retrieves seleceted Main Course to be added to the total order list
        private void mainCoursesCbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            StoreGoods_MainCourses selectedItem = null;
            selectedItem = (StoreGoods_MainCourses)mainCoursesCbBox.SelectedItem; ;
            newItem = new StoreGoods();

            if (selectedItem != null)
            {
                newItem.PurchaseName = selectedItem.MainCourseName;
                newItem.PurchaseCategory = selectedItem.MainCourseCategory;
                newItem.PurchasePrice = selectedItem.MainCoursePrice;
                newItemList.Add(newItem);
                BillCalculatorXMAL.Items.Add(newItem);
            }

        }
        //Retrieves seleceted Beverage to be added to the total order list
        private void beverageCbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            StoreGoods_Beverages selectedItem = null;
            selectedItem = (StoreGoods_Beverages)beverageCbBox.SelectedItem;
            newItem = new StoreGoods();
            if (selectedItem != null)
            {
                newItem.PurchaseName = selectedItem.BeverageName;
                newItem.PurchaseCategory = selectedItem.BeverageCategory;
                newItem.PurchasePrice = selectedItem.BeveragePrice;
                newItemList.Add(newItem);
                BillCalculatorXMAL.Items.Add(newItem);
            }
        }
        //Retrieves seleceted Dessert to be added to the total order list
        private void dessertCbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            StoreGoods_Desserts selectedItem = null;
            selectedItem = (StoreGoods_Desserts)dessertCbBox.SelectedItem;
            newItem = new StoreGoods();
            if (selectedItem != null)
            {
                newItem.PurchaseName = selectedItem.DessertName;
                newItem.PurchaseCategory = selectedItem.DessertCategory;
                newItem.PurchasePrice = selectedItem.DessertPrice;
                newItemList.Add(newItem);
                BillCalculatorXMAL.Items.Add(newItem);
            }
        }
        //Caluclates total by adding all the orders which were passed and added  to the list
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
        //Centennial Page Opener
        private void Label_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.centennialcollege.ca");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            clear();
        }

        private void clear()
        {
            subtotalTxt.Text = "0";
            taxTxt.Text = "0";
            grandTotalTxt.Text = "0";
            appetizerCbBox.SelectedIndex = -1;
            mainCoursesCbBox.SelectedItem = null;
            beverageCbBox.SelectedItem = null;
            dessertCbBox.SelectedItem = null;
            newItemList = new List<StoreGoods>();
            BillCalculatorXMAL.Items.Clear();
        }
    }
}

      