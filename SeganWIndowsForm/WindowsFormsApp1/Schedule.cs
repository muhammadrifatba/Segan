using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private Panel panel1;
        private PictureBox close;
        private PictureBox pictureBox2;
        private PictureBox SchedPBtoHome;
        private Panel panel2;
        private Label label2;
        private MonthCalendar monthCalendar1;
        private Panel panel3;
        private Panel panel4;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox5;
        private Label label1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SchedPBtoInput = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SchedPBtoHome = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Previousbutton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.panel34 = new System.Windows.Forms.Panel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.panel36 = new System.Windows.Forms.Panel();
            this.panel37 = new System.Windows.Forms.Panel();
            this.panel38 = new System.Windows.Forms.Panel();
            this.panel39 = new System.Windows.Forms.Panel();
            this.panel40 = new System.Windows.Forms.Panel();
            this.panel41 = new System.Windows.Forms.Panel();
            this.panel42 = new System.Windows.Forms.Panel();
            this.panel43 = new System.Windows.Forms.Panel();
            this.panel44 = new System.Windows.Forms.Panel();
            this.panel45 = new System.Windows.Forms.Panel();
            this.panel46 = new System.Windows.Forms.Panel();
            this.panel47 = new System.Windows.Forms.Panel();
            this.panel48 = new System.Windows.Forms.Panel();
            this.panel49 = new System.Windows.Forms.Panel();
            this.panel50 = new System.Windows.Forms.Panel();
            this.panel51 = new System.Windows.Forms.Panel();
            this.panel52 = new System.Windows.Forms.Panel();
            this.panel53 = new System.Windows.Forms.Panel();
            this.panel54 = new System.Windows.Forms.Panel();
            this.panel55 = new System.Windows.Forms.Panel();
            this.panel56 = new System.Windows.Forms.Panel();
            this.panel57 = new System.Windows.Forms.Panel();
            this.panel58 = new System.Windows.Forms.Panel();
            this.panel59 = new System.Windows.Forms.Panel();
            this.panel60 = new System.Windows.Forms.Panel();
            this.panel61 = new System.Windows.Forms.Panel();
            this.panel62 = new System.Windows.Forms.Panel();
            this.panel63 = new System.Windows.Forms.Panel();
            this.panel64 = new System.Windows.Forms.Panel();
            this.panel65 = new System.Windows.Forms.Panel();
            this.panel66 = new System.Windows.Forms.Panel();
            this.panel67 = new System.Windows.Forms.Panel();
            this.panel68 = new System.Windows.Forms.Panel();
            this.panel69 = new System.Windows.Forms.Panel();
            this.panel70 = new System.Windows.Forms.Panel();
            this.panel71 = new System.Windows.Forms.Panel();
            this.panel72 = new System.Windows.Forms.Panel();
            this.panel73 = new System.Windows.Forms.Panel();
            this.panel74 = new System.Windows.Forms.Panel();
            this.panel75 = new System.Windows.Forms.Panel();
            this.panel76 = new System.Windows.Forms.Panel();
            this.panel77 = new System.Windows.Forms.Panel();
            this.panel78 = new System.Windows.Forms.Panel();
            this.panel79 = new System.Windows.Forms.Panel();
            this.panel80 = new System.Windows.Forms.Panel();
            this.panel81 = new System.Windows.Forms.Panel();
            this.panel82 = new System.Windows.Forms.Panel();
            this.panel83 = new System.Windows.Forms.Panel();
            this.panel84 = new System.Windows.Forms.Panel();
            this.panel85 = new System.Windows.Forms.Panel();
            this.panel86 = new System.Windows.Forms.Panel();
            this.panel87 = new System.Windows.Forms.Panel();
            this.panel88 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SchedPBtoInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchedPBtoHome)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel31.SuspendLayout();
            this.panel33.SuspendLayout();
            this.panel35.SuspendLayout();
            this.panel37.SuspendLayout();
            this.panel39.SuspendLayout();
            this.panel41.SuspendLayout();
            this.panel43.SuspendLayout();
            this.panel45.SuspendLayout();
            this.panel47.SuspendLayout();
            this.panel49.SuspendLayout();
            this.panel51.SuspendLayout();
            this.panel53.SuspendLayout();
            this.panel55.SuspendLayout();
            this.panel57.SuspendLayout();
            this.panel59.SuspendLayout();
            this.panel61.SuspendLayout();
            this.panel63.SuspendLayout();
            this.panel65.SuspendLayout();
            this.panel67.SuspendLayout();
            this.panel69.SuspendLayout();
            this.panel71.SuspendLayout();
            this.panel73.SuspendLayout();
            this.panel75.SuspendLayout();
            this.panel77.SuspendLayout();
            this.panel79.SuspendLayout();
            this.panel81.SuspendLayout();
            this.panel83.SuspendLayout();
            this.panel85.SuspendLayout();
            this.panel87.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.panel1.Controls.Add(this.SchedPBtoInput);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.SchedPBtoHome);
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 673);
            this.panel1.TabIndex = 0;
            // 
            // SchedPBtoInput
            // 
            this.SchedPBtoInput.Image = ((System.Drawing.Image)(resources.GetObject("SchedPBtoInput.Image")));
            this.SchedPBtoInput.Location = new System.Drawing.Point(18, 258);
            this.SchedPBtoInput.Name = "SchedPBtoInput";
            this.SchedPBtoInput.Size = new System.Drawing.Size(50, 50);
            this.SchedPBtoInput.TabIndex = 12;
            this.SchedPBtoInput.TabStop = false;
            this.SchedPBtoInput.Click += new System.EventHandler(this.SchedPBtoInput_Click);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(18, 600);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(50, 50);
            this.close.TabIndex = 3;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // SchedPBtoHome
            // 
            this.SchedPBtoHome.Image = ((System.Drawing.Image)(resources.GetObject("SchedPBtoHome.Image")));
            this.SchedPBtoHome.Location = new System.Drawing.Point(18, 74);
            this.SchedPBtoHome.Name = "SchedPBtoHome";
            this.SchedPBtoHome.Size = new System.Drawing.Size(50, 50);
            this.SchedPBtoHome.TabIndex = 0;
            this.SchedPBtoHome.TabStop = false;
            this.SchedPBtoHome.Click += new System.EventHandler(this.SchedPBtoHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1328, 60);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segan";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Maroon;
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(121, 90);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(121, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 347);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(99, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 40);
            this.panel4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(120, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Obat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(119, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bodrex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "17.30";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(45, 126);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(134, 180);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Upcoming";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(398, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sunday";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(654, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tuesday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(531, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Monday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(1179, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Saturday";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(1058, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Friday";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.Location = new System.Drawing.Point(772, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Wednesday";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.Location = new System.Drawing.Point(914, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "Thursday";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel11);
            this.flowLayoutPanel1.Controls.Add(this.panel9);
            this.flowLayoutPanel1.Controls.Add(this.panel13);
            this.flowLayoutPanel1.Controls.Add(this.panel15);
            this.flowLayoutPanel1.Controls.Add(this.panel17);
            this.flowLayoutPanel1.Controls.Add(this.panel25);
            this.flowLayoutPanel1.Controls.Add(this.panel31);
            this.flowLayoutPanel1.Controls.Add(this.panel29);
            this.flowLayoutPanel1.Controls.Add(this.panel27);
            this.flowLayoutPanel1.Controls.Add(this.panel23);
            this.flowLayoutPanel1.Controls.Add(this.panel21);
            this.flowLayoutPanel1.Controls.Add(this.panel19);
            this.flowLayoutPanel1.Controls.Add(this.panel35);
            this.flowLayoutPanel1.Controls.Add(this.panel45);
            this.flowLayoutPanel1.Controls.Add(this.panel43);
            this.flowLayoutPanel1.Controls.Add(this.panel41);
            this.flowLayoutPanel1.Controls.Add(this.panel39);
            this.flowLayoutPanel1.Controls.Add(this.panel37);
            this.flowLayoutPanel1.Controls.Add(this.panel33);
            this.flowLayoutPanel1.Controls.Add(this.panel53);
            this.flowLayoutPanel1.Controls.Add(this.panel59);
            this.flowLayoutPanel1.Controls.Add(this.panel57);
            this.flowLayoutPanel1.Controls.Add(this.panel55);
            this.flowLayoutPanel1.Controls.Add(this.panel51);
            this.flowLayoutPanel1.Controls.Add(this.panel49);
            this.flowLayoutPanel1.Controls.Add(this.panel47);
            this.flowLayoutPanel1.Controls.Add(this.panel61);
            this.flowLayoutPanel1.Controls.Add(this.panel73);
            this.flowLayoutPanel1.Controls.Add(this.panel71);
            this.flowLayoutPanel1.Controls.Add(this.panel69);
            this.flowLayoutPanel1.Controls.Add(this.panel67);
            this.flowLayoutPanel1.Controls.Add(this.panel65);
            this.flowLayoutPanel1.Controls.Add(this.panel63);
            this.flowLayoutPanel1.Controls.Add(this.panel75);
            this.flowLayoutPanel1.Controls.Add(this.panel77);
            this.flowLayoutPanel1.Controls.Add(this.panel79);
            this.flowLayoutPanel1.Controls.Add(this.panel81);
            this.flowLayoutPanel1.Controls.Add(this.panel83);
            this.flowLayoutPanel1.Controls.Add(this.panel85);
            this.flowLayoutPanel1.Controls.Add(this.panel87);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(372, 139);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(920, 519);
            this.flowLayoutPanel1.TabIndex = 12;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Previousbutton
            // 
            this.Previousbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            this.Previousbutton.FlatAppearance.BorderSize = 0;
            this.Previousbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previousbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.Previousbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Previousbutton.Location = new System.Drawing.Point(927, 680);
            this.Previousbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Previousbutton.Name = "Previousbutton";
            this.Previousbutton.Size = new System.Drawing.Size(168, 34);
            this.Previousbutton.TabIndex = 13;
            this.Previousbutton.Text = "Previous";
            this.Previousbutton.UseVisualStyleBackColor = false;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.NextButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NextButton.Location = new System.Drawing.Point(1103, 680);
            this.NextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(168, 34);
            this.NextButton.TabIndex = 14;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(125, 80);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(126, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(120, 80);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(134, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(125, 80);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(126, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(120, 80);
            this.panel8.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(396, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(125, 80);
            this.panel9.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(126, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(120, 80);
            this.panel10.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Location = new System.Drawing.Point(265, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(125, 80);
            this.panel11.TabIndex = 4;
            // 
            // panel12
            // 
            this.panel12.Location = new System.Drawing.Point(126, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(120, 80);
            this.panel12.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Location = new System.Drawing.Point(527, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(125, 80);
            this.panel13.TabIndex = 6;
            // 
            // panel14
            // 
            this.panel14.Location = new System.Drawing.Point(126, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(120, 80);
            this.panel14.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Location = new System.Drawing.Point(658, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(125, 80);
            this.panel15.TabIndex = 5;
            // 
            // panel16
            // 
            this.panel16.Location = new System.Drawing.Point(126, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(120, 80);
            this.panel16.TabIndex = 1;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.panel18);
            this.panel17.Location = new System.Drawing.Point(789, 3);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(125, 80);
            this.panel17.TabIndex = 6;
            // 
            // panel18
            // 
            this.panel18.Location = new System.Drawing.Point(126, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(120, 80);
            this.panel18.TabIndex = 1;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.panel20);
            this.panel19.Location = new System.Drawing.Point(789, 89);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(125, 80);
            this.panel19.TabIndex = 7;
            // 
            // panel20
            // 
            this.panel20.Location = new System.Drawing.Point(126, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(120, 80);
            this.panel20.TabIndex = 1;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.panel22);
            this.panel21.Location = new System.Drawing.Point(658, 89);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(125, 80);
            this.panel21.TabIndex = 8;
            // 
            // panel22
            // 
            this.panel22.Location = new System.Drawing.Point(126, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(120, 80);
            this.panel22.TabIndex = 1;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.panel24);
            this.panel23.Location = new System.Drawing.Point(527, 89);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(125, 80);
            this.panel23.TabIndex = 10;
            // 
            // panel24
            // 
            this.panel24.Location = new System.Drawing.Point(126, 0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(120, 80);
            this.panel24.TabIndex = 1;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.panel26);
            this.panel25.Location = new System.Drawing.Point(3, 89);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(125, 80);
            this.panel25.TabIndex = 9;
            // 
            // panel26
            // 
            this.panel26.Location = new System.Drawing.Point(126, 0);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(120, 80);
            this.panel26.TabIndex = 1;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.panel28);
            this.panel27.Location = new System.Drawing.Point(396, 89);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(125, 80);
            this.panel27.TabIndex = 12;
            // 
            // panel28
            // 
            this.panel28.Location = new System.Drawing.Point(126, 0);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(120, 80);
            this.panel28.TabIndex = 1;
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.panel30);
            this.panel29.Location = new System.Drawing.Point(265, 89);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(125, 80);
            this.panel29.TabIndex = 11;
            // 
            // panel30
            // 
            this.panel30.Location = new System.Drawing.Point(126, 0);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(120, 80);
            this.panel30.TabIndex = 1;
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.panel32);
            this.panel31.Location = new System.Drawing.Point(134, 89);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(125, 80);
            this.panel31.TabIndex = 13;
            // 
            // panel32
            // 
            this.panel32.Location = new System.Drawing.Point(126, 0);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(120, 80);
            this.panel32.TabIndex = 1;
            // 
            // panel33
            // 
            this.panel33.Controls.Add(this.panel34);
            this.panel33.Location = new System.Drawing.Point(789, 175);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(125, 80);
            this.panel33.TabIndex = 7;
            // 
            // panel34
            // 
            this.panel34.Location = new System.Drawing.Point(126, 0);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(120, 80);
            this.panel34.TabIndex = 1;
            // 
            // panel35
            // 
            this.panel35.Controls.Add(this.panel36);
            this.panel35.Location = new System.Drawing.Point(3, 175);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(125, 80);
            this.panel35.TabIndex = 8;
            // 
            // panel36
            // 
            this.panel36.Location = new System.Drawing.Point(126, 0);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(120, 80);
            this.panel36.TabIndex = 1;
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.panel38);
            this.panel37.Location = new System.Drawing.Point(658, 175);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(125, 80);
            this.panel37.TabIndex = 10;
            // 
            // panel38
            // 
            this.panel38.Location = new System.Drawing.Point(126, 0);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(120, 80);
            this.panel38.TabIndex = 1;
            // 
            // panel39
            // 
            this.panel39.Controls.Add(this.panel40);
            this.panel39.Location = new System.Drawing.Point(527, 175);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(125, 80);
            this.panel39.TabIndex = 9;
            // 
            // panel40
            // 
            this.panel40.Location = new System.Drawing.Point(126, 0);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(120, 80);
            this.panel40.TabIndex = 1;
            // 
            // panel41
            // 
            this.panel41.Controls.Add(this.panel42);
            this.panel41.Location = new System.Drawing.Point(396, 175);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(125, 80);
            this.panel41.TabIndex = 12;
            // 
            // panel42
            // 
            this.panel42.Location = new System.Drawing.Point(126, 0);
            this.panel42.Name = "panel42";
            this.panel42.Size = new System.Drawing.Size(120, 80);
            this.panel42.TabIndex = 1;
            // 
            // panel43
            // 
            this.panel43.Controls.Add(this.panel44);
            this.panel43.Location = new System.Drawing.Point(265, 175);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(125, 80);
            this.panel43.TabIndex = 11;
            // 
            // panel44
            // 
            this.panel44.Location = new System.Drawing.Point(126, 0);
            this.panel44.Name = "panel44";
            this.panel44.Size = new System.Drawing.Size(120, 80);
            this.panel44.TabIndex = 1;
            // 
            // panel45
            // 
            this.panel45.Controls.Add(this.panel46);
            this.panel45.Location = new System.Drawing.Point(134, 175);
            this.panel45.Name = "panel45";
            this.panel45.Size = new System.Drawing.Size(125, 80);
            this.panel45.TabIndex = 13;
            // 
            // panel46
            // 
            this.panel46.Location = new System.Drawing.Point(126, 0);
            this.panel46.Name = "panel46";
            this.panel46.Size = new System.Drawing.Size(120, 80);
            this.panel46.TabIndex = 1;
            // 
            // panel47
            // 
            this.panel47.Controls.Add(this.panel48);
            this.panel47.Location = new System.Drawing.Point(789, 261);
            this.panel47.Name = "panel47";
            this.panel47.Size = new System.Drawing.Size(125, 80);
            this.panel47.TabIndex = 15;
            // 
            // panel48
            // 
            this.panel48.Location = new System.Drawing.Point(126, 0);
            this.panel48.Name = "panel48";
            this.panel48.Size = new System.Drawing.Size(120, 80);
            this.panel48.TabIndex = 1;
            // 
            // panel49
            // 
            this.panel49.Controls.Add(this.panel50);
            this.panel49.Location = new System.Drawing.Point(658, 261);
            this.panel49.Name = "panel49";
            this.panel49.Size = new System.Drawing.Size(125, 80);
            this.panel49.TabIndex = 20;
            // 
            // panel50
            // 
            this.panel50.Location = new System.Drawing.Point(126, 0);
            this.panel50.Name = "panel50";
            this.panel50.Size = new System.Drawing.Size(120, 80);
            this.panel50.TabIndex = 1;
            // 
            // panel51
            // 
            this.panel51.Controls.Add(this.panel52);
            this.panel51.Location = new System.Drawing.Point(527, 261);
            this.panel51.Name = "panel51";
            this.panel51.Size = new System.Drawing.Size(125, 80);
            this.panel51.TabIndex = 18;
            // 
            // panel52
            // 
            this.panel52.Location = new System.Drawing.Point(126, 0);
            this.panel52.Name = "panel52";
            this.panel52.Size = new System.Drawing.Size(120, 80);
            this.panel52.TabIndex = 1;
            // 
            // panel53
            // 
            this.panel53.Controls.Add(this.panel54);
            this.panel53.Location = new System.Drawing.Point(3, 261);
            this.panel53.Name = "panel53";
            this.panel53.Size = new System.Drawing.Size(125, 80);
            this.panel53.TabIndex = 19;
            // 
            // panel54
            // 
            this.panel54.Location = new System.Drawing.Point(126, 0);
            this.panel54.Name = "panel54";
            this.panel54.Size = new System.Drawing.Size(120, 80);
            this.panel54.TabIndex = 1;
            // 
            // panel55
            // 
            this.panel55.Controls.Add(this.panel56);
            this.panel55.Location = new System.Drawing.Point(396, 261);
            this.panel55.Name = "panel55";
            this.panel55.Size = new System.Drawing.Size(125, 80);
            this.panel55.TabIndex = 16;
            // 
            // panel56
            // 
            this.panel56.Location = new System.Drawing.Point(126, 0);
            this.panel56.Name = "panel56";
            this.panel56.Size = new System.Drawing.Size(120, 80);
            this.panel56.TabIndex = 1;
            // 
            // panel57
            // 
            this.panel57.Controls.Add(this.panel58);
            this.panel57.Location = new System.Drawing.Point(265, 261);
            this.panel57.Name = "panel57";
            this.panel57.Size = new System.Drawing.Size(125, 80);
            this.panel57.TabIndex = 17;
            // 
            // panel58
            // 
            this.panel58.Location = new System.Drawing.Point(126, 0);
            this.panel58.Name = "panel58";
            this.panel58.Size = new System.Drawing.Size(120, 80);
            this.panel58.TabIndex = 1;
            // 
            // panel59
            // 
            this.panel59.Controls.Add(this.panel60);
            this.panel59.Location = new System.Drawing.Point(134, 261);
            this.panel59.Name = "panel59";
            this.panel59.Size = new System.Drawing.Size(125, 80);
            this.panel59.TabIndex = 14;
            // 
            // panel60
            // 
            this.panel60.Location = new System.Drawing.Point(126, 0);
            this.panel60.Name = "panel60";
            this.panel60.Size = new System.Drawing.Size(120, 80);
            this.panel60.TabIndex = 1;
            // 
            // panel61
            // 
            this.panel61.Controls.Add(this.panel62);
            this.panel61.Location = new System.Drawing.Point(3, 347);
            this.panel61.Name = "panel61";
            this.panel61.Size = new System.Drawing.Size(125, 80);
            this.panel61.TabIndex = 16;
            // 
            // panel62
            // 
            this.panel62.Location = new System.Drawing.Point(126, 0);
            this.panel62.Name = "panel62";
            this.panel62.Size = new System.Drawing.Size(120, 80);
            this.panel62.TabIndex = 1;
            // 
            // panel63
            // 
            this.panel63.Controls.Add(this.panel64);
            this.panel63.Location = new System.Drawing.Point(789, 347);
            this.panel63.Name = "panel63";
            this.panel63.Size = new System.Drawing.Size(125, 80);
            this.panel63.TabIndex = 21;
            // 
            // panel64
            // 
            this.panel64.Location = new System.Drawing.Point(126, 0);
            this.panel64.Name = "panel64";
            this.panel64.Size = new System.Drawing.Size(120, 80);
            this.panel64.TabIndex = 1;
            // 
            // panel65
            // 
            this.panel65.Controls.Add(this.panel66);
            this.panel65.Location = new System.Drawing.Point(658, 347);
            this.panel65.Name = "panel65";
            this.panel65.Size = new System.Drawing.Size(125, 80);
            this.panel65.TabIndex = 19;
            // 
            // panel66
            // 
            this.panel66.Location = new System.Drawing.Point(126, 0);
            this.panel66.Name = "panel66";
            this.panel66.Size = new System.Drawing.Size(120, 80);
            this.panel66.TabIndex = 1;
            // 
            // panel67
            // 
            this.panel67.Controls.Add(this.panel68);
            this.panel67.Location = new System.Drawing.Point(527, 347);
            this.panel67.Name = "panel67";
            this.panel67.Size = new System.Drawing.Size(125, 80);
            this.panel67.TabIndex = 20;
            // 
            // panel68
            // 
            this.panel68.Location = new System.Drawing.Point(126, 0);
            this.panel68.Name = "panel68";
            this.panel68.Size = new System.Drawing.Size(120, 80);
            this.panel68.TabIndex = 1;
            // 
            // panel69
            // 
            this.panel69.Controls.Add(this.panel70);
            this.panel69.Location = new System.Drawing.Point(396, 347);
            this.panel69.Name = "panel69";
            this.panel69.Size = new System.Drawing.Size(125, 80);
            this.panel69.TabIndex = 17;
            // 
            // panel70
            // 
            this.panel70.Location = new System.Drawing.Point(126, 0);
            this.panel70.Name = "panel70";
            this.panel70.Size = new System.Drawing.Size(120, 80);
            this.panel70.TabIndex = 1;
            // 
            // panel71
            // 
            this.panel71.Controls.Add(this.panel72);
            this.panel71.Location = new System.Drawing.Point(265, 347);
            this.panel71.Name = "panel71";
            this.panel71.Size = new System.Drawing.Size(125, 80);
            this.panel71.TabIndex = 18;
            // 
            // panel72
            // 
            this.panel72.Location = new System.Drawing.Point(126, 0);
            this.panel72.Name = "panel72";
            this.panel72.Size = new System.Drawing.Size(120, 80);
            this.panel72.TabIndex = 1;
            // 
            // panel73
            // 
            this.panel73.Controls.Add(this.panel74);
            this.panel73.Location = new System.Drawing.Point(134, 347);
            this.panel73.Name = "panel73";
            this.panel73.Size = new System.Drawing.Size(125, 80);
            this.panel73.TabIndex = 15;
            // 
            // panel74
            // 
            this.panel74.Location = new System.Drawing.Point(126, 0);
            this.panel74.Name = "panel74";
            this.panel74.Size = new System.Drawing.Size(120, 80);
            this.panel74.TabIndex = 1;
            // 
            // panel75
            // 
            this.panel75.Controls.Add(this.panel76);
            this.panel75.Location = new System.Drawing.Point(3, 433);
            this.panel75.Name = "panel75";
            this.panel75.Size = new System.Drawing.Size(125, 80);
            this.panel75.TabIndex = 23;
            // 
            // panel76
            // 
            this.panel76.Location = new System.Drawing.Point(126, 0);
            this.panel76.Name = "panel76";
            this.panel76.Size = new System.Drawing.Size(120, 80);
            this.panel76.TabIndex = 1;
            // 
            // panel77
            // 
            this.panel77.Controls.Add(this.panel78);
            this.panel77.Location = new System.Drawing.Point(134, 433);
            this.panel77.Name = "panel77";
            this.panel77.Size = new System.Drawing.Size(125, 80);
            this.panel77.TabIndex = 28;
            // 
            // panel78
            // 
            this.panel78.Location = new System.Drawing.Point(126, 0);
            this.panel78.Name = "panel78";
            this.panel78.Size = new System.Drawing.Size(120, 80);
            this.panel78.TabIndex = 1;
            // 
            // panel79
            // 
            this.panel79.Controls.Add(this.panel80);
            this.panel79.Location = new System.Drawing.Point(265, 433);
            this.panel79.Name = "panel79";
            this.panel79.Size = new System.Drawing.Size(125, 80);
            this.panel79.TabIndex = 26;
            // 
            // panel80
            // 
            this.panel80.Location = new System.Drawing.Point(126, 0);
            this.panel80.Name = "panel80";
            this.panel80.Size = new System.Drawing.Size(120, 80);
            this.panel80.TabIndex = 1;
            // 
            // panel81
            // 
            this.panel81.Controls.Add(this.panel82);
            this.panel81.Location = new System.Drawing.Point(396, 433);
            this.panel81.Name = "panel81";
            this.panel81.Size = new System.Drawing.Size(125, 80);
            this.panel81.TabIndex = 27;
            // 
            // panel82
            // 
            this.panel82.Location = new System.Drawing.Point(126, 0);
            this.panel82.Name = "panel82";
            this.panel82.Size = new System.Drawing.Size(120, 80);
            this.panel82.TabIndex = 1;
            // 
            // panel83
            // 
            this.panel83.Controls.Add(this.panel84);
            this.panel83.Location = new System.Drawing.Point(527, 433);
            this.panel83.Name = "panel83";
            this.panel83.Size = new System.Drawing.Size(125, 80);
            this.panel83.TabIndex = 24;
            // 
            // panel84
            // 
            this.panel84.Location = new System.Drawing.Point(126, 0);
            this.panel84.Name = "panel84";
            this.panel84.Size = new System.Drawing.Size(120, 80);
            this.panel84.TabIndex = 1;
            // 
            // panel85
            // 
            this.panel85.Controls.Add(this.panel86);
            this.panel85.Location = new System.Drawing.Point(658, 433);
            this.panel85.Name = "panel85";
            this.panel85.Size = new System.Drawing.Size(125, 80);
            this.panel85.TabIndex = 25;
            // 
            // panel86
            // 
            this.panel86.Location = new System.Drawing.Point(126, 0);
            this.panel86.Name = "panel86";
            this.panel86.Size = new System.Drawing.Size(120, 80);
            this.panel86.TabIndex = 1;
            // 
            // panel87
            // 
            this.panel87.Controls.Add(this.panel88);
            this.panel87.Location = new System.Drawing.Point(789, 433);
            this.panel87.Name = "panel87";
            this.panel87.Size = new System.Drawing.Size(125, 80);
            this.panel87.TabIndex = 22;
            // 
            // panel88
            // 
            this.panel88.Location = new System.Drawing.Point(126, 0);
            this.panel88.Name = "panel88";
            this.panel88.Size = new System.Drawing.Size(120, 80);
            this.panel88.TabIndex = 1;
            // 
            // Schedule
            // 
            this.ClientSize = new System.Drawing.Size(1326, 725);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.Previousbutton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Schedule";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SchedPBtoInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchedPBtoHome)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            this.panel31.ResumeLayout(false);
            this.panel33.ResumeLayout(false);
            this.panel35.ResumeLayout(false);
            this.panel37.ResumeLayout(false);
            this.panel39.ResumeLayout(false);
            this.panel41.ResumeLayout(false);
            this.panel43.ResumeLayout(false);
            this.panel45.ResumeLayout(false);
            this.panel47.ResumeLayout(false);
            this.panel49.ResumeLayout(false);
            this.panel51.ResumeLayout(false);
            this.panel53.ResumeLayout(false);
            this.panel55.ResumeLayout(false);
            this.panel57.ResumeLayout(false);
            this.panel59.ResumeLayout(false);
            this.panel61.ResumeLayout(false);
            this.panel63.ResumeLayout(false);
            this.panel65.ResumeLayout(false);
            this.panel67.ResumeLayout(false);
            this.panel69.ResumeLayout(false);
            this.panel71.ResumeLayout(false);
            this.panel73.ResumeLayout(false);
            this.panel75.ResumeLayout(false);
            this.panel77.ResumeLayout(false);
            this.panel79.ResumeLayout(false);
            this.panel81.ResumeLayout(false);
            this.panel83.ResumeLayout(false);
            this.panel85.ResumeLayout(false);
            this.panel87.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private Label label12;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private PictureBox SchedPBtoInput;

        private void SchedPBtoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hom = new Home();
            hom.Show();
        }

        private void SchedPBtoInput_Click(object sender, EventArgs e)
        {
            this.Hide();
            InputObat inputdrag = new InputObat();
            inputdrag.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel5;
        private Button Previousbutton;
        private Button NextButton;

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel11;
        private Panel panel12;
        private Panel panel9;
        private Panel panel10;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private Panel panel25;
        private Panel panel26;
        private Panel panel31;
        private Panel panel32;
        private Panel panel29;
        private Panel panel30;
        private Panel panel27;
        private Panel panel28;
        private Panel panel23;
        private Panel panel24;
        private Panel panel21;
        private Panel panel22;
        private Panel panel19;
        private Panel panel20;
        private Panel panel35;
        private Panel panel36;
        private Panel panel45;
        private Panel panel46;
        private Panel panel43;
        private Panel panel44;
        private Panel panel41;
        private Panel panel42;
        private Panel panel39;
        private Panel panel40;
        private Panel panel37;
        private Panel panel38;
        private Panel panel33;
        private Panel panel34;
        private Panel panel53;
        private Panel panel54;
        private Panel panel59;
        private Panel panel60;
        private Panel panel57;
        private Panel panel58;
        private Panel panel55;
        private Panel panel56;
        private Panel panel51;
        private Panel panel52;
        private Panel panel49;
        private Panel panel50;
        private Panel panel47;
        private Panel panel48;
        private Panel panel61;
        private Panel panel62;
        private Panel panel73;
        private Panel panel74;
        private Panel panel71;
        private Panel panel72;
        private Panel panel69;
        private Panel panel70;
        private Panel panel67;
        private Panel panel68;
        private Panel panel65;
        private Panel panel66;
        private Panel panel63;
        private Panel panel64;
        private Panel panel75;
        private Panel panel76;
        private Panel panel77;
        private Panel panel78;
        private Panel panel79;
        private Panel panel80;
        private Panel panel81;
        private Panel panel82;
        private Panel panel83;
        private Panel panel84;
        private Panel panel85;
        private Panel panel86;
        private Panel panel87;
        private Panel panel88;

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
