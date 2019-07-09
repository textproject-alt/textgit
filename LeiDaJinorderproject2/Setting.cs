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
    public partial class Setting : Form
    {

      
        public Setting()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载事件使其Setting窗体显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Setting_Load(object sender, EventArgs e)
        {
            panel1.Visible=true;
            panel2.Visible=false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Location=panel1.Location;
            panel3.Location = panel1.Location;
            panel4.Location = panel1.Location;
            panel2.Size=panel1.Size;
            panel3.Size = panel1.Size;
            panel4.Size = panel1.Size;
            panel1.BringToFront();
        }
        /// <summary>
        /// 点击使initial窗体显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel2.BringToFront();
            initial initial = new initial();
            initial.TopLevel = false;
            initial.Parent = panel2;
            panel2.Controls.Add(initial);
            initial.Show();


        }
      /// <summary>
      /// initial窗体中点击返回按钮回到Setting窗体方法
      /// </summary>
        public void SetPanelVisible()
        {
            panel2.Visible = false;
            panel1.Visible = true;
            panel1.BringToFront();
            panel2.SendToBack();
        
        }
        /// <summary>
        /// 点击使calibration窗体显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel1.Visible = false;
            panel3.BringToFront();
            calibration cali = new calibration();
            cali.TopLevel = false;
            cali.Parent = panel3;
            panel3.Controls.Add(cali);
            cali.Show();

        }
        /// <summary>
        /// calibration窗体中点击返回按钮回到Setting窗体方法
        /// </summary>
        public void SetPanel2Visible()
        {
            panel1.Visible = true;
            panel3.Visible = false;
            panel1.BringToFront();
            panel3.SendToBack();
        
        
        }
        /// <summary>
        /// 点击使Newpassword窗体显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel1.Visible = false;
            panel4.BringToFront();
            Newpassword newpwd = new Newpassword();
            newpwd.TopLevel = false;
            newpwd.Parent = panel4;
            panel4.Controls.Add(newpwd);
            newpwd.Show();
        }
        /// <summary>
        /// Newpassword窗体中点击返回按钮回到Setting窗体方法
        /// </summary>
        public void SetPanel3Visible()
        {
            panel1.Visible = true;
            panel4.Visible = false;
            panel1.BringToFront();
            panel4.SendToBack();
        
        }

        private void button4_MouseDown_1(object sender, MouseEventArgs e)
        {
            button4.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\图片11.png");
        }

        private void button1_MouseDown_1(object sender, MouseEventArgs e)
        {
            button1.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\图片26.png");
        }

        private void button2_MouseDown_1(object sender, MouseEventArgs e)
        {
            button2.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\图片27.png");
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            button4.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\图片10.png");
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\图片28.png");
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\图片29.png");
        }

    

      

     

       

     
       
        }

      

       

       
    
}
