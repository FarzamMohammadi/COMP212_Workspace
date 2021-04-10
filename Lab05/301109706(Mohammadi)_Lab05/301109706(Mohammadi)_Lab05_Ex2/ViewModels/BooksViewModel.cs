using _301109706_Mohammadi__Lab05_Ex2.Models.Books.db;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301109706_Mohammadi__Lab05_Ex2.ViewModels
{
    class BooksViewModel : BindableBase
    {
        
        private ObservableCollection<Titles> _title;
        public ObservableCollection<Titles> Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private ObservableCollection<Titles> _bookAuthor;
        public ObservableCollection<Titles> BookAuthor
        {
            get { return _bookAuthor; }
            set { _bookAuthor = value; }
        }

        private ObservableCollection<BookList> _bookList;
        public ObservableCollection<BookList> BookList
        {
            get { return _bookList; }
            set { _bookList = value; }
        }

        public List<BookList> getBooksFromDB()
        {
            List<BookList> listToReturn = new List<BookList>();
            BookList objectToReturn = new BookList();
            List<Titles> dbList = new List<Titles>();
            StringBuilder sb = new StringBuilder();
            int numberOfEntries = 0;
            int counter = -1;
            List<string> auhtors = new List<string>();
            List<string> titles = new List<string>();

            string prevTitle = "";
            DataAccess db = new DataAccess();
            dbList = db.GetAllBooks();

            foreach (Titles item in dbList)
            {
                if (item.Title != prevTitle)
                {
                    titles.Add(item.Title);
                    numberOfEntries++;
                }
                prevTitle = item.Title;
            }

            foreach (Titles item in dbList)
            {
                
                if (counter == -1 && item.Title != prevTitle)
                {
                    counter++;
                    prevTitle = item.Title;
                }
                if (item.Title == prevTitle && counter != numberOfEntries - 1)
                {
                    sb.Append(item.FirstName + " " + item.LastName + ", ");
                }
                else if (item.Title != prevTitle || counter != numberOfEntries -1)
                {
                    prevTitle = item.Title;
                    auhtors.Add(sb.ToString());
                    sb = new StringBuilder();
                    counter++;
                    sb.Append(item.FirstName + " " + item.LastName + ", ");
                }

                if (item.Title == prevTitle && counter == numberOfEntries - 1 && item.FirstName != dbList.LastOrDefault().FirstName && item.LastName != dbList.LastOrDefault().LastName)
                {
                    sb.Append(item.FirstName + " " + item.LastName + ", ");
                }
                else if (item.FirstName == dbList.LastOrDefault().FirstName && item.LastName == dbList.LastOrDefault().LastName && counter == numberOfEntries - 1)
                {
                    sb.Append(item.FirstName + " " + item.LastName + ", ");
                    auhtors.Add(sb.ToString());
                }


            }

            for (int i = 0; i < titles.Count; i++)
            {
                string hellpo = dbList.LastOrDefault().FirstName;
                objectToReturn = new BookList();
                objectToReturn.Author = auhtors[i];
                objectToReturn.Title = titles[i];
                listToReturn.Add(objectToReturn);
            }

            return listToReturn;
        }

        public BooksViewModel()
        {

            List<BookList> listOfBooks = new List<BookList>();
            listOfBooks = getBooksFromDB();


            List<BookList> listToAddToGrid = new List<BookList>();
            
            BookList = new ObservableCollection<BookList>();
            
            foreach (BookList book in listOfBooks)
            {
                BookList itemToAddToList = new BookList();
                itemToAddToList.Title = book.Title;
                itemToAddToList.Author = book.Author;
                listToAddToGrid.Add(itemToAddToList);
            }



            foreach (BookList book in listToAddToGrid)
            {
                BookList.Add(book);
            }

        }

    }
}
