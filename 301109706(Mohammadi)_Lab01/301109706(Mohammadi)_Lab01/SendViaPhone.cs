using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301109706_Mohammadi__Lab01
{
    class SendViaPhone
    {
        public string PhoneNumber { get; set; }


        //Constructor.
        public SendViaPhone(string phonenumber)
        {
            PhoneNumber = phonenumber;

        }

        //Send Message.
        private string[] SendMessage(string msg)
        {
            string[] phoneList = new string[PhoneNumber.Length];
            phoneList.Append(PhoneNumber);
            return phoneList;
        }

        //Subscribe.
        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += SendMessage;
        }

        //Unsubscribe.
        public void UnSubscribe(Publisher pub)
        {
            pub.publishmsg -= SendMessage;
        }

        //List.
        public static List<string> GetPhoneNumberList = new List<string>();
    }
}
