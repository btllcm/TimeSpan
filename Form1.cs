using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/// <summary>
/// create by btl
/// create date 2019/8/27
/// </summary>
namespace TimeSpan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000009 RID: 9 RVA: 0x00002114 File Offset: 0x00000314
        public List<string> getYears()
        {
            List<string> years = new List<string>();
            int startyear = 1949;
            int endyear = DateTime.Now.Year;
            for (int i = startyear; i <= endyear; i++)
            {
                years.Add(i.ToString());
            }
            return years;
        }

        // Token: 0x0600000A RID: 10 RVA: 0x0000216C File Offset: 0x0000036C
        public List<string> getMonths()
        {
            List<string> list = new List<string>();
            int start = 1;
            int end = 12;
            for (int i = start; i <= end; i++)
            {
                list.Add(i.ToString());
            }
            return list;
        }

        // Token: 0x0600000B RID: 11 RVA: 0x000021B4 File Offset: 0x000003B4
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> years = this.getYears();
            this.cbx_start_year.DataSource = years;
            this.cbx_start_year.Text = "2018";
            this.cbx_end_year.DataSource = new List<string>(years.ToArray());
            this.cbx_end_year.Text = DateTime.Now.Year.ToString();
            this.cbx_start_month.DataSource = this.getMonths();
            this.cbx_end_month.DataSource = this.getMonths();
            this.cbx_end_month.DataSource = this.getMonths();
            this.cbx_start_month.Text = "4";
            this.cbx_end_month.Text = DateTime.Now.Month.ToString();
        }

        // Token: 0x0600000C RID: 12 RVA: 0x00002287 File Offset: 0x00000487
        private void Cbx_start_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.setDays(this.cbx_start_days, this.cbx_start_year.Text, this.cbx_start_month.Text, "7");
            this.caldays();
        }

        // Token: 0x0600000D RID: 13 RVA: 0x000022B9 File Offset: 0x000004B9
        private void Cbx_start_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.setDays(this.cbx_start_days, this.cbx_start_year.Text, this.cbx_start_month.Text, "7");
            this.caldays();
        }

        // Token: 0x0600000E RID: 14 RVA: 0x000022EC File Offset: 0x000004EC
        private void setDays(ComboBox cbx, string year, string month, string defaultday)
        {
            bool flag = year == "" || month == "";
            if (!flag)
            {
                bool flag2 = month == "无";
                if (flag2)
                {
                    cbx.DataSource = new List<string>
                    {
                        "无"
                    };
                }
                else
                {
                    int days = DateTime.DaysInMonth(int.Parse(year), int.Parse(month));
                    List<string> list = new List<string>
                    {
                        "无"
                    };
                    for (int i = 1; i <= days; i++)
                    {
                        list.Add(i.ToString());
                    }
                    cbx.DataSource = list;
                    cbx.Text = defaultday;
                }
            }
        }

        // Token: 0x0600000F RID: 15 RVA: 0x000023A8 File Offset: 0x000005A8
        private void Cbx_end_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.setDays(this.cbx_end_days, this.cbx_start_year.Text, this.cbx_start_month.Text, DateTime.Now.Day.ToString());
            this.caldays();
        }

        // Token: 0x06000010 RID: 16 RVA: 0x000023F8 File Offset: 0x000005F8
        private void Cbx_end_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.setDays(this.cbx_end_days, this.cbx_end_year.Text, this.cbx_end_month.Text, DateTime.Now.Day.ToString());
            this.caldays();
        }

        // Token: 0x06000011 RID: 17 RVA: 0x00002448 File Offset: 0x00000648
        private void caldays()
        {
            bool flag = this.cbx_start_year.Text == "" || this.cbx_end_year.Text == "";
            if (!flag)
            {
                string start_date = "";
                string end_date = "";
                bool flag2 = this.cbx_start_year.Text != "";
                if (flag2)
                {
                    start_date = this.cbx_start_year.Text;
                }
                bool flag3 = this.cbx_start_month.Text != "" && this.cbx_start_month.Text != "无";
                if (flag3)
                {
                    start_date = start_date + "-" + this.cbx_start_month.Text.PadLeft(2, '0');
                }
                bool flag4 = this.cbx_start_days.Text != "" && this.cbx_start_days.Text != "无";
                if (flag4)
                {
                    start_date = start_date + "-" + this.cbx_start_days.Text.PadLeft(2, '0');
                }
                DateTime start = default(DateTime);
                bool flag5 = !DateTime.TryParse(start_date, out start);
                if (!flag5)
                {
                    bool flag6 = this.cbx_end_year.Text != "";
                    if (flag6)
                    {
                        end_date = this.cbx_end_year.Text;
                    }
                    bool flag7 = this.cbx_end_month.Text != "" && this.cbx_end_month.Text != "无";
                    if (flag7)
                    {
                        end_date = end_date + "-" + this.cbx_end_month.Text.PadLeft(2, '0');
                    }
                    bool flag8 = this.cbx_end_days.Text != "" && this.cbx_end_days.Text != "无";
                    if (flag8)
                    {
                        end_date = end_date + "-" + this.cbx_end_days.Text.PadLeft(2, '0');
                    }
                    DateTime end = default(DateTime);
                    bool flag9 = !DateTime.TryParse(end_date, out end);
                    if (!flag9)
                    {
                        int span_year = 0;
                        int span_month = 0;
                        int span_days = 0;
                        bool flag10 = end > start;
                        if (flag10)
                        {
                            this.getYearMonthDay(start, end, ref span_year, ref span_month, ref span_days);
                        }
                        this.lb_tip.Text = "";
                        bool flag11 = span_year > 0;
                        if (flag11)
                        {
                            this.lb_tip.Text = span_year.ToString() + "年";
                        }
                        bool flag12 = span_month > 0;
                        if (flag12)
                        {
                            Label label = this.lb_tip;
                            label.Text = label.Text + span_month.ToString() + "月";
                        }
                        bool flag13 = span_days > 0;
                        if (flag13)
                        {
                            Label label2 = this.lb_tip;
                            label2.Text = label2.Text + span_days.ToString() + "天";
                        }
                    }
                }
            }
        }

        // Token: 0x06000012 RID: 18 RVA: 0x0000274C File Offset: 0x0000094C
        private void getYearMonthDay(DateTime start, DateTime end, ref int span_year, ref int span_month, ref int span_days)
        {
            span_year = end.Year - start.Year;
            bool flag = start.AddYears(span_year) > end;
            if (flag)
            {
                span_year--;
            }
            start = start.AddYears(span_year);
            while (start < end)
            {
                span_month++;
                start = start.AddMonths(1);
            }
            bool flag2 = start > end;
            if (flag2)
            {
                span_month--;
                start = start.AddMonths(-1);
            }
            while (start < end)
            {
                span_days++;
                start = start.AddDays(1.0);
            }
        }
        // Token: 0x06000013 RID: 19 RVA: 0x000027FA File Offset: 0x000009FA
        private void Cbx_start_days_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.caldays();
        }

        // Token: 0x06000014 RID: 20 RVA: 0x00002804 File Offset: 0x00000A04
        private void Cbx_end_days_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.caldays();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            cbx_start_year.Text = "2018";
            cbx_start_month.Text = "4";
            cbx_start_days.Text = "7";
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            cbx_end_year.Text = DateTime.Now.Year.ToString();
            cbx_end_month.Text = DateTime.Now.Month.ToString();
            cbx_end_days.Text = DateTime.Now.Day.ToString();
        }
    }
    }
