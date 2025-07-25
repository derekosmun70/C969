namespace C969_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userName = new TextBox();
            passWord = new TextBox();
            loginButton = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // userName
            // 
            userName.Location = new Point(116, 114);
            userName.Name = "userName";
            userName.PlaceholderText = "Username";
            userName.Size = new Size(213, 23);
            userName.TabIndex = 1;
            // 
            // passWord
            // 
            passWord.Location = new Point(116, 167);
            passWord.Name = "passWord";
            passWord.PlaceholderText = "Password";
            passWord.Size = new Size(213, 23);
            passWord.TabIndex = 2;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(180, 238);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 3;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(169, 11);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 97);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 294);
            Controls.Add(listView1);
            Controls.Add(loginButton);
            Controls.Add(passWord);
            Controls.Add(userName);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userName;
        private TextBox passWord;
        private Button loginButton;
        private ListView listView1;
    }
}
