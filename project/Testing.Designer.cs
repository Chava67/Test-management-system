namespace project
{
    partial class Testing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Testing));
            listBoxTest = new ListBox();
            startTest = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBoxTest
            // 
            listBoxTest.BackColor = Color.DeepSkyBlue;
            listBoxTest.Font = new Font("72 Monospace", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            listBoxTest.ForeColor = Color.Black;
            listBoxTest.FormattingEnabled = true;
            listBoxTest.ItemHeight = 15;
            listBoxTest.Location = new Point(501, 103);
            listBoxTest.Margin = new Padding(3, 2, 3, 2);
            listBoxTest.Name = "listBoxTest";
            listBoxTest.Size = new Size(213, 229);
            listBoxTest.TabIndex = 0;
            listBoxTest.SelectedIndexChanged += listBoxTest_SelectedIndexChanged_1;
            // 
            // startTest
            // 
            startTest.BackColor = Color.DeepSkyBlue;
            startTest.Enabled = false;
            startTest.Font = new Font("72 Monospace", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            startTest.Location = new Point(492, 404);
            startTest.Margin = new Padding(3, 2, 3, 2);
            startTest.Name = "startTest";
            startTest.Size = new Size(222, 118);
            startTest.TabIndex = 1;
            startTest.Text = "התחל מבחן";
            startTest.UseVisualStyleBackColor = false;
            startTest.Click += startTest_Click_1;
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
            // Testing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1112, 650);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(startTest);
            Controls.Add(listBoxTest);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Testing";
            Text = "Testing";
            Load += Testing_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxTest;
        private Button startTest;
        private Button button1;
        private Button button2;
    }
}