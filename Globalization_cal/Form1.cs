using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Globalization_cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            GetInfo();

        }
        private void btnHijri_Click(object sender, EventArgs e)
        {
            System.Globalization.HijriCalendar g = new System.Globalization.HijriCalendar();
            tbYear.Text = g.GetYear(DateTime.Now).ToString();
            tbMonth.Text = g.GetMonth(DateTime.Now).ToString();
            tbDay.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            tbDayOfWeek.Text = g.GetDayOfWeek(DateTime.Now).ToString();

            lblYear2.Text = g.GetYear(DateTime.Now).ToString();
            lblDay2.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            lblDayOfWeek2.Text = g.GetDayOfWeek(DateTime.Now).ToString();

            Int32 m;
            Int32.TryParse(tbMonth.Text, out m);
            GetMonth(m);
            lblMonth2.Text = GetMonth(m);
        }
        private void btnChin_Click(object sender, EventArgs e)
        {
            System.Globalization.ChineseLunisolarCalendar g = new System.Globalization.ChineseLunisolarCalendar();
            tbYear.Text = g.GetYear(DateTime.Now).ToString();
            tbMonth.Text = g.GetMonth(DateTime.Now).ToString();
            tbDay.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            tbDayOfWeek.Text = g.GetDayOfWeek(DateTime.Now).ToString();

            lblYear2.Text = g.GetYear(DateTime.Now).ToString();
            lblDay2.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            lblDayOfWeek2.Text = g.GetDayOfWeek(DateTime.Now).ToString();

            Int32 m;
            Int32.TryParse(tbMonth.Text, out m);
            GetMonth(m);
            lblMonth2.Text = GetMonth(m);

        }

        public void GetInfo()
        {
            System.Globalization.GregorianCalendar g = new System.Globalization.GregorianCalendar();
            tbYear.Text = g.GetYear(DateTime.Now).ToString();
            tbMonth.Text = g.GetMonth(DateTime.Now).ToString();
            tbDay.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            tbDayOfWeek.Text = g.GetDayOfWeek(DateTime.Now).ToString();

            lblYear2.Text = g.GetYear(DateTime.Now).ToString();
            lblDay2.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            lblDayOfWeek2.Text = g.GetDayOfWeek(DateTime.Now).ToString();

            Int32 m;
            Int32.TryParse(tbMonth.Text, out m);
            GetMonth(m);
            lblMonth2.Text = GetMonth(m);

        }

       

        public string GetMonth(Int32 monthNum)
        {
            Int32 m;
            Int32.TryParse(tbMonth.Text, out m);
            string mn;

            switch (monthNum)
            {
                case 1:
                    mn = "January";
                    break;

                case 2:
                    mn = "February";
                    break ;
                case 3:
                    mn = "March";
                    break;

                case 4:
                    mn = "April";
                    break;

                case 5:
                    mn = "May";
                    break;

                case 6:
                    mn = "June";
                    break;
                case 7:
                    mn = "July";
                    break;

                case 8:
                    mn = "August";
                    break;

                case 9:
                    mn = "September";
                    break;

                case 10:
                    mn = "October";
                    break;
                case 11:
                    mn = "November";
                    break;

                case 12:
                    mn = "December";
                    break;

                default:
                    mn = "Unkown";
                    break;
            }
            lblDisplayMonth.Text = mn;

            return mn;
        }

    }
}
