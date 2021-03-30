 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace _301109706_Mohammadi__Lab04
{
    sealed class MyViewModel : ObservableCollection<StoreGoods_Appetizers>, INotifyPropertyChanged
    {
     
        private ObservableCollection<StoreGoods_Appetizers> _appetizers;
        public ObservableCollection<StoreGoods_Appetizers> Appetizers
        {
            get { return _appetizers; }
            set { _appetizers = value; }
        }

        private ObservableCollection<StoreGoods_Beverages> _beverages;
        public ObservableCollection<StoreGoods_Beverages> Beverages
        {
            get { return _beverages; }
            set { _beverages = value; }
        }

        private ObservableCollection<StoreGoods_Desserts> _desserts;
        public ObservableCollection<StoreGoods_Desserts> Desserts
        {
            get { return _desserts; }
            set { _desserts = value; }
        }

        private ObservableCollection<StoreGoods_MainCourses> _mainCourses;
        public ObservableCollection<StoreGoods_MainCourses> MainCourses
        {
            get { return _mainCourses; }
            set { _mainCourses = value; }
        }


        public MyViewModel()
        {

            Appetizers = new ObservableCollection<StoreGoods_Appetizers>()
            {
              new StoreGoods_Appetizers(){ AppetizerName="Buffalo Wings",AppetizerCategory="Appetizer", AppetizerPrice= 5.95},
              new StoreGoods_Appetizers(){ AppetizerName="Buffalo Fingers",AppetizerCategory="Appetizer", AppetizerPrice= 6.95},
              new StoreGoods_Appetizers(){ AppetizerName="Potato Skins",AppetizerCategory="Appetizer", AppetizerPrice= 3.95},
              new StoreGoods_Appetizers(){ AppetizerName="Nachos",AppetizerCategory="Appetizer", AppetizerPrice= 6.95},
              new StoreGoods_Appetizers(){ AppetizerName="Mushroom Caps",AppetizerCategory="Appetizer", AppetizerPrice= 18.95},
              new StoreGoods_Appetizers(){ AppetizerName="Shrimp Cocktail",AppetizerCategory="Appetizer", AppetizerPrice= 31.95},
              new StoreGoods_Appetizers(){ AppetizerName="Choips and Salsa",AppetizerCategory="Appetizer", AppetizerPrice= 13.95}
            };

            Beverages = new ObservableCollection<StoreGoods_Beverages>()
            {
              new StoreGoods_Beverages(){ BeverageName="Coffee",BeverageCategory="Beverages", BeveragePrice= 1.95},
              new StoreGoods_Beverages(){ BeverageName="Tea",BeverageCategory="Beverages", BeveragePrice= 1.95},
              new StoreGoods_Beverages(){ BeverageName="Beer",BeverageCategory="Beverages", BeveragePrice= 5.95},
              new StoreGoods_Beverages(){ BeverageName="Milk",BeverageCategory="Beverages", BeveragePrice= 2.95},
              new StoreGoods_Beverages(){ BeverageName="Juice",BeverageCategory="Beverages", BeveragePrice= 2.95},
              new StoreGoods_Beverages(){ BeverageName="Water",BeverageCategory="Beverages", BeveragePrice= 1.95},
              new StoreGoods_Beverages(){ BeverageName="Soda",BeverageCategory="Beverages", BeveragePrice= 1.95}
            };

            MainCourses = new ObservableCollection<StoreGoods_MainCourses>()
            {
              new StoreGoods_MainCourses(){ MainCourseName="Chicken Alfredo",MainCourseCategory="Appetizer", MainCoursePrice= 15.95},
              new StoreGoods_MainCourses(){ MainCourseName="Chicken Picatta",MainCourseCategory="Appetizer", MainCoursePrice= 16.95},
              new StoreGoods_MainCourses(){ MainCourseName="Turkey Club",MainCourseCategory="Appetizer", MainCoursePrice= 13.95},
              new StoreGoods_MainCourses(){ MainCourseName="Lobster Pie",MainCourseCategory="Appetizer", MainCoursePrice= 26.95},
              new StoreGoods_MainCourses(){ MainCourseName="Prime Rib",MainCourseCategory="Appetizer", MainCoursePrice= 28.95},
              new StoreGoods_MainCourses(){ MainCourseName="Turkey Dinner",MainCourseCategory="Appetizer", MainCoursePrice= 18.95},
              new StoreGoods_MainCourses(){ MainCourseName="Stuffed Chicken",MainCourseCategory="Appetizer", MainCoursePrice= 24.95}
            };

            Desserts = new ObservableCollection<StoreGoods_Desserts>()
            {
              new StoreGoods_Desserts(){ DessertName="Apple Pie",DessertCategory="Appetizer", DessertPrice= 5.95},
              new StoreGoods_Desserts(){ DessertName="Sundae",DessertCategory="Appetizer", DessertPrice= 6.95},
              new StoreGoods_Desserts(){ DessertName="Carrot Cake",DessertCategory="Appetizer", DessertPrice= 3.95},
              new StoreGoods_Desserts(){ DessertName="Mud Pie",DessertCategory="Appetizer", DessertPrice= 6.95},
              new StoreGoods_Desserts(){ DessertName="Apple Crisp ",DessertCategory="Appetizer", DessertPrice= 8.95},
            };
             
        }
    }
}
