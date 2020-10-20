namespace practiceGUIapp
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
            this.loginbutton = new System.Windows.Forms.Button();
            this.userlabel = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.usertextBox = new System.Windows.Forms.TextBox();
            this.passtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(370, 267);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(95, 43);
            this.loginbutton.TabIndex = 0;
            this.loginbutton.Text = "login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Location = new System.Drawing.Point(294, 98);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(53, 13);
            this.userlabel.TabIndex = 3;
            this.userlabel.Text = "username";
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Location = new System.Drawing.Point(295, 155);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(52, 13);
            this.passlabel.TabIndex = 4;
            this.passlabel.Text = "password";
            // 
            // usertextBox
            // 
            this.usertextBox.Location = new System.Drawing.Point(448, 91);
            this.usertextBox.Name = "usertextBox";
            this.usertextBox.Size = new System.Drawing.Size(173, 20);
            this.usertextBox.TabIndex = 5;
            // 
            // passtextBox
            // 
            this.passtextBox.Location = new System.Drawing.Point(448, 164);
            this.passtextBox.Name = "passtextBox";
            this.passtextBox.Size = new System.Drawing.Size(173, 20);
            this.passtextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passtextBox);
            this.Controls.Add(this.usertextBox);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.userlabel);
            this.Controls.Add(this.loginbutton);
            this.Name = "Form1";
            this.Text = "LOGIN FORM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.TextBox usertextBox;
        private System.Windows.Forms.TextBox passtextBox;
    }
}

