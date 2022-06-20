using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SpielMitUhr
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch;
        string[] operators= {"+", "-", "*"};
        List<int> rightAnswers = new List<int>();
        List<int> wrongAnswers = new List<int>();
        Random random = new Random();
        string operation;
        string selectedOperator = "";
        string answer = "0";
        int num1=0;
        int num2=0;
        int result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void New_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();
            newOperation();
            

        }

        private void checkIt_button_Click(object sender, EventArgs e)
        {
            answer= antwort_box.Text;
            



            switch (selectedOperator)
            {
                case "+":
                    result= num1+num2;
                    break;
                case "-":
                    result= num1-num2;
                    break;
                case "*":
                    result= num1*num2;
                    break;
                    default:
                    break;

            }
            if (Convert.ToInt32(answer) == result)
            {
                rightAnswers.Add(Convert.ToInt32(answer));
                newOperation();
                result_label.Text=$"Congratulations! Your answer is correct :)\nYou have {rightAnswers.Count} correct answers.\nYou have {wrongAnswers.Count} wrong answers.";
                stopwatch.Stop();
                stopwatch.Start();
            }
            else
            {
                wrongAnswers.Add(Convert.ToInt32(answer));
                result_label.Text=$"Sorry! Your answer is wrong :(\nYou have {rightAnswers.Count} correct answers.\nYou have {wrongAnswers.Count} wrong answers.";
            }
            result_label.Visible= true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newOperation();
            stopwatch.Start();



        }
        public void newOperation()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
            antwort_box.Text="0";

            selectedOperator=$"{operators[random.Next(0, 3)]}";
            if (selectedOperator=="*")
            {
                num1=random.Next(1, 15);
                num2=random.Next(1, 15);
                operation=$"{num1} {selectedOperator} {num2}";

            }
            else
            {
                num1=random.Next(1, 100);
                num2=random.Next(1, 100);
                operation=$"{num1} {selectedOperator} {num2}";
            }

            aufgabe_lbl.Text=operation;
            if (selectedOperator=="*")
            {
                requiredTime_label.Text="required time :  45 sec";
                requiredTime_label.Visible=true;
            }
            else
            {
                requiredTime_label.Text="required time :  30 sec";
                requiredTime_label.Visible=true;

            }
            
            warch_label.Visible=true;
        }
        public void checkAnswer()
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            warch_label.Text=string.Format("{0:hh\\:mm\\:ss\\.ff}",stopwatch.Elapsed);
        }
    }
}
