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
        //List.
        public static List<string> GetPhoneNumberList = new List<string>();

        public string PhoneNumber { get; set; }

        //Constructor.
        public SendViaPhone(string phonenumber)
        {
            PhoneNumber = phonenumber;
        }

        //Send Message.
        private string SendPhoneList()
        {
            return PhoneNumber;
        }

        //Subscribe.
        public void Subscribe(Publisher pub)
        {
            pub.sendPhone += SendPhoneList;
        }

        //Unsubscribe.
        public void UnSubscribe(Publisher pub)
        {
            pub.sendPhone -= SendPhoneList;
        }
    }
}
