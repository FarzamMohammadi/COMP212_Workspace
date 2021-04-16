using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question01
{
    public partial class Form1 : Form
    {
        int[] userInputArray;

        public Form1()
        {
            InitializeComponent();
        }

  
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //if the Radio Button "Int Array" is checked pass through an int[] to Search()
                if (intArrayRadioButton.Checked)
                {
                    userInputArray = userInputTextBox.Text.Split(',').Select(s => Convert.ToInt32(s)).ToArray();
                    Search(userInputArray);
                }
                //if the Radio Button "Student Array" is checked pass through a Student[] to Search()
                else if (studentRadioButton.Checked)
                {
                    userInputArray = userInputTextBox.Text.Split(',').Select(s => Convert.ToInt32(s)).ToArray();
                    Student[] students = new Student[userInputArray.Length];
                    for (int i = 0; i < userInputArray.Length; i++)
                    {
                        students[i] = new Student(userInputArray[i]);
                    }
                    Search<Student>(students);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Search<T>(T[] userInputArray) where T : IComparable<T>
        {

            int searchKey = 301109706;
            int indexValueOfKey = -1;
            Student[] passedStudentArray = new Student[userInputArray.Length];

            //If the type of passed array is the same as the Student class Search through according to a Student[]
            if (passedStudentArray.GetType().Equals(userInputArray.GetType()))
            {
                for (int i = 0; i < passedStudentArray.Length; i++)
                {
                    passedStudentArray[i] = (Student)(Object)userInputArray[i];
                }
                for (int i = 0; i < passedStudentArray.Length; i++)
                {
                    if (searchKey.CompareTo(passedStudentArray[i].StudentID).Equals(0))
                    {
                        indexValueOfKey = i;
                      
                    }
                }
            }
            //Else if type of passed array is not of class Student then engage Search according to Int[]
            else
            {
                for (int i = 0; i < userInputArray.Length; i++)
                {
                    if (searchKey.CompareTo(userInputArray[i]).Equals(0))
                    {
                        indexValueOfKey = i;
                    }
                }
            }
            reslutTextBox.Text = indexValueOfKey.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void studentRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
