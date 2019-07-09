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
    public partial class Starting : Form
    {
        public Starting()
        {
            InitializeComponent();
            
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            Ohm ohm = new Ohm();
            ohm.MdiParent = this;
            ohm.Parent = panel1;
            panel1.Controls.Add(ohm);
            ohm.Show();
            panel1.BringToFront();
            panel2.Location = panel1.Location;
            panel3.Location = panel1.Location;
            panel4.Location = panel1.Location;
            panel5.Location = panel1.Location;
            panel6.Location = panel1.Location;
            panel2.Size = panel1.Size;
            panel3.Size = panel1.Size;
            panel4.Size = panel1.Size;
            panel5.Size = panel1.Size;
            panel6.Size = panel1.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PanelNowShow(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelNowShow(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelNowShow(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PanelNowShow(4);

        }

        public void button5_Click(object sender, EventArgs e)
        {
            PanelNowShow(5);
        }
      

        private void button6_Click(object sender, EventArgs e)
        {
            PanelNowShow(6);
        }

        private void PanelNowShow(int buttonNum) 
        {
            switch (buttonNum)
            {
                case 1:
                    Ohm ohm = new Ohm();
                    ohm.MdiParent = this;
                    ohm.Parent = panel1;
                    panel1.Controls.Add(ohm);
                    ohm.Show();
                    panel1.BringToFront();
                    button1.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击后ohm.png");
                    button2.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前VRL.png");
                    button3.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前VRD.png");
                    button4.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前RSI.png");
                    button5.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前Setting.png");
                    button6.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前Help.png");
                    break;

                case 2:
                 
                    panel2.Visible = true;
                    VPL vpl = new VPL();
                    vpl.MdiParent = this;
                    vpl.Parent = panel2;
                    panel2.Controls.Add(vpl);
                    vpl.Show();
                    panel2.BringToFront();
                    button1.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前ohm.png");
                    button2.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击后VRL.png");
                    button3.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前VRD.png");
                    button4.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前RSI.png");
                    button5.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前Setting.png");
                    button6.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前Help.png");
                    break;

                case 3:
                  
                    panel3.Visible = true;
                    VRD vrd = new VRD();
                    vrd.MdiParent = this;
                    vrd.Parent = panel3;
                    panel3.Controls.Add(vrd);
                    vrd.Show();
                    panel3.BringToFront();
                    button1.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前ohm.png");
                    button2.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前VRL.png");
                    button3.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击后VRD.png");
                    button4.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前RSI.png");
                    button5.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前Setting.png");
                    button6.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前Help.png");
                    break;

                case 4:
                   
                    panel4.Visible = true;
                    RSI rsi = new RSI();
                    rsi.MdiParent = this;
                    rsi.Parent = panel4;
                    panel4.Controls.Add(rsi);
                    rsi.Show();
                    panel4.BringToFront();
                    button4.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击后RSI.png");
                    button1.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前ohm.png");
                    button2.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前VRL.png");
                    button3.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前VRD.png");
                    button5.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前Setting.png");
                    button6.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前Help.png");
                    break;

                case 5:
                  
                    panel5.Visible = true;
                    Setting setting = new Setting();
                    setting.MdiParent = this;
                    setting.Parent = panel5;
                    panel5.Controls.Add(setting);
                    setting.Show();
                    panel5.BringToFront();
                    button5.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击后Setting.png");
                    button1.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前ohm.png");
                    button2.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前VRL.png");
                    button3.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前VRD.png");
                    button4.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前RSI.png");
                    button6.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前Help.png");
                    break;

                case 6:
                  
                    panel6.Visible = true;
                    Help help = new Help();
                    help.MdiParent = this;
                    help.Parent = panel6;
                    panel6.Controls.Add(help);
                    help.Show();
                    panel6.BringToFront();
                    button6.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击后Help.png");
                    button1.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前ohm.png");
                    button2.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前VRL.png");
                    button3.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前VRD.png");
                    button4.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前RSI.png");
                    button5.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\点击前Setting.png");
                    break;


            
            }
        
        }

       
      

       
    }
}
