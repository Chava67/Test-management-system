namespace project
{
    partial class ExistingTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExistingTest));
            listBox = new ListBox();
            deleteTest = new Button();
            conductTest = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.BackColor = Color.IndianRed;
            listBox.Font = new Font("72 Monospace", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(375, 162);
            listBox.Margin = new Padding(3, 2, 3, 2);
            listBox.Name = "listBox";
            listBox.Size = new Size(213, 229);
            listBox.TabIndex = 0;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged_1;
            // 
            // deleteTest
            // 
            deleteTest.BackColor = Color.IndianRed;
            deleteTest.Enabled = false;
            deleteTest.Font = new Font("72 Monospace", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            deleteTest.Location = new Point(678, 115);
            deleteTest.Margin = new Padding(3, 2, 3, 2);
            deleteTest.Name = "deleteTest";
            deleteTest.Size = new Size(222, 118);
            deleteTest.TabIndex = 2;
            deleteTest.Text = "מחיקת מבחן";
            deleteTest.UseVisualStyleBackColor = false;
            deleteTest.Click += deleteTest_Click_1;
            // 
            // conductTest
            // 
            conductTest.BackColor = Color.IndianRed;
            conductTest.Enabled = false;
            conductTest.Font = new Font("72 Monospace", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            conductTest.Location = new Point(678, 313);
            conductTest.Margin = new Padding(3, 2, 3, 2);
            conductTest.Name = "conductTest";
            conductTest.Size = new Size(222, 118);
            conductTest.TabIndex = 3;
            conductTest.Text = "עריכת מבחן";
            conductTest.UseVisualStyleBackColor = false;
            conductTest.Click += conductTest_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Location = new Point(12, 485);
            button2.Name = "button2";
            button2.Size = new Size(153, 153);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Snap ITC", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1024, 578);
            button1.Name = "button1";
            button1.Size = new Size(76, 60);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ExistingTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1112, 650);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(conductTest);
            Controls.Add(deleteTest);
            Controls.Add(listBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExistingTest";
            Text = "ExistingTest";
            Load += ExistingTest_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox;
        private Button deleteTest;
        private Button conductTest;
        private Button button2;
        private Button button1;
    }
}