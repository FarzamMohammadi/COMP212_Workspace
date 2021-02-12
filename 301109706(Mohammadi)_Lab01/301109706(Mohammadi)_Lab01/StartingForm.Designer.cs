
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnManageSubscription = new System.Windows.Forms.Button();
            this.btnPublishNotification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(547, 98);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(220, 71);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnManageSubscription
            // 
            this.btnManageSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnManageSubscription.Location = new System.Drawing.Point(31, 98);
            this.btnManageSubscription.Name = "btnManageSubscription";
            this.btnManageSubscription.Size = new System.Drawing.Size(220, 71);
            this.btnManageSubscription.TabIndex = 1;
            this.btnManageSubscription.Text = "Manage Subscription";
            this.btnManageSubscription.UseVisualStyleBackColor = true;
            this.btnManageSubscription.Click += new System.EventHandler(this.btnManageSubscription_Click);
            // 
            // btnPublishNotification
            // 
            this.btnPublishNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPublishNotification.Location = new System.Drawing.Point(290, 98);
            this.btnPublishNotification.Name = "btnPublishNotification";
            this.btnPublishNotification.Size = new System.Drawing.Size(220, 71);
            this.btnPublishNotification.TabIndex = 2;
            this.btnPublishNotification.Text = "Publish Notification";
            this.btnPublishNotification.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnPublishNotification.UseVisualStyleBackColor = true;
            this.btnPublishNotification.Click += new System.EventHandler(this.btnPublishNotification_Click);
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 236);
            this.Controls.Add(this.btnPublishNotification);
            this.Controls.Add(this.btnManageSubscription);
            this.Controls.Add(this.btnExit);
            this.Name = "StartingForm";
            this.Text = "Notification Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnManageSubscription;
        private System.Windows.Forms.Button btnPublishNotification;
    }
}

