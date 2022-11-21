
namespace WindowsFormsApp1
{
    partial class AddJadwalObat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddJadwalObat));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.cbObat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.submitDrugAct = new System.Windows.Forms.Button();
            this.deleteDrugAct = new System.Windows.Forms.Button();
            this.updateDrugAct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTanggal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDosis = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.cbObat);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.tbInterval);
            this.bunifuGradientPanel1.Controls.Add(this.submitDrugAct);
            this.bunifuGradientPanel1.Controls.Add(this.deleteDrugAct);
            this.bunifuGradientPanel1.Controls.Add(this.updateDrugAct);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.tbTanggal);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.tbDosis);
            this.bunifuGradientPanel1.Controls.Add(this.tbName);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(1, 1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(506, 616);
            this.bunifuGradientPanel1.TabIndex = 99999;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // cbObat
            // 
            this.cbObat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbObat.FormattingEnabled = true;
            this.cbObat.Location = new System.Drawing.Point(76, 151);
            this.cbObat.Name = "cbObat";
            this.cbObat.Size = new System.Drawing.Size(342, 29);
            this.cbObat.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(73, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Interval";
            // 
            // tbInterval
            // 
            this.tbInterval.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInterval.Location = new System.Drawing.Point(76, 359);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(342, 29);
            this.tbInterval.TabIndex = 20;
            // 
            // submitDrugAct
            // 
            this.submitDrugAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.submitDrugAct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitDrugAct.ForeColor = System.Drawing.Color.White;
            this.submitDrugAct.Location = new System.Drawing.Point(122, 495);
            this.submitDrugAct.Name = "submitDrugAct";
            this.submitDrugAct.Size = new System.Drawing.Size(237, 36);
            this.submitDrugAct.TabIndex = 19;
            this.submitDrugAct.Text = "Submit";
            this.submitDrugAct.UseVisualStyleBackColor = false;
            this.submitDrugAct.Click += new System.EventHandler(this.submitDrugAct_Click);
            // 
            // deleteDrugAct
            // 
            this.deleteDrugAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.deleteDrugAct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDrugAct.ForeColor = System.Drawing.Color.White;
            this.deleteDrugAct.Location = new System.Drawing.Point(252, 440);
            this.deleteDrugAct.Name = "deleteDrugAct";
            this.deleteDrugAct.Size = new System.Drawing.Size(166, 36);
            this.deleteDrugAct.TabIndex = 18;
            this.deleteDrugAct.Text = "Delete";
            this.deleteDrugAct.UseVisualStyleBackColor = false;
            this.deleteDrugAct.Click += new System.EventHandler(this.deleteDrugAct_Click);
            // 
            // updateDrugAct
            // 
            this.updateDrugAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.updateDrugAct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDrugAct.ForeColor = System.Drawing.Color.White;
            this.updateDrugAct.Location = new System.Drawing.Point(76, 440);
            this.updateDrugAct.Name = "updateDrugAct";
            this.updateDrugAct.Size = new System.Drawing.Size(161, 36);
            this.updateDrugAct.TabIndex = 17;
            this.updateDrugAct.Text = "Update";
            this.updateDrugAct.UseVisualStyleBackColor = false;
            this.updateDrugAct.Click += new System.EventHandler(this.updateDrugAct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(73, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Dikonsumsi tanggal";
            // 
            // tbTanggal
            // 
            this.tbTanggal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTanggal.Location = new System.Drawing.Point(76, 289);
            this.tbTanggal.Name = "tbTanggal";
            this.tbTanggal.Size = new System.Drawing.Size(342, 29);
            this.tbTanggal.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(73, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dosis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(73, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Obat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(73, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Schedule Name";
            // 
            // tbDosis
            // 
            this.tbDosis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDosis.Location = new System.Drawing.Point(76, 216);
            this.tbDosis.Name = "tbDosis";
            this.tbDosis.Size = new System.Drawing.Size(342, 29);
            this.tbDosis.TabIndex = 10;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(76, 82);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(342, 29);
            this.tbName.TabIndex = 9;
            // 
            // AddJadwalObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 615);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "AddJadwalObat";
            this.Text = "AddJadwalObat";
            this.Load += new System.EventHandler(this.AddJadwalObat_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Button updateDrugAct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTanggal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDosis;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button submitDrugAct;
        private System.Windows.Forms.Button deleteDrugAct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.ComboBox cbObat;
    }
}