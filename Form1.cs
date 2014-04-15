using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Display1, Display2;
            float answer;


            Display1 = int.Parse(Disp1.Text);
           // Display2 = int.Parse(Disp2.Text);

           // answer = Display1 * Display2;
            //Display1 = int.Parse("10");



            //MessageBox.Show(answer.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Disp1.Text = ("1");
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void Disp2_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnPL_Click(object sender, EventArgs e)
        {
            int Display1, Display2;
            int answer;


            Display1 = int.Parse(Disp1.Text);
            //Display2 = int.Parse(Disp2.Text);

           // answer = Display1 + Display2;
            //Display1 = int.Parse("10");



          //  MessageBox.Show(answer.ToString());
        }


        private void btnMI_Click(object sender, EventArgs e)
        {
             int Display1, Display2;
            int answer;


            Display1 = int.Parse(Disp1.Text);
            //Display2 = int.Parse(Disp2.Text);

           // answer = Display1 - Display2;
            //Display1 = int.Parse("10");



           // MessageBox.Show(answer.ToString());
        }

        private void btnTI_Click(object sender, EventArgs e)
        {
            int Display1, Display2;
            int answer;


            Display1 = int.Parse(Disp1.Text);
            //Display2 = int.Parse(Disp2.Text);

          //  answer = Display1 * Display2;
            //Display1 = int.Parse("10");



           // MessageBox.Show(answer.ToString());
        }

        private void Disp1_TextChanged(object sender, EventArgs e)
        {
            int Display1;

            Display1 = int.Parse("10");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Disp1.Text = ("2");
        }
        
    }
}
