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
    public partial class Newpassword : Form
    {
        public Newpassword()
        {
            InitializeComponent();
        }

        Setting setting = new Setting();

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Form form in Application.OpenForms)
            {
                if(form.GetType()==typeof(Setting))
                {
                    setting = (Setting)form;
                    setting.SetPanel3Visible();
                
                }
            
            }
    
            
        }

       

       

        
    }
}
