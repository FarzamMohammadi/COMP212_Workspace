
namespace _301109706_Mohammadi__Lab01
{
    partial class ManageSubscriptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSubscribe = new System.Windows.Forms.Button();
            this.CbxEmail = new System.Windows.Forms.CheckBox();
            this.BtnUnSubscribe = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CbxPhone = new System.Windows.Forms.CheckBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtSms = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSubscribe
            // 
            this.BtnSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnSubscribe.Location = new System.Drawing.Point(12, 292);
            this.BtnSubscribe.Name = "BtnSubscribe";
            this.BtnSubscribe.Size = new System.Drawing.Size(189, 42);
            this.BtnSubscribe.TabIndex = 0;
            this.BtnSubscribe.Text = "Subscribe";
            this.BtnSubscribe.UseVisualStyleBackColor = true;
            this.BtnSubscribe.Click += new System.EventHandler(this.BtnSubscribe_Click);
            // 
            // CbxEmail
            // 
            this.CbxEmail.AutoSize = true;
            this.CbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CbxEmail.Location = new System.Drawing.Point(12, 36);
            this.CbxEmail.Name = "CbxEmail";
            this.CbxEmail.Size = new System.Drawing.Size(160, 21);
            this.CbxEmail.TabIndex = 2;
            this.CbxEmail.Text = "Email Notification To:";
            this.CbxEmail.UseVisualStyleBackColor = true;
            // 
            // BtnUnSubscribe
            // 
            this.BtnUnSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnUnSubscribe.Location = new System.Drawing.Point(319, 292);
            this.BtnUnSubscribe.Name = "BtnUnSubscribe";
            this.BtnUnSubscribe.Size = new System.Drawing.Size(189, 42);
            this.BtnUnSubscribe.TabIndex = 3;
            this.BtnUnSubscribe.Text = "Unsubscribe";
            this.BtnUnSubscribe.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnCancel.Location = new System.Drawing.Point(615, 292);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(189, 42);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Back to Main Window";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click_1);
            // 
            // CbxPhone
            // 
            this.CbxPhone.AutoSize = true;
            this.CbxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CbxPhone.Location = new System.Drawing.Point(12, 172);
            this.CbxPhone.Name = "CbxPhone";
            this.CbxPhone.Size = new System.Drawing.Size(153, 21);
            this.CbxPhone.TabIndex = 5;
            this.CbxPhone.Text = "Text Notification To:";
            this.CbxPhone.UseVisualStyleBackColor = true;
            // 
            // TxtEmail
            // 
            this.TxtEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.TxtEmail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TxtEmail.Location = new System.Drawing.Point(265, 36);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtEmail.Size = new System.Drawing.Size(488, 20);
            this.TxtEmail.TabIndex = 7;
            this.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtSms
            // 
            this.TxtSms.Location = new System.Drawing.Point(265, 170);
            this.TxtSms.Name = "TxtSms";
            this.TxtSms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSms.Size = new System.Drawing.Size(488, 20);
            this.TxtSms.TabIndex = 8;
            // 
            // ManageSubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 366);
            this.Controls.Add(this.TxtSms);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.CbxPhone);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnUnSubscribe);
            this.Controls.Add(this.CbxEmail);
            this.Controls.Add(this.BtnSubscribe);
            this.Name = "ManageSubscriptionForm";
            this.Text = "ManageSubscriptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSubscribe;
        private System.Windows.Forms.CheckBox CbxEmail;
        private System.Windows.Forms.Button BtnUnSubscribe;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.CheckBox CbxPhone;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtSms;
      
    }
}