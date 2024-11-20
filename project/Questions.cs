using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace project
{
    public partial class Questions : Form
    {
        internal List<Question_details> l = new List<Question_details>();
        internal event EventHandler<MyEventArgs> OnAddQuestion;

        public Questions()
        {
            InitializeComponent();
            this.OnAddQuestion += Add;
        }



        public TestDetails Test { get; set; }
        internal Question_details Ques { get; set; }


        private void Questions_Load_1(object sender, EventArgs e)
        {
            if (Ques != null)
            {
                q.Text = Ques.Content;
                combo_type.Text = Ques.Type;
                progressBar.Value = Test.Percnt;
                score.Text = Ques.Percent;
                switch (Ques.Type)
                {
                    case "Yes / No":
                        yes_no.Visible = true;
                        if (Ques.Answer[0] == "yes")
                        {
                            yes.Checked = true;
                        }
                        break;
                    case "American":
                        American.Visible = true;
                        textoption1.Text = Ques.AnswersOptions[0];
                        textoption2.Text = Ques.AnswersOptions[1];
                        textoption3.Text = Ques.AnswersOptions[2];
                        if (Ques.Answer[0] == textoption3.Text)
                        {
                            radio3.Checked = true;
                        }
                        else
                        {
                            if (Ques.Answer[0] == textoption2.Text)
                            {
                                radio2.Checked = true;
                            }
                            else
                            {
                                radio1.Checked = true;
                            }
                        }
                        break;
                    default:
                        multiple_choice.Visible = true;
                        option1.Text = Ques.AnswersOptions[0];
                        option2.Text = Ques.AnswersOptions[1];
                        option3.Text = Ques.AnswersOptions[2];
                        if (Ques.Answer[0] == "true")
                        {
                            op1.Checked = true;
                        }
                        if (Ques.Answer[1] == "true")
                        {
                            op2.Checked = true;
                        }
                        if (Ques.Answer[2] == "true")
                        {
                            op3.Checked = true;
                        }
                        break;
                }

            }
            progressBar.Value = Test.Percnt;
        }

        private void Sava_question_Click_1(object sender, EventArgs e)
        {

            if (q.Text == "" || score.Text == "" || combo_type.Text != "Yes / No" && combo_type.Text != "American" && combo_type.Text != "multiple choice")
            {
                MessageBox.Show("All fields are required!");
                return;
            }
            else
            {


                saveTest.Enabled = true;
                //try
                //{
                //int num = int.Parse(score.Text);

                //    //if (progressBar.Value + num >= 100)
                //    //{
                //    //    score.Text = (100 - progressBar.Value).ToString();
                //    //    progressBar.Value = 100;
                //    //    endTest.Enabled = true;
                //    //}
                //    //else { progressBar.Value = progressBar.Value + num; }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
                switch (combo_type.Text)
                {
                    case "Yes / No":
                        if (!yes.Checked && !no.Checked)
                        {
                            MessageBox.Show("All fields are required!");
                            return;
                        }

                        string[] aop = new string[] { "yes", "no" };
                        string[] a = new string[1];
                        string t = yes.Checked ? "yes" : "no";
                        a[0] = t;
                        Question_details q1 = new Question_details(Test.Id, q.Text, combo_type.Text, a, aop, score.Text);
                        l.Add(q1);
                        yes_no.Visible = false;
                        break;
                    case "American":
                        if (textoption1.Text == "" || textoption2.Text == "" || textoption3.Text == "" || (!radio1.Checked && !radio2.Checked && !radio3.Checked))
                        {
                            MessageBox.Show("All fields are required!");
                            return;
                        }
                        string[] aop2 = new string[] { textoption1.Text, textoption2.Text, textoption3.Text };
                        string[] a2 = new string[1];
                        string tp = radio1.Checked ? textoption1.Text : radio2.Checked ? textoption2.Text : textoption3.Text;
                        a2[0] = tp;
                        Question_details q2 = new Question_details(Test.Id, q.Text, combo_type.Text, a2, aop2, score.Text);
                        l.Add(q2);
                        American.Visible = false;
                        break;
                    default:
                        if (option1.Text == "" || option2.Text == "" || option3.Text == "" || (!op1.Checked && !op2.Checked && !op3.Checked))
                        {
                            MessageBox.Show("All fields are required!");
                            return;
                        }
                        string[] aop3 = new string[] { option1.Text, option2.Text, option3.Text };
                        string[] a3 = new string[] { op1.Checked ? "true" : "false", op2.Checked ? "true" : "false", op3.Checked ? "true" : "false" };
                        Question_details q3 = new Question_details(Test.Id, q.Text, combo_type.Text, a3, aop3, score.Text);
                        l.Add(q3);
                        multiple_choice.Visible = false;
                        break;
                }
                OnAddQuestion(this, new MyEventArgs(int.Parse(score.Text)));

                q.Text = "";
                score.Text = "";
                combo_type.Text = "";
            }
        }

        private void saveTest_Click_1(object sender, EventArgs e)
        {
            try
            {
                string read = File.ReadAllText("questionsData.json");
                if (read == "")
                {
                    var list1 = new List<List<Question_details>>();
                    list1.Add(l);
                    string json1 = JsonConvert.SerializeObject(list1);
                    File.WriteAllText("questionsData.json", json1);
                    this.Hide();
                    Form1 f = new Form1();
                    f.Show();
                }
                else
                {
                    var existingData = JsonConvert.DeserializeObject<List<List<Question_details>>>(read);
                    existingData.Add(l);
                    string json = JsonConvert.SerializeObject(existingData);
                    File.WriteAllText("questionsData.json", json);
                    string filePath = Path.GetFullPath("questionsData.json");
                    this.Hide();
                    Form1 f = new Form1();
                    f.Show();
                }
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
            try
            {
                string readTest = File.ReadAllText("testData.json");
                if (readTest != "")
                {
                    var existingData = JsonConvert.DeserializeObject<List<TestDetails>>(readTest);
                    Test.Percnt = progressBar.Value;
                    Test.NumofQuestion = l.Count();
                    existingData.Add(Test);
                    string json = JsonConvert.SerializeObject(existingData);
                    File.WriteAllText("testData.json", json);
                }
                else
                {
                    var list = new List<TestDetails>();
                    Test.Percnt = progressBar.Value;
                    Test.NumofQuestion = l.Count();
                    list.Add(Test);
                    string json = JsonConvert.SerializeObject(list);
                    File.WriteAllText("testData.json", json);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            var a = Test.NumofQuestion;
        }

        private void endTest_Click_1(object sender, EventArgs e)
        {
            try
            {
                string read = File.ReadAllText("questionsData.json");
                if (read == "")
                {
                    var list1 = new List<List<Question_details>>();
                    list1.Add(l);
                    string json1 = JsonConvert.SerializeObject(list1);
                    File.WriteAllText("questionsData.json", json1);

                }
                else
                {
                    var existingData = JsonConvert.DeserializeObject<List<List<Question_details>>>(read);
                    existingData.Add(l);
                    string json = JsonConvert.SerializeObject(existingData);
                    File.WriteAllText("questionsData.json", json);
                }
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
            try
            {
                string readTest = File.ReadAllText("testData.json");
                if (readTest != "")
                {
                    var existingData = JsonConvert.DeserializeObject<List<TestDetails>>(readTest);
                    Test.Percnt = 100;
                    Test.Status = true;
                    Test.NumofQuestion = l.Count();
                    existingData.Add(Test);
                    string json = JsonConvert.SerializeObject(existingData);
                    File.WriteAllText("testData.json", json);
                    this.Hide();
                    Form1 f = new Form1();
                    f.Show();
                }
                else
                {
                    var list = new List<TestDetails>();
                    Test.Percnt = 100;
                    Test.Status = true;
                    Test.NumofQuestion = l.Count();
                    list.Add(Test);
                    string json = JsonConvert.SerializeObject(list);
                    File.WriteAllText("testData.json", json);
                    this.Hide();
                    Form1 f = new Form1();
                    f.Show();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void combo_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (combo_type.Text)
            {
                case "Yes / No":
                    American.Visible = false;
                    multiple_choice.Visible = false;
                    yes.Checked = false;
                    no.Checked = false;
                    yes_no.Visible = true;
                    break;
                case "American":
                    multiple_choice.Visible = false;
                    yes_no.Visible = false;
                    textoption1.Text = "";
                    textoption2.Text = "";
                    textoption3.Text = "";
                    radio1.Checked = false;
                    radio2.Checked = false;
                    radio3.Checked = false;
                    American.Visible = true;
                    break;
                default:
                    yes_no.Visible = false;
                    American.Visible = false;
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    op1.Checked = false;
                    op2.Checked = false;
                    op3.Checked = false;
                    multiple_choice.Visible = true;
                    break;
            }
        }
        private void Add(object? sender, MyEventArgs e)
        {
            if (progressBar.Value + e.Message >= 100)
            {
                score.Text = (100 - progressBar.Value).ToString();
                progressBar.Value = 100;
                endTest.Enabled = true;
                Sava_question.Enabled = false;
            }
            else { progressBar.Value = progressBar.Value + e.Message; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
