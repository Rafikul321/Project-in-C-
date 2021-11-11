
namespace APPLICATION
{
    partial class Main
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
            this.btBacktoLogin = new System.Windows.Forms.Button();
            this.lb4 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.checkbxShowPassword = new System.Windows.Forms.CheckBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBacktoLogin
            // 
            this.btBacktoLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btBacktoLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btBacktoLogin.Location = new System.Drawing.Point(777, 902);
            this.btBacktoLogin.Name = "btBacktoLogin";
            this.btBacktoLogin.Size = new System.Drawing.Size(272, 46);
            this.btBacktoLogin.TabIndex = 23;
            this.btBacktoLogin.Text = "Back to Login";
            this.btBacktoLogin.UseVisualStyleBackColor = false;
            this.btBacktoLogin.Click += new System.EventHandler(this.btBacktoLogin_Click);
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(777, 867);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(293, 32);
            this.lb4.TabIndex = 22;
            this.lb4.Text = "Already Have an Account?";
            this.lb4.Click += new System.EventHandler(this.lb4_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.White;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btClear.Location = new System.Drawing.Point(682, 786);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(460, 61);
            this.btClear.TabIndex = 21;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.Lime;
            this.btRegister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btRegister.ForeColor = System.Drawing.Color.Blue;
            this.btRegister.Location = new System.Drawing.Point(682, 696);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(460, 61);
            this.btRegister.TabIndex = 20;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // checkbxShowPassword
            // 
            this.checkbxShowPassword.AutoSize = true;
            this.checkbxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbxShowPassword.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkbxShowPassword.ForeColor = System.Drawing.Color.Blue;
            this.checkbxShowPassword.Location = new System.Drawing.Point(871, 617);
            this.checkbxShowPassword.Name = "checkbxShowPassword";
            this.checkbxShowPassword.Size = new System.Drawing.Size(271, 49);
            this.checkbxShowPassword.TabIndex = 19;
            this.checkbxShowPassword.Text = "Show Password";
            this.checkbxShowPassword.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(682, 552);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(460, 59);
            this.txtConfirmPassword.TabIndex = 18;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Nirmala UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb3.ForeColor = System.Drawing.Color.Black;
            this.lb3.Location = new System.Drawing.Point(682, 490);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(364, 59);
            this.lb3.TabIndex = 17;
            this.lb3.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(682, 398);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(461, 60);
            this.txtPassword.TabIndex = 16;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Nirmala UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.ForeColor = System.Drawing.Color.Black;
            this.lbPassword.Location = new System.Drawing.Point(685, 336);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(201, 59);
            this.lbPassword.TabIndex = 15;
            this.lbPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(685, 250);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(461, 54);
            this.txtUsername.TabIndex = 14;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Nirmala UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb2.ForeColor = System.Drawing.Color.Black;
            this.lb2.Location = new System.Drawing.Point(685, 188);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(227, 59);
            this.lb2.TabIndex = 13;
            this.lb2.Text = "Username ";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb1.ForeColor = System.Drawing.Color.Navy;
            this.lb1.Location = new System.Drawing.Point(673, 65);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(376, 86);
            this.lb1.TabIndex = 12;
            this.lb1.Text = "Get Started ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1819, 1012);
            this.Controls.Add(this.btBacktoLogin);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.checkbxShowPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "Main";
            this.Text = "Register_Form";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBacktoLogin;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.CheckBox checkbxShowPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
    }
}