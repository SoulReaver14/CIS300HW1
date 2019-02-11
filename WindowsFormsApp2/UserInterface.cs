using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    //User Interface Class
    public partial class UserInterface : Form
    {
        CalculatorModel _calculator;
        private string inputsequence;
        public UserInterface()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Occurs when the D button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxD_Click(object sender, EventArgs e)
        {
            //WORK ON THIS FIRST!!!!
            if(uxTextbox.Text.Length < 8)
            {
                uxTextbox.Text += "d";
            }
        }
        
        private void uxE_Click(object sender, EventArgs e)
        {
            //WORK ON THIS FIRST!!!!
            if (uxTextbox.Text.Length < 8)
            {
                uxTextbox.Text += "d";
            }
        }

        private void uxF_Click(object sender, EventArgs e)
        {
            //WORK ON THIS FIRST!!!!
            if (uxTextbox.Text.Length < 8)
            {
                uxTextbox.Text += "d";
            }
        }

        private void uxA_Click(object sender, EventArgs e)
        {
            //WORK ON THIS FIRST!!!!
            if (uxTextbox.Text.Length < 8)
            {
                uxTextbox.Text += "d";
            }
        }

        private void uxB_Click(object sender, EventArgs e)
        {
            //WORK ON THIS FIRST!!!!
            if (uxTextbox.Text.Length < 8)
            {
                uxTextbox.Text += "d";
            }
        }

        private void uxC_Click(object sender, EventArgs e)
        {
            //WORK ON THIS FIRST!!!!
            if (uxTextbox.Text.Length < 8)
            {
                uxTextbox.Text += "d";
            }
        }

        private void uxSeven_Click(object sender, EventArgs e)
        {
            //WORK ON THIS FIRST!!!!
            if (uxTextbox.Text.Length < 8)
            {
                uxTextbox.Text += "d";
            }
        }

        private void uxEight_Click(object sender, EventArgs e)
        {
            //WORK ON THIS FIRST!!!!
            if (uxTextbox.Text.Length < 8)
            {
                uxTextbox.Text += "d";
            }
        }

        private void uxNine_Click(object sender, EventArgs e)
        {
            //WORK ON THIS FIRST!!!!
            if (uxTextbox.Text.Length < 8)
            {
                uxTextbox.Text += "d";
            }
        }

        private void uxFour_Click(object sender, EventArgs e)
        {
            //WORK ON THIS FIRST!!!!
            if (uxTextbox.Text.Length < 8)
            {
                uxTextbox.Text += "d";
            }
        }

        private void uxFive_Click(object sender, EventArgs e)
        {
            //WORK ON THIS FIRST!!!!
            if (uxTextbox.Text.Length < 8)
            {
                uxTextbox.Text += "d";
            }
        }

        private void uxSix_Click(object sender, EventArgs e)
        {
            //WORK ON THIS FIRST!!!!
            if (uxTextbox.Text.Length < 8)
            {
                uxTextbox.Text += "d";
            }
        }

        private void uxOne_Click(object sender, EventArgs e)
        {
            //WORK ON THIS FIRST!!!!
            if (uxTextbox.Text.Length < 8)
            {
                uxTextbox.Text += "d";
            }
        }

        private void uxTwo_Click(object sender, EventArgs e)
        {
            //WORK ON THIS FIRST!!!!
            if (uxTextbox.Text.Length < 8)
            {
                uxTextbox.Text += "d";
            }
        }

        private void uxThree_Click(object sender, EventArgs e)
        {
            //WORK ON THIS FIRST!!!!
            if (uxTextbox.Text.Length < 8)
            {
                uxTextbox.Text += "d";
            }
        }

        private void uxZero_Click(object sender, EventArgs e)
        {
            //WORK ON THIS FIRST!!!!
            if (uxTextbox.Text.Length < 8)
            {
                uxTextbox.Text += "d";
            }
        }

        //BEGINNING OF THE ACTUAL METHOD

        /// <summary>
        /// Places an Open Parenthesis in the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpeningParenthesis_Click(object sender, EventArgs e)
        {
            uxTextbox.Text += "(";
        }

        /// <summary>
        /// Places a Closed Parenthesis in the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxClosingParenthesis_Click(object sender, EventArgs e)
        {
            uxTextbox.Text += ")";
        }

        /// <summary>
        /// Does the AND operation between the first Hex value and the Second Hex value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAnd_Click(object sender, EventArgs e)
        {
            string firstvalue = uxTextbox.Text;
            calculatorvalues.Push(firstvalue);
        }

        /// <summary>
        /// Does the OR operation between the first Hex value and the Second Hex value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOr_Click(object sender, EventArgs e)
        {
            string firstvalue = uxTextbox.Text;
            calculatorvalues.Push(firstvalue);
        }

        /// <summary>
        /// Does the XOR operation between the first Hex value and the Second Hex value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxXor_Click(object sender, EventArgs e)
        {
            string firstvalue = uxTextbox.Text;
            calculatorvalues.Push(firstvalue);
        }

        /// <summary>
        /// Does the NOT operation between the first Hex value and the Second Hex value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNot_Click(object sender, EventArgs e)
        {
            //REMEBER NOT IS DIFFERENT
            uxTextbox.Text += "NOT";
        }

        /// <summary>
        /// Places the final simplified answer into the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEquals_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Clears the text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxClear_Click(object sender, EventArgs e)
        {
            _calculator.Clear();
        }

        /// <summary>
        /// Grabs the information that is currently in the text box.
        /// </summary>
        private uint GetCurrentEntry()
        {
            return Convert.ToUInt32(inputsequence);
        }

        /// <summary>
        /// Shows the Calculated Value. (Call from uxEqual_Click)
        /// </summary>
        private void ShowCalculatedValue()
        {
            uxTextbox.Text = Convert.ToString(_calculator.CalculatedValue);
            inputsequence = "";
        }
    }

    //Calculator Model Class
    public class CalculatorModel
    {
        PartialOperation _expression;
        private Stack<PartialOperation> Partials = new Stack<PartialOperation>();
        public uint CalculatedValue { get; private set; }
        public CalculatorModel()
        {

        }
        public void Clear()
        {
        }
        private static uint Compute(string s, uint firstv, uint secondv)
        {
            if(s == "AND")
            {
                return (firstv & secondv);
            }
            else if(s == "OR")
            {
                return (firstv | secondv);
            }
            else
            {
                return (firstv ^ secondv);
            }
        }

        public void EnterBinaryOperator(uint value , string s)
        {
            //ASK FOR HELP HERE
            uint simplifiedvalue = Simplify(value, s);
            simplifiedvalue += Convert.ToUInt32(s);
            CalculatedValue = simplifiedvalue;
        }
        
        public void EnterCloseParenthesis(uint value)
        {
            Simplify(value, ")");
        }

        public void EnterEquals()
        {

        }

        public void EnterOpenParenthesis(uint newvalue)
        {
            CalculatedValue = (newvalue += Convert.ToUInt32("("));
        }
        //GET PRECEDENCE MUST BE WORKED ON
        private static int GetPrecedence(string s)
        {
            if(s == "NOT")
            {
                return 6;
            }
            else if(s == "AND")
            {
                return 5;
            }
            else if(s == "XOR")
            {
                return 4;
            }
            else if(s == "OR")
            {
                return 3;
            }
            else if(s == ")")
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        public void Negate(uint firstvalue)
        {
            CalculatedValue = (firstvalue ^ 0xffffffff);
        }
        private uint Simplify(uint firstv, string s)
        {
            //ASK FOR HELP
            //ASK FOR HELP
            _expression(firstv, s);
            Partials.Push(firstv , s);
            int precedence = GetPrecedence(s);
        }
    }

    //Partial Operation Class
    public class PartialOperation
    {
        public uint Operand { get; }
        public string Operator { get; }
        public PartialOperation(uint O, string Or)
        {
            Operand = O;
            Operator = Or;
        }
    }

}
