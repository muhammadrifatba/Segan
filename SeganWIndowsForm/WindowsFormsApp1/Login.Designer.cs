
namespace WindowsFormsApp1
{
    partial class Login

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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginPasswordlabel = new System.Windows.Forms.Label();
            this.LoginUserLabel = new System.Windows.Forms.Label();
            this.LoginPasstB1 = new System.Windows.Forms.TextBox();
            this.UserLogintB1 = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(116, 92);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(168, 128);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel2.Controls.Add(this.panel1);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(-4, 0);
            this.bunifuGradientPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1093, 640);
            this.bunifuGradientPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.linkLabelLogin);
            this.panel1.Controls.Add(pictureBox1);
            this.panel1.Controls.Add(this.Loginbutton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LoginPasswordlabel);
            this.panel1.Controls.Add(this.LoginUserLabel);
            this.panel1.Controls.Add(this.LoginPasstB1);
            this.panel1.Controls.Add(this.UserLogintB1);
            this.panel1.Location = new System.Drawing.Point(349, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 487);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.Location = new System.Drawing.Point(97, 394);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "NoAccount ?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogin.Location = new System.Drawing.Point(207, 394);
            this.linkLabelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(53, 19);
            this.linkLabelLogin.TabIndex = 9;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "SignUp";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            this.Loginbutton.FlatAppearance.BorderSize = 0;
            this.Loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.Loginbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Loginbutton.Location = new System.Drawing.Point(101, 420);
            this.Loginbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(168, 34);
            this.Loginbutton.TabIndex = 8;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.label4.Location = new System.Drawing.Point(120, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Segan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Welcome to";
            // 
            // LoginPasswordlabel
            // 
            this.LoginPasswordlabel.AutoSize = true;
            this.LoginPasswordlabel.Location = new System.Drawing.Point(51, 315);
            this.LoginPasswordlabel.Name = "LoginPasswordlabel";
            this.LoginPasswordlabel.Size = new System.Drawing.Size(69, 17);
            this.LoginPasswordlabel.TabIndex = 3;
            this.LoginPasswordlabel.Text = "Password";
            // 
            // LoginUserLabel
            // 
            this.LoginUserLabel.AutoSize = true;
            this.LoginUserLabel.Location = new System.Drawing.Point(51, 252);
            this.LoginUserLabel.Name = "LoginUserLabel";
            this.LoginUserLabel.Size = new System.Drawing.Size(73, 17);
            this.LoginUserLabel.TabIndex = 2;
            this.LoginUserLabel.Text = "Username";
            // 
            // LoginPasstB1
            // 
            this.LoginPasstB1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoginPasstB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginPasstB1.Location = new System.Drawing.Point(53, 335);
            this.LoginPasstB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginPasstB1.MinimumSize = new System.Drawing.Size(269, 35);
            this.LoginPasstB1.Name = "LoginPasstB1";
            this.LoginPasstB1.Size = new System.Drawing.Size(269, 30);
            this.LoginPasstB1.TabIndex = 1;
            // 
            // UserLogintB1
            // 
            this.UserLogintB1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserLogintB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserLogintB1.Location = new System.Drawing.Point(53, 272);
            this.UserLogintB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserLogintB1.MinimumSize = new System.Drawing.Size(269, 35);
            this.UserLogintB1.Name = "UserLogintB1";
            this.UserLogintB1.Size = new System.Drawing.Size(269, 30);
            this.UserLogintB1.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 634);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox LoginPasstB1;
        private System.Windows.Forms.TextBox UserLogintB1;
        private System.Windows.Forms.Label LoginPasswordlabel;
        private System.Windows.Forms.Label LoginUserLabel;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
    }
}