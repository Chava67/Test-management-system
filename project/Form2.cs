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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void updateTest_Click_1(object sender, EventArgs e)
        {
            try
            {
                string readTest = File.ReadAllText("testData.json");
                if (readTest != "" && readTest != "[]")
                {
                    this.Hide();
                    ExistingTest existingTest = new ExistingTest();
                    existingTest.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewTest_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            newTest newTest = new newTest();
            newTest.Show();
        }

        private void returnHomePage_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
