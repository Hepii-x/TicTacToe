using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        List<string> fields = CreateEmptyFields();

        public Form1()
        {
            InitializeComponent();


            // Same event for buttons
            button1.Click += new EventHandler(multiBtnClick);
            button2.Click += new EventHandler(multiBtnClick);
            button3.Click += new EventHandler(multiBtnClick);
            button4.Click += new EventHandler(multiBtnClick);
            button5.Click += new EventHandler(multiBtnClick);
            button6.Click += new EventHandler(multiBtnClick);
            button7.Click += new EventHandler(multiBtnClick);
            button8.Click += new EventHandler(multiBtnClick);
            button9.Click += new EventHandler(multiBtnClick);
        }

        private void multiBtnClick(object sender, EventArgs e)
        {
            // Get clicked button
            Button clickedButton = (Button)sender;

            // check if field is empty
            if (fields[clickedButton.TabIndex] != "-")
            {
                Output.Text = "Niewłaściwy ruch!";
            }
            else
            {
                clickedButton.Text = "O";
                fields[clickedButton.TabIndex] = "O";
            }
        }

        // Create empty lists
        private static List<string> CreateEmptyFields()
        {
            List<string> fields = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                fields.Add("-");
            }
            Console.WriteLine(fields[8]);
            return fields;
        }

        private bool CheckWinnerPlayer()
        {
            // 123 fields
            if (fields[0] == "O" && fields[1] == "O" && fields[2] == "O")
                return true;
            // 456 fields
            else if (fields[3] == "O" && fields[4] == "O" && fields[5] == "O")
                return true;
            // 789 fields
            else if (fields[6] == "O" && fields[7] == "O" && fields[8] == "O")
                return true;
            // 147 fields
            else if (fields[0] == "O" && fields[3] == "O" && fields[6] == "O")
                return true;
            // 258 fields
            else if (fields[1] == "O" && fields[4] == "O" && fields[7] == "O")
                return true;
            // 369 fields
            else if (fields[2] == "O" && fields[5] == "O" && fields[8] == "O")
                return true;
            // 159 fields
            else if (fields[0] == "O" && fields[4] == "O" && fields[8] == "O")
                return true;
            // 357 fields
            else if (fields[2] == "O" && fields[4] == "O" && fields[6] == "O")
                return true;
            else
                return false;
        }

        private bool CheckWinnerPC()
        {
            // 123 fields
            if (fields[0] == "X" && fields[1] == "X" && fields[2] == "X")
                return true;
            // 456 fields
            else if (fields[3] == "X" && fields[4] == "X" && fields[5] == "X")
                return true;
            // 789 fields
            else if (fields[6] == "X" && fields[7] == "X" && fields[8] == "X")
                return true;
            // 147 fields
            else if (fields[0] == "X" && fields[3] == "X" && fields[6] == "X")
                return true;
            // 258 fields
            else if (fields[1] == "X" && fields[4] == "X" && fields[7] == "X")
                return true;
            // 369 fields
            else if (fields[2] == "X" && fields[5] == "X" && fields[8] == "X")
                return true;
            // 159 fields
            else if (fields[0] == "X" && fields[4] == "X" && fields[8] == "X")
                return true;
            // 357 fields
            else if (fields[2] == "X" && fields[4] == "X" && fields[6] == "X")
                return true;
            else
                return false;
        }

        private bool CheckDraw()
        {
            if (fields.Contains("-"))
                return false;
            else
                return true;
        }
    }
}
