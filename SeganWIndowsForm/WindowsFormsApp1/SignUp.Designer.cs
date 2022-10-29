
namespace WindowsFormsApp1
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SignUpbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SignUpPasswordlabel = new System.Windows.Forms.Label();
            this.SignUpUserLabel = new System.Windows.Forms.Label();
            this.SignUpPasstB1 = new System.Windows.Forms.TextBox();
            this.UserSignUptB1 = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(-3, 0);
            this.bunifuGradientPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(820, 520);
            this.bunifuGradientPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.SignUpbutton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SignUpPasswordlabel);
            this.panel1.Controls.Add(this.SignUpUserLabel);
            this.panel1.Controls.Add(this.SignUpPasstB1);
            this.panel1.Controls.Add(this.UserSignUptB1);
            this.panel1.Location = new System.Drawing.Point(262, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 396);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(86, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SignUpbutton
            // 
            this.SignUpbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            this.SignUpbutton.FlatAppearance.BorderSize = 0;
            this.SignUpbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.SignUpbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignUpbutton.Location = new System.Drawing.Point(77, 341);
            this.SignUpbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignUpbutton.Name = "SignUpbutton";
            this.SignUpbutton.Size = new System.Drawing.Size(125, 28);
            this.SignUpbutton.TabIndex = 8;
            this.SignUpbutton.Text = "Sign Up";
            this.SignUpbutton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sign Up";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.label4.Location = new System.Drawing.Point(90, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Segan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Welcome to";
            // 
            // SignUpPasswordlabel
            // 
            this.SignUpPasswordlabel.AutoSize = true;
            this.SignUpPasswordlabel.Location = new System.Drawing.Point(42, 275);
            this.SignUpPasswordlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignUpPasswordlabel.Name = "SignUpPasswordlabel";
            this.SignUpPasswordlabel.Size = new System.Drawing.Size(53, 13);
            this.SignUpPasswordlabel.TabIndex = 3;
            this.SignUpPasswordlabel.Text = "Password";
            // 
            // SignUpUserLabel
            // 
            this.SignUpUserLabel.AutoSize = true;
            this.SignUpUserLabel.Location = new System.Drawing.Point(42, 224);
            this.SignUpUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignUpUserLabel.Name = "SignUpUserLabel";
            this.SignUpUserLabel.Size = new System.Drawing.Size(55, 13);
            this.SignUpUserLabel.TabIndex = 2;
            this.SignUpUserLabel.Text = "Username";
            // 
            // SignUpPasstB1
            // 
            this.SignUpPasstB1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SignUpPasstB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SignUpPasstB1.Location = new System.Drawing.Point(44, 291);
            this.SignUpPasstB1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignUpPasstB1.MinimumSize = new System.Drawing.Size(203, 35);
            this.SignUpPasstB1.Name = "SignUpPasstB1";
            this.SignUpPasstB1.Size = new System.Drawing.Size(203, 35);
            this.SignUpPasstB1.TabIndex = 1;
            // 
            // UserSignUptB1
            // 
            this.UserSignUptB1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserSignUptB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserSignUptB1.Location = new System.Drawing.Point(44, 240);
            this.UserSignUptB1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserSignUptB1.MinimumSize = new System.Drawing.Size(203, 35);
            this.UserSignUptB1.Name = "UserSignUptB1";
            this.UserSignUptB1.Size = new System.Drawing.Size(203, 35);
            this.UserSignUptB1.TabIndex = 0;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 515);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignUp";
            this.Text = "Login";
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SignUpPasstB1;
        private System.Windows.Forms.TextBox UserSignUptB1;
        private System.Windows.Forms.Label SignUpPasswordlabel;
        private System.Windows.Forms.Label SignUpUserLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SignUpbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}