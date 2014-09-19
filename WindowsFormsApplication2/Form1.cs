using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

    


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) 
        {
            isDragging = true;

            currentX = e.X;
            currentY = e.Y;
            L_name.Text = "名稱";
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                pictureBox1.Top = pictureBox1.Top + (e.Y - currentY);
                pictureBox1.Left = pictureBox1.Left + (e.X - currentX);
            }
            else 
            {
                L_name.Text = "名稱 測試!";
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            L_name.Text = "名稱";
            Console.WriteLine(dropRect.Contains(pictureBox1.Bounds));
            
        }

        
     
    }
}
