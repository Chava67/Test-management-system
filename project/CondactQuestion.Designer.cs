namespace project
{
    partial class CondactQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CondactQuestion));
            listBoxQuestion = new ListBox();
            update = new Button();
            deleteQoestion = new Button();
            addQ = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBoxQuestion
            // 
            listBoxQuestion.BackColor = Color.RoyalBlue;
            listBoxQuestion.Font = new Font("72 Monospace", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            listBoxQuestion.FormattingEnabled = true;
            listBoxQuestion.ItemHeight = 15;
            listBoxQuestion.Location = new Point(412, 187);
            listBoxQuestion.Margin = new Padding(3, 2, 3, 2);
            listBoxQuestion.Name = "listBoxQuestion";
            listBoxQuestion.Size = new Size(213, 229);
            listBoxQuestion.TabIndex = 0;
            listBoxQuestion.SelectedIndexChanged += listBoxQuestion_SelectedIndexChanged_1;
            // 
            // update
            // 
            update.BackColor = Color.RoyalBlue;
            update.Enabled = false;
            update.Font = new Font("72 Monospace", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            update.Location = new Point(735, 264);
            update.Margin = new Padding(3, 2, 3, 2);
            update.Name = "update";
            update.Size = new Size(222, 118);
            update.TabIndex = 1;
            update.Text = "עדכון שאלה";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click_1;
            // 
            // deleteQoestion
            // 
            deleteQoestion.BackColor = Color.RoyalBlue;
            deleteQoestion.Enabled = false;
            deleteQoestion.Font = new Font("72 Monospace", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            deleteQoestion.Location = new Point(735, 94);
            deleteQoestion.Margin = new Padding(3, 2, 3, 2);
            deleteQoestion.Name = "deleteQoestion";
            deleteQoestion.Size = new Size(222, 118);
            deleteQoestion.TabIndex = 2;
            deleteQoestion.Text = "מחיקת שאלה";
            deleteQoestion.UseVisualStyleBackColor = false;
            deleteQoestion.Click += deleteQoestion_Click_1;
            // 
            // addQ
            // 
            addQ.BackColor = Color.RoyalBlue;
            addQ.Font = new Font("72 Monospace", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addQ.Location = new Point(735, 437);
            addQ.Margin = new Padding(3, 2, 3, 2);
            addQ.Name = "addQ";
            addQ.Size = new Size(222, 118);
            addQ.TabIndex = 3;
            addQ.Text = "הוספת שאלה";
            addQ.UseVisualStyleBackColor = false;
            addQ.Click += addQ_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(12, 485);
            button1.Name = "button1";
            button1.Size = new Size(153, 153);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = false;
            // 
            // CondactQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1112, 650);
            Controls.Add(button1);
            Controls.Add(addQ);
            Controls.Add(deleteQoestion);
            Controls.Add(update);
            Controls.Add(listBoxQuestion);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CondactQuestion";
            Text = "CondactQuestion";
            Load += CondactQuestion_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxQuestion;
        private Button update;
        private Button deleteQoestion;
        private Button addQ;
        private Button button1;
    }
}