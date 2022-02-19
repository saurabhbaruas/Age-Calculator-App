using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = Convert.ToDateTime(textBox1.Text);
            int year = d2.Year;
            int month = d2.Month;
            int day = d2.Day;

            int leap_year = 0;
            for (int i = year; i < d1.Year; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    ++leap_year;
                }
            }

            TimeSpan timespan = d1.Subtract(d2);
            day = timespan.Days - leap_year;
            int r = 0;
            year = Math.DivRem(day, 365, out r);
            month = Math.DivRem(r, 30, out r);
            day = r;
            label1.Text = day.ToString();
            label2.Text = month.ToString();
            label3.Text = year.ToString();
        }
    }
}
