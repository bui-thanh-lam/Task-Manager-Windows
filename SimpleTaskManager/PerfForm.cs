using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;

namespace TaskManagerForm
{
    public partial class PerfForm : Form
    {
        public PerfForm()
        {
            InitializeComponent();
        }

        private void CPU_count() 
        {
            float fcpu = pCPU.NextValue();
            float fhandle = pHandle.NextValue();
            float fprocess = pProcess.NextValue();
            
            labelCPU.Text = string.Format("{0:0.00}%", fcpu);
            labelHandle.Text = string.Format("{0:0}", fhandle);
            labelProcess.Text = string.Format("{0:0}", fprocess);

            chartCPU.Series["CPU"].Points.AddY(fcpu);
        }

        private void RAM_count()
        {
            ComputerInfo cpI = new ComputerInfo();
            float fram = pRAM.NextValue();
            float framCmt = pRAMcmt.NextValue();
            float framAvai = pRAMavai.NextValue();
            float fCached = pCached.NextValue();
            float fPaged = pPaged.NextValue();
            float fNPaged = pNPaged.NextValue();
            float avaiRAM = cpI.TotalPhysicalMemory / (1024 * 1024 * 1024); //GB
            
            labelRAM.Text = string.Format("{0:0.0} GB", (fram / 100) * avaiRAM);
            labelCmt.Text = string.Format("{0:0.0} GB", framCmt / (1024 * 1024 * 1024));
            labelRamAvai.Text = string.Format("{0:0.0} GB", framAvai / 1024);
            labelCached.Text = string.Format("{0:0.0} GB", fCached / (1024 * 1024 * 1024));
            labelPaged.Text = string.Format("{0:0} MB", fPaged / (1024 * 1024));
            labelNPaged.Text = string.Format("{0:0} MB", fNPaged / (1024 * 1024));
            
            chartRAM.Series["RAM"].Points.AddY(fram);
        }

        private void DISK_count()
        {
            float fdisk = pDISK.NextValue();
            float fdRead = pReadSpd.NextValue();
            float fdWrite = pWriteSpd.NextValue();

            labelDiskUse.Text = string.Format("{0:0}%", fdisk);
            labelReadSpd.Text = string.Format("{0:0.0} KB/s", fdRead / 1024);
            labelWriteSpd.Text = string.Format("{0:0.0} KB/s", fdWrite / 1024);

            chartDiskUse.Series["DiskUse"].Points.AddY(fdisk);
            chartDiskRate.Series["DiskRead"].Points.AddY(fdRead);
            chartDiskRate.Series["DiskWrite"].Points.AddY(fdWrite);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CPU_count();
            RAM_count();
            DISK_count();
        }

        private void perfForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

    }
}
