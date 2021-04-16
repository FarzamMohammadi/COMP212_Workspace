
namespace Question01
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.reslutTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.intArrayRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Result:";
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Location = new System.Drawing.Point(25, 60);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(502, 20);
            this.userInputTextBox.TabIndex = 1;
            // 
            // reslutTextBox
            // 
            this.reslutTextBox.Location = new System.Drawing.Point(114, 102);
            this.reslutTextBox.Name = "reslutTextBox";
            this.reslutTextBox.Size = new System.Drawing.Size(211, 20);
            this.reslutTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Your Desired group of elements here. (Separate with a comma)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "-1 = No Results";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search For a Match";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Location = new System.Drawing.Point(484, 107);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(89, 17);
            this.studentRadioButton.TabIndex = 7;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "Student Array";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            this.studentRadioButton.CheckedChanged += new System.EventHandler(this.studentRadioButton_CheckedChanged);
            // 
            // intArrayRadioButton
            // 
            this.intArrayRadioButton.AutoSize = true;
            this.intArrayRadioButton.Location = new System.Drawing.Point(484, 130);
            this.intArrayRadioButton.Name = "intArrayRadioButton";
            this.intArrayRadioButton.Size = new System.Drawing.Size(64, 17);
            this.intArrayRadioButton.TabIndex = 8;
            this.intArrayRadioButton.TabStop = true;
            this.intArrayRadioButton.Text = "Int Array";
            this.intArrayRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Choose your entry:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 202);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.intArrayRadioButton);
            this.Controls.Add(this.studentRadioButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reslutTextBox);
            this.Controls.Add(this.userInputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.TextBox reslutTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton studentRadioButton;
        private System.Windows.Forms.RadioButton intArrayRadioButton;
        private System.Windows.Forms.Label label4;
    }
}

