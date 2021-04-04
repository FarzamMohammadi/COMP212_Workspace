using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

            if (selectedItem != null && !refreshOrderList(false, selectedItem.AppetizerName, true))
            {
                newItem.PurchaseName = selectedItem.AppetizerName;
                newItem.PurchaseCategory = selectedItem.AppetizerCategory;
                newItem.PurchasePrice = selectedItem.AppetizerPrice;
                newItem.Quantity = 1;

                newItemList.Add(newItem);
                BillCalculatorXMAL.Items.Add(newItem);
            }
            else if(selectedItem != null)
            {
                refreshOrderList(true, selectedItem.AppetizerName, false);
            }
            //Clear Combobox
            appetizerCbBox.SelectedIndex = -1;

        }
        //Retrieves seleceted Main Course to be added to the total order list
        private void mainCoursesCbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            StoreGoods_MainCourses selectedItem = null;
            selectedItem = (StoreGoods_MainCourses)mainCoursesCbBox.SelectedItem; ;
            newItem = new StoreGoods();

            if (selectedItem != null && !refreshOrderList(false, selectedItem.MainCourseName, true))
            {
                newItem.PurchaseName = selectedItem.MainCourseName;
                newItem.PurchaseCategory = selectedItem.MainCourseCategory;
                newItem.PurchasePrice = selectedItem.MainCoursePrice;
                newItem.Quantity = 1;

                newItemList.Add(newItem);
                BillCalculatorXMAL.Items.Add(newItem);
            }
            else if (selectedItem != null)
            {
                refreshOrderList(true, selectedItem.MainCourseName, false);
            }
            //Clear Combobox
            mainCoursesCbBox.SelectedIndex = -1;

        }
        //Retrieves seleceted Beverage to be added to the total order list
        private void beverageCbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            StoreGoods_Beverages selectedItem = null;
            selectedItem = (StoreGoods_Beverages)beverageCbBox.SelectedItem;
            newItem = new StoreGoods();

            if (selectedItem != null && !refreshOrderList(false, selectedItem.BeverageName, true))
            {
                newItem.PurchaseName = selectedItem.BeverageName;
                newItem.PurchaseCategory = selectedItem.BeverageCategory;
                newItem.PurchasePrice = selectedItem.BeveragePrice;
                newItem.Quantity = 1;

                newItemList.Add(newItem);
                BillCalculatorXMAL.Items.Add(newItem);
            }
            else if (selectedItem != null)
            {
                refreshOrderList(true, selectedItem.BeverageName, false);
            }
            //Clear Combobox
            beverageCbBox.SelectedIndex = -1;

        }
        //Retrieves seleceted Dessert to be added to the total order list
        private void dessertCbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            StoreGoods_Desserts selectedItem = null;
            selectedItem = (StoreGoods_Desserts)dessertCbBox.SelectedItem;
            newItem = new StoreGoods();


            if (selectedItem != null && !refreshOrderList(false, selectedItem.DessertName, true))
            {
                newItem.PurchaseName = selectedItem.DessertName;
                newItem.PurchaseCategory = selectedItem.DessertCategory;
                newItem.PurchasePrice = selectedItem.DessertPrice;
                newItem.Quantity = 1;

                newItemList.Add(newItem);
                BillCalculatorXMAL.Items.Add(newItem);
            }
            else if (selectedItem != null)
            {
                refreshOrderList(true, selectedItem.DessertName, false);
            }
            //Clear Combobox
            dessertCbBox.SelectedIndex = -1;
        }
        //Caluclates total by adding all the orders which were passed and added  to the list
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double total = 0;
            foreach(StoreGoods items in newItemList)
            {
                total += items.PurchasePrice * items.Quantity;
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
            mainCoursesCbBox.SelectedItem = -1;
            beverageCbBox.SelectedItem = -1;
            dessertCbBox.SelectedItem = -1;
            newItemList = new List<StoreGoods>();
            BillCalculatorXMAL.Items.Clear();
        }

        //When Remove Button Is clicked
        void RemoveRow(object sender, RoutedEventArgs e)
        {
            for (var vis = sender as Visual; vis != null; vis = VisualTreeHelper.GetParent(vis) as Visual)
                if (vis is DataGridRow)
                {
                    var row = (DataGridRow)vis;
                    if (row.IsSelected == true)
                    {
                        StoreGoods selectedForDelete = (StoreGoods)row.Item;
                        refreshOrderList(false, selectedForDelete.PurchaseName, false);
                    }
                }
        }

        //Helper for removing and adding quanitity of rows
        private bool refreshOrderList(bool amountChange, string nameOfItem, bool itemExistsInList)
        {
            //Also returns true if item is found for extra help
            bool found = false;
            //If we are adding to qunatity
            if (amountChange && !itemExistsInList)
            {
                foreach (StoreGoods item in newItemList)
                {
                    if (nameOfItem == item.PurchaseName)
                    {
                        found = true;
                        item.Quantity = item.Quantity + 1;
                        BillCalculatorXMAL.Items.Refresh();
                        break;
                    }
                }
            }
            //Else If we are removing Row
            else if(!amountChange && !itemExistsInList)
            {
                foreach (StoreGoods item in newItemList)
                {
                    if (nameOfItem == item.PurchaseName)
                    {
                        newItemList.Remove(item);
                        BillCalculatorXMAL.Items.Remove(item);
                        BillCalculatorXMAL.Items.Refresh();
                        break;
                    }
                }
            }
            else
            {
                foreach (StoreGoods item in newItemList)
                {
                    if (nameOfItem == item.PurchaseName)
                    {
                        found = true;
                    }
                }
            }
            return found;
        }

    }
}

      