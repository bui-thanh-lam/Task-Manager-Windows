using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTaskManager
{
    public partial class RunNewTaskForm : Form
    {
        public RunNewTaskForm()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e) // chạy một ứng dụng mà người dùng mới nhập vào
        {
            if (!string.IsNullOrEmpty(openInput.Text))
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = openInput.Text;
                    proc.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RunNewTaskForm_Load(object sender, EventArgs e)
        {

        }
    }
}
