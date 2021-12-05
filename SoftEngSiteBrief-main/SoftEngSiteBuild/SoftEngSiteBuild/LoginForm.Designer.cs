
namespace SoftEngSiteBuild
{
    partial class LoginForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(297, 226);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Don\'t have an account? Click here to create one!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBox1.Location = new System.Drawing.Point(160, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 19);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Enter UserName ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBox2.Location = new System.Drawing.Point(160, 110);
            this.textBox2.Margin = new System.Windows.Forms.Padding(1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Enter Password ";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(297, 77);
            this.username.Margin = new System.Windows.Forms.Padding(1);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(207, 20);
            this.username.TabIndex = 4;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(297, 112);
            this.password.Margin = new System.Windows.Forms.Padding(1);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(207, 20);
            this.password.TabIndex = 5;
            // 
            // btClose
            // 
            this.btClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btClose.Location = new System.Drawing.Point(0, 292);
            this.btClose.Margin = new System.Windows.Forms.Padding(1);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(857, 19);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click_1);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(366, 180);
            this.login.Margin = new System.Windows.Forms.Padding(2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(65, 29);
            this.login.TabIndex = 8;
            this.login.Text = "Log In";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.button3_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(459, 146);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 27);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(297, 154);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(59, 19);
            this.ClearButton.TabIndex = 21;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Location = new System.Drawing.Point(523, 115);
            this.showPassword.Margin = new System.Windows.Forms.Padding(2);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(108, 17);
            this.showPassword.TabIndex = 22;
            this.showPassword.Text = "Show Password?";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 311);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.login);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "LoginForm";
            this.Text = "Main_Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.CheckBox showPassword;
    }
}

