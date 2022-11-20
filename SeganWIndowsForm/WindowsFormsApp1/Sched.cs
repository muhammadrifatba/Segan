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
    public partial class Sched : Form
    {
        int month, year;
        private string userId_var, username_var;
        private int role_var;
        
        public Sched(string userId, string username, string role)
        {
            InitializeComponent();
            UserSchedLabel.Text = username;
            userId_var = username;
            username_var = username;
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

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }


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
                UserControlDays ucdays = new UserControlDays();
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
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        
      }
   }
