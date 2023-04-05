namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double a;
        public double b;
        public char c;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0)
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.TextLength - 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text += "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text += "0";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox2.Text);

                c = '+';

                textBox2.Text = "";
            }
            catch (Exception)
            {

            }

        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox2.Text);

                c = '-';

                textBox2.Text = "";
            }
            catch (Exception)
            {

            }

        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox2.Text);

                c = '*';

                textBox2.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox2.Text);

                c = '/';

                textBox2.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 0)
            {
                textBox2.Text = "";
            }

            b = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";

            _ = c switch
            {
                '+' => textBox2.Text = Convert.ToString(a + b),
                '-' => textBox2.Text = Convert.ToString(a - b),
                '*' => textBox2.Text = Convert.ToString(a * b),
                '/' => textBox2.Text = Convert.ToString(a / b)
            };
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox2.Text += ",";
            return;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 0)
            {
                textBox2.Text = "";
                return;
            }

            a = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(Math.Pow(a, 2));
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 0)
            {
                textBox2.Text = "";
                return;
            }

            a = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(Math.Sin(a));
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 0)
            {
                textBox2.Text = "";
                return;
            }

            a = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(Math.Cos(a));
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 0)
            {
                textBox2.Text = "";
                return;
            }

            a = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(Math.Tan(a));
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (textBox2.TextLength == 0)
            {
                textBox2.Text = "";
                return;
            }

            a = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(1 / Math.Tan(a));

        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 0)
            {
                textBox2.Text = "";
                return;
            }

            a = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(Math.Sqrt(a));

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("калькулятор");
        }
    }
}