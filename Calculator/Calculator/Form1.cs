namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length<18)
            {
            }
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 18)
            {
                textBox1.Text += "1";
            }
            setLowText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 18)
            {
                textBox1.Text += "2";
            }
            setLowText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 18)
            {
                textBox1.Text += "3";
            }
            setLowText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 18)
            {
                textBox1.Text += "4";
            }
            setLowText();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 18)
            {
                textBox1.Text += "5";
            }
            setLowText();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 18)
            {
                textBox1.Text += "6";
            }
            setLowText();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 18)
            {
                textBox1.Text += "7";
            }
            setLowText();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 18)
            {
                textBox1.Text += "8";
            }
            setLowText();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 18)
            {
                textBox1.Text += "9";
            }
            setLowText();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int idx = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            text = text.Remove(idx);
            textBox1.Text = text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (!isOperatorExist())
            {
                if (!isPointExist(textBox1.Text))
                {
                    textBox1.Text += ".";
                }
            }
            else
            {
                string s2 = getSecondPart(textBox1.Text);
                if (!isPointExist(s2))
                {
                    textBox1.Text += ".";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 18)
            {
                if(!isOperatorExist())
                {
                    textBox1.Text += "+";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length < 18)
            {
                if (!isOperatorExist())
                {
                    textBox1.Text += "-";
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length < 18)
            {
                if (!isOperatorExist())
                {
                    textBox1.Text += "x";
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length < 18)
            {
                if (!isOperatorExist())
                {
                    textBox1.Text += "/";
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length < 18)
            {
                if (!isOperatorExist())
                {
                    textBox1.Text += "%";
                }
            }
        }
        private bool isOperatorExist()
        {
            if (textBox1.Text == "")
            {
                return true;
            }
            foreach (char c in textBox1.Text)
            {
                if (c == '+' || c == '-' || c == 'x' || c == '/' || c == '%')
                    return true;
            }
            return false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (getResult() != null)
            {
                textBox1.Text = getResult();
            }
        }
        private string getResult()
        {
            string text = textBox1.Text;
            int len = text.Length - 1;
            char op = '!';
            string s1 = "", s2 = "";
            bool b = true;
            //if last character is not operator
            if (text[len] != 'x' && text[len] != '/' && text[len] != '-' && text[len] != '+' && text[len] != '%')
            {
                foreach (char c in text)
                {
                    if (c == 'x' || c == '/' || c == '+' || c == '-' || c == '%')
                    {
                        op = c;
                        b = false;
                    }
                    else if (b)
                    {
                        s1 += c;
                    }
                    else
                    {
                        s2 += c;
                    }
                }
                float result = 0;
                if (op == 'x')
                {
                    result = float.Parse(s1) * float.Parse(s2);
                }
                if (op == '+')
                {
                    result = float.Parse(s1) + float.Parse(s2);
                }
                if (op == '-')
                {
                    result = float.Parse(s1) - float.Parse(s2);
                }
                if (op == '/')
                {
                    result = float.Parse(s1) / float.Parse(s2);
                }
                if (op == '%')
                {
                    result = float.Parse(s1) % float.Parse(s2);
                }
                if(op == '!')
                {
                    result = float.Parse(s1);
                }
                return result.ToString();
            }
            return null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void setLowText()
        {
            if (getResult() != null && isOperatorExist())
            {
                label2.Text = getResult();
            }
            else
            {
                label2.Text = "        ";
            }
        }
        private bool isPointExist(string s)
        {
            foreach (char c in s)
            {
                if (c == '.')
                    return true;
            }
            return false;
        }
        private string getSecondPart(string s)
        {
            bool b = false;
            string output = "";
            foreach (char c in s)
            {
                if (c == 'x' || c == '/' || c == '+' || c == '-' || c == '%')
                {
                    b = true;
                }
                else if (b)
                {
                    output += c;
                }
            }
            return output;
        }
    }
}