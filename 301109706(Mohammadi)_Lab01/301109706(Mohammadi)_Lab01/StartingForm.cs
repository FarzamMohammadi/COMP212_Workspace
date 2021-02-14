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
        private void FrmNotificationManager_Load(object sender, EventArgs e)
        {

        }
        public void EnablePublishBtn(bool EnablePub)
        {
            this.BtnPublishNotification.Enabled = EnablePub;
        }

        private void BtnManageSubscription_Click_1(object sender, EventArgs e)
        {

            //When button click Manage Subscription Form will pop up.
            var myForm = new ManageSubscriptionForm(this);
            myForm.Show();
        }

        private void BtnPublishNotification_Click_1(object sender, EventArgs e)
        {
            //When button click Publish Notification Form will pop up.
            var myForm = new PublishNotificationForm(this);
            myForm.Show();
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            //Prompt user with message box.
            if (MessageBox.Show("Are you sure you want to close application?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //If yes is selected form will close.
                this.Close();
            }
            else
            {
                //Else if no is selected form will stay open.
                this.Activate();
            }
        }
    }
}
