using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace _301109706_Mohammadi__Test01
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;



        public Excel(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }

        //This method was from my previous Lab3 assignment which does not get used for this test
       /* public string ReadCell(int row, int column)
        {
            row++;
            column++;
            if (ws.Cells[row, column].Value != null)
            {
                return ws.Cells[row, column].Value.ToString();
            }
            else
            {
                return "";
            }
        }
*/
        public List<string> GetCountryList()
        {
            // This method gets the values of every row in the second column, which are the country names
            int counter = 0;
            //Creates countryList to add each value and when done returns it to the caller
            List<string> countryList = new List<string>();
            if (ws.Columns[2].Value != null)
            {
                foreach (var value in ws.Columns[2].Value)
                {
                    if (counter > 0 && value != null)
                    {
                        countryList.Add(value.ToString());
                    }
                    counter++;
                }
                return countryList;
            }
            else
            {
                return countryList;
            }
        }
        public List<CovidResult> ReadRowAndReturnCovidResult(int row)
        {
            // This method Reads every row available and returns the results as a list of CovidResult Objects
            row++;
            string conuntry = "";
            string province = "";
            int counter = 0;

            List<CovidResult> listOfObjectsToReturn = new List<CovidResult>();
            if (ws.Rows[row].Value2 != null)
            {      
                foreach (var value in ws.Rows[row].Value2)
                {
                    CovidResult newResult = new CovidResult();
                    // Assigns the Province/State value to be used for instanciating the CovidResult Object later
                    if (value != null && counter == 0)
                    {
                        province = value.ToString();
                    }
                    // Assigns the Country/Region value to be used for instanciating the CovidResult Object later
                    else if (value != null && counter == 1)
                    {
                        conuntry = value.ToString();
                    }
                    else if (value != null && value > 0 && counter > 1)
                    {
                        // Instaciates the newResult object of CovidResult to be added to the list of CovidResults, which will be returned
                        newResult.countryRegion = conuntry;
                        newResult.provinceState = province;
                        newResult.numberOfRecovered =value.ToString();
                        newResult.recordDates = ws.Cells[1, counter + 1].Value;                  
                    }
                    counter++;
                    if (newResult.countryRegion != null)
                    {
                        // Adds the object to the returning list of CovidResults -ONLY- if it does not contain null values
                        listOfObjectsToReturn.Add(newResult);
                    }                 
                }

                return listOfObjectsToReturn;
            }
            else
            {
                return listOfObjectsToReturn;
            }
        }
    }
}
