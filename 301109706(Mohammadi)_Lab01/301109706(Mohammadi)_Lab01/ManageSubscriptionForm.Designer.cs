
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSubscribe
            // 
            this.BtnSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnSubscribe.Location = new System.Drawing.Point(12, 180);
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
            this.BtnUnSubscribe.Location = new System.Drawing.Point(290, 180);
            this.BtnUnSubscribe.Name = "BtnUnSubscribe";
            this.BtnUnSubscribe.Size = new System.Drawing.Size(189, 42);
            this.BtnUnSubscribe.TabIndex = 3;
            this.BtnUnSubscribe.Text = "Unsubscribe";
            this.BtnUnSubscribe.UseVisualStyleBackColor = true;
            this.BtnUnSubscribe.Click += new System.EventHandler(this.BtnUnSubscribe_Click_1);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnCancel.Location = new System.Drawing.Point(564, 180);
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
            this.CbxPhone.Location = new System.Drawing.Point(12, 76);
            this.CbxPhone.Name = "CbxPhone";
            this.CbxPhone.Size = new System.Drawing.Size(153, 21);
            this.CbxPhone.TabIndex = 5;
            this.CbxPhone.Text = "Text Notification To:";
            this.CbxPhone.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtEmail.Location = new System.Drawing.Point(265, 36);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.Size = new System.Drawing.Size(488, 20);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged_1);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(265, 76);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(488, 20);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please make sure that your -Email- and -Phone- entries are in correct format.";
            // 
            // ManageSubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
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
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
    }
}