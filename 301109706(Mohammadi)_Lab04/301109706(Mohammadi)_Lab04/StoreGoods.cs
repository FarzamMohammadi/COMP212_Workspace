using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301109706_Mohammadi__Lab04
{
    class StoreGoods
    {
        public string AppetizerName { get; set; }
        public string AppetizerCategory { get; set; }
        public double AppetizerPrice { get; set; }

        public string BeverageName { get; set; }
        public string BeverageCategory { get; set; }
        public double BeveragePrice { get; set; }

        public string DessertName { get; set; }
        public string DessertCategory { get; set; }
        public double DessertPrice { get; set; }

        public string MainCourseName { get; set; }
        public string MainCourseCategory { get; set; }
        public double MainCoursePrice { get; set; }

        public string PurchaseName { get; set; }
        public string PurchaseCategory { get; set; }
        public double PurchasePrice { get; set; }

        StoreGoods(string _name, string _category,double _price)
        {
            PurchaseName = _name;
            PurchaseCategory = _category;
            PurchasePrice = _price;
        }

        public StoreGoods()
        {
        }

        private double calculateSubtotal(StoreGoods[] customerOrder)
        {
            double subtotal = 0;
            foreach(StoreGoods purchase in customerOrder)
            {
                subtotal += purchase.PurchasePrice;
            }
            return subtotal;
        }

        public double calculateTax(double subtotalPrice)
        {
            return subtotalPrice * 0.13;
        }
        public double calculateGrandTotal(double subtotalPrice)
        {
            return calculateTax(subtotalPrice) + subtotalPrice;
        }

    }
}
