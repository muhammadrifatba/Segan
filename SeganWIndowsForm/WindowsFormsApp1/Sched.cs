using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    //TODO:
    //1. Upcoming
    //2. Auto Refres

    public partial class Sched : Form
    {
        int month, year;
        string userId_var, username_var, role_var;
        
        public static int static_month, static_year;
        public Sched(string userId, string username, string role)
        {
            InitializeComponent();
            UserSchedLabel.Text = username;
            userId_var = userId;
            username_var = username;
            role_var = role;

            if (role_var == "2")
            {
                drugpbsched.Hide();
            }
        }

        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelMonthYear.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            static_month = month;
            static_year = year;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays(userId_var, i);
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }


        }

        private void drugpbsched_Click(object sender, EventArgs e)
        {
            this.Hide();
            InputObat inputdrag = new InputObat(userId_var, username_var, role_var);
            inputdrag.Show();
        }


        private void daycontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sched_Load(object sender, EventArgs e)
        {
            displaDays();
        }

        private void Previousbutton_Click_1(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();
            if (month == 1)
            {
                month = 13;
                year--;

            }
            
            //increment month
            month--;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelMonthYear.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays(userId_var, i);
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        

        private void NextButton_Click_1(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();
            //increment month

            if (month == 12)
            {
                month = 0;
                year++;
               
            }
            month++;

            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelMonthYear.Text = monthname + " " + year;


            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays(userId_var, i);
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        
      }
   }
