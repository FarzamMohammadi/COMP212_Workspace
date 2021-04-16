using _301109706_Mohammadi__Test2.Data;
using _301109706_Mohammadi__Test2.Models;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _301109706_Mohammadi__Test2.ViewModels
{
    class MainWindowViewModel
    {
        //Retrieves All Buttons 
        public ICommand LINQProjectQSCommand { get; private set; }
        public ICommand LINQFilterCommand { get; private set; }
        public ICommand LINQOrderASCommand { get; private set; }
        public ICommand LINQJoinCommand { get; private set; }
        public ICommand ClearButtonCommand { get; private set; }
        public ICommand DeleteRowCommand { get; private set; }

        private ObservableCollection<string> _fruit;
        public ObservableCollection<string> Fruits
        {
            get { return _fruit; }
            set { _fruit = value; }
        }

        private ObservableCollection<string> _planet;
        public ObservableCollection<string> Planets
        {
            get { return _planet; }
            set { _planet = value; }
        }

        private ObservableCollection<Fruit> _userAddedFruits;
        public ObservableCollection<Fruit> UserAddedFruits
        {
            get { return _userAddedFruits; }
            set { _userAddedFruits = value; }
        }

        private ObservableCollection<Planet> _userAddedPlanets;
        public ObservableCollection<Planet> UserAddedPlanets
        {
            get { return _userAddedPlanets; }
            set { _userAddedPlanets = value; }
        }

        private string _fruitsSelectedItem;
        public string FruitsSelectedItem
        {
            get { return _fruitsSelectedItem; }
            set
            {
                _fruitsSelectedItem = value;
                addRowToFruit(value);
                updateRows();
            }
        }

        private string _planetsSelectedItem;
        public string PlanetsSelectedItem
        {
            get { return _planetsSelectedItem; }
            set
            {
                _planetsSelectedItem = value;
                addRowToPlanet(value);
                updateRows();
            }
        }

        //Gets selcted grid 1 row for deletion
        private Fruit _selectedGridOneItem;
        public Fruit SelectedGridOneItem
        {
            get { return _selectedGridOneItem; }
            set
            {
                _selectedGridOneItem = value;
            }
        }
        //Gets selcted grid 2 row for deletion
        private Planet _selectedGridTwoItem;
        public Planet SelectedGridTwoItem
        {
            get { return _selectedGridTwoItem; }
            set
            {
                _selectedGridTwoItem = value;
            }
        }

        private ObservableCollection<PlanetAndFruit> _returnedData;
        public ObservableCollection<PlanetAndFruit> ReturnedData
        {
            get { return _returnedData; }
            set { _returnedData = value; }
        }

        private void addRowToFruit(string value)
        {
            if (value != null)
            {
                try
                {
                    DataAccess db = new DataAccess();
                    string[] rowToAdd = value.Split(' ');
                    db.InsertFruit(rowToAdd[0].ToString(), rowToAdd[1]);
                }
                catch (Exception e)
                {
                    Console.Write("Oh no, Exception!" + e.Message);
                }
            }
        }
        private void addRowToPlanet(string value)
        {
            if (value != null)
            {
                try
                {
                    DataAccess db = new DataAccess();
                    string[] rowToAdd = value.Split(' ');
                    db.InsertPlanet(rowToAdd[0], rowToAdd[1]);
                }
                catch (Exception e)
                {
                    Console.Write("Oh no, Exception!" + e.Message);
                }
            }
        }


        private void ExecuteProjectCommand()
        {
            ReturnedData.Clear();
            DataAccess db = new DataAccess();
            PlanetAndFruit itemToAdd;

            foreach (var item in db.GetAllFruitsOverID())
            {
                itemToAdd = new PlanetAndFruit();
                itemToAdd.Name = item.Name;
                ReturnedData.Add(itemToAdd);
            }

        }
        private void ExecuteFilterCommand()
        {
            ReturnedData.Clear();
            DataAccess db = new DataAccess();
            PlanetAndFruit itemToAdd;
            if (FruitsSelectedItem != null)
            {
                try
                {
                    //Filter based on current color
                    string filer = FruitsSelectedItem.Split(' ')[1];
                    foreach (var item in db.GetAllFruitsWithColor(filer))
                    {
                        itemToAdd = new PlanetAndFruit();
                        itemToAdd.Name = item.Name;
                        ReturnedData.Add(itemToAdd);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("You Must Select A Color First!");
                }
            }
            else
            {
                MessageBox.Show("You Must Select A Color First!");
            }

        }
        private void ExecuteORderASCCommand()
        {
            ReturnedData.Clear();
            DataAccess db = new DataAccess();
            PlanetAndFruit itemToAdd;

            foreach (var item in db.GetAllFruitsASC())
            {
                itemToAdd = new PlanetAndFruit();
                itemToAdd.Name = item.Name;
                ReturnedData.Add(itemToAdd);
            }
        }
        private void ExecuteJoinCommand()
        {
            ReturnedData.Clear();
            DataAccess db = new DataAccess();
            PlanetAndFruit itemToAdd;

            foreach (var item in db.GetAllJoinByColor())
            {
                itemToAdd = new PlanetAndFruit();
                itemToAdd.Name = item.Name;
                itemToAdd.Name2 = item.Name2;
                ReturnedData.Add(itemToAdd);
            }
        }
        private void ExecuteClearCommand()
        {
            
            Planets = new ObservableCollection<string>();
            DataAccess db = new DataAccess();
            db.ClearAllUserCreatedRows();
            clearDataGrids();
            updateRows();
            FruitsSelectedItem = null;
            PlanetsSelectedItem = null;

            Fruits.Clear();
            Planets.Clear();
            populateComboBoxes();
        }

        public void clearDataGrids()
        {
            UserAddedFruits.Clear();
            UserAddedPlanets.Clear();
        }
        private void ExecuteDeleteRowCommand()
        {
            DataAccess db = new DataAccess();
            if (SelectedGridOneItem != null)
            {
                db.RemoveFriut(SelectedGridOneItem.FruitId);
                clearDataGrids();
                updateRows();
                SelectedGridOneItem = null;
                MessageBox.Show("Row Removed");
            }
            else if (SelectedGridTwoItem != null)
            {
                db.RemovePlanet(SelectedGridTwoItem.PlanetId);
                clearDataGrids();
                updateRows();
                SelectedGridTwoItem = null;
                MessageBox.Show("Row Removed");
            }
        }
        public void updateRows()
        {
            DataAccess db = new DataAccess();
            //Populate Both DataGrids If Any Previously Added Rows Exist
            foreach (var item in db.GetUserAddedFruits())
            {
                bool exists = false;
                foreach(Fruit value in UserAddedFruits)
                {
                    //If it doesnt already exist in datagrid add it otherwise don't
                    if (value.FruitId.Equals(item.FruitId))
                    {
                        exists = true;
                    }
                }
                if (!exists)
                {
                    UserAddedFruits.Add(item);
                }
            }
            foreach (Planet item in db.GetUserAddedPlanets())
            {
                bool exists = false;
                foreach (Planet value in UserAddedPlanets)
                {
                    //If it doesnt already exist in datagrid add it otherwise don't
                    if (value.PlanetId.Equals(item.PlanetId))
                    {
                        exists = true;
                    }
                }
                if (!exists)
                {
                    UserAddedPlanets.Add(item);
                }
            }
        }

        public void populateComboBoxes()
        {
            //Populate Both ComboBoxes
            DataAccess db = new DataAccess();
            foreach (var item in db.GetAllFruits())
            {
                Fruits.Add(item.Name + " " + item.Color);
            }
            foreach (var item in db.GetAllPlanets())
            {
                Planets.Add(item.Name2 + " " + item.Color2);
            }
        }
        public MainWindowViewModel()
        {
            //Button Delegates
            LINQProjectQSCommand = new DelegateCommand(ExecuteProjectCommand);
            LINQFilterCommand = new DelegateCommand(ExecuteFilterCommand);
            LINQOrderASCommand = new DelegateCommand(ExecuteORderASCCommand);
            LINQJoinCommand = new DelegateCommand(ExecuteJoinCommand);
            ClearButtonCommand = new DelegateCommand(ExecuteClearCommand);
            DeleteRowCommand = new DelegateCommand(ExecuteDeleteRowCommand);

            ReturnedData = new ObservableCollection<PlanetAndFruit>();
            UserAddedFruits = new ObservableCollection<Fruit>();
            UserAddedPlanets = new ObservableCollection<Planet>();
            Fruits = new ObservableCollection<string>();
            Planets = new ObservableCollection<string>();

            //Populate Both ComboBoxes
            populateComboBoxes();
            //Populate Both DataGrids If Any Previously Added Rows Exist
            updateRows();

        }
    }
}
