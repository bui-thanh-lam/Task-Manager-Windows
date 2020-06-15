namespace SimpleTaskManager
{
    partial class PerfForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabPerformance = new System.Windows.Forms.TabControl();
            this.tabCPU = new System.Windows.Forms.TabPage();
            this.chartCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.labelProcess = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelHandle = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRAM = new System.Windows.Forms.TabPage();
            this.labelCmt = new System.Windows.Forms.Label();
            this.labelNPaged = new System.Windows.Forms.Label();
            this.labelPaged = new System.Windows.Forms.Label();
            this.labelCached = new System.Windows.Forms.Label();
            this.labelRamAvai = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartRAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabDisk = new System.Windows.Forms.TabPage();
            this.labelWriteSpd = new System.Windows.Forms.Label();
            this.labelReadSpd = new System.Windows.Forms.Label();
            this.labelDiskUse = new System.Windows.Forms.Label();
            this.chartDiskRate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chartDiskUse = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.tabInternet = new System.Windows.Forms.TabPage();
            this.labelNetworkType = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelNetR = new System.Windows.Forms.Label();
            this.labelNetS = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.chartInternet = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pDISK = new System.Diagnostics.PerformanceCounter();
            this.pReadSpd = new System.Diagnostics.PerformanceCounter();
            this.pWriteSpd = new System.Diagnostics.PerformanceCounter();
            this.pRAMcmt = new System.Diagnostics.PerformanceCounter();
            this.pRAMavai = new System.Diagnostics.PerformanceCounter();
            this.pCached = new System.Diagnostics.PerformanceCounter();
            this.pPaged = new System.Diagnostics.PerformanceCounter();
            this.pNPaged = new System.Diagnostics.PerformanceCounter();
            this.pHandle = new System.Diagnostics.PerformanceCounter();
            this.pProcess = new System.Diagnostics.PerformanceCounter();
            this.tabPerformance.SuspendLayout();
            this.tabCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).BeginInit();
            this.tabRAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRAM)).BeginInit();
            this.tabDisk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiskRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiskUse)).BeginInit();
            this.tabInternet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartInternet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDISK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReadSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWriteSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAMcmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAMavai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCached)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPaged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNPaged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHandle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPerformance
            // 
            this.tabPerformance.AccessibleDescription = "";
            this.tabPerformance.Controls.Add(this.tabCPU);
            this.tabPerformance.Controls.Add(this.tabRAM);
            this.tabPerformance.Controls.Add(this.tabDisk);
            this.tabPerformance.Controls.Add(this.tabInternet);
            this.tabPerformance.Location = new System.Drawing.Point(12, 12);
            this.tabPerformance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPerformance.Name = "tabPerformance";
            this.tabPerformance.RightToLeftLayout = true;
            this.tabPerformance.SelectedIndex = 0;
            this.tabPerformance.Size = new System.Drawing.Size(743, 578);
            this.tabPerformance.TabIndex = 0;
            // 
            // tabCPU
            // 
            this.tabCPU.BackColor = System.Drawing.Color.Moccasin;
            this.tabCPU.Controls.Add(this.chartCPU);
            this.tabCPU.Controls.Add(this.label2);
            this.tabCPU.Controls.Add(this.labelProcess);
            this.tabCPU.Controls.Add(this.label16);
            this.tabCPU.Controls.Add(this.labelHandle);
            this.tabCPU.Controls.Add(this.label10);
            this.tabCPU.Controls.Add(this.labelCPU);
            this.tabCPU.Controls.Add(this.label1);
            this.tabCPU.Location = new System.Drawing.Point(4, 25);
            this.tabCPU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCPU.Name = "tabCPU";
            this.tabCPU.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCPU.Size = new System.Drawing.Size(735, 549);
            this.tabCPU.TabIndex = 0;
            this.tabCPU.Text = "  CPU";
            // 
            // chartCPU
            // 
            this.chartCPU.BackColor = System.Drawing.Color.PapayaWhip;
            chartArea12.AxisY.Maximum = 100D;
            chartArea12.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            chartArea12.Name = "ChartArea1";
            this.chartCPU.ChartAreas.Add(chartArea12);
            this.chartCPU.Location = new System.Drawing.Point(17, 47);
            this.chartCPU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartCPU.Name = "chartCPU";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series17.Name = "CPU";
            this.chartCPU.Series.Add(series17);
            this.chartCPU.Size = new System.Drawing.Size(700, 300);
            this.chartCPU.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "% Utilization";
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcess.Location = new System.Drawing.Point(424, 424);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(26, 29);
            this.labelProcess.TabIndex = 0;
            this.labelProcess.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(423, 390);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Threads";
            // 
            // labelHandle
            // 
            this.labelHandle.AutoSize = true;
            this.labelHandle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHandle.Location = new System.Drawing.Point(248, 424);
            this.labelHandle.Name = "labelHandle";
            this.labelHandle.Size = new System.Drawing.Size(26, 29);
            this.labelHandle.TabIndex = 0;
            this.labelHandle.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(247, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Handle";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPU.Location = new System.Drawing.Point(62, 424);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(54, 29);
            this.labelCPU.TabIndex = 0;
            this.labelCPU.Text = "0 %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilization";
            // 
            // tabRAM
            // 
            this.tabRAM.BackColor = System.Drawing.Color.Moccasin;
            this.tabRAM.Controls.Add(this.labelCmt);
            this.tabRAM.Controls.Add(this.labelNPaged);
            this.tabRAM.Controls.Add(this.labelPaged);
            this.tabRAM.Controls.Add(this.labelCached);
            this.tabRAM.Controls.Add(this.labelRamAvai);
            this.tabRAM.Controls.Add(this.labelRAM);
            this.tabRAM.Controls.Add(this.label7);
            this.tabRAM.Controls.Add(this.label14);
            this.tabRAM.Controls.Add(this.label13);
            this.tabRAM.Controls.Add(this.label12);
            this.tabRAM.Controls.Add(this.label11);
            this.tabRAM.Controls.Add(this.label4);
            this.tabRAM.Controls.Add(this.label3);
            this.tabRAM.Controls.Add(this.chartRAM);
            this.tabRAM.Location = new System.Drawing.Point(4, 25);
            this.tabRAM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRAM.Name = "tabRAM";
            this.tabRAM.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRAM.Size = new System.Drawing.Size(735, 549);
            this.tabRAM.TabIndex = 1;
            this.tabRAM.Text = "RAM";
            // 
            // labelCmt
            // 
            this.labelCmt.AutoSize = true;
            this.labelCmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCmt.Location = new System.Drawing.Point(59, 483);
            this.labelCmt.Name = "labelCmt";
            this.labelCmt.Size = new System.Drawing.Size(66, 29);
            this.labelCmt.TabIndex = 1;
            this.labelCmt.Text = "0 GB";
            // 
            // labelNPaged
            // 
            this.labelNPaged.AutoSize = true;
            this.labelNPaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNPaged.Location = new System.Drawing.Point(506, 483);
            this.labelNPaged.Name = "labelNPaged";
            this.labelNPaged.Size = new System.Drawing.Size(68, 29);
            this.labelNPaged.TabIndex = 1;
            this.labelNPaged.Text = "0 MB";
            // 
            // labelPaged
            // 
            this.labelPaged.AutoSize = true;
            this.labelPaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaged.Location = new System.Drawing.Point(284, 483);
            this.labelPaged.Name = "labelPaged";
            this.labelPaged.Size = new System.Drawing.Size(68, 29);
            this.labelPaged.TabIndex = 1;
            this.labelPaged.Text = "0 MB";
            // 
            // labelCached
            // 
            this.labelCached.AutoSize = true;
            this.labelCached.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCached.Location = new System.Drawing.Point(506, 406);
            this.labelCached.Name = "labelCached";
            this.labelCached.Size = new System.Drawing.Size(66, 29);
            this.labelCached.TabIndex = 1;
            this.labelCached.Text = "0 GB";
            // 
            // labelRamAvai
            // 
            this.labelRamAvai.AutoSize = true;
            this.labelRamAvai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRamAvai.Location = new System.Drawing.Point(284, 406);
            this.labelRamAvai.Name = "labelRamAvai";
            this.labelRamAvai.Size = new System.Drawing.Size(66, 29);
            this.labelRamAvai.TabIndex = 1;
            this.labelRamAvai.Text = "0 GB";
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRAM.Location = new System.Drawing.Point(59, 406);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(66, 29);
            this.labelRAM.TabIndex = 1;
            this.labelRAM.Text = "0 GB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Committed";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(506, 455);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Non-paged pool";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(506, 374);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Cached";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(285, 455);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Paged pool";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(285, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Available";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "In use";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "% Memory Usage";
            // 
            // chartRAM
            // 
            this.chartRAM.BackColor = System.Drawing.Color.PapayaWhip;
            chartArea13.AxisY.Maximum = 100D;
            chartArea13.Name = "ChartArea1";
            this.chartRAM.ChartAreas.Add(chartArea13);
            legend10.Enabled = false;
            legend10.Name = "Legend1";
            this.chartRAM.Legends.Add(legend10);
            this.chartRAM.Location = new System.Drawing.Point(15, 49);
            this.chartRAM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartRAM.Name = "chartRAM";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Legend = "Legend1";
            series18.Name = "RAM";
            this.chartRAM.Series.Add(series18);
            this.chartRAM.Size = new System.Drawing.Size(700, 300);
            this.chartRAM.TabIndex = 0;
            this.chartRAM.Text = "chartRAM";
            // 
            // tabDisk
            // 
            this.tabDisk.BackColor = System.Drawing.Color.Moccasin;
            this.tabDisk.Controls.Add(this.labelWriteSpd);
            this.tabDisk.Controls.Add(this.labelReadSpd);
            this.tabDisk.Controls.Add(this.labelDiskUse);
            this.tabDisk.Controls.Add(this.chartDiskRate);
            this.tabDisk.Controls.Add(this.label9);
            this.tabDisk.Controls.Add(this.label8);
            this.tabDisk.Controls.Add(this.label6);
            this.tabDisk.Controls.Add(this.chartDiskUse);
            this.tabDisk.Controls.Add(this.label5);
            this.tabDisk.Location = new System.Drawing.Point(4, 25);
            this.tabDisk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDisk.Name = "tabDisk";
            this.tabDisk.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDisk.Size = new System.Drawing.Size(735, 549);
            this.tabDisk.TabIndex = 2;
            this.tabDisk.Text = "Disk";
            // 
            // labelWriteSpd
            // 
            this.labelWriteSpd.AutoSize = true;
            this.labelWriteSpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWriteSpd.Location = new System.Drawing.Point(371, 504);
            this.labelWriteSpd.Name = "labelWriteSpd";
            this.labelWriteSpd.Size = new System.Drawing.Size(83, 29);
            this.labelWriteSpd.TabIndex = 4;
            this.labelWriteSpd.Text = "0 KB/s";
            // 
            // labelReadSpd
            // 
            this.labelReadSpd.AutoSize = true;
            this.labelReadSpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReadSpd.Location = new System.Drawing.Point(215, 504);
            this.labelReadSpd.Name = "labelReadSpd";
            this.labelReadSpd.Size = new System.Drawing.Size(83, 29);
            this.labelReadSpd.TabIndex = 4;
            this.labelReadSpd.Text = "0 KB/s";
            // 
            // labelDiskUse
            // 
            this.labelDiskUse.AutoSize = true;
            this.labelDiskUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiskUse.Location = new System.Drawing.Point(62, 504);
            this.labelDiskUse.Name = "labelDiskUse";
            this.labelDiskUse.Size = new System.Drawing.Size(48, 29);
            this.labelDiskUse.TabIndex = 4;
            this.labelDiskUse.Text = "0%";
            // 
            // chartDiskRate
            // 
            this.chartDiskRate.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            this.chartDiskRate.BackColor = System.Drawing.Color.PapayaWhip;
            chartArea14.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea14.Name = "ChartArea1";
            this.chartDiskRate.ChartAreas.Add(chartArea14);
            legend11.Enabled = false;
            legend11.Name = "Legend1";
            this.chartDiskRate.Legends.Add(legend11);
            this.chartDiskRate.Location = new System.Drawing.Point(17, 350);
            this.chartDiskRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartDiskRate.Name = "chartDiskRate";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.IsVisibleInLegend = false;
            series19.Legend = "Legend1";
            series19.Name = "DiskRead";
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Legend = "Legend1";
            series20.Name = "DiskWrite";
            this.chartDiskRate.Series.Add(series19);
            this.chartDiskRate.Series.Add(series20);
            this.chartDiskRate.Size = new System.Drawing.Size(700, 117);
            this.chartDiskRate.TabIndex = 3;
            this.chartDiskRate.Text = "chart2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(372, 480);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Write speed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(216, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Read speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Active time";
            // 
            // chartDiskUse
            // 
            this.chartDiskUse.BackColor = System.Drawing.Color.PapayaWhip;
            chartArea15.Name = "ChartArea1";
            this.chartDiskUse.ChartAreas.Add(chartArea15);
            legend12.Enabled = false;
            legend12.Name = "Legend1";
            this.chartDiskUse.Legends.Add(legend12);
            this.chartDiskUse.Location = new System.Drawing.Point(17, 44);
            this.chartDiskUse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartDiskUse.Name = "chartDiskUse";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Legend = "Legend1";
            series21.Name = "DiskUse";
            this.chartDiskUse.Series.Add(series21);
            this.chartDiskUse.Size = new System.Drawing.Size(700, 300);
            this.chartDiskUse.TabIndex = 1;
            this.chartDiskUse.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "% Active Time";
            // 
            // tabInternet
            // 
            this.tabInternet.BackColor = System.Drawing.Color.Moccasin;
            this.tabInternet.Controls.Add(this.labelNetworkType);
            this.tabInternet.Controls.Add(this.label19);
            this.tabInternet.Controls.Add(this.labelNetR);
            this.tabInternet.Controls.Add(this.labelNetS);
            this.tabInternet.Controls.Add(this.label18);
            this.tabInternet.Controls.Add(this.label17);
            this.tabInternet.Controls.Add(this.label15);
            this.tabInternet.Controls.Add(this.chartInternet);
            this.tabInternet.Location = new System.Drawing.Point(4, 25);
            this.tabInternet.Name = "tabInternet";
            this.tabInternet.Size = new System.Drawing.Size(735, 549);
            this.tabInternet.TabIndex = 3;
            this.tabInternet.Text = "Internet";
            // 
            // labelNetworkType
            // 
            this.labelNetworkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetworkType.Location = new System.Drawing.Point(269, 408);
            this.labelNetworkType.Name = "labelNetworkType";
            this.labelNetworkType.Size = new System.Drawing.Size(444, 113);
            this.labelNetworkType.TabIndex = 5;
            this.labelNetworkType.Text = "Network Information";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(270, 377);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 20);
            this.label19.TabIndex = 4;
            this.label19.Text = "Active NIC";
            // 
            // labelNetR
            // 
            this.labelNetR.AutoSize = true;
            this.labelNetR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetR.Location = new System.Drawing.Point(56, 492);
            this.labelNetR.Name = "labelNetR";
            this.labelNetR.Size = new System.Drawing.Size(88, 29);
            this.labelNetR.TabIndex = 3;
            this.labelNetR.Text = "0 Kbps";
            // 
            // labelNetS
            // 
            this.labelNetS.AutoSize = true;
            this.labelNetS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetS.Location = new System.Drawing.Point(56, 408);
            this.labelNetS.Name = "labelNetS";
            this.labelNetS.Size = new System.Drawing.Size(88, 29);
            this.labelNetS.TabIndex = 3;
            this.labelNetS.Text = "0 Kbps";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(57, 460);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "Receive";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(57, 377);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "Send";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(51, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Throughput";
            // 
            // chartInternet
            // 
            this.chartInternet.BackColor = System.Drawing.Color.PapayaWhip;
            chartArea11.Name = "ChartArea1";
            this.chartInternet.ChartAreas.Add(chartArea11);
            legend9.Enabled = false;
            legend9.Name = "Legend1";
            this.chartInternet.Legends.Add(legend9);
            this.chartInternet.Location = new System.Drawing.Point(13, 48);
            this.chartInternet.Name = "chartInternet";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.IsVisibleInLegend = false;
            series15.Legend = "Legend1";
            series15.Name = "Send";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.IsVisibleInLegend = false;
            series16.Legend = "Legend1";
            series16.Name = "Receive";
            this.chartInternet.Series.Add(series15);
            this.chartInternet.Series.Add(series16);
            this.chartInternet.Size = new System.Drawing.Size(700, 300);
            this.chartInternet.TabIndex = 0;
            this.chartInternet.Text = "chart1";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pDISK
            // 
            this.pDISK.CategoryName = "PhysicalDisk";
            this.pDISK.CounterName = "% Disk Time";
            this.pDISK.InstanceName = "_Total";
            // 
            // pReadSpd
            // 
            this.pReadSpd.CategoryName = "PhysicalDisk";
            this.pReadSpd.CounterName = "Disk Read Bytes/sec";
            this.pReadSpd.InstanceName = "_Total";
            // 
            // pWriteSpd
            // 
            this.pWriteSpd.CategoryName = "PhysicalDisk";
            this.pWriteSpd.CounterName = "Disk Write Bytes/sec";
            this.pWriteSpd.InstanceName = "_Total";
            // 
            // pRAMcmt
            // 
            this.pRAMcmt.CategoryName = "Memory";
            this.pRAMcmt.CounterName = "Committed Bytes";
            // 
            // pRAMavai
            // 
            this.pRAMavai.CategoryName = "Memory";
            this.pRAMavai.CounterName = "Available MBytes";
            // 
            // pCached
            // 
            this.pCached.CategoryName = "Memory";
            this.pCached.CounterName = "Cache Bytes";
            // 
            // pPaged
            // 
            this.pPaged.CategoryName = "Memory";
            this.pPaged.CounterName = "Pool Paged Bytes";
            // 
            // pNPaged
            // 
            this.pNPaged.CategoryName = "Memory";
            this.pNPaged.CounterName = "Pool Nonpaged Bytes";
            // 
            // pHandle
            // 
            this.pHandle.CategoryName = "Process";
            this.pHandle.CounterName = "Handle Count";
            this.pHandle.InstanceName = "_Total";
            // 
            // pProcess
            // 
            this.pProcess.CategoryName = "Process";
            this.pProcess.CounterName = "Thread Count";
            this.pProcess.InstanceName = "_Total";
            // 
            // PerfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 603);
            this.Controls.Add(this.tabPerformance);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PerfForm";
            this.Text = "Performance";
            this.Load += new System.EventHandler(this.perfForm_Load);
            this.tabPerformance.ResumeLayout(false);
            this.tabCPU.ResumeLayout(false);
            this.tabCPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).EndInit();
            this.tabRAM.ResumeLayout(false);
            this.tabRAM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRAM)).EndInit();
            this.tabDisk.ResumeLayout(false);
            this.tabDisk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiskRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiskUse)).EndInit();
            this.tabInternet.ResumeLayout(false);
            this.tabInternet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartInternet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDISK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReadSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWriteSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAMcmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAMavai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCached)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPaged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNPaged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHandle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabRAM;
        private System.Windows.Forms.TabPage tabDisk;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRAM;
        private System.Windows.Forms.Label label3;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDiskUse;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiskRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiskUse;
        private System.Windows.Forms.Label label5;
        private System.Diagnostics.PerformanceCounter pDISK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelWriteSpd;
        private System.Windows.Forms.Label labelReadSpd;
        private System.Diagnostics.PerformanceCounter pReadSpd;
        private System.Diagnostics.PerformanceCounter pWriteSpd;
        private System.Diagnostics.PerformanceCounter pRAMcmt;
        private System.Windows.Forms.Label labelCmt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelRamAvai;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelNPaged;
        private System.Windows.Forms.Label labelPaged;
        private System.Windows.Forms.Label labelCached;
        private System.Diagnostics.PerformanceCounter pRAMavai;
        private System.Diagnostics.PerformanceCounter pCached;
        private System.Diagnostics.PerformanceCounter pPaged;
        private System.Diagnostics.PerformanceCounter pNPaged;
        private System.Diagnostics.PerformanceCounter pHandle;
        private System.Diagnostics.PerformanceCounter pProcess;
        private System.Windows.Forms.TabPage tabCPU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelHandle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabPerformance;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInternet;
        private System.Windows.Forms.Label labelNetR;
        private System.Windows.Forms.Label labelNetS;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabInternet;
        private System.Windows.Forms.Label labelNetworkType;
        private System.Windows.Forms.Label label19;
    }
}