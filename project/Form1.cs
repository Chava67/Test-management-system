using Newtonsoft.Json;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void createTest_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void Test_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Testing f = new Testing();
            f.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                string readTest = File.ReadAllText("testData.json");
                if (readTest == "")
                {
                    Test.Enabled = false;
                }
                else
                {
                    var existingData = JsonConvert.DeserializeObject<List<TestDetails>>(readTest);
                    var a = existingData.Find(y => y.Status == true);
                    if (a == null)
                    {
                        Test.Enabled = false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}