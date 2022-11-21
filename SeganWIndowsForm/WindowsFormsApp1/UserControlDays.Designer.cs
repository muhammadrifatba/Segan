
namespace WindowsFormsApp1
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelday = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelday
            // 
            this.labelday.AutoSize = true;
            this.labelday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelday.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelday.Location = new System.Drawing.Point(17, 17);
            this.labelday.Name = "labelday";
            this.labelday.Size = new System.Drawing.Size(21, 16);
            this.labelday.TabIndex = 0;
            this.labelday.Text = "00";
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelday);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControlDays";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(125, 80);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelday;
    }
}
