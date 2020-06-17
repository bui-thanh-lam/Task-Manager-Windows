using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTaskManager
{
    public class ListViewItemComparer : IComparer // so sánh 
    {
        private int col;
        public ListViewItemComparer()
        {
            col = 0;
        }
        public ListViewItemComparer(int col)
        {
            this.col = col;
        }
        public int Compare(object x, object y)
        {
            int returnValue = -1;
            if (col == 0 || col == 3 || col == 4)
            {
                returnValue = String.Compare(((ListViewItem)x).SubItems[col].Text,
                    ((ListViewItem)y).SubItems[col].Text);
            } else if (col == 1)
            {
                returnValue = Int32.Parse(((ListViewItem)x).SubItems[col].Text) - Int32.Parse(((ListViewItem)y).SubItems[col].Text);
            } else if (col == 2)
            {
                returnValue = Int32.Parse(((ListViewItem)x).SubItems[5].Text) - Int32.Parse(((ListViewItem)y).SubItems[5].Text);
            }
            return returnValue;
        }
    }
}
