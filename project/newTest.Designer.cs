namespace project
{
    partial class newTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newTest));
            TestName = new TextBox();
            startToWriteTest = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // TestName
            // 
            TestName.BackColor = Color.Yellow;
            TestName.Font = new Font("72 Monospace", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TestName.Location = new Point(542, 209);
            TestName.Margin = new Padding(3, 2, 3, 2);
            TestName.Name = "TestName";
            TestName.PlaceholderText = "הכנס שם מבחן";
            TestName.Size = new Size(132, 35);
            TestName.TabIndex = 0;
            // 
            // startToWriteTest
            // 
            startToWriteTest.BackColor = Color.Yellow;
            startToWriteTest.Font = new Font("72 Monospace", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            startToWriteTest.Location = new Point(497, 309);
            startToWriteTest.Margin = new Padding(3, 2, 3, 2);
            startToWriteTest.Name = "startToWriteTest";
            startToWriteTest.Size = new Size(222, 118);
            startToWriteTest.TabIndex = 1;
            startToWriteTest.Text = "התחל מבחן";
            startToWriteTest.UseVisualStyleBackColor = false;
            startToWriteTest.Click += startToWriteTest_Click_1;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Snap ITC", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1024, 578);
            button1.Name = "button1";
            button1.Size = new Size(76, 60);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Location = new Point(12, 485);
            button2.Name = "button2";
            button2.Size = new Size(153, 153);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            // 
            // newTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1112, 650);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(startToWriteTest);
            Controls.Add(TestName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "newTest";
            Text = "newTest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TestName;
        private Button startToWriteTest;
        private TextBox Id;
        private Button button1;
        private Button button2;
    }
}