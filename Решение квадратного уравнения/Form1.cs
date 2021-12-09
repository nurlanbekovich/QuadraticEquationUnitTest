using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Решение_квадратного_уравнения;

namespace Решение_квадратного_уравнения
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findSolutionButton_Click(object sender, EventArgs e)
        {
            try
            {
                X1Result.Text = "";
                X2Result.Text = "";
                discResult.Text ="";
                CountRoots cnt = new CountRoots();
                List<double> result = new List<double>();
                result = cnt.сountRoots(ATextBox.Text, BTextBox.Text, CTextBox.Text);
                if (result.Count() == 2)
                {
                    discResult.Text = result[0].ToString();
                    X1Result.Text = result[1].ToString();
                    label7.Text = "";
                    //X2Result.Text = result[0].ToString();
                }
                else if (result.Count() == 3)
                {
                    discResult.Text = result[0].ToString();
                    X1Result.Text = result[1].ToString();
                    X2Result.Text = result[2].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cleanTextBoxButton_Click(object sender, EventArgs e)
        {
            ATextBox.Text = "";
            BTextBox.Text = "";
            CTextBox.Text = "";
            X1Result.Text = "";
            X2Result.Text = "";
            discResult.Text ="";
            label7.Text = "X2=";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
