using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301109706_Mohammadi__Lab01
{
    class SendViaEmail
    {
        public string EmailAdress { get; set; }
        //Constructor.
        public SendViaEmail(string emailadress)
        {
            EmailAdress = emailadress;

        }

        //Send Message.
        public string[] SendEmail(string msg)
        {
            string[] emailList = new string[EmailAdress.Length];
            emailList.Append(EmailAdress);
            return emailList;
        }


        //Subscribe.
        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += SendEmail;
        }



        //Unsubscribe.
        public void UnSubscribe(Publisher pub)
        {
            pub.publishmsg -= SendEmail;
        }


        //List.
        public static List<string> GetEmailAddressList = new List<string>();

    }
}
