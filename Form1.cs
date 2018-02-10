using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC
{
    public partial class Form1 : Form
    {
        double W, H;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Body mass index (BMI) is a measure of body fat 
based on your weight in relation to your height, 
and applies to most adult men and women aged 20 and over and for children aged 2 and over, 
BMI percentile is the best assessment of body fat 
BMI does not measure body fat directly.However, 
research indicates that BMI correlates to direct measures of body 
fat such as underwater weighing and dual-energy X-ray absorptiometry(DXA), 
and is considered an inexpensive
and easy - to - perform alternative for these", "About BMI");
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                W = Convert.ToDouble(textBox1.Text);
                H = Convert.ToDouble(textBox2.Text);
            }
            catch 
            {
                MessageBox.Show("Fill in the textbox", "ERROR");
            }
            double output =0;
            if (checkBox1.Checked == true && checkBox3.Checked == true)
            {
                output = W / (H * H);
            }
            else if (checkBox2.Checked == true && checkBox4.Checked == true)
            {
                output = (W / 2.2046) / ((H / 3.2808) * (H / 3.2808));
            }
            else if (checkBox1.Checked == true && checkBox4.Checked == true)
            {
                output = W / ((H / 3.2808) * (H / 3.2808));
            }
            else if (checkBox2.Checked==true && checkBox3.Checked==true)
            {
                output = (W / 2.2046) / (H * H);
            }
            else if((checkBox1.Checked==true && checkBox2.Checked==true)||(checkBox3.Checked==true&&checkBox4.Checked==true))
            {
                MessageBox.Show(@"Make sure you didn't check the two 
                                units under the same section", "ERROR");
            }
            else
            {
                MessageBox.Show(@"Pls make sure you checked all necessary boxes","ERROR");
            }
            this.Hide();
            Form2 ResultSheet = new Form2();
            ResultSheet.Show();
            ResultSheet.Output.Text = output.ToString();

            if (output <= 18.5)
                ResultSheet.Recommend.Text = "The fat content in your body is below normal." 
                    +"You should feed better";
            else if (output < 24.9 && output > 18.5)
                ResultSheet.Recommend.Text = "The fat content in your body is at a normal" 
                    +"level." 
                    +"You should keep it up";
            else if (output > 24.9 && output <= 29.9)
                ResultSheet.Recommend.Text = "The fat content in your body has exceeded" 
                    +"the normal level this indicates" 
                    +"that your are medically overweight." 
                    +"Work on it";
            else if (output >= 30)
                ResultSheet.Recommend.Text = "The fat content in your body has exceeded"
                    +"the normal level and your are declared medically obessed." 
                    +"Work on it";

        }
    }
}
