namespace SimpleTaskManager
{
    partial class TaskManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManagerForm));
            this.listView = new System.Windows.Forms.ListView();
            this.ProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProcessID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Memory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProcessType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.endTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realtimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endTaskButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.perfButton = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runNewTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightClickMenu.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.White;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessName,
            this.ProcessID,
            this.Memory,
            this.Status,
            this.ProcessType});
            this.listView.ContextMenuStrip = this.rightClickMenu;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 27);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(650, 491);
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // ProcessName
            // 
            this.ProcessName.Text = "Process Name";
            this.ProcessName.Width = 200;
            // 
            // ProcessID
            // 
            this.ProcessID.Text = "Process ID";
            this.ProcessID.Width = 100;
            // 
            // Memory
            // 
            this.Memory.Text = "Memory Usage";
            this.Memory.Width = 100;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 100;
            // 
            // ProcessType
            // 
            this.ProcessType.Text = "ProcessType";
            this.ProcessType.Width = 200;
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.BackColor = System.Drawing.Color.PeachPuff;
            this.rightClickMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endTaskToolStripMenuItem,
            this.setPriorityToolStripMenuItem});
            this.rightClickMenu.Name = "rightClickMenu";
            this.rightClickMenu.Size = new System.Drawing.Size(132, 48);
            // 
            // endTaskToolStripMenuItem
            // 
            this.endTaskToolStripMenuItem.Name = "endTaskToolStripMenuItem";
            this.endTaskToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.endTaskToolStripMenuItem.Text = "End Task";
            this.endTaskToolStripMenuItem.Click += new System.EventHandler(this.endTaskToolStripMenuItem_Click);
            // 
            // setPriorityToolStripMenuItem
            // 
            this.setPriorityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idleToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.highToolStripMenuItem,
            this.realtimeToolStripMenuItem});
            this.setPriorityToolStripMenuItem.Name = "setPriorityToolStripMenuItem";
            this.setPriorityToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.setPriorityToolStripMenuItem.Text = "Set Priority";
            // 
            // idleToolStripMenuItem
            // 
            this.idleToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.idleToolStripMenuItem.Name = "idleToolStripMenuItem";
            this.idleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.idleToolStripMenuItem.Text = "Idle";
            this.idleToolStripMenuItem.Click += new System.EventHandler(this.idleToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // highToolStripMenuItem
            // 
            this.highToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.highToolStripMenuItem.Name = "highToolStripMenuItem";
            this.highToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.highToolStripMenuItem.Text = "High";
            this.highToolStripMenuItem.Click += new System.EventHandler(this.highToolStripMenuItem_Click);
            // 
            // realtimeToolStripMenuItem
            // 
            this.realtimeToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.realtimeToolStripMenuItem.Name = "realtimeToolStripMenuItem";
            this.realtimeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.realtimeToolStripMenuItem.Text = "Realtime";
            this.realtimeToolStripMenuItem.Click += new System.EventHandler(this.realtimeToolStripMenuItem_Click);
            // 
            // endTaskButton
            // 
            this.endTaskButton.BackColor = System.Drawing.Color.LightSalmon;
            this.endTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.endTaskButton.Location = new System.Drawing.Point(587, 524);
            this.endTaskButton.Name = "endTaskButton";
            this.endTaskButton.Size = new System.Drawing.Size(75, 23);
            this.endTaskButton.TabIndex = 1;
            this.endTaskButton.Text = "End Task";
            this.endTaskButton.UseVisualStyleBackColor = false;
            this.endTaskButton.Click += new System.EventHandler(this.endTaskButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.BackColor = System.Drawing.Color.LightSalmon;
            this.reloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reloadButton.Location = new System.Drawing.Point(13, 524);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(75, 23);
            this.reloadButton.TabIndex = 2;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = false;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // perfButton
            // 
            this.perfButton.Location = new System.Drawing.Point(0, 0);
            this.perfButton.Name = "perfButton";
            this.perfButton.Size = new System.Drawing.Size(75, 23);
            this.perfButton.TabIndex = 5;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(674, 24);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "menuStrip1";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon;
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runNewTaskToolStripMenuItem,
            this.performanceToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // runNewTaskToolStripMenuItem
            // 
            this.runNewTaskToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.runNewTaskToolStripMenuItem.Name = "runNewTaskToolStripMenuItem";
            this.runNewTaskToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.runNewTaskToolStripMenuItem.Text = "Run New Task";
            this.runNewTaskToolStripMenuItem.Click += new System.EventHandler(this.runNewTaskToolStripMenuItem_Click);
            // 
            // performanceToolStripMenuItem
            // 
            this.performanceToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.performanceToolStripMenuItem.Name = "performanceToolStripMenuItem";
            this.performanceToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.performanceToolStripMenuItem.Text = "Performance";
            this.performanceToolStripMenuItem.Click += new System.EventHandler(this.performanceToolStripMenuItem_Click);
            // 
            // TaskManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 554);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.perfButton);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.endTaskButton);
            this.Controls.Add(this.listView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "TaskManagerForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Simple Task Manager";
            this.rightClickMenu.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader ProcessID;
        private System.Windows.Forms.ColumnHeader Memory;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader ProcessType;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem endTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPriorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realtimeToolStripMenuItem;
        private System.Windows.Forms.Button endTaskButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button perfButton;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runNewTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performanceToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader ProcessName;
    }
}

