using _301109706_Mohammadi__Lab05_Ex2.Models.Books.db;
using _301109706_Mohammadi__Lab05_Ex2.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace _301109706_Mohammadi__Lab05_Ex2.ViewModels
{
    class AddBookPageViewModel : BindableBase
    {
        //New book user inputs
        private string _newBookISBN;
        public string NewBookISBN
        {
            get { return _newBookISBN; }
            set { SetProperty(ref _newBookISBN, value); }
        }

        private string _newBookPubDate;
        public string NewBookPubDate
        {
            get { return _newBookPubDate; }
            set { SetProperty(ref _newBookPubDate, value); }
        }

        private string _newBookTitle;
        public string NewBookTitle
        {
            get { return _newBookTitle; }
            set { SetProperty(ref _newBookTitle, value); }
        }

        private string _newBookAuthors;
        public string NewBookAuthors
        {
            get { return _newBookAuthors; }
            set { SetProperty(ref _newBookAuthors, value); }
        }

        private string _newBookEdition;
        public string NewBookEdition
        {
            get { return _newBookEdition; }
            set { SetProperty(ref _newBookEdition, value); }
        }

        //Retrieves Button Click
        public ICommand ClearButtonCommand { get; private set; }
        public ICommand CancelButtonCommand { get; private set; }
        public ICommand SubmitButtonCommand { get; private set; }

        public AddBookPageViewModel()
        {
            ClearButtonCommand = new DelegateCommand(ExecuteClearCommand, CanExecute);
            CancelButtonCommand = new DelegateCommand(ExecuteCancelCommand, CanExecute);
            SubmitButtonCommand = new DelegateCommand(ExecuteSubmitCommand, CanExecute);
        }

        private void ExecuteClearCommand()
        {
            NewBookISBN = "";
            NewBookAuthors = "";
            NewBookEdition = "";
            NewBookPubDate = "";
            NewBookTitle = "";
        }
        
        private void ExecuteCancelCommand()
        {
            ExecuteClearCommand();
        }

        private void ExecuteSubmitCommand()
        {
            //Date Format for Databse Submission
             string newCopyRight = NewBookPubDate.Substring(0, 4);

            //Name Formating for Database Submission
            string userInputNames = NewBookAuthors;
            string[] fullNames = userInputNames.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string isbnNumber = NewBookISBN;
            string titleName = NewBookTitle;
            string editionNumber = NewBookEdition;

            DataAccess db = new DataAccess();
            db.submitNewBook(isbnNumber, titleName, int.Parse(editionNumber), newCopyRight, fullNames);
            ExecuteClearCommand();

        }
        private readonly Func<bool> _canExecute;
        private bool CanExecute()
        {
            if (_canExecute == null)
                return true;
            else
                return _canExecute();
        }
    }
}
