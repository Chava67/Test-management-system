using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace project
{
    public partial class AnswerQuestion : Form
    {
        internal event EventHandler<MyEventArgs> OnAddAnswer;

        public AnswerQuestion()
        {
            InitializeComponent();
            this.OnAddAnswer += countAnswer;

        }



        public TestDetails Test { get; set; }
        internal List<Question_details> Qlist { get; set; }
        public string[] AnswerList { get; set; }
        public int Index { get; set; }
        public int Count { get; set; }

        private void countAnswer(object? sender, MyEventArgs e)
        {
            Count = 0;
            foreach (var item in AnswerList)
            {
                if (item != "" && item != "false false false")
                {
                    Count++;
                }
            }
        }
        private void show(int index)
        {
            OnAddAnswer(this, new MyEventArgs(Count));
            var Question = Qlist.ElementAt(index);
            num_question.Text = " שאלה מספר" + (index + 1).ToString() + " / " + Test.NumofQuestion;
            counter.Text = " ענית על" + Count + " שאלות";
            question.Text = Question.Content;
            American.Visible = false;
            multiple_choice.Visible = false;
            yes_no.Visible = false;
            switch (Question.Type)
            {
                case "Yes / No":
                    yes_no.Visible = true;
                    break;
                case "American":
                    American.Visible = true;
                    op1.Text = Question.AnswersOptions[0];
                    op2.Text = Question.AnswersOptions[1];
                    op3.Text = Question.AnswersOptions[2];
                    break;
                default:
                    multiple_choice.Visible = true;
                    option1.Text = Question.AnswersOptions[0];
                    option2.Text = Question.AnswersOptions[1];
                    option3.Text = Question.AnswersOptions[2];
                    break;
            }
        }
        private void addQToList(int i)
        {
            var Question = Qlist.ElementAt(i);
            List<string> l = new List<string>();
            switch (Question.Type)
            {
                case "Yes / No":
                    string a = yes.Checked ? a = "yes" : no.Checked ? a = "no" : a = "";
                    AnswerList[i] = a;
                    if (i != Qlist.Count - 1)
                    {
                        yes.Checked = false;
                        no.Checked = false;
                    }
                    //if (a != "") { Count++; }
                    break;
                case "American":
                    string b = radio1.Checked ? b = op1.Text : radio2.Checked ? b = op2.Text : radio3.Checked ? b = op3.Text : b = "";
                    AnswerList[i] = b;
                    if (i != Qlist.Count - 1)
                    {
                        radio1.Checked = false;
                        radio2.Checked = false;
                        radio3.Checked = false;
                    }
                    //if (b != "") { Count++; }
                    break;
                default:
                    string c;
                    c = check1.Checked ? c = "true" : "false";
                    string d = check2.Checked ? d = "true" : "false";
                    string s = check3.Checked ? s = "true" : "false";
                    c = c + " " + d + " " + s;
                    //if (c != "") { Count++; }
                    AnswerList[i] = c;

                    check1.Checked = false;
                    check2.Checked = false;
                    check3.Checked = false;
                    break;

            }

        }
        private void loadQuestion(int i)
        {
            var Question = Qlist.ElementAt(i);
            switch (Question.Type)
            {
                case "Yes / No":
                    var a = AnswerList[i] == "yes" ? yes.Checked = true : AnswerList[i] == "no" ? no.Checked = true : no.Checked = false;
                    break;
                case "American":
                    var b = AnswerList[i] == op1.Text ? radio1.Checked = true : AnswerList[i] == op2.Text ? radio2.Checked = true : AnswerList[i] == op3.Text ? radio3.Checked = true : radio3.Checked = false;
                    break;
                default:
                    if (AnswerList[i] != "")
                    {
                        check1.Checked = false;
                        check2.Checked = false;
                        check3.Checked = false;
                        var arr = AnswerList[i].Split(" ");
                        if (arr[0] == "true")
                        { check1.Checked = true; }
                        if (arr[1] == "true")
                        { check2.Checked = true; }
                        if (arr[2] == "true")
                        { check3.Checked = true; }


                    }
                    break;
            }
        }

        private void checkTest()
        {
            int score = 100;
            string worngAnswer = "";
            string temp;

            for (int i = 0; i < Qlist.Count; i++)
            {
                var q = Qlist[i];
                temp = "";
                switch (q.Type)
                {
                    case "multiple choice":
                        int num = 3;
                        var arr = AnswerList[i].Split(" ");
                        string temp2 = "שאלה מספר " + (i + 1) + ":\n" + "תוכן השאלה: " + q.Content + "\n";

                        for (int j = 0; j < 3; j++)
                        {
                            if (arr[j] == q.Answer[j])
                                num -= 1;
                            else

                                temp += "אופציה מספר  " + (j + 1) + "\nהתשובה הנכונה היא:\n" + q.Answer[j] + "\nהתשובה שלך:\n " + arr[j] + "\n\n";

                        }
                        if (temp != "")
                            temp = temp2 + temp;

                        score = score - int.Parse(q.Percent) / 3 * num;

                        break;
                    default:
                        if (q.Answer[0] != AnswerList[i])
                        {
                            score = score - int.Parse(q.Percent);
                            temp += "שאלה מספר " + (i + 1) + ":\n" + "תוכן השאלה: " + q.Content + "\n" + "\nהתשובה הנכונה:\n " + q.Answer[0] + "\nהתשובה שלך: " + AnswerList[i] + "\n\n";
                        }
                        break;



                }
                worngAnswer += temp;
            }
            multiple_choice.Visible = false;
            yes_no.Visible = false;
            American.Visible = false;
            question.Visible = false;
            num_question.Visible = false;
            forward.Visible = false;
            back.Visible = false;
            end.Visible = false;
            counter.Visible = false;
            returnHomePage.Visible = true;
            testScore.Visible = true;
            testScore.Text = "הציון שלך הוא: " + score;
            if (worngAnswer != "")
            {
                worngA.Visible = true;
                worngA.Text = worngAnswer;
            }

        }

        private void AnswerQuestion_Load_1(object sender, EventArgs e)
        {
            AnswerList = new string[Qlist.Count];
            for (int i = 0; i < Qlist.Count; i++)
            {
                AnswerList[i] = "";
            }
            Index = 0;
            show(0);
        }

        private void end_Click_1(object sender, EventArgs e)
        {
            if (Count != Qlist.Count)
            {
                DialogResult res = MessageBox.Show("לא ענית על " + (Qlist.Count - Count) + " שאלות. האם אתה רוצה לעבור לבדיקת מבחן?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    checkTest();
                }
                if (res == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                checkTest();
            }
        }

        private void forward_Click_1(object sender, EventArgs e)
        {
            addQToList(Index);
            if (Index < Qlist.Count - 1)
            {
                Index++;
                show(Index);
                loadQuestion(Index);
            }
            else
            {
                end.Visible = true;
                show(Index);
                loadQuestion(Index);
            }
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            if (Index != 0)
            {
                addQToList(Index);
                Index--;
                show(Index);
                loadQuestion(Index);
                end.Visible = false;
            }
        }

        private void returnHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }


    }
}
