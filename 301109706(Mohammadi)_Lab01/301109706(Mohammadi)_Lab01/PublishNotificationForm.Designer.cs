
namespace _301109706_Mohammadi__Lab01
{
    partial class PublishNotificationForm
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
            this.TbxNotiCont = new System.Windows.Forms.TextBox();
            this.txtRecievers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPublish = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbxNotiCont
            // 
            this.TbxNotiCont.Location = new System.Drawing.Point(33, 43);
            this.TbxNotiCont.Multiline = true;
            this.TbxNotiCont.Name = "TbxNotiCont";
            this.TbxNotiCont.Size = new System.Drawing.Size(700, 130);
            this.TbxNotiCont.TabIndex = 0;
            // 
            // txtRecievers
            // 
            this.txtRecievers.Location = new System.Drawing.Point(33, 276);
            this.txtRecievers.Multiline = true;
            this.txtRecievers.Name = "txtRecievers";
            this.txtRecievers.Size = new System.Drawing.Size(700, 162);
            this.txtRecievers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notification Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(30, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Notification has been sent to the following subscribers:";
            // 
            // BtnPublish
            // 
            this.BtnPublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPublish.Location = new System.Drawing.Point(127, 191);
            this.BtnPublish.Name = "BtnPublish";
            this.BtnPublish.Size = new System.Drawing.Size(196, 57);
            this.BtnPublish.TabIndex = 4;
            this.BtnPublish.Text = "Publish";
            this.BtnPublish.UseVisualStyleBackColor = true;
            this.BtnPublish.Click += new System.EventHandler(this.BtnPublish_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnExit.Location = new System.Drawing.Point(431, 191);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(196, 57);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Back to Main Window";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // PublishNotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnPublish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRecievers);
            this.Controls.Add(this.TbxNotiCont);
            this.Name = "PublishNotificationForm";
            this.Text = "PublishNotificationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxNotiCont;
        private System.Windows.Forms.TextBox txtRecievers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPublish;
        private System.Windows.Forms.Button BtnExit;
    }
}