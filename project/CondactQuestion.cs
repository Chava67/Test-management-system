using Newtonsoft.Json;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project
{
    public partial class CondactQuestion : Form
    {
        public CondactQuestion()
        {
            InitializeComponent();
        }
        public TestDetails Tests { get; set; }

        private void update_Click_1(object sender, EventArgs e)
        {
            try
            {
                string read = File.ReadAllText("questionsData.json");
                var existingDataq = JsonConvert.DeserializeObject<List<List<Question_details>>>(read);
                var foundlist = existingDataq.Find(y => y[0].Id_test == Tests.Id);
                existingDataq.Remove(foundlist);
                var qupdate = foundlist.Find(y => y.Content == listBoxQuestion.SelectedItem.ToString());
                foundlist.Remove(qupdate);
                string json = JsonConvert.SerializeObject(existingDataq);
                File.WriteAllText("questionsData.json", json);
                Tests.Percnt = Tests.Percnt - int.Parse(qupdate.Percent);
                this.Hide();
                Questions questions = new Questions();
                questions.Test = Tests;
                questions.Ques = qupdate;
                questions.l = foundlist;
                questions.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteQoestion_Click_1(object sender, EventArgs e)
        {
            try
            {
                string read = File.ReadAllText("questionsData.json");
                var existingDataq = JsonConvert.DeserializeObject<List<List<Question_details>>>(read);
                var foundlist = existingDataq.Find(y => y[0].Id_test == Tests.Id);
                existingDataq.Remove(foundlist);
                var qDelete = foundlist.Find(y => y.Content == listBoxQuestion.SelectedItem.ToString());
                if (foundlist.Count == 1)
                {
                    string json = JsonConvert.SerializeObject(existingDataq);
                    File.WriteAllText("questionsData.json", json);
                    string readTest = File.ReadAllText("testData.json");
                    var existingData = JsonConvert.DeserializeObject<List<TestDetails>>(readTest);
                    var check = existingData.Find(y => y.Id == qDelete.Id_test);
                    existingData.Remove(check);
                    string json1 = JsonConvert.SerializeObject(existingData);
                    File.WriteAllText("testData.json", json1);
                    this.Hide();
                    Form1 f = new Form1();
                    f.Show();

                }
                else
                {
                    foundlist.Remove(qDelete);
                    existingDataq.Add(foundlist);
                    string json = JsonConvert.SerializeObject(existingDataq);
                    File.WriteAllText("questionsData.json", json);
                    string readTest = File.ReadAllText("testData.json");
                    var existingData = JsonConvert.DeserializeObject<List<TestDetails>>(readTest);
                    var check = existingData.Find(y => y.Id == qDelete.Id_test);
                    if (check != null)
                    {
                        existingData.Remove(check);
                    }
                    try
                    {
                        Tests.Percnt = Tests.Percnt - int.Parse(qDelete.Percent);
                        Tests.NumofQuestion = Tests.NumofQuestion - 1;
                        Tests.NumofQuestion -= 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    existingData.Add(Tests);
                    string json1 = JsonConvert.SerializeObject(existingData);
                    File.WriteAllText("testData.json", json1);
                    this.Hide();
                    CondactQuestion question = new CondactQuestion();
                    question.Tests = Tests;
                    question.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addQ_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Tests.Percnt < 100)
                {
                    string read = File.ReadAllText("questionsData.json");
                    var existingDataq = JsonConvert.DeserializeObject<List<List<Question_details>>>(read);
                    var foundlist = existingDataq.Find(y => y[0].Id_test == Tests.Id);
                    existingDataq.Remove(foundlist);
                    string json = JsonConvert.SerializeObject(existingDataq);
                    File.WriteAllText("questionsData.json", json);
                    this.Hide();
                    Questions questions = new Questions();
                    questions.Test = Tests;
                    questions.l = foundlist;
                    questions.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void returnHomePage_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void listBoxQuestion_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            deleteQoestion.Enabled = true;
            update.Enabled = true;
        }

        private void CondactQuestion_Load_1(object sender, EventArgs e)
        {
            try
            {
                string read = File.ReadAllText("questionsData.json");
                var existingDataq = JsonConvert.DeserializeObject<List<List<Question_details>>>(read);
                var found = existingDataq.Find(y => y[0].Id_test == Tests.Id);
                found.ForEach(y => { listBoxQuestion.Items.Add(y.Content); });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

