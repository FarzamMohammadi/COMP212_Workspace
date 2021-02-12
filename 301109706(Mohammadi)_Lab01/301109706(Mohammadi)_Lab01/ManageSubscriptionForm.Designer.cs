
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
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnUnsubscribe = new System.Windows.Forms.Button();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSubscribe.Location = new System.Drawing.Point(12, 292);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(189, 42);
            this.btnSubscribe.TabIndex = 0;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox1.Location = new System.Drawing.Point(12, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Email Notification To:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnUnsubscribe
            // 
            this.btnUnsubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUnsubscribe.Location = new System.Drawing.Point(319, 292);
            this.btnUnsubscribe.Name = "btnUnsubscribe";
            this.btnUnsubscribe.Size = new System.Drawing.Size(189, 42);
            this.btnUnsubscribe.TabIndex = 3;
            this.btnUnsubscribe.Text = "Unsubscribe";
            this.btnUnsubscribe.UseVisualStyleBackColor = true;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBackToMain.Location = new System.Drawing.Point(615, 292);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(189, 42);
            this.btnBackToMain.TabIndex = 4;
            this.btnBackToMain.Text = "Back to Main Window";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox2.Location = new System.Drawing.Point(12, 172);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(153, 21);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Text Notification To:";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.txtEmail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtEmail.Location = new System.Drawing.Point(265, 34);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmail.Size = new System.Drawing.Size(488, 77);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(265, 170);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPhoneNumber.Size = new System.Drawing.Size(488, 77);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // ManageSubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 366);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.btnUnsubscribe);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSubscribe);
            this.Name = "ManageSubscriptionForm";
            this.Text = "ManageSubscriptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnUnsubscribe;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
    }
}