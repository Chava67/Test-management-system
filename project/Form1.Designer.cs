namespace project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            createTest = new Button();
            Test = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // createTest
            // 
            createTest.BackColor = Color.Red;
            createTest.Font = new Font("72 Monospace", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            createTest.Location = new Point(630, 175);
            createTest.Margin = new Padding(3, 2, 3, 2);
            createTest.Name = "createTest";
            createTest.Size = new Size(222, 118);
            createTest.TabIndex = 0;
            createTest.Text = "יצרת\\עריכת מבחן";
            createTest.UseVisualStyleBackColor = false;
            createTest.Click += createTest_Click_1;
            // 
            // Test
            // 
            Test.BackColor = Color.Red;
            Test.Font = new Font("72 Monospace", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Test.Location = new Point(369, 175);
            Test.Margin = new Padding(3, 2, 3, 2);
            Test.Name = "Test";
            Test.Size = new Size(222, 118);
            Test.TabIndex = 1;
            Test.Text = "בחינה";
            Test.UseVisualStyleBackColor = false;
            Test.Click += Test_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(36, 456);
            button1.Name = "button1";
            button1.Size = new Size(153, 153);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            CausesValidation = false;
            ClientSize = new Size(1112, 650);
            Controls.Add(button1);
            Controls.Add(Test);
            Controls.Add(createTest);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Button createTest;
        private Button Test;
        private Button button1;
    }
}