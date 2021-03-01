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
        //List.
        public static List<string> GetEmailAddressList = new List<string>();

        //Constructor.
        public SendViaEmail(string emailadress)
        {
            EmailAdress = emailadress;
        }

        //Send Message.
        public string SendEmailList()
        {

            return EmailAdress;
        }

        //Subscribe.
        public void Subscribe(Publisher pub)
        {
            pub.sendEmail += SendEmailList;
        }

        //Unsubscribe.
        public void UnSubscribe(Publisher pub)
        {
            pub.sendEmail -= SendEmailList;
        }
    }
}
