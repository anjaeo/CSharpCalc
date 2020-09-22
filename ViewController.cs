using Foundation;
using System;
using UIKit;

namespace test1
{
    public partial class ViewController : UIViewController
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void Zero_TouchUpInside(UIButton sender)
        {
            this.display.Text = "";
            input += "0";
            this.display.Text += input;
        }

        partial void One_TouchUpInside(UIButton sender)
        {
            this.display.Text = "";
            input += "1";
            this.display.Text += input;
        }

        partial void Two_TouchUpInside(UIButton sender)
        {
            this.display.Text = "";
            input += "2";
            this.display.Text += input;
        }

        partial void Three_TouchUpInside(UIButton sender)
        {
            this.display.Text = "";
            input += "3";
            this.display.Text += input;
        }

        partial void Four_TouchUpInside(UIButton sender)
        {
            this.display.Text = "";
            input += "4";
            this.display.Text += input;
        }

        partial void Five_TouchUpInside(UIButton sender)
        {
            this.display.Text = "";
            input += "5";
            this.display.Text += input;
        }

        partial void Six_TouchUpInside(UIButton sender)
        {
            this.display.Text = "";
            input += "6";
            this.display.Text += input;
        }

        partial void Seven_TouchUpInside(UIButton sender)
        {
            this.display.Text = "";
            input += "7";
            this.display.Text += input;
        }

        partial void Eight_TouchUpInside(UIButton sender)
        {
            this.display.Text = "";
            input += "8";
            this.display.Text += input;
        }

        partial void Nine_TouchUpInside(UIButton sender)
        {
            this.display.Text = "";
            input += "9";
            this.display.Text += input;
        }

        partial void DecimalBtn_TouchUpInside(UIButton sender)
        {
            this.display.Text = "";
            input += ".";
            this.display.Text += input;
        }

        partial void ClearBtn_TouchUpInside(UIButton sender)
        {
            this.display.Text = "0";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        partial void DivideBtn_TouchUpInside(UIButton sender)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        partial void MultiplyBtn_TouchUpInside(UIButton sender)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        partial void SubtractBtn_TouchUpInside(UIButton sender)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        partial void AddBtn_TouchUpInside(UIButton sender)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        partial void EqualsBtn_TouchUpInside(UIButton sender)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            this.display.Text = "0";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;

            if (operation == '+')
            {
                result = num1 + num2;
                display.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                display.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                display.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    display.Text = result.ToString();
                }
                else
                {
                    display.Text = "DIV/Zero!";
                }

            }
        }

        
    }
}