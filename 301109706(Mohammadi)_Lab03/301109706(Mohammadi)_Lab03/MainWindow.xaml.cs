using System.Windows;
using System.IO;


namespace _301109706_Mohammadi__Lab03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Stock MSFT = new Stock();
            MSFT.stockSymbol = "MSFT";
            MSFT.retrievedDate = "2/28/2019";
            MSFT.openingPrice = "868.21";
            MSFT.highestPrice = "890.27";
            MSFT.lowestPrice = "849.97";
            MSFT.closingPrice = "908.51";

            StocskDataGridXAML.Items.Add(MSFT);
            getExcelFileInfo();

        }

        public void getExcelFileInfo()
        {
            string[] symbolColumnInfo = new string[3099];
            string[] dataColummnInfo = new string[3099];
            string[] openColumnInfo = new string[3099];
            string[] highColumnInfo = new string[3099];
            string[] lowColumnInfo = new string[3099];
            string[] closeColumnInfo = new string[3099];
            bool reachedFinalCell = false;
            int numberOfColumns = 6;
            int numberOfRows = 3099;
            string retrievedCellString = "";

            Excel excel = new Excel(@"stockData.csv", 1);       

            do
            { 
                for(int row = 1; row < numberOfRows; row++)
                {
                   
                        Stock stock = new Stock();
                        
                                retrievedCellString = excel.ReadCell(row, 0);
                                stock.stockSymbol = retrievedCellString;
                              
                                retrievedCellString = excel.ReadCell(row, 1);
                                stock.retrievedDate = retrievedCellString;
                         
                                retrievedCellString = excel.ReadCell(row, 2);
                                stock.openingPrice = retrievedCellString;
                             
                                retrievedCellString = excel.ReadCell(row, 3);
                                stock.highestPrice = retrievedCellString;
                           
                                retrievedCellString = excel.ReadCell(row, 4);
                                stock.lowestPrice = retrievedCellString;
                          
                                retrievedCellString = excel.ReadCell(row, 5);
                                stock.closingPrice = retrievedCellString;
                                StocskDataGridXAML.Items.Add(stock);
                             
                        
                    
                    reachedFinalCell = true;
                }


            } while (reachedFinalCell != true);
            

            MessageBox.Show(excel.ReadCell(2, 0));
        }

    }
}
