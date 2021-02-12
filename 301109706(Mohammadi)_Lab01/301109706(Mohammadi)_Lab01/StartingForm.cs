using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _301109706_Mohammadi__Lab01
{
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        private void btnManageSubscription_Click(object sender, EventArgs e)
        {
            var subscriptionManagerForm = new ManageSubscriptionForm();
            subscriptionManagerForm.Show();
            subscriptionManagerForm.Close();
        }

        private void btnPublishNotification_Click(object sender, EventArgs e)
        {
            var publishNotificationForm = new PublishNotificationForm();
            publishNotificationForm.Show();
            //publishNotificationForm.Close();
        }
    }
}
