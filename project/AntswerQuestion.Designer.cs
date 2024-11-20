namespace project
{
    partial class AnswerQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnswerQuestion));
            question = new Label();
            forward = new Button();
            back = new Button();
            American = new GroupBox();
            radio3 = new RadioButton();
            radio2 = new RadioButton();
            radio1 = new RadioButton();
            op3 = new Label();
            op2 = new Label();
            op1 = new Label();
            multiple_choice = new GroupBox();
            check3 = new CheckBox();
            check2 = new CheckBox();
            check1 = new CheckBox();
            option3 = new Label();
            option2 = new Label();
            option1 = new Label();
            num_question = new Label();
            end = new Button();
            counter = new Label();
            worngA = new Label();
            testScore = new Label();
            returnHomePage = new Button();
            button2 = new Button();
            yes_no = new GroupBox();
            no = new RadioButton();
            yes = new RadioButton();
            American.SuspendLayout();
            multiple_choice.SuspendLayout();
            yes_no.SuspendLayout();
            SuspendLayout();
            // 
            // question
            // 
            question.AutoSize = true;
            question.BackColor = Color.MediumPurple;
            question.Font = new Font("72 Monospace", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            question.Location = new Point(519, 199);
            question.Name = "question";
            question.Size = new Size(29, 30);
            question.TabIndex = 0;
            question.Text = "1";
            // 
            // forward
            // 
            forward.BackColor = Color.Black;
            forward.Font = new Font("Snap ITC", 30F, FontStyle.Regular, GraphicsUnit.Point);
            forward.ForeColor = Color.MediumPurple;
            forward.Location = new Point(369, 436);
            forward.Margin = new Padding(3, 2, 3, 2);
            forward.Name = "forward";
            forward.Size = new Size(102, 59);
            forward.TabIndex = 1;
            forward.Text = "<";
            forward.UseVisualStyleBackColor = false;
            forward.Click += forward_Click_1;
            // 
            // back
            // 
            back.BackColor = Color.Black;
            back.Font = new Font("72 Monospace", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            back.ForeColor = Color.MediumPurple;
            back.Location = new Point(599, 436);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(98, 59);
            back.TabIndex = 2;
            back.Text = ">";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click_1;
            // 
            // American
            // 
            American.BackColor = Color.MediumPurple;
            American.Controls.Add(radio3);
            American.Controls.Add(radio2);
            American.Controls.Add(radio1);
            American.Controls.Add(op3);
            American.Controls.Add(op2);
            American.Controls.Add(op1);
            American.Font = new Font("72 Monospace", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            American.Location = new Point(570, 248);
            American.Margin = new Padding(3, 2, 3, 2);
            American.Name = "American";
            American.Padding = new Padding(3, 2, 3, 2);
            American.Size = new Size(239, 152);
            American.TabIndex = 4;
            American.TabStop = false;
            American.Text = "american";
            American.Visible = false;
            // 
            // radio3
            // 
            radio3.AutoSize = true;
            radio3.Location = new Point(5, 111);
            radio3.Margin = new Padding(3, 2, 3, 2);
            radio3.Name = "radio3";
            radio3.Size = new Size(14, 13);
            radio3.TabIndex = 5;
            radio3.TabStop = true;
            radio3.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            radio2.AutoSize = true;
            radio2.Location = new Point(5, 66);
            radio2.Margin = new Padding(3, 2, 3, 2);
            radio2.Name = "radio2";
            radio2.Size = new Size(14, 13);
            radio2.TabIndex = 4;
            radio2.TabStop = true;
            radio2.UseVisualStyleBackColor = true;
            // 
            // radio1
            // 
            radio1.AutoSize = true;
            radio1.Location = new Point(5, 27);
            radio1.Margin = new Padding(3, 2, 3, 2);
            radio1.Name = "radio1";
            radio1.Size = new Size(14, 13);
            radio1.TabIndex = 3;
            radio1.TabStop = true;
            radio1.UseVisualStyleBackColor = true;
            // 
            // op3
            // 
            op3.AutoSize = true;
            op3.Location = new Point(167, 112);
            op3.Name = "op3";
            op3.Size = new Size(55, 15);
            op3.TabIndex = 2;
            op3.Text = "label3";
            // 
            // op2
            // 
            op2.AutoSize = true;
            op2.Location = new Point(167, 66);
            op2.Name = "op2";
            op2.Size = new Size(55, 15);
            op2.TabIndex = 1;
            op2.Text = "label2";
            // 
            // op1
            // 
            op1.AutoSize = true;
            op1.Location = new Point(167, 28);
            op1.Name = "op1";
            op1.Size = new Size(55, 15);
            op1.TabIndex = 0;
            op1.Text = "label1";
            // 
            // multiple_choice
            // 
            multiple_choice.BackColor = Color.MediumPurple;
            multiple_choice.Controls.Add(check3);
            multiple_choice.Controls.Add(check2);
            multiple_choice.Controls.Add(check1);
            multiple_choice.Controls.Add(option3);
            multiple_choice.Controls.Add(option2);
            multiple_choice.Controls.Add(option1);
            multiple_choice.Font = new Font("72 Monospace", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            multiple_choice.Location = new Point(570, 248);
            multiple_choice.Margin = new Padding(3, 2, 3, 2);
            multiple_choice.Name = "multiple_choice";
            multiple_choice.Padding = new Padding(3, 2, 3, 2);
            multiple_choice.Size = new Size(239, 152);
            multiple_choice.TabIndex = 5;
            multiple_choice.TabStop = false;
            multiple_choice.Text = "multi chioces";
            multiple_choice.Visible = false;
            // 
            // check3
            // 
            check3.AutoSize = true;
            check3.Location = new Point(23, 111);
            check3.Margin = new Padding(3, 2, 3, 2);
            check3.Name = "check3";
            check3.Size = new Size(15, 14);
            check3.TabIndex = 8;
            check3.UseVisualStyleBackColor = true;
            // 
            // check2
            // 
            check2.AutoSize = true;
            check2.Location = new Point(23, 66);
            check2.Margin = new Padding(3, 2, 3, 2);
            check2.Name = "check2";
            check2.Size = new Size(15, 14);
            check2.TabIndex = 7;
            check2.UseVisualStyleBackColor = true;
            // 
            // check1
            // 
            check1.AutoSize = true;
            check1.Location = new Point(23, 18);
            check1.Margin = new Padding(3, 2, 3, 2);
            check1.Name = "check1";
            check1.Size = new Size(15, 14);
            check1.TabIndex = 6;
            check1.UseVisualStyleBackColor = true;
            // 
            // option3
            // 
            option3.AutoSize = true;
            option3.Location = new Point(113, 112);
            option3.Name = "option3";
            option3.Size = new Size(55, 15);
            option3.TabIndex = 5;
            option3.Text = "label6";
            // 
            // option2
            // 
            option2.AutoSize = true;
            option2.Location = new Point(113, 73);
            option2.Name = "option2";
            option2.Size = new Size(55, 15);
            option2.TabIndex = 4;
            option2.Text = "label5";
            // 
            // option1
            // 
            option1.AutoSize = true;
            option1.Location = new Point(113, 25);
            option1.Name = "option1";
            option1.Size = new Size(55, 15);
            option1.TabIndex = 3;
            option1.Text = "label4";
            // 
            // num_question
            // 
            num_question.AutoSize = true;
            num_question.Font = new Font("72 Monospace", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            num_question.ForeColor = Color.MediumPurple;
            num_question.Location = new Point(155, 126);
            num_question.Name = "num_question";
            num_question.Size = new Size(88, 23);
            num_question.TabIndex = 6;
            num_question.Text = "label1";
            // 
            // end
            // 
            end.BackColor = Color.MediumPurple;
            end.Font = new Font("72 Monospace", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            end.Location = new Point(438, 500);
            end.Name = "end";
            end.Size = new Size(222, 118);
            end.TabIndex = 7;
            end.Text = "הגשת מבחן";
            end.UseVisualStyleBackColor = false;
            end.Visible = false;
            end.Click += end_Click_1;
            // 
            // counter
            // 
            counter.AutoSize = true;
            counter.BackColor = Color.Black;
            counter.Font = new Font("72 Monospace", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            counter.ForeColor = Color.MediumPurple;
            counter.Location = new Point(887, 126);
            counter.Name = "counter";
            counter.Size = new Size(88, 23);
            counter.TabIndex = 8;
            counter.Text = "label1";
            // 
            // worngA
            // 
            worngA.AutoSize = true;
            worngA.BackColor = Color.MediumPurple;
            worngA.Font = new Font("72 Monospace", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            worngA.Location = new Point(570, 128);
            worngA.Name = "worngA";
            worngA.Size = new Size(76, 21);
            worngA.TabIndex = 9;
            worngA.Text = "label1";
            worngA.Visible = false;
            // 
            // testScore
            // 
            testScore.AutoSize = true;
            testScore.BackColor = Color.MediumPurple;
            testScore.Font = new Font("72 Monospace", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            testScore.Location = new Point(548, 39);
            testScore.Name = "testScore";
            testScore.Size = new Size(131, 37);
            testScore.TabIndex = 10;
            testScore.Text = "label1";
            testScore.Visible = false;
            // 
            // returnHomePage
            // 
            returnHomePage.BackgroundImage = (Image)resources.GetObject("returnHomePage.BackgroundImage");
            returnHomePage.BackgroundImageLayout = ImageLayout.Zoom;
            returnHomePage.Font = new Font("Snap ITC", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            returnHomePage.Location = new Point(1024, 578);
            returnHomePage.Name = "returnHomePage";
            returnHomePage.Size = new Size(76, 60);
            returnHomePage.TabIndex = 12;
            returnHomePage.UseVisualStyleBackColor = true;
            returnHomePage.Click += returnHomePage_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Location = new Point(23, 485);
            button2.Name = "button2";
            button2.Size = new Size(153, 153);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = false;
            // 
            // yes_no
            // 
            yes_no.BackColor = Color.MediumPurple;
            yes_no.Controls.Add(no);
            yes_no.Controls.Add(yes);
            yes_no.Font = new Font("72 Monospace", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            yes_no.ForeColor = SystemColors.ControlText;
            yes_no.Location = new Point(570, 248);
            yes_no.Margin = new Padding(2);
            yes_no.Name = "yes_no";
            yes_no.Padding = new Padding(2);
            yes_no.Size = new Size(239, 152);
            yes_no.TabIndex = 14;
            yes_no.TabStop = false;
            yes_no.Text = "yes & no";
            yes_no.Visible = false;
            // 
            // no
            // 
            no.AutoSize = true;
            no.Location = new Point(102, 81);
            no.Margin = new Padding(2);
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
            yes.Location = new Point(102, 36);
            yes.Margin = new Padding(2);
            yes.Name = "yes";
            yes.Size = new Size(49, 19);
            yes.TabIndex = 0;
            yes.TabStop = true;
            yes.Text = "yes";
            yes.UseVisualStyleBackColor = true;
            // 
            // AnswerQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1112, 650);
            Controls.Add(yes_no);
            Controls.Add(button2);
            Controls.Add(returnHomePage);
            Controls.Add(testScore);
            Controls.Add(worngA);
            Controls.Add(counter);
            Controls.Add(end);
            Controls.Add(multiple_choice);
            Controls.Add(num_question);
            Controls.Add(American);
            Controls.Add(back);
            Controls.Add(forward);
            Controls.Add(question);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AnswerQuestion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AntswerQuestion";
            Load += AnswerQuestion_Load_1;
            American.ResumeLayout(false);
            American.PerformLayout();
            multiple_choice.ResumeLayout(false);
            multiple_choice.PerformLayout();
            yes_no.ResumeLayout(false);
            yes_no.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label question;
        private Button forward;
        private Button back;
        private GroupBox American;
        private RadioButton radio1;
        private Label op3;
        private Label op2;
        private Label op1;
        private GroupBox multiple_choice;
        private Label option3;
        private Label option2;
        private Label option1;
        private RadioButton radio3;
        private RadioButton radio2;
        private CheckBox check3;
        private CheckBox check2;
        private CheckBox check1;
        private Label num_question;
        private Button end;
        private Label counter;
        private Label worngA;
        private Label testScore;
        private Button returnHomePage;
        private Button button2;
        private GroupBox yes_no;
        private RadioButton no;
        private RadioButton yes;
    }
}