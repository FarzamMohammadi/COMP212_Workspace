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
        public delegate string[] PublishMessageDel(string msg);

        //Declare an instance variable which is a Delegate object 
        public PublishMessageDel publishmsg = null;

        //Method used to Invoke Delegate
        public string[] PublishMessage(string message)
        {
            //Invoke Delegate
            return publishmsg.Invoke(message);
        }
    }
}
