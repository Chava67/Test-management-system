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
    public partial class ExistingTest : Form
    {
        public ExistingTest()
        {
            InitializeComponent();
        }

        private void deleteTest_Click_1(object sender, EventArgs e)
        {
            try
            {

                string readTest = File.ReadAllText("testData.json");
                var existingData = JsonConvert.DeserializeObject<List<TestDetails>>(readTest);
                var check = existingData.Find(y => y.Name == listBox.SelectedItem.ToString());
                string read = File.ReadAllText("questionsData.json");
                var existingDataq = JsonConvert.DeserializeObject<List<List<Question_details>>>(read);
                if (existingData.Count == 1)
                {
                    existingData.Clear();
                    existingDataq.Clear();
                    string jsonTest = JsonConvert.SerializeObject(existingData);
                    File.WriteAllText("testData.json", jsonTest);
                    string json = JsonConvert.SerializeObject(existingData);
                    File.WriteAllText("questionsData.json", json);
                    this.Hide();
                    Form1 f = new Form1();
                    f.Show();
                }
                else
                {
                    var question = existingDataq.Find(y => y[0].Id_test == check.Id);
                    existingDataq.Remove(question);
                    string json = JsonConvert.SerializeObject(existingDataq);
                    File.WriteAllText("questionsData.json", json);
                    existingData.Remove(check);
                    string jsonTest = JsonConvert.SerializeObject(existingData);
                    File.WriteAllText("testData.json", jsonTest);
                    this.Hide();
                    ExistingTest f = new ExistingTest();
                    f.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void conductTest_Click_1(object sender, EventArgs e)
        {
            try
            {
                string readTest = File.ReadAllText("testData.json");
                var existingData = JsonConvert.DeserializeObject<List<TestDetails>>(readTest);
                var check = existingData.Find(y => y.Name == listBox.SelectedItem.ToString());
                existingData.Remove(check);
                check.Status = false;
                // existingData.Add(check);
                string json1 = JsonConvert.SerializeObject(existingData);
                File.WriteAllText("testData.json", json1);
                this.Hide();
                CondactQuestion f = new CondactQuestion();
                f.Tests = check;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void listBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            deleteTest.Enabled = true;
            conductTest.Enabled = true;
        }

        private void ExistingTest_Load_1(object sender, EventArgs e)
        {
            try
            {
                string readTest = File.ReadAllText("testData.json");
                var existingData = JsonConvert.DeserializeObject<List<TestDetails>>(readTest);
                if (existingData.Count == 0)
                {
                    this.Hide();
                    Form1 f = new Form1();
                    f.Show();
                }
                else
                {
                    existingData.ForEach(y => { listBox.Items.Add(y.Name); });
                }
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
