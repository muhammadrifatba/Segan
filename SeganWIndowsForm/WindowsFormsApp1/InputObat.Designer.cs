
namespace WindowsFormsApp1
{
    partial class InputObat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputObat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.InputPBtoSched = new System.Windows.Forms.PictureBox();
            this.InputPBtoHome = new System.Windows.Forms.PictureBox();
            this.tbNamaObat = new System.Windows.Forms.TextBox();
            this.tbTipeObat = new System.Windows.Forms.TextBox();
            this.tbDescObat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbImgObat = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.dgvObat = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputPBtoSched)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputPBtoHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1330, 60);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.InputPBtoSched);
            this.panel1.Controls.Add(this.InputPBtoHome);
            this.panel1.Location = new System.Drawing.Point(-1, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 673);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(18, 258);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(18, 600);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // InputPBtoSched
            // 
            this.InputPBtoSched.Image = ((System.Drawing.Image)(resources.GetObject("InputPBtoSched.Image")));
            this.InputPBtoSched.Location = new System.Drawing.Point(18, 168);
            this.InputPBtoSched.Margin = new System.Windows.Forms.Padding(2);
            this.InputPBtoSched.Name = "InputPBtoSched";
            this.InputPBtoSched.Size = new System.Drawing.Size(50, 50);
            this.InputPBtoSched.TabIndex = 1;
            this.InputPBtoSched.TabStop = false;
            this.InputPBtoSched.Click += new System.EventHandler(this.InputPBtoSched_Click);
            // 
            // InputPBtoHome
            // 
            this.InputPBtoHome.Image = ((System.Drawing.Image)(resources.GetObject("InputPBtoHome.Image")));
            this.InputPBtoHome.Location = new System.Drawing.Point(18, 74);
            this.InputPBtoHome.Margin = new System.Windows.Forms.Padding(2);
            this.InputPBtoHome.Name = "InputPBtoHome";
            this.InputPBtoHome.Size = new System.Drawing.Size(50, 50);
            this.InputPBtoHome.TabIndex = 0;
            this.InputPBtoHome.TabStop = false;
            this.InputPBtoHome.Click += new System.EventHandler(this.InputPBtoHome_Click);
            // 
            // tbNamaObat
            // 
            this.tbNamaObat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbNamaObat.Location = new System.Drawing.Point(329, 105);
            this.tbNamaObat.Margin = new System.Windows.Forms.Padding(2);
            this.tbNamaObat.Name = "tbNamaObat";
            this.tbNamaObat.Size = new System.Drawing.Size(242, 32);
            this.tbNamaObat.TabIndex = 14;
            // 
            // tbTipeObat
            // 
            this.tbTipeObat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbTipeObat.Location = new System.Drawing.Point(329, 160);
            this.tbTipeObat.Margin = new System.Windows.Forms.Padding(2);
            this.tbTipeObat.Name = "tbTipeObat";
            this.tbTipeObat.Size = new System.Drawing.Size(242, 32);
            this.tbTipeObat.TabIndex = 15;
            // 
            // tbDescObat
            // 
            this.tbDescObat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbDescObat.Location = new System.Drawing.Point(329, 219);
            this.tbDescObat.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescObat.Name = "tbDescObat";
            this.tbDescObat.Size = new System.Drawing.Size(242, 32);
            this.tbDescObat.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(217, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nama Obat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(708, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Link Gambar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(217, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tipe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(217, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Deskripsi";
            // 
            // tbImgObat
            // 
            this.tbImgObat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbImgObat.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbImgObat.Location = new System.Drawing.Point(881, 106);
            this.tbImgObat.Margin = new System.Windows.Forms.Padding(2);
            this.tbImgObat.Name = "tbImgObat";
            this.tbImgObat.Size = new System.Drawing.Size(242, 32);
            this.tbImgObat.TabIndex = 23;
            this.tbImgObat.Text = "(Optional)";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(716, 294);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 28);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(103)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(881, 294);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 28);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(558, 294);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 28);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.btnInput.FlatAppearance.BorderSize = 0;
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInput.Location = new System.Drawing.Point(392, 294);
            this.btnInput.Margin = new System.Windows.Forms.Padding(2);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(125, 28);
            this.btnInput.TabIndex = 31;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // dgvObat
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvObat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvObat.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvObat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvObat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObat.DoubleBuffered = true;
            this.dgvObat.EnableHeadersVisualStyles = false;
            this.dgvObat.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvObat.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvObat.Location = new System.Drawing.Point(176, 342);
            this.dgvObat.Margin = new System.Windows.Forms.Padding(2);
            this.dgvObat.Name = "dgvObat";
            this.dgvObat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvObat.RowHeadersWidth = 51;
            this.dgvObat.RowTemplate.Height = 24;
            this.dgvObat.Size = new System.Drawing.Size(1069, 345);
            this.dgvObat.TabIndex = 32;
            this.dgvObat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObat_CellContentClick);
            // 
            // InputObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 725);
            this.Controls.Add(this.dgvObat);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbImgObat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescObat);
            this.Controls.Add(this.tbTipeObat);
            this.Controls.Add(this.tbNamaObat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InputObat";
            this.Text = "InputObat";
            this.Load += new System.EventHandler(this.InputObat_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputPBtoSched)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputPBtoHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox InputPBtoSched;
        private System.Windows.Forms.PictureBox InputPBtoHome;
        private System.Windows.Forms.TextBox tbNamaObat;
        private System.Windows.Forms.TextBox tbTipeObat;
        private System.Windows.Forms.TextBox tbDescObat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbImgObat;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInput;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvObat;
        private System.Windows.Forms.Label label7;
    }
}