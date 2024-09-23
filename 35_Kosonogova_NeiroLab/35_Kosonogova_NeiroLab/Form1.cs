using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35_Kosonogova_NeiroLab
{
    public partial class Form1 : Form
    {
        double[] matrix = new double[15];

        public Form1()
        {
            InitializeComponent();
            UpdateMatrixText();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            ChangeButtonState(clickedButton, Int32.Parse(clickedButton.Tag.ToString()));
        }


        private void ChangeButtonState(Button button, int index)
        {
            if(button.BackColor == Color.White)
            {
                button.BackColor = Color.Black;
                matrix[index] = 1;
            }
            else
            {
                button.BackColor = Color.White;
                matrix[index] = 0;
            }

            UpdateMatrixText();            
        }

        private void UpdateMatrixText()
        {
            string text = "";
            for (int i = 0; i < matrix.Length; i++)
            {
                if (i % 3 == 0)
                    text += "\n";
                text += $"{matrix[i]}    ";
            }

            matrixText.Text = text;

            matrixText.SelectAll();

            matrixText.SelectionAlignment = HorizontalAlignment.Center;

            matrixText.DeselectAll();
        }
    }
}
