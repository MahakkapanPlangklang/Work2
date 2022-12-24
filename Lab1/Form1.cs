namespace Lab1
{
    public partial class Form1 : Form
    {
        double input1 = 0;
        string op = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (Input.Text.Length > 0)
            //{
             //  Input.Text = Convert.ToDouble(Input.Text).ToString();
             //  Input.SelectionStart = Input.Text.Length;
            //   this.Input.Text = string.Format("{0:n}", double.Parse(this.Input.Text));
          //  }

        }

        private void one_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "1";
            this.Input2.Text = this.Input2.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "2";
            this.Input2.Text = this.Input2.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "3";
            this.Input2.Text = this.Input2.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "4";
            this.Input2.Text = this.Input2.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "5";
            this.Input2.Text = this.Input2.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "6";
            this.Input2.Text = this.Input2.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "7";
            this.Input2.Text = this.Input2.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "8";
            this.Input2.Text = this.Input2.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "9";
            this.Input2.Text = this.Input2.Text + "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "0";
            this.Input2.Text = this.Input2.Text + "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
          
            this.input1 = Double.Parse(this.Input2.Text);
            this.Input.Text = "";
            this.op = "+";
            this.Input2.Text = this.Input2.Text + "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.Input.Text);
            this.Input.Text = "";
            this.op = "-";
            this.Input2.Text = this.Input2.Text + "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.Input.Text);
            this.Input.Text = "";
            this.op = "x";
            this.Input2.Text = this.Input2.Text + "x";
        }

        private void divine_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.Input.Text);
            this.Input.Text = "";
            this.op = "/";
            this.Input2.Text = this.Input2.Text + "/";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double input2 = Double.Parse(this.Input.Text);
            double result = 0;
            if (this.op == "+")
            {
                result = input1 + input2;
            }
            else if (this.op == "-")
            {
                result = input1 - input2;
            }
            else if (this.op == "x")
            {
                result = input1 * input2;
            }
            else if (this.op == "/")
            {
                result = input1 / input2;
            }
            else if (this.op == "C")
            {
                result = input2;
            }
            //this.Input.Text = result.ToString();
            //this.Input2.Text = result.ToString();
            this.Input.Text = Convert.ToString(result);
            this.Input.Text = string.Format("{0:n}",double.Parse(this.Input.Text));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Input.Clear();
            Input2.Clear();
            this.op = "C";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!this.Input.Text.Contains("."))
            {
                this.Input.Text +=  ".";
                this.Input2.Text +=  ".";
            }
        }

        private void Input2_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}