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

namespace project
{
    public partial class Testing : Form
    {
        public Testing()
        {
            InitializeComponent();
        }

        private void listBoxTest_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            startTest.Enabled = true;
        }

        private void startTest_Click_1(object sender, EventArgs e)
        {
            try
            {
                string readTest = File.ReadAllText("testData.json");
                var existingData = JsonConvert.DeserializeObject<List<TestDetails>>(readTest);
                var found = existingData.Find(y => y.Name == listBoxTest.SelectedItem.ToString());
                string read = File.ReadAllText("questionsData.json");
                var existingDataq = JsonConvert.DeserializeObject<List<List<Question_details>>>(read);
                var foundQuestinList = existingDataq.Find(y => y[0].Id_test == found.Id);
                this.Hide();
                AnswerQuestion antswerQuestion = new AnswerQuestion();
                antswerQuestion.Test = found;
                antswerQuestion.Qlist = foundQuestinList;
                antswerQuestion.Show();

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

        private void Testing_Load_1(object sender, EventArgs e)
        {
            try
            {
                string readTest = File.ReadAllText("testData.json");

                var existingData = JsonConvert.DeserializeObject<List<TestDetails>>(readTest);
                var found = existingData.FindAll(x => x.Status == true);
                if (found.Count == 0)
                {
                    MessageBox.Show("there are no tests available");
                    this.Hide();
                    Form1 f = new Form1();
                    f.Show();
                }
                found.ForEach(y => { listBoxTest.Items.Add(y.Name); });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
