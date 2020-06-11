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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea29 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series36 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea30 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend22 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea31 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend23 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series39 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea32 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend24 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series40 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.pNetSend = new System.Diagnostics.PerformanceCounter();
            this.pNetReceive = new System.Diagnostics.PerformanceCounter();
            this.labelCPUname = new System.Windows.Forms.Label();
            this.tabPerformance.SuspendLayout();
            this.tabCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).BeginInit();
            this.tabRAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRAM)).BeginInit();
            this.tabDisk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiskRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiskUse)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.pNetSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNetReceive)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPerformance
            // 
            this.tabPerformance.AccessibleDescription = "";
            this.tabPerformance.Controls.Add(this.tabCPU);
            this.tabPerformance.Controls.Add(this.tabRAM);
            this.tabPerformance.Controls.Add(this.tabDisk);
            this.tabPerformance.Location = new System.Drawing.Point(9, 10);
            this.tabPerformance.Margin = new System.Windows.Forms.Padding(2);
            this.tabPerformance.Name = "tabPerformance";
            this.tabPerformance.SelectedIndex = 0;
            this.tabPerformance.Size = new System.Drawing.Size(557, 470);
            this.tabPerformance.TabIndex = 0;
            // 
            // tabCPU
            // 
            this.tabCPU.Controls.Add(this.labelCPUname);
            this.tabCPU.Controls.Add(this.chartCPU);
            this.tabCPU.Controls.Add(this.label2);
            this.tabCPU.Controls.Add(this.labelProcess);
            this.tabCPU.Controls.Add(this.label16);
            this.tabCPU.Controls.Add(this.labelHandle);
            this.tabCPU.Controls.Add(this.label10);
            this.tabCPU.Controls.Add(this.labelCPU);
            this.tabCPU.Controls.Add(this.label1);
            this.tabCPU.Location = new System.Drawing.Point(4, 22);
            this.tabCPU.Margin = new System.Windows.Forms.Padding(2);
            this.tabCPU.Name = "tabCPU";
            this.tabCPU.Padding = new System.Windows.Forms.Padding(2);
            this.tabCPU.Size = new System.Drawing.Size(549, 444);
            this.tabCPU.TabIndex = 0;
            this.tabCPU.Text = "  CPU";
            this.tabCPU.UseVisualStyleBackColor = true;
            // 
            // chartCPU
            // 
            chartArea29.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            chartArea29.Name = "ChartArea1";
            this.chartCPU.ChartAreas.Add(chartArea29);
            this.chartCPU.Location = new System.Drawing.Point(13, 38);
            this.chartCPU.Margin = new System.Windows.Forms.Padding(2);
            this.chartCPU.Name = "chartCPU";
            series36.ChartArea = "ChartArea1";
            series36.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series36.Name = "CPU";
            this.chartCPU.Series.Add(series36);
            this.chartCPU.Size = new System.Drawing.Size(525, 244);
            this.chartCPU.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "% Utilization";
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcess.Location = new System.Drawing.Point(336, 333);
            this.labelProcess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(14, 15);
            this.labelProcess.TabIndex = 0;
            this.labelProcess.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(326, 307);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Process";
            // 
            // labelHandle
            // 
            this.labelHandle.AutoSize = true;
            this.labelHandle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHandle.Location = new System.Drawing.Point(205, 333);
            this.labelHandle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHandle.Name = "labelHandle";
            this.labelHandle.Size = new System.Drawing.Size(14, 15);
            this.labelHandle.TabIndex = 0;
            this.labelHandle.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(194, 307);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Handle";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPU.Location = new System.Drawing.Point(69, 333);
            this.labelCPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(28, 15);
            this.labelCPU.TabIndex = 0;
            this.labelCPU.Text = "0 %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 307);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilization";
            // 
            // tabRAM
            // 
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
            this.tabRAM.Location = new System.Drawing.Point(4, 22);
            this.tabRAM.Margin = new System.Windows.Forms.Padding(2);
            this.tabRAM.Name = "tabRAM";
            this.tabRAM.Padding = new System.Windows.Forms.Padding(2);
            this.tabRAM.Size = new System.Drawing.Size(549, 444);
            this.tabRAM.TabIndex = 1;
            this.tabRAM.Text = "RAM";
            this.tabRAM.UseVisualStyleBackColor = true;
            // 
            // labelCmt
            // 
            this.labelCmt.AutoSize = true;
            this.labelCmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCmt.Location = new System.Drawing.Point(46, 399);
            this.labelCmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCmt.Name = "labelCmt";
            this.labelCmt.Size = new System.Drawing.Size(34, 15);
            this.labelCmt.TabIndex = 1;
            this.labelCmt.Text = "0 GB";
            // 
            // labelNPaged
            // 
            this.labelNPaged.AutoSize = true;
            this.labelNPaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNPaged.Location = new System.Drawing.Point(380, 399);
            this.labelNPaged.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNPaged.Name = "labelNPaged";
            this.labelNPaged.Size = new System.Drawing.Size(36, 15);
            this.labelNPaged.TabIndex = 1;
            this.labelNPaged.Text = "0 MB";
            // 
            // labelPaged
            // 
            this.labelPaged.AutoSize = true;
            this.labelPaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaged.Location = new System.Drawing.Point(228, 399);
            this.labelPaged.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPaged.Name = "labelPaged";
            this.labelPaged.Size = new System.Drawing.Size(36, 15);
            this.labelPaged.TabIndex = 1;
            this.labelPaged.Text = "0 MB";
            // 
            // labelCached
            // 
            this.labelCached.AutoSize = true;
            this.labelCached.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCached.Location = new System.Drawing.Point(380, 336);
            this.labelCached.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCached.Name = "labelCached";
            this.labelCached.Size = new System.Drawing.Size(34, 15);
            this.labelCached.TabIndex = 1;
            this.labelCached.Text = "0 GB";
            // 
            // labelRamAvai
            // 
            this.labelRamAvai.AutoSize = true;
            this.labelRamAvai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRamAvai.Location = new System.Drawing.Point(228, 336);
            this.labelRamAvai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRamAvai.Name = "labelRamAvai";
            this.labelRamAvai.Size = new System.Drawing.Size(34, 15);
            this.labelRamAvai.TabIndex = 1;
            this.labelRamAvai.Text = "0 GB";
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRAM.Location = new System.Drawing.Point(46, 336);
            this.labelRAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(34, 15);
            this.labelRAM.TabIndex = 1;
            this.labelRAM.Text = "0 GB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 370);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Committed";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(362, 370);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Non-paged pool";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(362, 304);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Cached";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(202, 370);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Paged pool";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(202, 304);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Available";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "In use";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "% Memory Usage";
            // 
            // chartRAM
            // 
            chartArea30.Name = "ChartArea1";
            this.chartRAM.ChartAreas.Add(chartArea30);
            legend22.Enabled = false;
            legend22.Name = "Legend1";
            this.chartRAM.Legends.Add(legend22);
            this.chartRAM.Location = new System.Drawing.Point(11, 40);
            this.chartRAM.Margin = new System.Windows.Forms.Padding(2);
            this.chartRAM.Name = "chartRAM";
            series37.ChartArea = "ChartArea1";
            series37.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series37.Legend = "Legend1";
            series37.Name = "RAM";
            this.chartRAM.Series.Add(series37);
            this.chartRAM.Size = new System.Drawing.Size(525, 244);
            this.chartRAM.TabIndex = 0;
            this.chartRAM.Text = "chartRAM";
            // 
            // tabDisk
            // 
            this.tabDisk.Controls.Add(this.labelWriteSpd);
            this.tabDisk.Controls.Add(this.labelReadSpd);
            this.tabDisk.Controls.Add(this.labelDiskUse);
            this.tabDisk.Controls.Add(this.chartDiskRate);
            this.tabDisk.Controls.Add(this.label9);
            this.tabDisk.Controls.Add(this.label8);
            this.tabDisk.Controls.Add(this.label6);
            this.tabDisk.Controls.Add(this.chartDiskUse);
            this.tabDisk.Controls.Add(this.label5);
            this.tabDisk.Location = new System.Drawing.Point(4, 22);
            this.tabDisk.Margin = new System.Windows.Forms.Padding(2);
            this.tabDisk.Name = "tabDisk";
            this.tabDisk.Padding = new System.Windows.Forms.Padding(2);
            this.tabDisk.Size = new System.Drawing.Size(549, 444);
            this.tabDisk.TabIndex = 2;
            this.tabDisk.Text = "Disk";
            this.tabDisk.UseVisualStyleBackColor = true;
            // 
            // labelWriteSpd
            // 
            this.labelWriteSpd.AutoSize = true;
            this.labelWriteSpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWriteSpd.Location = new System.Drawing.Point(254, 416);
            this.labelWriteSpd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWriteSpd.Name = "labelWriteSpd";
            this.labelWriteSpd.Size = new System.Drawing.Size(42, 15);
            this.labelWriteSpd.TabIndex = 4;
            this.labelWriteSpd.Text = "0 KB/s";
            // 
            // labelReadSpd
            // 
            this.labelReadSpd.AutoSize = true;
            this.labelReadSpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReadSpd.Location = new System.Drawing.Point(163, 416);
            this.labelReadSpd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReadSpd.Name = "labelReadSpd";
            this.labelReadSpd.Size = new System.Drawing.Size(42, 15);
            this.labelReadSpd.TabIndex = 4;
            this.labelReadSpd.Text = "0 KB/s";
            // 
            // labelDiskUse
            // 
            this.labelDiskUse.AutoSize = true;
            this.labelDiskUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiskUse.Location = new System.Drawing.Point(63, 416);
            this.labelDiskUse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDiskUse.Name = "labelDiskUse";
            this.labelDiskUse.Size = new System.Drawing.Size(25, 15);
            this.labelDiskUse.TabIndex = 4;
            this.labelDiskUse.Text = "0%";
            // 
            // chartDiskRate
            // 
            this.chartDiskRate.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            chartArea31.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea31.Name = "ChartArea1";
            this.chartDiskRate.ChartAreas.Add(chartArea31);
            legend23.Enabled = false;
            legend23.Name = "Legend1";
            this.chartDiskRate.Legends.Add(legend23);
            this.chartDiskRate.Location = new System.Drawing.Point(13, 284);
            this.chartDiskRate.Margin = new System.Windows.Forms.Padding(2);
            this.chartDiskRate.Name = "chartDiskRate";
            series38.ChartArea = "ChartArea1";
            series38.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series38.IsVisibleInLegend = false;
            series38.Legend = "Legend1";
            series38.Name = "DiskRead";
            series39.ChartArea = "ChartArea1";
            series39.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series39.Legend = "Legend1";
            series39.Name = "DiskWrite";
            this.chartDiskRate.Series.Add(series38);
            this.chartDiskRate.Series.Add(series39);
            this.chartDiskRate.Size = new System.Drawing.Size(525, 95);
            this.chartDiskRate.TabIndex = 3;
            this.chartDiskRate.Text = "chart2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(231, 390);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Write speed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(136, 390);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Read speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 390);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Active time";
            // 
            // chartDiskUse
            // 
            chartArea32.Name = "ChartArea1";
            this.chartDiskUse.ChartAreas.Add(chartArea32);
            legend24.Enabled = false;
            legend24.Name = "Legend1";
            this.chartDiskUse.Legends.Add(legend24);
            this.chartDiskUse.Location = new System.Drawing.Point(13, 36);
            this.chartDiskUse.Margin = new System.Windows.Forms.Padding(2);
            this.chartDiskUse.Name = "chartDiskUse";
            series40.ChartArea = "ChartArea1";
            series40.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series40.Legend = "Legend1";
            series40.Name = "DiskUse";
            this.chartDiskUse.Series.Add(series40);
            this.chartDiskUse.Size = new System.Drawing.Size(525, 244);
            this.chartDiskUse.TabIndex = 1;
            this.chartDiskUse.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Active Time";
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
            // pNetSend
            // 
            this.pNetSend.CategoryName = "Network Interface";
            this.pNetSend.CounterName = "Bytes Sent/sec";
            this.pNetSend.InstanceName = "Intel[R] Dual Band Wireless-AC 8265";
            // 
            // pNetReceive
            // 
            this.pNetReceive.CategoryName = "Network Interface";
            this.pNetReceive.CounterName = "Bytes Received/sec";
            this.pNetReceive.InstanceName = "Intel[R] Dual Band Wireless-AC 8265";
            // 
            // labelCPUname
            // 
            this.labelCPUname.AutoSize = true;
            this.labelCPUname.Location = new System.Drawing.Point(462, 22);
            this.labelCPUname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCPUname.Name = "labelCPUname";
            this.labelCPUname.Size = new System.Drawing.Size(58, 13);
            this.labelCPUname.TabIndex = 3;
            this.labelCPUname.Text = "CPU name";
            // 
            // PerfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 490);
            this.Controls.Add(this.tabPerformance);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            ((System.ComponentModel.ISupportInitialize)(this.pNetSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNetReceive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPerformance;
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
        private System.Diagnostics.PerformanceCounter pNetSend;
        private System.Diagnostics.PerformanceCounter pNetReceive;
        private System.Windows.Forms.TabPage tabCPU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelHandle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCPUname;
    }
}