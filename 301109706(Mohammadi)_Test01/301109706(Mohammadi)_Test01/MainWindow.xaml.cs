using System;
using System.Windows;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Globalization;

namespace _301109706_Mohammadi__Test01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
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
        }


        private async Task populateGridAsynchronously()
        {
            int numberOfRows = 3099;
            string retrievedCellString = "";
            string path = Path.Combine(Environment.CurrentDirectory, @"covid19_recovered_global");
            Excel excel = new Excel(path, 1);

            //Keep Populating The Grid Until We Reach The End of The Excel File 
            //While Also Setting The Values To the Arrays To Keep For The Search Process
            for (int row = 1; row < numberOfRows; row++)
            {
                //Each Item Gets Added To The Grid Asynchronously
                await Task.Delay(200);
                CovidResult result = new CovidResult();

                retrievedCellString = excel.ReadCell(row, 0);
                result.countryRegion = retrievedCellString;
                symbolColumnInfo[row - 1] = retrievedCellString;
/*
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
                closeColumnInfo[row - 1] = isItNegative(retrievedCellString).ToString();*/

            }
        }












        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}
