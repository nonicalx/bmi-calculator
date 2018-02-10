using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://en.wikipedia.org/w/index.php?search=Body+mass+index%2F&title=Special:Search&fulltext=1&searchToken=bprm6bdrmgaxp4dtg4c01gp9p/");
            Process.Start(sInfo);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo1 = new ProcessStartInfo("http://www.medicalnewstoday.com/info/obesity/what-is-bmi/");
            Process.Start(sInfo1);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo2 = new ProcessStartInfo("http://www.healthhub.sg/bmi-calculator/");
            Process.Start(sInfo2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 back = new Form1();
            back.Show();
        }
    }
}
