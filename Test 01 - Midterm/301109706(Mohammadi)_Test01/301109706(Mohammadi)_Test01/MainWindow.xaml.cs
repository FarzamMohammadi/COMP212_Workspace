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
        public MainWindow()
        {
            InitializeComponent();
            // Asynchronously calling methods
            _ = populateDropDownBox();
            _ =populateGridAsynchronously();
        }


        private async Task populateDropDownBox()
        {
            // Goes through the 2nd column and adds each country to the drop down list
            List<string> countryList = new List<string>();
            string path = Path.Combine(Environment.CurrentDirectory, @"covid19_recovered_global");
            Excel excel = new Excel(path, 1);

            // Calls Excel class to get all cell values of the country names  
            countryList = excel.GetCountryList();
            string previousCountry = "";
            foreach(string country in countryList)
            {
                if (country != previousCountry)
                {
                    // Adds each returned country name from the Excel file to the drop down menu
                    countryRegionDropDown.Items.Add(country);
                    previousCountry = country;
                }
                await Task.Delay(20);
            }
        }

        private async Task populateGridAsynchronously()
        {
            // For every row in the excel files it add creates a CovidResult object to add to the grid
            int numberOfRows = 258;
            string path = Path.Combine(Environment.CurrentDirectory, @"covid19_recovered_global");
            Excel excel = new Excel(path, 1);

            // Goes through every row 
            for (int row = 1; row < numberOfRows; row++)
            {
                //Calls the method in Excel class to read and return all of the available and appropriate results 
                List<CovidResult> results = new List<CovidResult>();
                results = excel.ReadRowAndReturnCovidResult(row);
                foreach (Object result in results)
                {
                    // Adds the received CovidResult to the list
                    CovidDataGrid.Items.Add(result);
                    await Task.Delay(20);
                }
            }
        }
        private void clearBoxes()
        {
            // Clears all boxes
            countryRegionDropDown.Text = null;
            provinceTxt.Text = "";
            newRecordDate.SelectedDate = null;
            numberOfRecovered.Text = "";
            
        }
        private void insertButton_Click(object sender, RoutedEventArgs e)
        {
            // Create new CovidResult Object to Add to the grid 
            CovidResult newInsertedData = new CovidResult();
            newInsertedData.countryRegion = countryRegionDropDown.Text;
            newInsertedData.provinceState = provinceTxt.Text ?? null;
            newInsertedData.recordDates = newRecordDate.DisplayDate;
            newInsertedData.numberOfRecovered = numberOfRecovered.Text;
            CovidDataGrid.Items.Add(newInsertedData);

            // After adding clear all the boxes 
            clearBoxes();
            // Scoll to the location where the information was added
            CovidDataGrid.ScrollIntoView(newInsertedData);

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
