
namespace _301109706_Mohammadi__Lab01
{
    partial class StartingForm
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnManageSubscription = new System.Windows.Forms.Button();
            this.BtnPublishNotification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnExit.Location = new System.Drawing.Point(547, 98);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(220, 71);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
            // 
            // BtnManageSubscription
            // 
            this.BtnManageSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnManageSubscription.Location = new System.Drawing.Point(31, 98);
            this.BtnManageSubscription.Name = "BtnManageSubscription";
            this.BtnManageSubscription.Size = new System.Drawing.Size(220, 71);
            this.BtnManageSubscription.TabIndex = 1;
            this.BtnManageSubscription.Text = "Manage Subscription";
            this.BtnManageSubscription.UseVisualStyleBackColor = true;
            this.BtnManageSubscription.Click += new System.EventHandler(this.BtnManageSubscription_Click_1);
            // 
            // BtnPublishNotification
            // 
            this.BtnPublishNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPublishNotification.Location = new System.Drawing.Point(290, 98);
            this.BtnPublishNotification.Name = "BtnPublishNotification";
            this.BtnPublishNotification.Size = new System.Drawing.Size(220, 71);
            this.BtnPublishNotification.TabIndex = 2;
            this.BtnPublishNotification.Text = "Publish Notification";
            this.BtnPublishNotification.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnPublishNotification.UseVisualStyleBackColor = true;
            this.BtnPublishNotification.Click += new System.EventHandler(this.BtnPublishNotification_Click_1);
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 236);
            this.Controls.Add(this.BtnPublishNotification);
            this.Controls.Add(this.BtnManageSubscription);
            this.Controls.Add(this.BtnExit);
            this.Name = "StartingForm";
            this.Text = "Notification Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnManageSubscription;
        private System.Windows.Forms.Button BtnPublishNotification;
    }
}

