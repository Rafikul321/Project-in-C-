namespace SoftEngSiteBuild
{
    partial class Register
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
            this.LabelAge = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.TableName = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.RegisterUser = new System.Windows.Forms.Button();
            this.GobackToLogInPage = new System.Windows.Forms.Button();
            this.TableAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.Location = new System.Drawing.Point(267, 211);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(44, 20);
            this.LabelAge.TabIndex = 9;
            this.LabelAge.Text = "DOB";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(267, 169);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(51, 20);
            this.LabelName.TabIndex = 7;
            this.LabelName.Text = "Name";
            // 
            // TableName
            // 
            this.TableName.Location = new System.Drawing.Point(448, 163);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(218, 26);
            this.TableName.TabIndex = 6;
            this.TableName.TextChanged += new System.EventHandler(this.TableName_TextChanged);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(448, 267);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(220, 26);
            this.Username.TabIndex = 10;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(448, 324);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(220, 26);
            this.Password.TabIndex = 11;
            // 
            // RegisterUser
            // 
            this.RegisterUser.Location = new System.Drawing.Point(449, 479);
            this.RegisterUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegisterUser.Name = "RegisterUser";
            this.RegisterUser.Size = new System.Drawing.Size(219, 40);
            this.RegisterUser.TabIndex = 12;
            this.RegisterUser.Text = "RegisterYourAccount";
            this.RegisterUser.UseVisualStyleBackColor = true;
            this.RegisterUser.Click += new System.EventHandler(this.RegisterUser_Click);
            // 
            // GobackToLogInPage
            // 
            this.GobackToLogInPage.Location = new System.Drawing.Point(455, 577);
            this.GobackToLogInPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GobackToLogInPage.Name = "GobackToLogInPage";
            this.GobackToLogInPage.Size = new System.Drawing.Size(211, 40);
            this.GobackToLogInPage.TabIndex = 13;
            this.GobackToLogInPage.Text = "Go back to log in page";
            this.GobackToLogInPage.UseVisualStyleBackColor = true;
            this.GobackToLogInPage.Click += new System.EventHandler(this.GobackToLogInPage_Click);
            // 
            // TableAge
            // 
            this.TableAge.Location = new System.Drawing.Point(448, 211);
            this.TableAge.Name = "TableAge";
            this.TableAge.Size = new System.Drawing.Size(218, 26);
            this.TableAge.TabIndex = 14;
            this.TableAge.TextChanged += new System.EventHandler(this.TableAge_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password";
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(448, 382);
            this.confirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(220, 26);
            this.confirmPassword.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Confirm Password";
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Location = new System.Drawing.Point(712, 326);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(150, 24);
            this.showPassword.TabIndex = 19;
            this.showPassword.Text = "Show Password?";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(514, 416);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(88, 29);
            this.ClearButton.TabIndex = 20;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableAge);
            this.Controls.Add(this.GobackToLogInPage);
            this.Controls.Add(this.RegisterUser);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.LabelAge);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TableName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TableName;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button RegisterUser;
        private System.Windows.Forms.Button GobackToLogInPage;
        private System.Windows.Forms.TextBox TableAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.Button ClearButton;
    }
}