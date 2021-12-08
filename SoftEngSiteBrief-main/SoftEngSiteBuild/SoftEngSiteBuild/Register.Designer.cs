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
            this.LabelDOB = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.TableName = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.RegisterUser = new System.Windows.Forms.Button();
            this.GobackToLogInPage = new System.Windows.Forms.Button();
            this.TableDOB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelDOB
            // 
            this.LabelDOB.AutoSize = true;
            this.LabelDOB.Location = new System.Drawing.Point(267, 211);
            this.LabelDOB.Name = "LabelDOB";
            this.LabelDOB.Size = new System.Drawing.Size(44, 20);
            this.LabelDOB.TabIndex = 9;
            this.LabelDOB.Text = "DOB";
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
            this.TableName.Location = new System.Drawing.Point(448, 165);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(218, 26);
            this.TableName.TabIndex = 6;
            this.TableName.TextChanged += new System.EventHandler(this.TableName_TextChanged);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(448, 268);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(220, 26);
            this.Username.TabIndex = 10;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(448, 325);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(220, 26);
            this.Password.TabIndex = 11;
            // 
            // RegisterUser
            // 
            this.RegisterUser.Location = new System.Drawing.Point(448, 478);
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
            this.GobackToLogInPage.Location = new System.Drawing.Point(454, 577);
            this.GobackToLogInPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GobackToLogInPage.Name = "GobackToLogInPage";
            this.GobackToLogInPage.Size = new System.Drawing.Size(212, 40);
            this.GobackToLogInPage.TabIndex = 13;
            this.GobackToLogInPage.Text = "Go back to log in page";
            this.GobackToLogInPage.UseVisualStyleBackColor = true;
            this.GobackToLogInPage.Click += new System.EventHandler(this.GobackToLogInPage_Click);
            // 
            // TableDOB
            // 
            this.TableDOB.Location = new System.Drawing.Point(448, 211);
            this.TableDOB.Name = "TableDOB";
            this.TableDOB.Size = new System.Drawing.Size(218, 26);
            this.TableDOB.TabIndex = 14;
            this.TableDOB.TextChanged += new System.EventHandler(this.TableAge_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 329);
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
            this.ClearButton.Location = new System.Drawing.Point(514, 415);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(88, 29);
            this.ClearButton.TabIndex = 20;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(722, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Format:  daymonthyear e.g 081221";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(708, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Password must include a minimum of 7 characters";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 748);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableDOB);
            this.Controls.Add(this.GobackToLogInPage);
            this.Controls.Add(this.RegisterUser);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.LabelDOB);
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

        private System.Windows.Forms.Label LabelDOB;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TableName;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button RegisterUser;
        private System.Windows.Forms.Button GobackToLogInPage;
        private System.Windows.Forms.TextBox TableDOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}