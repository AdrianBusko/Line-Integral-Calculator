using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace IntegralCalculatorWindow
{
    public partial class Form1 : Form
    {
        //objects
        Integral D = new Integral();

        //methods
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddFunctionValue()
        {
            if (textBox1.Enabled) D.CompletionFunction(textBox1.Text);
            if (textBox9.Enabled) D.CompletionFunction(textBox9.Text);
            if (textBox7.Enabled) D.CompletionFunction(textBox7.Text);
            if (textBox5.Enabled) D.CompletionFunction(textBox5.Text);
            if (textBox10.Enabled) D.CompletionFunction(textBox10.Text);
            if (textBox6.Enabled) D.CompletionFunction(textBox6.Text);
            if (textBox8.Enabled) D.CompletionFunction(textBox8.Text);
            if (textBox4.Enabled) D.CompletionFunction(textBox4.Text);
            if (textBox11.Enabled) D.CompletionFunction(textBox11.Text);

        }

        private void CalculateAll()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            D.CountX = Convert.ToInt32(numericUpDown1.Value);
            D.LimitDown = Convert.ToInt32(textBox2.Text);
            D.LimitUp = Convert.ToInt32(textBox3.Text);
            D.CountOfTrapeze = Convert.ToInt32(textBox12.Text);
            groupBox2.Enabled = true;
            groupBox1.Enabled = false;
            button1.Enabled = true;

            //activate textboxes
            textBox11.Enabled = true;
            if (D.CountX >= 2)
            {
                textBox4.Enabled = true;
                if (D.CountX >= 3)
                {
                    textBox8.Enabled = true;
                    if (D.CountX >= 4)
                    {
                        textBox6.Enabled = true;
                        if (D.CountX >= 5)
                        {
                            textBox10.Enabled = true;
                            if (D.CountX >= 6)
                            {
                                textBox5.Enabled = true;
                                if (D.CountX >= 7)
                                {
                                    textBox7.Enabled = true;
                                    if (D.CountX >= 8)
                                    {
                                        textBox9.Enabled = true;
                                        if (D.CountX >= 8) textBox1.Enabled = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFunctionValue();
            FarOfTrapeze();

            for (int i = 0; i < D.CountOfTrapeze; i++)
            {
                double tmp1, tmp2;
                tmp1 = (i * D.OnePartOfIntegral) + D.LimitDown;
                tmp2 = D.CountOneWall(tmp1);
                chart1.Series["Series1"].Points.AddXY(tmp1 ,tmp2);
            }

            if (button1.BackColor == Color.Red)
            {
                Application.Exit();
            }
            else
            {
                button1.Text = "Exit";
                button1.BackColor = Color.Red;
            }
        }

        private void FarOfTrapeze()  //count of basis of one trapeze
        {
            D.OnePartOfIntegral = (D.LimitUp - D.LimitDown) / D.CountOfTrapeze;
        }
    }
}
