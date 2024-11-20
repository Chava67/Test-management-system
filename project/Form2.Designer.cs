namespace project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            updateTest = new Button();
            NewTest = new Button();
            returnHomePage = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // updateTest
            // 
            updateTest.BackColor = Color.FromArgb(255, 128, 0);
            updateTest.BackgroundImageLayout = ImageLayout.Stretch;
            updateTest.Font = new Font("72 Monospace", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            updateTest.Location = new Point(317, 177);
            updateTest.Margin = new Padding(3, 2, 3, 2);
            updateTest.Name = "updateTest";
            updateTest.Size = new Size(222, 118);
            updateTest.TabIndex = 0;
            updateTest.Text = "עריכת מבחן";
            updateTest.UseVisualStyleBackColor = false;
            updateTest.Click += updateTest_Click_1;
            // 
            // NewTest
            // 
            NewTest.BackColor = Color.FromArgb(255, 128, 0);
            NewTest.Font = new Font("72 Monospace", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NewTest.Location = new Point(627, 177);
            NewTest.Margin = new Padding(3, 2, 3, 2);
            NewTest.Name = "NewTest";
            NewTest.Size = new Size(222, 118);
            NewTest.TabIndex = 1;
            NewTest.Text = "יצרת מבחן חדש";
            NewTest.UseVisualStyleBackColor = false;
            NewTest.Click += NewTest_Click_1;
            // 
            // returnHomePage
            // 
            returnHomePage.BackgroundImage = (Image)resources.GetObject("returnHomePage.BackgroundImage");
            returnHomePage.BackgroundImageLayout = ImageLayout.Zoom;
            returnHomePage.Font = new Font("Snap ITC", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            returnHomePage.Location = new Point(1024, 578);
            returnHomePage.Name = "returnHomePage";
            returnHomePage.Size = new Size(76, 60);
            returnHomePage.TabIndex = 2;
            returnHomePage.UseVisualStyleBackColor = true;
            returnHomePage.Click += returnHomePage_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(12, 485);
            button1.Name = "button1";
            button1.Size = new Size(153, 153);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1112, 650);
            Controls.Add(button1);
            Controls.Add(returnHomePage);
            Controls.Add(NewTest);
            Controls.Add(updateTest);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button updateTest;
        private Button NewTest;
        private Button returnHomePage;
        private Button button1;
    }
}