using System.Windows;
using System.IO;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System;
using System.Globalization;
using System.Numerics;
using System.Threading.Tasks;

namespace _301109706_Mohammadi__Lab03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        //Initanciate String Arrays to Add Stock Values For Search Process
        string[] symbolColumnInfo = new string[3099];
        string[] dataColummnInfo = new string[3099];
        string[] openColumnInfo = new string[3099];
        string[] highColumnInfo = new string[3099];
        string[] lowColumnInfo = new string[3099];
        string[] closeColumnInfo = new string[3099];
        public MainWindow()
        {
            InitializeComponent();
            _ = populateGridAsynchronously();
        }
        private async Task populateGridAsynchronously()
        {
            int numberOfRows = 3099;
            string retrievedCellString = "";
            Excel excel = new Excel(@"stockData.csv", 1);

            //Keep Populating The Grid Until We Reach The End of The Excel File 
            //While Also Setting The Values To the Arrays To Keep For The Search Process
            for (int row = 1; row < numberOfRows; row++)
            {
                //Each Item Gets Added To The Grid Asynchronously
                await Task.Delay(200);
                Stock stock = new Stock();

                retrievedCellString = excel.ReadCell(row, 0);
                stock.stockSymbol = retrievedCellString;
                symbolColumnInfo[row - 1] = retrievedCellString;

                retrievedCellString = excel.ReadCell(row, 1);
                stock.retrievedDate = retrievedCellString;
                dataColummnInfo[row - 1] = retrievedCellString;

                retrievedCellString = excel.ReadCell(row, 2);
                stock.openingPrice = isItNegative(retrievedCellString).ToString();
                openColumnInfo[row - 1] = isItNegative(retrievedCellString).ToString();

                retrievedCellString = excel.ReadCell(row, 3);
                stock.highestPrice = isItNegative(retrievedCellString).ToString();
                highColumnInfo[row - 1] = isItNegative(retrievedCellString).ToString();

                retrievedCellString = excel.ReadCell(row, 4);
                stock.lowestPrice = isItNegative(retrievedCellString).ToString();
                lowColumnInfo[row - 1] = isItNegative(retrievedCellString).ToString();

                retrievedCellString = excel.ReadCell(row, 5);
                stock.closingPrice = isItNegative(retrievedCellString).ToString();
                StocskDataGridXAML.Items.Add(stock);
                closeColumnInfo[row - 1] = isItNegative(retrievedCellString).ToString();

            }
        }

        //Checks If Passed Number of Type String Is Negative Or Not
        //If Negative Returns 'Null' Else It Retruns The Number
        public Nullable<double> isItNegative(string passedNumber)
        {
            double numberToCompare = (double.Parse(passedNumber, CultureInfo.InvariantCulture));
            if (numberToCompare < 0)
            { 
                return null; 
            }
            else
            {
                return numberToCompare;
            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //Once the button is click it searches if any matching stock symbols exist in the array that hols all symbols
            int counter = 0;
            foreach(string element in symbolColumnInfo)
            {
                //If matching symbol is found, we use the indext to import all relevant stock information to the datagrid
                if(element == searchTextBox.Text)
                {
                    //Each Item Gets Added To The Grid Asynchronously
                    await Task.Delay(1000);
                    Stock searchReturn = new Stock();
                    searchReturn.stockSymbol = element;
                    searchReturn.retrievedDate = dataColummnInfo[counter];
                    searchReturn.openingPrice = openColumnInfo[counter];
                    searchReturn.highestPrice = highColumnInfo[counter];
                    searchReturn.lowestPrice = lowColumnInfo[counter];
                    searchReturn.closingPrice = closeColumnInfo[counter];

                    //Sort By Date
                    //string date1 = "2019-02-28 12:00:00 AM";
                    //string date2 = "2019-03-18 12:00:00 AM";
                    //string date3 = "2019-02-18 12:00:00 AM";
                    //string[] date = { date1, date2, date3 };
                    //var orderedDateList = date.OrderBy(x => DateTime.Parse(x)).ToList();
                    //foreach(var time in orderedDateList)
                    //{
                    //    MessageBox.Show(time);
                    //}
                    SearchStockGridXAML.Items.Add(searchReturn);
                    
                }
                counter++;
            }

        }

        private void Search_Clear_Button(object sender, RoutedEventArgs e)
        {
            //Clears the Datagrid
            SearchStockGridXAML.Items.Clear();
        }

        private void getFactorialBtn_Click(object sender, RoutedEventArgs e)
        {
            //Calculated The Factorial of User Input
            long number = long.Parse(userNumberInputTxtBox.Text);
            BigInteger factorial = new BigInteger();
            factorial = number;
            for (long i = number - 1; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            
            factorialResultTxtBox.Text = factorial.ToString();
        }
    }
}
