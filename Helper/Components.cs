using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace UIExplorer.Helper
{
    internal static class Components
    {
        public static DriveInfo[] GetDrives = DriveInfo.GetDrives();

        public static GroupBox GroupBox;
        public static PictureBox PictureBox;
        public static ProgressBar ProgressBar;
        public static Label Label;
        public static TextBox TextBox;

        public static Dictionary<string, string> KeyValuePairs = new Dictionary<string, string>();

        public static ContextMenuStrip ContextMenuStrip;
        public static ToolStripMenuItem CreateMenuStripItem;
    }
}