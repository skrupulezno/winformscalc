using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string Action1 = "";
        string Action2 = "";
        string opearation = "";
        bool isNotDone = true;
        int math1 = 0, math2 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isNotDone)
            {
                Action1 += "1";
            }
            else
            {
                Action2 += "1";
            }
            Output();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (isNotDone)
            {
                Action1 += "2";
            }
            else
            {
                Action2 += "2";
            }
            Output();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (isNotDone)
            {
                Action1 += "3";
            }
            else
            {
                Action2 += "3";
            }
            Output();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (isNotDone)
            {
                Action1 += "4";
            }
            else
            {
                Action2 += "4";
            }
            Output();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (isNotDone)
            {
                Action1 += "5";
            }
            else
            {
                Action2 += "5";
            }
            Output();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (isNotDone)
            {
                Action1 += "6";
            }
            else
            {
                Action2 += "6";
            }
            Output();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (isNotDone)
            {
                Action1 += "7";
            }
            else
            {
                Action2 += "7";
            }
            Output();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (isNotDone)
            {
                Action1 += "8";
            }
            else
            {
                Action2 += "8";
            }
            Output();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (isNotDone)
            {
                Action1 += "9";
            }
            else
            {
                Action2 += "9";
            }
            Output();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (isNotDone)
            {
                Action1 += "0";
            }
            else
            {
                Action2 += "0";
            }
            Output();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //+
            opearation = "+";
            isNotDone = false;
            Output();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //-
            opearation = "-";
            isNotDone = false;
            Output();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //=
            switch (opearation)
            {
                case "+":
                    {
                        math1 = Convert.ToInt32(Action1);
                        math2 = Convert.ToInt32(Action2);
                        Action1 = (math1 + math2).ToString();
                        Otvet();
                        Output();
                        break;

                    }
                case "-":
                    {
                        math1 = Convert.ToInt32(Action1);
                        math2 = Convert.ToInt32(Action2);
                        Action1 = (math1 - math2).ToString();
                        Otvet();
                        break;
                    }
                case "X":
                    {
                        math1 = Convert.ToInt32(Action1);
                        math2 = Convert.ToInt32(Action2);
                        Action1 = (math1 * math2).ToString();
                        Otvet();
                        break;
                    }
                case "÷":
                    {
                        double math1d = Convert.ToDouble(Action1);
                        double math2d = Convert.ToDouble(Action2);
                        Action1 = (math1d / math2d).ToString();
                        Otvet();
                        break;
                    }
            }
        }

        private void Otvet()
        {
            opearation = "";
            Action2 = "";
            isNotDone = true;
            Output();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            opearation = "X";
            isNotDone = false;
            Output();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            opearation = "÷";
            isNotDone = false;
            Output();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!isNotDone && Action2 != "")
            {
                Action2 = Action2.TrimEnd(Action2[Action2.Length - 1]);

            }
            else if (opearation != "")
            {
                opearation = "";
            }
            else if (Action1 != "")
            {
                Action1 = Action1.TrimEnd(Action1[Action1.Length - 1]);
            }
            Output();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Action1 = "";
            Action2 = "";
            opearation = "";
            Output();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!isNotDone && Action2 != "")
            {
                Action2 = "";

            }
            else if (opearation != "")
            {
                opearation = "";
            }
            else if (Action1 != "")
            {
                Action1 = "";
            }
            Output();
        }

        private void Output()
        {
            Console.WriteLine(Action1);
            label1.Text = $"{Action1} {opearation} {Action2}";
        }

       
    }
}
