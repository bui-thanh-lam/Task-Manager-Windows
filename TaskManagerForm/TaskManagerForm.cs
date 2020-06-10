using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace TaskManagerForm
{
    public partial class TaskManagerForm : Form
    {
        public TaskManagerForm()
        {
            InitializeComponent();
            GetProcess();
        }

        Process[] processes;

        void GetProcess()
        {
            processes = Process.GetProcesses();
            listView.Items.Clear();
            foreach (Process p in processes)
            {
                ListViewItem newItem = new ListViewItem() { Text = p.ProcessName };
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = p.Id.ToString() });
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = MemoryToString(p.PrivateMemorySize64) });
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (p.Responding == true ? "Responding" : "Not responding") });
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = p.PrivateMemorySize64.ToString() });
                listView.Items.Add(newItem);
            }
        }

        string MemoryToString(long memory)
        {
            string[] suffixes = { " B", " KB", " MB", " GB", " TB", " PB" };
            for (int i = 0; i < suffixes.Length; i++)
            {
                long tmp = memory / (int)Math.Pow(1024, i + 1);
                if (tmp == 0)
                    return (memory / (int)Math.Pow(1024, i)) + suffixes[i];

            }
            return memory.ToString();
        }

        private Process getSelectedProcess()
        {
            int index = 0;
            foreach (Process p in processes)
            {
                if (p.Id == Int16.Parse(listView.SelectedItems[0].SubItems[1].Text))
                {
                    index = processes.ToList().IndexOf(p);
                    break;
                }
            }
            return processes[index];
        }

        private void endTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                getSelectedProcess().Kill();
            }
        }

        private void idleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                getSelectedProcess().PriorityClass = ProcessPriorityClass.Idle;
            }
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                getSelectedProcess().PriorityClass = ProcessPriorityClass.Normal;
            }
        }

        private void highToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                getSelectedProcess().PriorityClass = ProcessPriorityClass.High;
            }
        }

        private void realtimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                getSelectedProcess().PriorityClass = ProcessPriorityClass.RealTime;
            }
        }

        private void endTaskButton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                getSelectedProcess().Kill();
            }
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            GetProcess();
        }

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            listView.ListViewItemSorter = new ListViewItemComparer(e.Column);
            listView.Sort();
        }
        
        private void runNewTaskToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (RunNewTask frm = new RunNewTask())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    GetProcess();
            }
        }
    }
}
