
namespace KP_ExceptionPackageTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadNonExistingFileButton = new System.Windows.Forms.Button();
            this.ThrowOnCloseCheckBox = new System.Windows.Forms.CheckBox();
            this.BadCastButton = new System.Windows.Forms.Button();
            this.ArgumentNullExceptionButton = new System.Windows.Forms.Button();
            this.BadThreadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadNonExistingFileButton
            // 
            this.ReadNonExistingFileButton.Location = new System.Drawing.Point(17, 17);
            this.ReadNonExistingFileButton.Name = "ReadNonExistingFileButton";
            this.ReadNonExistingFileButton.Size = new System.Drawing.Size(271, 23);
            this.ReadNonExistingFileButton.TabIndex = 0;
            this.ReadNonExistingFileButton.Text = "Read file not exists";
            this.ReadNonExistingFileButton.UseVisualStyleBackColor = true;
            this.ReadNonExistingFileButton.Click += new System.EventHandler(this.ReadNonExistingFileButton_Click);
            // 
            // ThrowOnCloseCheckBox
            // 
            this.ThrowOnCloseCheckBox.AutoSize = true;
            this.ThrowOnCloseCheckBox.Location = new System.Drawing.Point(13, 175);
            this.ThrowOnCloseCheckBox.Name = "ThrowOnCloseCheckBox";
            this.ThrowOnCloseCheckBox.Size = new System.Drawing.Size(190, 19);
            this.ThrowOnCloseCheckBox.TabIndex = 1;
            this.ThrowOnCloseCheckBox.Text = "Throw exception on form close";
            this.ThrowOnCloseCheckBox.UseVisualStyleBackColor = true;
            // 
            // BadCastButton
            // 
            this.BadCastButton.Location = new System.Drawing.Point(17, 46);
            this.BadCastButton.Name = "BadCastButton";
            this.BadCastButton.Size = new System.Drawing.Size(271, 23);
            this.BadCastButton.TabIndex = 2;
            this.BadCastButton.Text = "Bad cast";
            this.BadCastButton.UseVisualStyleBackColor = true;
            this.BadCastButton.Click += new System.EventHandler(this.BadCastButton_Click);
            // 
            // ArgumentNullExceptionButton
            // 
            this.ArgumentNullExceptionButton.Location = new System.Drawing.Point(17, 75);
            this.ArgumentNullExceptionButton.Name = "ArgumentNullExceptionButton";
            this.ArgumentNullExceptionButton.Size = new System.Drawing.Size(271, 23);
            this.ArgumentNullExceptionButton.TabIndex = 3;
            this.ArgumentNullExceptionButton.Text = "Argument Null Exception";
            this.ArgumentNullExceptionButton.UseVisualStyleBackColor = true;
            this.ArgumentNullExceptionButton.Click += new System.EventHandler(this.ArgumentNullExceptionButton_Click);
            // 
            // BadThreadButton
            // 
            this.BadThreadButton.Location = new System.Drawing.Point(17, 104);
            this.BadThreadButton.Name = "BadThreadButton";
            this.BadThreadButton.Size = new System.Drawing.Size(271, 23);
            this.BadThreadButton.TabIndex = 4;
            this.BadThreadButton.Text = "Thread error";
            this.BadThreadButton.UseVisualStyleBackColor = true;
            this.BadThreadButton.Click += new System.EventHandler(this.BadThreadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 209);
            this.Controls.Add(this.BadThreadButton);
            this.Controls.Add(this.ArgumentNullExceptionButton);
            this.Controls.Add(this.BadCastButton);
            this.Controls.Add(this.ThrowOnCloseCheckBox);
            this.Controls.Add(this.ReadNonExistingFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unhandle exceptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadNonExistingFileButton;
        private System.Windows.Forms.CheckBox ThrowOnCloseCheckBox;
        private System.Windows.Forms.Button BadCastButton;
        private System.Windows.Forms.Button ArgumentNullExceptionButton;
        private System.Windows.Forms.Button BadThreadButton;
    }
}

