namespace project
{
    partial class Questions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questions));
            label1 = new Label();
            q = new TextBox();
            combo_type = new ComboBox();
            yes_no = new GroupBox();
            no = new RadioButton();
            yes = new RadioButton();
            multiple_choice = new GroupBox();
            op3 = new CheckBox();
            op2 = new CheckBox();
            op1 = new CheckBox();
            option3 = new TextBox();
            option2 = new TextBox();
            option1 = new TextBox();
            American = new GroupBox();
            radio3 = new RadioButton();
            radio2 = new RadioButton();
            textoption1 = new TextBox();
            radio1 = new RadioButton();
            textoption3 = new TextBox();
            textoption2 = new TextBox();
            label_id_test = new Label();
            label2 = new Label();
            score = new TextBox();
            Sava_question = new Button();
            progressBar = new ProgressBar();
            saveTest = new Button();
            endTest = new Button();
            label3 = new Label();
            button1 = new Button();
            yes_no.SuspendLayout();
            multiple_choice.SuspendLayout();
            American.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("72 Monospace", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(794, 44);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 0;
            label1.Text = "הכנס שאלה";
            label1.Click += label1_Click;
            // 
            // q
            // 
            q.BackColor = Color.Lime;
            q.Font = new Font("72 Monospace", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            q.Location = new Point(672, 81);
            q.Margin = new Padding(3, 2, 3, 2);
            q.Name = "q";
            q.Size = new Size(361, 29);
            q.TabIndex = 1;
            // 
            // combo_type
            // 
            combo_type.BackColor = Color.Lime;
            combo_type.Font = new Font("72 Monospace", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            combo_type.FormattingEnabled = true;
            combo_type.Items.AddRange(new object[] { "Yes / No", "multiple choice", "American" });
            combo_type.Location = new Point(459, 185);
            combo_type.Margin = new Padding(3, 2, 3, 2);
            combo_type.Name = "combo_type";
            combo_type.Size = new Size(300, 29);
            combo_type.TabIndex = 2;
            combo_type.SelectedIndexChanged += combo_type_SelectedIndexChanged;
            // 
            // yes_no
            // 
            yes_no.BackColor = Color.Lime;
            yes_no.Controls.Add(no);
            yes_no.Controls.Add(yes);
            yes_no.Font = new Font("72 Monospace", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            yes_no.Location = new Point(437, 240);
            yes_no.Margin = new Padding(3, 2, 3, 2);
            yes_no.Name = "yes_no";
            yes_no.Padding = new Padding(3, 2, 3, 2);
            yes_no.Size = new Size(239, 152);
            yes_no.TabIndex = 3;
            yes_no.TabStop = false;
            yes_no.Text = "yes no";
            yes_no.Visible = false;
            // 
            // no
            // 
            no.AutoSize = true;
            no.Location = new Point(100, 79);
            no.Margin = new Padding(3, 2, 3, 2);
            no.Name = "no";
            no.Size = new Size(41, 19);
            no.TabIndex = 1;
            no.TabStop = true;
            no.Text = "no";
            no.UseVisualStyleBackColor = true;
            // 
            // yes
            // 
            yes.AutoSize = true;
            yes.Location = new Point(100, 35);
            yes.Margin = new Padding(3, 2, 3, 2);
            yes.Name = "yes";
            yes.Size = new Size(49, 19);
            yes.TabIndex = 0;
            yes.TabStop = true;
            yes.Text = "yes";
            yes.UseVisualStyleBackColor = true;
            // 
            // multiple_choice
            // 
            multiple_choice.BackColor = Color.Lime;
            multiple_choice.Controls.Add(op3);
            multiple_choice.Controls.Add(op2);
            multiple_choice.Controls.Add(op1);
            multiple_choice.Controls.Add(option3);
            multiple_choice.Controls.Add(option2);
            multiple_choice.Controls.Add(option1);
            multiple_choice.Font = new Font("72 Monospace", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            multiple_choice.ForeColor = Color.Black;
            multiple_choice.Location = new Point(505, 244);
            multiple_choice.Margin = new Padding(3, 2, 3, 2);
            multiple_choice.Name = "multiple_choice";
            multiple_choice.Padding = new Padding(3, 2, 3, 2);
            multiple_choice.Size = new Size(239, 152);
            multiple_choice.TabIndex = 4;
            multiple_choice.TabStop = false;
            multiple_choice.Text = "multiple choice";
            multiple_choice.Visible = false;
            // 
            // op3
            // 
            op3.AutoSize = true;
            op3.Location = new Point(18, 106);
            op3.Margin = new Padding(3, 2, 3, 2);
            op3.Name = "op3";
            op3.Size = new Size(15, 14);
            op3.TabIndex = 5;
            op3.UseVisualStyleBackColor = true;
            // 
            // op2
            // 
            op2.AutoSize = true;
            op2.Location = new Point(18, 65);
            op2.Margin = new Padding(3, 2, 3, 2);
            op2.Name = "op2";
            op2.Size = new Size(15, 14);
            op2.TabIndex = 4;
            op2.UseVisualStyleBackColor = true;
            // 
            // op1
            // 
            op1.AutoSize = true;
            op1.Location = new Point(18, 24);
            op1.Margin = new Padding(3, 2, 3, 2);
            op1.Name = "op1";
            op1.Size = new Size(15, 14);
            op1.TabIndex = 3;
            op1.UseVisualStyleBackColor = true;
            // 
            // option3
            // 
            option3.Location = new Point(56, 102);
            option3.Margin = new Padding(3, 2, 3, 2);
            option3.Name = "option3";
            option3.Size = new Size(177, 22);
            option3.TabIndex = 2;
            // 
            // option2
            // 
            option2.Location = new Point(56, 61);
            option2.Margin = new Padding(3, 2, 3, 2);
            option2.Name = "option2";
            option2.Size = new Size(177, 22);
            option2.TabIndex = 1;
            // 
            // option1
            // 
            option1.Location = new Point(56, 20);
            option1.Margin = new Padding(3, 2, 3, 2);
            option1.Name = "option1";
            option1.Size = new Size(177, 22);
            option1.TabIndex = 0;
            // 
            // American
            // 
            American.BackColor = Color.Lime;
            American.Controls.Add(radio3);
            American.Controls.Add(radio2);
            American.Controls.Add(textoption1);
            American.Controls.Add(radio1);
            American.Controls.Add(textoption3);
            American.Controls.Add(textoption2);
            American.Font = new Font("72 Monospace", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            American.Location = new Point(508, 244);
            American.Margin = new Padding(3, 2, 3, 2);
            American.Name = "American";
            American.Padding = new Padding(3, 2, 3, 2);
            American.Size = new Size(239, 152);
            American.TabIndex = 5;
            American.TabStop = false;
            American.Text = "American";
            American.Visible = false;
            // 
            // radio3
            // 
            radio3.AutoSize = true;
            radio3.Location = new Point(25, 100);
            radio3.Margin = new Padding(3, 2, 3, 2);
            radio3.Name = "radio3";
            radio3.Size = new Size(14, 13);
            radio3.TabIndex = 13;
            radio3.TabStop = true;
            radio3.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            radio2.AutoSize = true;
            radio2.Location = new Point(25, 61);
            radio2.Margin = new Padding(3, 2, 3, 2);
            radio2.Name = "radio2";
            radio2.Size = new Size(14, 13);
            radio2.TabIndex = 12;
            radio2.TabStop = true;
            radio2.UseVisualStyleBackColor = true;
            // 
            // textoption1
            // 
            textoption1.Location = new Point(56, 24);
            textoption1.Margin = new Padding(3, 2, 3, 2);
            textoption1.Name = "textoption1";
            textoption1.Size = new Size(177, 22);
            textoption1.TabIndex = 1;
            // 
            // radio1
            // 
            radio1.AutoSize = true;
            radio1.Location = new Point(25, 24);
            radio1.Margin = new Padding(3, 2, 3, 2);
            radio1.Name = "radio1";
            radio1.Size = new Size(14, 13);
            radio1.TabIndex = 11;
            radio1.TabStop = true;
            radio1.UseVisualStyleBackColor = true;
            // 
            // textoption3
            // 
            textoption3.Location = new Point(56, 96);
            textoption3.Margin = new Padding(3, 2, 3, 2);
            textoption3.Name = "textoption3";
            textoption3.Size = new Size(177, 22);
            textoption3.TabIndex = 3;
            // 
            // textoption2
            // 
            textoption2.Location = new Point(56, 63);
            textoption2.Margin = new Padding(3, 2, 3, 2);
            textoption2.Name = "textoption2";
            textoption2.Size = new Size(177, 22);
            textoption2.TabIndex = 2;
            // 
            // label_id_test
            // 
            label_id_test.AutoSize = true;
            label_id_test.Location = new Point(532, 18);
            label_id_test.Name = "label_id_test";
            label_id_test.Size = new Size(0, 15);
            label_id_test.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("72 Monospace", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(260, 46);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 7;
            label2.Text = "הכנס כמה אחוזים";
            // 
            // score
            // 
            score.BackColor = Color.Lime;
            score.Font = new Font("72 Monospace", 12F, FontStyle.Italic, GraphicsUnit.Point);
            score.Location = new Point(294, 81);
            score.Margin = new Padding(3, 2, 3, 2);
            score.Name = "score";
            score.Size = new Size(98, 26);
            score.TabIndex = 8;
            // 
            // Sava_question
            // 
            Sava_question.BackColor = Color.Lime;
            Sava_question.Font = new Font("72 Monospace", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Sava_question.Location = new Point(515, 430);
            Sava_question.Margin = new Padding(3, 2, 3, 2);
            Sava_question.Name = "Sava_question";
            Sava_question.Size = new Size(161, 60);
            Sava_question.TabIndex = 9;
            Sava_question.Text = "שמירה שאלה";
            Sava_question.UseVisualStyleBackColor = false;
            Sava_question.Click += Sava_question_Click_1;
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.White;
            progressBar.ForeColor = Color.Lime;
            progressBar.Location = new Point(260, 508);
            progressBar.Margin = new Padding(3, 2, 3, 2);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(628, 22);
            progressBar.TabIndex = 10;
            // 
            // saveTest
            // 
            saveTest.BackColor = Color.Lime;
            saveTest.Enabled = false;
            saveTest.Font = new Font("72 Monospace", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            saveTest.Location = new Point(386, 572);
            saveTest.Margin = new Padding(3, 2, 3, 2);
            saveTest.Name = "saveTest";
            saveTest.Size = new Size(161, 60);
            saveTest.TabIndex = 11;
            saveTest.Text = "שמירת מבחן";
            saveTest.UseVisualStyleBackColor = false;
            saveTest.Click += saveTest_Click_1;
            // 
            // endTest
            // 
            endTest.BackColor = Color.Lime;
            endTest.Enabled = false;
            endTest.Font = new Font("72 Monospace", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            endTest.Location = new Point(654, 572);
            endTest.Margin = new Padding(3, 2, 3, 2);
            endTest.Name = "endTest";
            endTest.Size = new Size(161, 60);
            endTest.TabIndex = 12;
            endTest.Text = "סיים מבחן";
            endTest.UseVisualStyleBackColor = false;
            endTest.Click += endTest_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("72 Monospace", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(532, 151);
            label3.Name = "label3";
            label3.Size = new Size(147, 21);
            label3.TabIndex = 13;
            label3.Text = "בחר את סוג השאלה";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(12, 479);
            button1.Name = "button1";
            button1.Size = new Size(153, 153);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = false;
            // 
            // Questions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1112, 650);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(endTest);
            Controls.Add(saveTest);
            Controls.Add(multiple_choice);
            Controls.Add(progressBar);
            Controls.Add(Sava_question);
            Controls.Add(score);
            Controls.Add(yes_no);
            Controls.Add(label2);
            Controls.Add(label_id_test);
            Controls.Add(American);
            Controls.Add(combo_type);
            Controls.Add(q);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Questions";
            Text = "Questions";
            Load += Questions_Load_1;
            yes_no.ResumeLayout(false);
            yes_no.PerformLayout();
            multiple_choice.ResumeLayout(false);
            multiple_choice.PerformLayout();
            American.ResumeLayout(false);
            American.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox q;
        private ComboBox combo_type;
        private GroupBox yes_no;
        private RadioButton no;
        private RadioButton yes;
        private GroupBox multiple_choice;
        private CheckBox op3;
        private CheckBox op2;
        private CheckBox op1;
        private TextBox option3;
        private TextBox option2;
        private TextBox option1;
        private GroupBox American;
        private TextBox textoption3;
        private TextBox textoption2;
        private TextBox textoption1;
        private Label label_id_test;
        private Label label2;
        private TextBox score;
        private Button Sava_question;
        private ProgressBar progressBar;
        private RadioButton radio3;
        private RadioButton radio2;
        private RadioButton radio1;
        private Button saveTest;
        private Button endTest;
        private Label label3;
        private Button button1;
    }
}