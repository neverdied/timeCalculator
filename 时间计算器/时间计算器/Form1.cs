using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 时间计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan res=dateTimePicker2.Value - dateTimePicker1.Value;
            label3.Text = "时间差为："+res.Days.ToString()+"天"+res.Hours.ToString()+"小时"+res.Minutes.ToString()+"分钟"+res.Seconds+"秒钟";
            label4.Text = "小时差为：" + (res.Days*24 + res.Hours).ToString() + "小时" + res.Minutes.ToString() + "分钟" + res.Seconds + "秒钟";
            label5.Text = "分钟差为：" + (res.Days * 24*60 + res.Hours*60+ res.Minutes).ToString() + "分钟" + res.Seconds + "秒钟";

        }
    }
}
