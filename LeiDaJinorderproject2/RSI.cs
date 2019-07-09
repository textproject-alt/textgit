using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using System.IO;

namespace LeiDaJinorderproject2
{
    public partial class RSI : Form
    {
        public RSI()
        {
            InitializeComponent();
        }

        //定义收集过滤器信息的对象
        private FilterInfoCollection videoDevices;
        //定义视频源抓取类
        private VideoCaptureDevice cameraDevice;
      
       

        private void RSI_Deactivate(object sender, EventArgs e)
        {
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
        }

        private void RSI_FormClosed(object sender, FormClosedEventArgs e)
        {
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
        }

        private void RSI_Load(object sender, EventArgs e)
        {
            //加载所有摄像头
            //FilterCategory.VideoInputDevice视频输入设备类别7
            this.videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);//实例化过滤类

            //打开该摄像头
            if (null != cameraDevice)
            {
                videoSourcePlayer1.SignalToStop();
                videoSourcePlayer1.WaitForStop();

            }
            //实例化视频源抓取类    
            cameraDevice = new VideoCaptureDevice(this.videoDevices[0].MonikerString);//连接摄像头
            //cameraDevice.DesiredFrameSize = new Size(320, 240);
            //cameraDevice.DesiredFrameRate = 1;
            //把实例化好的cameraDevice类赋值到VideoSourcePlayer控件的VideoSource属性
            videoSourcePlayer1.VideoSource = cameraDevice;
            videoSourcePlayer1.Start();
        }

    
       

       
    }
}
