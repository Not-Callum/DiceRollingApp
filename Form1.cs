using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRollingApp
{
    public partial class Form1 : Form
    {

        Random dice = new Random();

        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randNum1 = dice.Next(1,7);
            int randNum2 = dice.Next(1, 7);

            int totalNum1 = 0;
            int totalNum2 = 0;

            switch(randNum1)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Dices_Large_6;
                    totalNum1 = 1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Dices_Large_5;
                    totalNum1 = 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Dices_Large_4;
                    totalNum1 = 3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Dices_Large_3;
                    totalNum1 = 4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.Dices_Large_2;
                    totalNum1 = 5;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.Dices_Large_1;
                    totalNum1 = 6;
                    break;
                default:
                    pictureBox1.Image = Properties.Resources.Dices_Large_6;
                    totalNum1 = 1;
                    break;
            }

            switch(randNum2)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources.Dices_Large_6;
                    totalNum2 = 1;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.Dices_Large_5;
                    totalNum2 = 2;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.Dices_Large_4;
                    totalNum2 = 3;
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources.Dices_Large_3;
                    totalNum2 = 4;
                    break;
                case 5:
                    pictureBox2.Image = Properties.Resources.Dices_Large_2;
                    totalNum2 = 5;
                    break;
                case 6:
                    pictureBox2.Image = Properties.Resources.Dices_Large_1;
                    totalNum2 = 6;
                    break;
                default:
                    pictureBox2.Image = Properties.Resources.Dices_Large_6;
                    totalNum2 = 1;
                    break;
            }

            TotalText.Text = "Total = " + (totalNum1 += totalNum2).ToString();
        }
    }
}
