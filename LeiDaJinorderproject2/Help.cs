using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeiDaJinorderproject2
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_MouseDown_1(object sender, MouseEventArgs e)
        {
            button4.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\图片2.png");
        }

        private void button2_MouseDown_1(object sender, MouseEventArgs e)
        {
            button2.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\图片7.png");
        }

        private void button3_MouseDown_1(object sender, MouseEventArgs e)
        {
            button3.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\图片8.png");
        }

        private void Help_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel1.BringToFront();
            panel2.Size = panel1.Size;
            panel2.Location = panel1.Location;
            panel3.Size = panel1.Size;
            panel3.Location = panel1.Location;
            panel4.Size = panel1.Size;
            panel4.Location = panel1.Location;
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            button4.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\图片3.png");
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\图片9.png");
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            button3.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\图片12.png");
        }

      

       
    }
}
