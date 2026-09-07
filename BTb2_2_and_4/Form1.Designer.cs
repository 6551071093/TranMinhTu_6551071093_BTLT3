namespace BTb2_2
{
    partial class Winform1
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
            btnClickMe = new Button();
            SuspendLayout();
            // 
            // btnClickMe
            // 
            btnClickMe.BackColor = SystemColors.Control;
            btnClickMe.Dock = DockStyle.Bottom;
            btnClickMe.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClickMe.ForeColor = Color.Red;
            btnClickMe.Location = new Point(0, 244);
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Size = new Size(557, 119);
            btnClickMe.TabIndex = 0;
            btnClickMe.Text = "Click Me";
            btnClickMe.UseVisualStyleBackColor = false;
            btnClickMe.Click += frmSimpleEvent_Click;
            // 
            // Winform1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 363);
            Controls.Add(btnClickMe);
            Name = "Winform1";
            Text = "Simple Event Example";
            Click += btnClickMe_Click;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClickMe;
    }
}
