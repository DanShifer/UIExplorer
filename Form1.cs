using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIExplorer
{
    public partial class UIFExplorer : Form
    {
        public UIFExplorer()
        {
            InitializeComponent();
        }

        //private void UIFExplorer_MouseDown(object sender, MouseEventArgs e)
        //{
        //    base.Capture = false;
        //    Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
        //    this.WndProc(ref m);
        //}
    }
}