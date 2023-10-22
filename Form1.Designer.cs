namespace maia_c_sharp
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
            screen = new PictureBox();
            doSomething = new Button();
            ((System.ComponentModel.ISupportInitialize)screen).BeginInit();
            SuspendLayout();
            // 
            // screen
            // 
            screen.BackColor = Color.White;
            screen.Location = new Point(12, 12);
            screen.Name = "screen";
            screen.Size = new Size(700, 540);
            screen.TabIndex = 0;
            screen.TabStop = false;
            // 
            // doSomething
            // 
            doSomething.Location = new Point(637, 569);
            doSomething.Name = "doSomething";
            doSomething.Size = new Size(75, 23);
            doSomething.TabIndex = 1;
            doSomething.Text = "Haz algo";
            doSomething.UseVisualStyleBackColor = true;
            doSomething.Click += doSomething_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 602);
            Controls.Add(doSomething);
            Controls.Add(screen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)screen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox screen;
        private Button doSomething;
    }
}