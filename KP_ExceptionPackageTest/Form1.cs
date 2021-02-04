using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KP_ExceptionPackageTest.Classes;

namespace KP_ExceptionPackageTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Shown += OnShown;
        }

        private void OnShown(object? sender, EventArgs e)
        {
            if (Debugger.IsAttached)
            {

                if (Environment.UserName != "PayneK")
                {
                    MessageBox.Show(@"This does not work while in debug mode\nStart this project from Windows Explorer.");
                }

            }
            else
            {
                Closing += OnClosing;
            }

        }
        /// <summary>
        /// Throw exception if CheckBox is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClosing(object sender, CancelEventArgs e)
        {
            if (Debugger.IsAttached && ThrowOnCloseCheckBox.Checked)
            {
                throw new NotImplementedException();
            }
        }
        private void ReadNonExistingFileButton_Click(object sender, EventArgs e)
        {
            File.ReadAllLines("DoesNotExists");
        }

        private void BadCastButton_Click(object sender, EventArgs e)
        {
            var badCast = (Label)sender;
            MessageBox.Show(badCast.Text);
        }

        /// <summary>
        /// Passing a null string will throw a runtime exception. Note that if
        /// this method could handle a null value via assertion than that is
        /// an option while currently we would assert before calling this method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string NoNullExample([NotNull] string value) => value.ToLower();

        private void ArgumentNullExceptionButton_Click(object sender, EventArgs e)
        {
            /*
             * This will work as expected
             */
            var firstName = "KAREN";
            MessageBox.Show(NoNullExample(firstName));

            /*
             * This will throw a runtime exception
             */
            firstName = null;
            MessageBox.Show(NoNullExample(firstName));
        }

        private void BadThreadButton_Click(object sender, EventArgs e)
        {
            Thready.Start();
        }
    }
}
