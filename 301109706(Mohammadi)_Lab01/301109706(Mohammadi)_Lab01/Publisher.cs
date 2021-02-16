using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301109706_Mohammadi__Lab01
{
    class Publisher
    {
        //Declare Delegate
        public delegate string GetRecieversList();

        //Declare an instance variable which is a Delegate object 
        public GetRecieversList sendEmail = null;
        public GetRecieversList sendPhone = null;

        //Method used to Invoke Delegate
        public List<string> ReturnRecieversList()
        {
            //Instanciate array of delegates
            Delegate[] emailList;
            Delegate[] phonelList;
            //Create lists to hold the phone numbers and emails
            List<string> emailListToReturn = new List<string>();
            List<string> phoneListToReturn = new List<string>();

            //If email addresses exist adds them to list
            if (sendEmail != null)
            {
                emailList = sendEmail.GetInvocationList();
                foreach (var element in emailList)
                {
                    emailListToReturn.Add(element.DynamicInvoke().ToString());
                }
            }

            //if phone numbers exist adds them to list
            if (sendPhone != null)
            {
                phonelList = sendPhone.GetInvocationList();
                foreach (var element in phonelList)
                {
                    phoneListToReturn.Add(element.DynamicInvoke().ToString());
                }
            }
            //joins boths lists before returning
            foreach(string element in phoneListToReturn)
            {
                emailListToReturn.Add(element);
            }
            return emailListToReturn;
        }
    }
}
