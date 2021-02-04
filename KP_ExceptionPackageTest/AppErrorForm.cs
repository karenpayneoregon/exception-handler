using System;
using System.Windows.Forms;

namespace KP_ExceptionPackageTest
{
    public partial class AppErrorForm : Form
    {
        public AppErrorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
