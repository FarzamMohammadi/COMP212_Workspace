using System.Windows;
using System.IO;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System;
using System.Globalization;

namespace _301109706_Mohammadi__Lab03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        string[] symbolColumnInfo = new string[3099];
        string[] dataColummnInfo = new string[3099];
        string[] openColumnInfo = new string[3099];
        string[] highColumnInfo = new string[3099];
        string[] lowColumnInfo = new string[3099];
        string[] closeColumnInfo = new string[3099];
        public MainWindow()
        {
            InitializeComponent();
            populateGrid();
        }

        public void populateGrid()
        {
            
            int numberOfRows = 3099;
            string retrievedCellString = "";

            Excel excel = new Excel(@"stockData.csv", 1);

            for (int row = 1; row < 200; row++)
            {

                Stock stock = new Stock();

                retrievedCellString = excel.ReadCell(row, 0);
                stock.stockSymbol = retrievedCellString;
                symbolColumnInfo[row - 1] = retrievedCellString;

                retrievedCellString = excel.ReadCell(row, 1);
                stock.retrievedDate = retrievedCellString;
                dataColummnInfo[row - 1] = retrievedCellString;

                retrievedCellString = excel.ReadCell(row, 2);
                MessageBox.Show((double.Parse(retrievedCellString, CultureInfo.InvariantCulture).ToString()));
                if(double.Parse(retrievedCellString, CultureInfo.InvariantCulture) < 0)
                {
                    stock.openingPrice = "";
                }
                else
                {
                    stock.openingPrice = retrievedCellString;
                    openColumnInfo[row - 1] = null;
                }
                
                retrievedCellString = excel.ReadCell(row, 3);
                stock.highestPrice = retrievedCellString;
                highColumnInfo[row - 1] = retrievedCellString;

                retrievedCellString = excel.ReadCell(row, 4);
                MessageBox.Show((double.Parse(retrievedCellString, CultureInfo.InvariantCulture).ToString()));
                if (double.Parse(retrievedCellString, CultureInfo.InvariantCulture) < 0)
                {
                    stock.highestPrice = "";
                }
                else
                {
                    stock.lowestPrice = retrievedCellString;
                    lowColumnInfo[row - 1] = null;
                }

                retrievedCellString = excel.ReadCell(row, 5);
                stock.closingPrice = retrievedCellString;
                StocskDataGridXAML.Items.Add(stock);
                closeColumnInfo[row - 1] = retrievedCellString;

            }


            //MessageBox.Show(excel.ReadCell(2, 0));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Once the button is click it searches if any matching stock symbols exist in the array that hols all symbols
            int counter = 0;
            foreach(string element in symbolColumnInfo)
            {
                //If matching symbol is found, we use the indext to import all relevant stock information to the datagrid
                if(element == searchTextBox.Text)
                {
                    Stock searchReturn = new Stock();
                    searchReturn.stockSymbol = element;
                    searchReturn.retrievedDate = dataColummnInfo[counter];
                    searchReturn.openingPrice = openColumnInfo[counter];
                    searchReturn.highestPrice = highColumnInfo[counter];
                    searchReturn.lowestPrice = lowColumnInfo[counter];
                    searchReturn.closingPrice = closeColumnInfo[counter];

                    //string date1 = "2019-02-28 12:00:00 AM";
                    //string date2 = "2019-03-18 12:00:00 AM";
                    //string date3 = "2019-02-18 12:00:00 AM";
                    //string[] date = { date1, date2, date3 };
                    //var orderedDateList = date.OrderBy(x => DateTime.Parse(x)).ToList();
                    //foreach(var time in orderedDateList)
                    //{
                    //    MessageBox.Show(time);
                    //}
                    //SearchStockGridXAML.Items.Add(searchReturn);
                    
                }
                counter++;
            }

        }

        private void Search_Clear_Button(object sender, RoutedEventArgs e)
        {
            //Clears the Datagrid
            SearchStockGridXAML.Items.Clear();
        }
    }
}
