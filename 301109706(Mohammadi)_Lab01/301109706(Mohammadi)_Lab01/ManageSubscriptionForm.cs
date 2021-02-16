using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _301109706_Mohammadi__Lab01
{
    public partial class ManageSubscriptionForm : Form
    {
        List<SendViaEmail> emailAddressList = new List<SendViaEmail>();

        //Initializing Phone List Collection.
        List<SendViaPhone> phoneNumberList = new List<SendViaPhone>();

        //Declare an instance variable of the Notification Manager Form.
        StartingForm StartingForm;

        public ManageSubscriptionForm(StartingForm parent)
        {
            InitializeComponent();
            //Initializing Notification Manager Form as the parent.
            StartingForm = parent;
        }

        private void BtnSubscribe_Click(object sender, EventArgs e)
        {
            //Linq that check if email already exists.
            var ExistantEmail = emailAddressList.Exists(x => x.EmailAdress == txtEmail.Text);

            //Linq that check if phone already exists.
            var ExistantPhone = phoneNumberList.Exists(x => x.PhoneNumber == txtPhone.Text);

            if (ExistantEmail || ExistantPhone)
            {
                MessageBox.Show("Information already exists.");
            }
            else
            {
                //Add new item to phone or/and email list depending on the user selection.
                if (CbxEmail.Checked && !CbxPhone.Checked == true)
                {
                    SendViaEmail NewEmail = new SendViaEmail(txtEmail.Text);
                    emailAddressList.Add(NewEmail);
                    NewEmail.Subscribe(Program.publisher);

                    MessageBox.Show("Your email address has been added.");
                    txtEmail.Clear();
                    CbxEmail.Checked = false;

                }
                else if (CbxPhone.Checked && !CbxEmail.Checked == true)
                {

                    SendViaPhone NewPhone = new SendViaPhone(txtPhone.Text);
                    phoneNumberList.Add(NewPhone);
                    NewPhone.Subscribe(Program.publisher);

                    MessageBox.Show("Your phone number has been added.");
                    txtPhone.Clear();
                    CbxPhone.Checked = false;

                }
                else if (CbxEmail.Checked && CbxPhone.Checked == true)
                {
                    //Email
                    SendViaEmail NewEmail = new SendViaEmail(txtEmail.Text);
                    emailAddressList.Add(NewEmail);
                    NewEmail.Subscribe(Program.publisher);

                    txtEmail.Clear();
                    CbxEmail.Checked = false;

                    //Phone
                    SendViaPhone NewPhone = new SendViaPhone(txtPhone.Text);
                    phoneNumberList.Add(NewPhone);
                    NewPhone.Subscribe(Program.publisher);

                    txtPhone.Clear();
                    CbxPhone.Checked = false;
                    MessageBox.Show("Both email and phone have been added.");
                }

                //Check list if it is empty or not.
                if (emailAddressList.Count() > 0 || phoneNumberList.Count() > 0)
                {
                    //Enable Publish button.
                    StartingForm.EnablePublishBtn(true);
                }
            }
        }

        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            //Prompt user with message box.
            if (MessageBox.Show("Are you sure you want to close application?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                //Close current form and show PublishNotificationForm form
                this.Close();
            }
            else
            {
                //Else if no is selected form will stay open.
                this.Activate();
            }
        }

        private void BtnUnSubscribe_Click_1(object sender, EventArgs e)
        {
            //Just incase the user email or phone number is not in the list.
            try
            {
                //Remove new item from phone or/and email list depending on the user selection.
                if (CbxEmail.Checked && !CbxPhone.Checked == true)
                {
                    var EmailMatch = emailAddressList.Single(s => s.EmailAdress == txtEmail.Text);
                    emailAddressList.Remove(EmailMatch);
                    EmailMatch.UnSubscribe(Program.publisher);

                    MessageBox.Show("Your email address has been removed.");
                    txtEmail.Clear();
                    CbxEmail.Checked = false;
                    //EprEmail.Clear();
                }
                else if (CbxPhone.Checked && !CbxEmail.Checked == true)
                {
                    var PhoneMatch = phoneNumberList.Single(s => s.PhoneNumber == txtPhone.Text);
                    phoneNumberList.Remove(PhoneMatch);
                    PhoneMatch.UnSubscribe(Program.publisher);


                    MessageBox.Show("Your phone number has been removed.");
                    txtPhone.Clear();
                    CbxPhone.Checked = false;
                    //EprPhone.Clear();
                }
                else if (CbxEmail.Checked && CbxPhone.Checked == true)
                {
                    //Email
                    var EmailMatch = emailAddressList.Single(s => s.EmailAdress == txtEmail.Text);
                    emailAddressList.Remove(EmailMatch);
                    EmailMatch.UnSubscribe(Program.publisher);

                    txtEmail.Clear();
                    CbxEmail.Checked = false;
                    //EprEmail.Clear();

                    //Phone
                    var PhoneMatch = phoneNumberList.Single(s => s.PhoneNumber == txtPhone.Text);
                    phoneNumberList.Remove(PhoneMatch);
                    PhoneMatch.UnSubscribe(Program.publisher);

                    txtPhone.Clear();
                    CbxPhone.Checked = false;
                    //EprPhone.Clear();
 
                    MessageBox.Show("Both email and phone have been removed.");

                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("One or more information already exists.");
            }

            //Check list if it is empty or not.
            if (emailAddressList.Count() == 0 || phoneNumberList.Count() == 0)
            {
                //Enable Publish button.
                StartingForm.EnablePublishBtn(false);
            }

        }

        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {
            //Email Address Validation.
            Regex email = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool EmailValid = email.IsMatch(txtEmail.Text.Trim());

            if (!EmailValid)
            {
                //If invalid disable Subscribe & Unsubscribe button.
                BtnSubscribe.Enabled = false;
                BtnUnSubscribe.Enabled = false;
            }
            else
            {
                //If valid email Subscribe & Unsubscribe button.
                BtnSubscribe.Enabled = true;
                BtnUnSubscribe.Enabled = true;
            }
        }

        private void txtPhone_TextChanged_1(object sender, EventArgs e)
        {
            //Phone Number Validation.
            Regex phone = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
            bool PhoneValid = phone.IsMatch(txtPhone.Text);
            if (!PhoneValid)
            {
                //If invalid disable Subscribe & Unsubscribe button.
                BtnSubscribe.Enabled = false;
                BtnUnSubscribe.Enabled = false;
            }
            else
            {
                //If valid email Subscribe & Unsubscribe button.
                BtnSubscribe.Enabled = true;
                BtnUnSubscribe.Enabled = true;
            }
        }
    }
}
