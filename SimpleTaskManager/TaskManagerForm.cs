using System;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;

namespace SimpleTaskManager
{
    public partial class TaskManagerForm : Form
    {
        public TaskManagerForm()
        {
            InitializeComponent();
            GetProcess();
        }

        Process[] processes;

        void GetProcess() // liệt kê các tiến trình đang thực hiện tại thời điểm hiện tại
        {
            processes = Process.GetProcesses();
            listView.Items.Clear();
            foreach (Process p in processes)
            {
                ListViewItem newItem = new ListViewItem(p.ProcessName);
                //newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = p.ProcessName });
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = p.Id.ToString() });
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = MemoryToString(p.PrivateMemorySize64) });
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (p.Responding == true ? "Responding" : "Not responding") });
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (p.MainWindowHandle == IntPtr.Zero) ? "Backgrorund Process" : (String.IsNullOrEmpty(p.MainWindowTitle) ? "Window Process" : "App") });
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = p.PrivateMemorySize64.ToString() });
                listView.Items.Add(newItem);
            }
        }

        string MemoryToString(long memory) // chuyển đổi dung lượng tiến trình đang sử dụng từ kiểu long sang kiểu string
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

        void changeColor()
        {
            int i = 0;
            foreach (Process p in processes)
            {
                if (i % 2 == 0) listView.Items[i].BackColor = Color.Moccasin;
                else listView.Items[i].BackColor = Color.White;
                i++;
            }
        }

        private Process getSelectedProcess() // lấy ra tiến trình được lựa chọn
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

        private void endTaskToolStripMenuItem_Click(object sender, EventArgs e) // dừng một tiến trình bằng cách sử dụng button trên giao diện
        {
            if (listView.SelectedItems.Count > 0)
            {
                getSelectedProcess().Kill();
            }
            GetProcess();
            changeColor();
        }

        private void idleToolStripMenuItem_Click(object sender, EventArgs e) // đặt lại mức độ ưu tiên cho các tiếm trình với các mức idle/ normal/ high/ realtime
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

        private void endTaskButton_Click(object sender, EventArgs e) // dừng một tiến trình đang thực hiện bằng cách click trực tiếp vào tiến trình đó
        {
            if (listView.SelectedItems.Count > 0)
            {
                getSelectedProcess().Kill();
            }
            GetProcess();
            changeColor();
        }

        private void reloadButton_Click(object sender, EventArgs e) // cập nhật lại danh sách tiến trình
        {
            GetProcess();
            changeColor();
        }

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e) // sắp xếp các tiến trình theo thứ tự tăng dần giá trị ứng với cột được chọn
        {
            listView.ListViewItemSorter = new ListViewItemComparer(e.Column);
            listView.Sort();
            changeColor();
        }

        private void runNewTaskToolStripMenuItem_Click(object sender, EventArgs e) // mở của sổ chạy một ứng dụng mới
        {
            using (RunNewTaskForm runNewTaskForm = new RunNewTaskForm())
            {
                if (runNewTaskForm.ShowDialog() == DialogResult.OK)
                {
                    GetProcess();
                    changeColor();
                }
            }
        }

        private void performanceToolStripMenuItem_Click(object sender, EventArgs e) // mở cửa sổ biểu diễn hiệu suất hệ thống: CPU, RAM
        {
            PerfForm perfForm = new PerfForm();
            perfForm.ShowDialog();
        }
    }
}
