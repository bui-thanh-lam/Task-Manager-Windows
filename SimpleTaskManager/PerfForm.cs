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
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimpleTaskManager
{
    public partial class PerfForm : Form
    {
        public PerfForm()
        {
            InitializeComponent();
        }

        private int count = 0;
        private PerformanceCounter pWifiS = new PerformanceCounter();
        private PerformanceCounter pWifiR = new PerformanceCounter();
        private PerformanceCounter pEthernetS = new PerformanceCounter();
        private PerformanceCounter pEthernetR = new PerformanceCounter();

        private void CPU_count(int count) // biểu diễn hiệu năng của CPU
        {
            float fcpu = pCPU.NextValue();
            float fhandle = pHandle.NextValue();
            float fprocess = pProcess.NextValue();

            labelCPU.Text = string.Format("{0:0.00}%", fcpu);
            labelHandle.Text = string.Format("{0:0}", fhandle);
            labelProcess.Text = string.Format("{0:0}", fprocess);

            if (count >= 60)
                chartCPU.Series["CPU"].Points.RemoveAt(0);
            chartCPU.Series["CPU"].Points.AddY(fcpu);
        }

        

        private void RAM_count(int count) // biểu diễn hiệu năng của RAM
        {
            ComputerInfo cpI = new ComputerInfo();
            float avaiRAM = cpI.TotalPhysicalMemory / (1024 * 1024 * 1024); //GB
            float fram = pRAM.NextValue();
            float framCmt = pRAMcmt.NextValue();
            float framAvai = pRAMavai.NextValue();
            float fCached = pCached.NextValue();
            float fPaged = pPaged.NextValue();
            float fNPaged = pNPaged.NextValue();


            labelRAM.Text = string.Format("{0:0.0} GB", (fram/100) * avaiRAM);
            labelCmt.Text = string.Format("{0:0.0} GB", framCmt / (1024 * 1024 * 1024));
            labelRamAvai.Text = string.Format("{0:0.0} GB", framAvai / 1024);
            labelCached.Text = string.Format("{0:0.0} GB", fCached / (1024 * 1024 * 1024));
            labelPaged.Text = string.Format("{0:0} MB", fPaged / (1024 * 1024));
            labelNPaged.Text = string.Format("{0:0} MB", fNPaged / (1024 * 1024));

            if (count >= 60)
                chartRAM.Series["RAM"].Points.RemoveAt(0);
            chartRAM.Series["RAM"].Points.AddY(fram);
        }

        private void DISK_count(int count) // biểu diễn hiệu năng của DISK
        {
            float fdisk = pDISK.NextValue();
            float fdRead = pReadSpd.NextValue();
            float fdWrite = pWriteSpd.NextValue();

            labelDiskUse.Text = string.Format("{0:0}%", fdisk);
            labelReadSpd.Text = string.Format("{0:0.0} KB/s", fdRead / 1024);
            labelWriteSpd.Text = string.Format("{0:0.0} KB/s", fdWrite / 1024);

            if (count >= 60)
            {
                chartDiskUse.Series["DiskUse"].Points.RemoveAt(0);
                chartDiskRate.Series["DiskRead"].Points.RemoveAt(0);
                chartDiskRate.Series["DiskWrite"].Points.RemoveAt(0);
            }
            chartDiskUse.Series["DiskUse"].Points.AddY(fdisk);
            chartDiskRate.Series["DiskRead"].Points.AddY(fdRead / 1024);
            chartDiskRate.Series["DiskWrite"].Points.AddY(fdWrite / 1024);
        }

        private void WIFI_count(int count) // biểu diễn hiệu thông số kết nối Wi-Fi
        { 
            String name = String.Copy(getWifiCard());
            Console.WriteLine(name);
            try
            {
                pWifiS.CategoryName = "Network Interface";
                pWifiS.CounterName = "Bytes Sent/sec";
                pWifiS.InstanceName = name;
                pWifiR.CategoryName = "Network Interface";
                pWifiR.CounterName = "Bytes Received/sec";
                pWifiR.InstanceName = name;
                float fsend = pWifiS.NextValue();
                float freceive = pWifiR.NextValue();

                labelWifiS.Text = string.Format("{0:0.0} Kbps", fsend * 8 / 1024);
                labelWifiR.Text = string.Format("{0:0.0} Kbps", freceive * 8 / 1024);

                if (count >= 60)
                {
                    chartWifi.Series["Send"].Points.RemoveAt(0);
                    chartWifi.Series["Receive"].Points.RemoveAt(0);
                }
                chartWifi.Series["Send"].Points.AddY(fsend * 8 / 1024);
                chartWifi.Series["Receive"].Points.AddY(freceive * 8 / 1024);
            } 
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }       
        }

        public String getWifiCard() // tìm tên Card Wi-Fi
        {
            string s = "";
            PerformanceCounterCategory category = new PerformanceCounterCategory("Network Interface");
            String[] instancename = category.GetInstanceNames();

            foreach (string name in instancename)
            {
                if (name.Contains("Wireless"))
                    s = String.Copy(name);
            }
            return s;
        }

        private void ETHERNET_count(int count) // biểu diễn hiệu thông số kết nối Ethernet
        {
            String name = String.Copy(getEthernetCard());
            Console.WriteLine(name);
            try
            {
                pEthernetS.CategoryName = "Network Interface";
                pEthernetS.CounterName = "Bytes Sent/sec";
                pEthernetS.InstanceName = name;
                pEthernetR.CategoryName = "Network Interface";
                pEthernetR.CounterName = "Bytes Received/sec";
                pEthernetR.InstanceName = name;
                float fsend = pEthernetS.NextValue();
                float freceive = pEthernetR.NextValue();

                labelEthernetS.Text = string.Format("{0:0.0} Kbps", fsend * 8 / 1024);
                labelEthernetR.Text = string.Format("{0:0.0} Kbps", freceive * 8 / 1024);

                if (count >= 60)
                {
                    chartEthernet.Series["Send"].Points.RemoveAt(0);
                    chartEthernet.Series["Receive"].Points.RemoveAt(0);
                }
                chartEthernet.Series["Send"].Points.AddY(fsend * 8 / 1024);
                chartEthernet.Series["Receive"].Points.AddY(freceive * 8 / 1024);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public String getEthernetCard() // tìm tên Card Ethernet
        {
            string s = "";
            PerformanceCounterCategory category = new PerformanceCounterCategory("Network Interface");
            String[] instancename = category.GetInstanceNames();

            foreach (string name in instancename)
            {
                if (name.Contains("Ethernet"))
                    s = String.Copy(name);
            }
            Console.WriteLine(s);
            return s;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            CPU_count(count);
            RAM_count(count);
            DISK_count(count);
            WIFI_count(count);
            ETHERNET_count(count);
            count++;
        }

        private void perfForm_Load(object sender, EventArgs e)
        {
            if (getWifiCard().Length == 0)
                tabPerformance.TabPages.Remove(tabWifi);
            if (getEthernetCard().Length == 0)
                tabPerformance.TabPages.Remove(tabWifi);
            timer.Start();
        }

    }
}
