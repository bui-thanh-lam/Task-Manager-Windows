namespace TaskManagerForm
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
            this.listView = new System.Windows.Forms.ListView();
            this.ProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProcessID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Memory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.endTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realtimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endTaskButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.rightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessName,
            this.ProcessID,
            this.Memory,
            this.Status});
            this.listView.ContextMenuStrip = this.rightClickMenu;
            this.listView.Location = new System.Drawing.Point(12, 13);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(629, 505);
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
            // rightClickMenu
            // 
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
            this.idleToolStripMenuItem.Name = "idleToolStripMenuItem";
            this.idleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.idleToolStripMenuItem.Text = "Idle";
            this.idleToolStripMenuItem.Click += new System.EventHandler(this.idleToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // highToolStripMenuItem
            // 
            this.highToolStripMenuItem.Name = "highToolStripMenuItem";
            this.highToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.highToolStripMenuItem.Text = "High";
            this.highToolStripMenuItem.Click += new System.EventHandler(this.highToolStripMenuItem_Click);
            // 
            // realtimeToolStripMenuItem
            // 
            this.realtimeToolStripMenuItem.Name = "realtimeToolStripMenuItem";
            this.realtimeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.realtimeToolStripMenuItem.Text = "Realtime";
            this.realtimeToolStripMenuItem.Click += new System.EventHandler(this.realtimeToolStripMenuItem_Click);
            // 
            // endTaskButton
            // 
            this.endTaskButton.Location = new System.Drawing.Point(566, 524);
            this.endTaskButton.Name = "endTaskButton";
            this.endTaskButton.Size = new System.Drawing.Size(75, 23);
            this.endTaskButton.TabIndex = 1;
            this.endTaskButton.Text = "End Task";
            this.endTaskButton.UseVisualStyleBackColor = true;
            this.endTaskButton.Click += new System.EventHandler(this.endTaskButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(13, 524);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(75, 23);
            this.reloadButton.TabIndex = 2;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // TaskManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 559);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.endTaskButton);
            this.Controls.Add(this.listView);
            this.Name = "TaskManagerForm";
            this.Text = "Simple Task Manager";
            this.rightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader ProcessName;
        private System.Windows.Forms.ColumnHeader ProcessID;
        private System.Windows.Forms.ColumnHeader Memory;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem endTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPriorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realtimeToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button endTaskButton;
        private System.Windows.Forms.Button reloadButton;
    }
}

