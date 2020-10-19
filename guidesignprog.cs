namespace MySecondGUIAPP
{
    partial class Home_Screen
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
            this.user_Name_TextBox = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.user_Name_label = new System.Windows.Forms.Label();
            this.password_Label = new System.Windows.Forms.Label();
            this.passwd_TextBox = new System.Windows.Forms.TextBox();
            this.login_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_Name_TextBox
            // 
            this.user_Name_TextBox.Location = new System.Drawing.Point(372, 87);
            this.user_Name_TextBox.Name = "user_Name_TextBox";
            this.user_Name_TextBox.Size = new System.Drawing.Size(131, 20);
            this.user_Name_TextBox.TabIndex = 0;
            // 
            // login_label
            // 
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.Location = new System.Drawing.Point(295, 22);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(188, 45);
            this.login_label.TabIndex = 1;
            this.login_label.Text = "Log In";
            this.login_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_Name_label
            // 
            this.user_Name_label.AutoSize = true;
            this.user_Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_Name_label.Location = new System.Drawing.Point(241, 87);
            this.user_Name_label.Name = "user_Name_label";
            this.user_Name_label.Size = new System.Drawing.Size(110, 25);
            this.user_Name_label.TabIndex = 2;
            this.user_Name_label.Text = "User Name";
            // 
            // password_Label
            // 
            this.password_Label.AutoSize = true;
            this.password_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_Label.Location = new System.Drawing.Point(241, 137);
            this.password_Label.Name = "password_Label";
            this.password_Label.Size = new System.Drawing.Size(98, 25);
            this.password_Label.TabIndex = 4;
            this.password_Label.Text = "Password";
            // 
            // passwd_TextBox
            // 
            this.passwd_TextBox.Location = new System.Drawing.Point(372, 137);
            this.passwd_TextBox.Name = "passwd_TextBox";
            this.passwd_TextBox.PasswordChar = '*';
            this.passwd_TextBox.Size = new System.Drawing.Size(131, 20);
            this.passwd_TextBox.TabIndex = 3;
            // 
            // login_Button
            // 
            this.login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Button.Location = new System.Drawing.Point(339, 178);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(75, 34);
            this.login_Button.TabIndex = 5;
            this.login_Button.Text = "Login";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // Home_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.password_Label);
            this.Controls.Add(this.passwd_TextBox);
            this.Controls.Add(this.user_Name_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.user_Name_TextBox);
            this.Name = "Home_Screen";
            this.Text = "Home Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_Name_TextBox;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label user_Name_label;
        private System.Windows.Forms.Label password_Label;
        private System.Windows.Forms.TextBox passwd_TextBox;
        private System.Windows.Forms.Button login_Button;
    }
}

